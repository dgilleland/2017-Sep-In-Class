using System;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindTraders.Security.Entities
{
    /// <summary>
    /// RoleProfile is a Data Transfer Object summarizing information about the site's security roles.
    /// </summary>
    public class RoleProfile
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public IEnumerable<string> UserNames { get; set; }
    }
}
