using Microsoft.AspNet.Identity; // for RoleManager<T>
using Microsoft.AspNet.Identity.EntityFramework; // for IdentityRole
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website; // for ApplicationDbContext

namespace NorthwindTraders.Security.BLL
{
    [DataObject]
    public class RoleManager : RoleManager<IdentityRole>
    {
        public RoleManager()
            : base(new RoleStore<IdentityRole>(new ApplicationDbContext()))
        {
        }

        public void AddStartupRoles()
        {
            // Security roles that will added on startup
            var startupRoles = ConfigurationManager.AppSettings["startupRoles"].Split(';');
            foreach(var roleName in startupRoles)
            {
                // Check if it exists
                if(!Roles.Any(r => r.Name.Equals(roleName)))
                {
                    this.Create(new IdentityRole(roleName));
                }
            }
        }

        #region Standard CRUD Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<string> ListAllSecurityRoles()
        {
            var results = from role in Roles.ToList()
                          select role.Name;
            return results.ToList();
                      
        }
        #endregion
    }
}
