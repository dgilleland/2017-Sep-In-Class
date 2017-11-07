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
            if (userInfo.UserName == ConfigurationManager.AppSettings["adminUserName"])
                throw new Exception("The webmaster account cannot be removed");
            this.Delete(this.FindById(userInfo.UserId));
        }
        #endregion
    }
}
