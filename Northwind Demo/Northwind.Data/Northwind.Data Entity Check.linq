<Query Kind="Statements">
  <Connection>
    <ID>d2680611-0859-4122-802a-895fe15d73e6</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>.\bin\Debug\Northwind.Data.dll</CustomAssemblyPath>
    <CustomTypeName>Northwind.Data.NorthwindContext</CustomTypeName>
    <AppConfigPath>.\App.config</AppConfigPath>
  </Connection>
</Query>

Categories.Dump();
Products.Dump();
Suppliers.Dump();
// TODO: Check all entity/table mappings...
Employees.Dump();
Territories.Dump();
//Regions.Dump();
//Customers.Dump();
//Orders.Dump();
//OrderDetails.Dump();