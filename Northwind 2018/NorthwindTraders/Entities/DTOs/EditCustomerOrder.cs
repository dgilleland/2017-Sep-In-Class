using NorthwindTraders.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTraders.Entities.DTOs
{
    public class EditCustomerOrder
    {
        public string CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public IEnumerable<EditOrderItem> OrderItems { get; set; }
    }
}
