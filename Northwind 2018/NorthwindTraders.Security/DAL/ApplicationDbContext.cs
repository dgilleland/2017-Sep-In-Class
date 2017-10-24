using Microsoft.AspNet.Identity.EntityFramework;

namespace Website
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
//namespace NorthwindTraders.Security.DAL
//{
//    class ApplicationDbContext
//    {
//    }
//}
