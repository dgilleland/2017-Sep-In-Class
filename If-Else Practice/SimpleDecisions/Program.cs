using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for the price of the item,
            // and the number of items being purchased.
            // If the total is over $100, then give a 10% discount
            double itemPrice;
            int quantity;
            string userInput;

            Console.Write("What is the unit price? ");
            userInput = Console.ReadLine(); // all user input is text
            // convert the user input to a double data type
            itemPrice = double.Parse(userInput);

            Console.Write("How many items are you purchasing? ");
            userInput = Console.ReadLine();
            // convert userInput to a whole number
            quantity = int.Parse(userInput);

            // declare two variables for my calculations
            double total, discount;
            total = itemPrice * quantity;
            // Give a disount if the total is over $100
            if (total > 100)
                discount = total * 0.10; // 10%
            else
                discount = 0;

            // apply the discount to the total
            total = total - discount;

            // Ask if the user will be paying with cash.
            // (If they pay with cash, then we want to 
            //  round to the nearest 5 cents)
            Console.Write("Are you paying with cash (Y/N)");
            userInput = Console.ReadLine();
            userInput = userInput.ToUpper(); // force to upper-case
            if(userInput == "Y")
            {
                // round to the nearest 5 cents.
                // first, convert the dollars/cents into just pennies
                int pennies = (int) Math.Round(total * 100); // (int) does casting
                int remainder = pennies % 5;
                
                switch(remainder)
                {
                    case 1:
                        pennies = pennies - 1;
                        break;
                    case 2:
                        pennies = pennies - 2;
                        break;
                    case 3:
                        // go up to the nearest 5 cents
                        pennies = pennies + 2;
                        break;
                    case 4:
                        pennies = pennies + 1;
                        break;
                }
                total = pennies / 100.0; // back to dollars/cents
            }

            // Display to the user
            // format for "inline variables" is like this:
            // {expression,length:format string}
            // the length and format string are optional
            Console.WriteLine($"Your total is {total:C} with a discount of {discount:C}.");

            // Let's output the results in a formatted receipt
            Console.WriteLine(); // put in a blank line
            Console.WriteLine($"{quantity,-6} items @ {itemPrice,12:C}");
            Console.WriteLine($"Subtotal --    {quantity * itemPrice,12:C}");
            Console.WriteLine($"Discount --    {discount,12:C}");
            Console.WriteLine($"Total    --    {total,12:C}");
        } // end of Main() method
    } // end of Program class
} // end of namespace
