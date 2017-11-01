using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pretend these values were calculated from user input
            const int descriptionLength = -30; // tweak as needed
            const int priceLength = 10;
            string computerModel = "Asus Laptop";
            double computerPrice = 1399.00;
            string headphones = "Sennheiser GSP 300 Headset";
            double headphonePrice = 129.00;
            int warrantyYears = 1;
            int warrantyRate = 5;
            double total = computerPrice + headphonePrice;

            Console.WriteLine($"{computerModel, descriptionLength} {computerPrice,priceLength:C}");
            Console.WriteLine($"{headphones, descriptionLength} {headphonePrice,priceLength:C}");
            string warrantySummary = $"Warranty - {warrantyYears} Year ({warrantyRate}%) - ";
            Console.WriteLine($"{warrantySummary, descriptionLength} {total * warrantyRate / 100,priceLength:C}");
            Console.WriteLine($"{"",30} ---------");
            Console.WriteLine($"{"Subtotal",descriptionLength} {total,priceLength:C}");
            Console.WriteLine($"{"GST",3-0} {total * .05,priceLength:C}");
            Console.WriteLine($"{"",descriptionLength} =========");
            Console.WriteLine($"{"Total",descriptionLength} {total * 1.05,priceLength:C}");
        }
    }
}
