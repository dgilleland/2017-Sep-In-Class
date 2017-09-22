using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Data
{
    [Table("Shippers")]
    public class Shipper
    {
        #region Column Mappings
        [Key]
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        #endregion

        #region Navigational Properties
        public virtual ICollection<Order> Orders { get; set; }
        #endregion
    }
}