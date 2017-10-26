using Microsoft.AspNet.Identity.EntityFramework;

namespace Website // TODO: replace with namespace NorthwindTraders.Security.Entities
{
    // You can add User data for the user by adding more properties to your User class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        // An application user, in this website, can be either an Employee or a Customer
        public int? EmployeeId { get; set; }
        public string CustomerId { get; set; }
    }
}
