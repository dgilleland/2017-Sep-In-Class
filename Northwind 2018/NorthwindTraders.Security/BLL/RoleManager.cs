using Microsoft.AspNet.Identity; // for RoleManager<T>
using Microsoft.AspNet.Identity.EntityFramework; // for IdentityRole
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website; // for ApplicationDbContext

namespace NorthwindTraders.Security.BLL
{
    public class RoleManager : RoleManager<IdentityRole>
    {
        public RoleManager()
            : base(new RoleStore<IdentityRole>(new ApplicationDbContext()))
        {
        }

        public void AddStartupRoles()
        {
            // Security roles that will added on startup
            var startupRoles = new string[] { "Administrators", "Employees", "Customers" };
            foreach(var roleName in startupRoles)
            {
                // Check if it exists
                if(!Roles.Any(r => r.Name.Equals(roleName)))
                {
                    this.Create(new IdentityRole(roleName));
                }
            }
        }
    }
}
