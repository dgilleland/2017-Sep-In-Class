using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTraders.Security.Entities
{

    /// <summary>
    /// An UnregisteredUser is one who is a user (Employee, Customer)
    /// without a mapped Website Login account (ApplicationUser)
    /// </summary>
    public class UnregisteredUser
    {
        public string Id { get; set; }
        public UnregisteredUserType UserType { get; set; }
        public string Name { get; set; }
        public string OtherName { get; set; }
        public string AssignedUserName { get; set; }
        public string AssignedEmail { get; set; }
        public string Phone { get; set; }
    }
}
