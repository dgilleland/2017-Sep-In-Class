using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTraders.Security.Entities
{
    public class UserProfile
    {
        public string CustomerId { get; internal set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; internal set; }
        public int? EmployeeId { get; internal set; }
        public string FullName { get; internal set; }
        public IEnumerable<string> RoleMemberships { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
