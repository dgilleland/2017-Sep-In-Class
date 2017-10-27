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
        public string Email { get; internal set; }
        public bool EmailConfirmed { get; internal set; }
        public int? EmployeeId { get; internal set; }
        public string FullName { get; internal set; }
        public IEnumerable<string> RoleMemberships { get; internal set; }
        public string UserId { get; internal set; }
        public string UserName { get; internal set; }
    }
}
