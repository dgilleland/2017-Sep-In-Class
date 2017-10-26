using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using NorthwindTraders.Security.Entities; // UserProfile
using System.Collections.Generic; // List<T>
using System.ComponentModel; // [DataObject] et.al.
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
            string username = "Webmaster@Northwind.tba";
            if(!Users.Any(u => u.UserName.Equals(username)))
            {
                var webMasterAccount = new ApplicationUser()
                {
                    UserName = username,
                    Email = username, // nice happenstance :)
                    EmailConfirmed = true
                };
                this.Create(webMasterAccount, "Pa$$word1");
                // Add the webmaster account to the Administrators security role
                this.AddToRole(webMasterAccount.Id, "Administrators");
            }
        }

        #region Standard CRUD Operations for Users
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<UserProfile> ListAllUsers()
        {
            // The UserManager for ASP.Net Identity has a built-in property for all users
            var result = from person in Users.ToList()
                         select new UserProfile
                         {
                             UserId = person.Id,
                             UserName = person.UserName,
                             Email = person.Email,
                             EmailConfirmed = person.EmailConfirmed,
                             CustomerId = person.CustomerId,
                             EmployeeId = person.EmployeeId
                         };
            return result.ToList();
        }
        #endregion
    }
}
