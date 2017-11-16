<Query Kind="Expression">
  <Connection>
    <ID>c3c442ec-7d55-4319-843f-d9fffadc6a63</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Northwind_DMIT2018</Database>
  </Connection>
</Query>

from data in Products
where !data.Discontinued
select new
{
    data.Supplier.CompanyName,
    data.Category.CategoryName,
    data.ProductName,
    data.UnitPrice,
    data.UnitsInStock,
    data.QuantityPerUnit,
    data.UnitsOnOrder,
    data.ReorderLevel
}