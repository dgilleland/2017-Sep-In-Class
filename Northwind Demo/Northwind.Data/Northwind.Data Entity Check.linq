<Query Kind="Statements">
  <Connection>
    <ID>d2680611-0859-4122-802a-895fe15d73e6</ID>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\dgilleland\Documents\GitHub\2017-Sep-In-Class\Northwind Demo\Northwind.Data\bin\Debug\Northwind.Data.dll</CustomAssemblyPath>
    <CustomTypeName>Northwind.Data.NorthwindContext</CustomTypeName>
    <AppConfigPath>C:\Users\dgilleland\Documents\GitHub\2017-Sep-In-Class\Northwind Demo\Northwind.Data\App.config</AppConfigPath>
    <CustomAssemblyPathEncoded>&lt;MyDocuments&gt;\GitHub\2017-Sep-In-Class\Northwind Demo\Northwind.Data\bin\Debug\Northwind.Data.dll</CustomAssemblyPathEncoded>
  </Connection>
</Query>

Categories.Dump();
Products.Dump();
Suppliers.Dump();
// TODO: Check all entity/table mappings...
Employees.Dump();
Territories.Dump();
Regions.Dump();
Customers.Dump();
Orders.Take(5).Dump();
OrderDetails.Take(5).Dump();
Shippers.Dump();