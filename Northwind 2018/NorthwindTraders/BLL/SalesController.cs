using NorthwindTraders.DAL;
using NorthwindTraders.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTraders.BLL
{
    [DataObject]
    public class SalesController
    {
        #region Methods for DataBound Controls
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<KeyValueOption> ListCustomerNames()
        {
            using (var context = new NorthwindContext())
            {
                var names = from data in context.Customers
                            orderby data.CompanyName
                            select new KeyValueOption
                            {
                                Key = data.CustomerID.ToString(),
                                Text = data.CompanyName
                            };
                return names.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<KeyValueOption> GetOrderHistoryFilters()
        {
            var results = new List<KeyValueOption>();
            results.Add(new KeyValueOption { Key = "open", Text = "Open" });
            results.Add(new KeyValueOption { Key = "shipped", Text = "Shipped" });
            return results.ToList();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<CustomerOrder> GetOrdersByCustomer(string customerId, string filter)
        {
            if (!"open".Equals(filter.ToLower()) && !"shipped".Equals(filter.ToLower()))
                throw new ArgumentException("Filter values are required", nameof(filter));
            using (var context = new NorthwindContext())
            {
                var shipped = "shipped".Equals(filter.ToLower());

                var results = from data in context.Orders
                              where data.CustomerID == customerId
                                 && data.ShippedDate.HasValue == shipped
                              select new CustomerOrder
                              {
                                  OrderId = data.OrderID,
                                  Employee = data.Employee.FirstName + " " + data.Employee.LastName,
                                  OrderDate = data.OrderDate,
                                  RequiredDate = data.RequiredDate,
                                  ShippedDate = data.ShippedDate,
                                  Freight = data.Freight,
                                  Shipper = data.Shipper.CompanyName,
                                  OrderTotal = data.OrderDetails.Sum(x => x.Quantity * x.UnitPrice)
                              };
                return results.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<string> ListCountries()
        {
            using (var context = new NorthwindContext())
            {
                var eCountries = context.Employees.Select(x => x.Country);
                var cCountries = context.Customers.Select(x => x.Country);
                var result = eCountries.Union(cCountries).Distinct().ToList();
                result.Sort();
                return result;
            }
        }
        #endregion

        #region Methods for Manual UI Processing
        public CustomerSummary GetCustomerSummary(string customerId)
        {
            using (var context = new NorthwindContext())
            {
                var customer = context.Customers.Find(customerId);
                if (customer == null)
                    throw new ArgumentException("Customer does not exist", nameof(customerId));
                return new CustomerSummary
                {
                    CompanyName = customer.CompanyName,
                    ContactName = $"{customer.ContactName} ({customer.ContactTitle})",
                    Phone = customer.Phone,
                    Fax = customer.Fax
                };
            }
        }
        #endregion
    }
}
