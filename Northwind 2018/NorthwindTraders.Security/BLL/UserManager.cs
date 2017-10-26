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
