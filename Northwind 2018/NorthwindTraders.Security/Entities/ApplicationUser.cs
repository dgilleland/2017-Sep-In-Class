using Microsoft.AspNet.Identity.EntityFramework;

namespace Website
{
    // You can add User data for the user by adding more properties to your User class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        // Track the user's favorite color
        public string FavoriteColor { get; set; }
    }
}
//namespace NorthwindTraders.Security.Entities
//{
//    class ApplicationUser
//    {
//    }
//}
