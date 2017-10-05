using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace NorthwindTraders.BLL
{
    /// <summary>
    /// The SandboxController is a place to "try out" LINQ.
    /// </summary>
    [DataObject]
    public class SandboxController
    {
        // TODO: ) Discontinued products
        // TODO: ) Understocked products (UnitsInStock > ReorderLevel)
        // TODO: ) Recommended product re-orders (UnitsInStock + UnitsOnOrder > ReorderLevel)
        // TODO: ) Shippers and the number of orders they have handled
        // TODO: 1) Customer Order History
        //          (dates, ship-to, freight, total cost, with order detail summary and employee rep)
        // TODO: 2) Employee Bio
        // TODO: 3) Product Catalogue (by Category)
        // TODO: 4) Suppliers and their Products (with category photo and category name)
        // TODO: 5) Most Popular products sold (qty), by year and month
        // TODO: 6) Sales Regions and their Sales Representatives
        // TODO: 7) Sales, ordered by date, including the order date, the time allowed to ship (in days), the actual time to ship (in days), and the customer name/city.
        // TODO: 8) Market Area information: A union query listing all the cities of suppliers and customers, with two columns, one for the city name and the other for whether it is a customer or supplier.
        // TODO: 9) Top 5 customers (by total sales amount)
        // TODO: 10) Top selling products (by total sales quantity)
        // TODO: 11) Customer Sales Profile, showing the customer name, the number of orders placed, the average order amount (in $), and the max/min order amounts ($)
        // TODO: ) Discontinued products, with the date of the last time they were ordered by a customer.
    }
}
