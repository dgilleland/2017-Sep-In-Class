using Northwind.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Proof that the Many-to-Many mapping of Employees/Territories is working...
            using (var context = new NorthwindContext())
            {
                var result = from data in context.Territories
                             select new
                             {
                                 data.TerritoryDescription,
                                 Employees = from item in data.Employees
                                             select item.FirstName
                             };
                foreach (var item in result)
                {
                    System.Console.WriteLine($"{item.TerritoryDescription}");
                    foreach (var person in item.Employees)
                        System.Console.WriteLine($"\t{person}");
                }
            }
        }
    }
}
