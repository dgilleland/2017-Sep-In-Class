<Query Kind="Expression">
  <Connection>
    <ID>4dc8b401-4542-4b0d-b435-b01d9117ac30</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>NorthwindExtended</Database>
  </Connection>
</Query>

// Get the order totals and basic customer information for each order
from row in Orders
select new
// Initialization List - Google this....
{
   Company = row.Customer.CompanyName,
   Contact = row.Customer.ContactName,
   Items = from item in row.OrderDetails
           select new
			{
				ProductName = item.Product.ProductName,
				item.UnitPrice,
				item.Quantity,
				item.Discount,
				Total = item.UnitPrice * item.Quantity // todo: apply a discount
			}
}