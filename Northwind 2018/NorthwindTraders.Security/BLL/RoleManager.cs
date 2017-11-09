using Microsoft.AspNet.Identity; // for RoleManager<T>
using Microsoft.AspNet.Identity.EntityFramework; // for IdentityRole
using NorthwindTraders.Security.Entities;
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
        public List<RoleProfile> ListAllRoles()
        {
            var um = new UserManager();
            var result = from data in Roles.ToList() // .ToList() pulls db data into memory
                         select new RoleProfile()
                         {
                             RoleId = data.Id,
                             RoleName = data.Name,
                             UserNames = data.Users.Select(u => um.FindById(u.UserId).UserName)
                         };

            return result.ToList();
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void AddRole(RoleProfile role)
        {
            if (!this.RoleExists(role.RoleName))
                this.Create(new IdentityRole(role.RoleName));
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void RemoveRole(RoleProfile role)
        {
            this.Delete(this.FindById(role.RoleId));
        }
        #endregion
    }
}
