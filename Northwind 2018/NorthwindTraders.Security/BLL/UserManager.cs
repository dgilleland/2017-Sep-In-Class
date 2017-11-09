using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using NorthwindTraders.DAL;
using NorthwindTraders.Security.BLL;
using NorthwindTraders.Security.Entities; // UserProfile
using System;
using System.Collections.Generic; // List<T>
using System.ComponentModel; // [DataObject] et.al.
using System.Configuration;
using System.Linq; // for various Extension methods for collections, such as .ToList()

namespace Website // TODO: rename namespace NorthwindTraders.Security.BLL
{
    [DataObject]
    public class UserManager : UserManager<ApplicationUser>
    {
        public UserManager()
            : base(new UserStore<ApplicationUser>(new ApplicationDbContext()))
        {
        }

        public void AddWewbMaster()
        {
            // Add a web master user, if one doesn't exist
            string username = ConfigurationManager.AppSettings["adminUserName"];
            if(!Users.Any(u => u.UserName.Equals(username)))
            {
                var webMasterAccount = new ApplicationUser()
                {
                    UserName = username,
                    Email = ConfigurationManager.AppSettings["adminEmail"],
                    EmailConfirmed = true
                };
                this.Create(webMasterAccount, ConfigurationManager.AppSettings["adminPassword"]);
                // Add the webmaster account to the Administrators security role
                this.AddToRole(webMasterAccount.Id, ConfigurationManager.AppSettings["adminRole"]);
            }
        }

        #region Standard CRUD Operations for Users
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<UserProfile> ListAllUsers()
        {
            var rm = new RoleManager();
            // The UserManager for ASP.Net Identity has a built-in property for all users
            var result = from person in Users.ToList()
                         select new UserProfile
                         {
                             UserId = person.Id,
                             UserName = person.UserName,
                             Email = person.Email,
                             EmailConfirmed = person.EmailConfirmed,
                             CustomerId = person.CustomerId,
                             EmployeeId = person.EmployeeId,
                             RoleMemberships = person.Roles.Select(r => rm.FindById(r.RoleId).Name)
                         };

            // Get any name info on the users
            using (var context = new NorthwindContext())
            {
                foreach (var person in result)
                    if (person.EmployeeId.HasValue)
                        person.FullName = context.Employees.Find(person.EmployeeId).FirstName + " " + context.Employees.Find(person.EmployeeId).LastName;
                    else if (!string.IsNullOrEmpty(person.CustomerId))
                        person.FullName = context.Customers.Find(person.CustomerId).ContactName;
            }

            return result.ToList();
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void AddUser(UserProfile userInfo)
        {
            var userAccount = new ApplicationUser()
            {
                UserName = userInfo.UserName,
                Email = userInfo.Email
            };
            this.Create(userAccount, ConfigurationManager.AppSettings["newUserPassword"]);
            foreach (var roleName in userInfo.RoleMemberships)
                this.AddToRole(userAccount.Id, roleName);
        }


        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void RemoveUser(UserProfile userInfo)
        {
            // userInfo only has the .UserId, therefore we need to get
            // the complete ApplicationUser object to check the .UserName
            var user = Users.Single(u => u.Id == userInfo.UserId);
            if (user.UserName == ConfigurationManager.AppSettings["adminUserName"])
                throw new Exception("The webmaster account cannot be removed");
            this.Delete(this.FindById(userInfo.UserId));
        }
        #endregion

        #region Business Process Operations
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<UnregisteredUser> ListAllUnregsiteredUsers()
        {
            using (var context = new NorthwindContext())
            {
                // Make an in-memory list of employees who have login accounts
                var registeredEmployees = (from emp in Users
                                           where emp.EmployeeId.HasValue
                                           select emp.EmployeeId).ToList();
                // Query employees who don't have login accounts.
                // Make it in-memory (.ToList()) for the next step of assigning usernames/emails
                var employees = (from emp in context.Employees
                                 where !registeredEmployees.Any(e => emp.EmployeeID == e)
                                 select new UnregisteredUser()
                                 {
                                     Id = emp.EmployeeID.ToString(),
                                     Name = emp.FirstName,
                                     OtherName = emp.LastName,
                                     UserType = UnregisteredUserType.Employee
                                 }).ToList();
                // Assign employee usernames and emails
                foreach (var person in employees)
                {
                    string generatedUserName = $"{person.Name}.{person.OtherName}".Replace(" ", "");
                    person.AssignedUserName = generatedUserName;
                    string generatedEmail = $"{generatedUserName}@Northwind.tba";
                    person.AssignedEmail = generatedEmail;
                }

                // Make an in-memory list of customers who have login accounts
                var registeredCustomers = (from cust in Users
                                           where cust.CustomerId != null
                                           select cust.CustomerId).ToList();
                // Query customers who don't have login accounts.
                var customers = from cust in context.Customers
                                where !registeredCustomers.Any(c => cust.CustomerID == c)
                                select new UnregisteredUser()
                                {
                                    Id = cust.CustomerID,
                                    Name = cust.ContactName,
                                    OtherName = cust.CompanyName,
                                    Phone = cust.Phone,
                                    UserType = UnregisteredUserType.Customer
                                };

                // Merge and return the results
                return employees.Union(customers).ToList();
            }
        }

        public void RegisterUser(UnregisteredUser userInfo)
        {
            // Basic validation
            if (userInfo == null)
                throw new ArgumentNullException(nameof(userInfo), "Data for unregistered users is required");
            if (string.IsNullOrEmpty(userInfo.AssignedUserName))
                throw new ArgumentException(nameof(userInfo.AssignedUserName), "New users must have a username");
            // string randomPassword = Guid.NewGuid().ToString().Replace("-", "");
            var userAccount = new ApplicationUser()
            {
                UserName = userInfo.AssignedUserName,
                Email = userInfo.AssignedEmail
            };
            switch (userInfo.UserType)
            {
                case UnregisteredUserType.Customer:
                    userAccount.CustomerId = userInfo.Id;
                    userAccount.PhoneNumber = userInfo.Phone;
                    break;
                case UnregisteredUserType.Employee:
                    userAccount.EmployeeId = int.Parse(userInfo.Id);
                    break;
            }

            this.Create(userAccount, ConfigurationManager.AppSettings["newUserPassword"]); // or randomPassword
            switch (userInfo.UserType)
            {
                case UnregisteredUserType.Employee:
                    this.AddToRole(userAccount.Id, ConfigurationManager.AppSettings["employeeRole"]);
                    break;
                case UnregisteredUserType.Customer:
                    this.AddToRole(userAccount.Id, ConfigurationManager.AppSettings["customerRole"]);
                    break;
            }
        }
        #endregion
    }
}
