using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoops
{
    public class Program
    {
        #region Driver Methods
        public static void Main(string[] args)
        {
            // A common place for a do-while statement
            // is in the Driver of a console application
            string menuChoice;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Demo Looping");
                Console.WriteLine("============");

                // The main "work" of the driver
                DisplayMenu();
                menuChoice = Console.ReadLine().ToUpper();
                ProcessMenuChoice(menuChoice);
            } while (menuChoice != "X");
        } // end of Main() method

        private static void ProcessMenuChoice(string menuChoice)
        {
            switch (menuChoice)
            {
                case "A": // Do-While Statement
                    DoWhileDemo();
                    break;
                case "B": // While Statement
                    WhileDemo();
                    break;
                case "C": // For Statement
                    ForDemo();
                    break;
                case "D": // For-Each Statement
                    ForEachDemo();
                    break;
                case "X":
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid menu choice.");
                    Console.ResetColor();
                    break;
            }
        } // end of ProcessMenuChoice() method

        private static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("A) Do-While Statement");
            Console.WriteLine("B) While Statement");
            Console.WriteLine("C) For Statement");
            Console.WriteLine("D) For-Each Statement");
            Console.WriteLine("X) eXit");
            Console.ResetColor(); // reset colors to defaults
            Console.Write("Select an option from the menu: ");
        } // end of DisplayMenu() method
        #endregion

        #region Core of the actual program
        private static void DoWhileDemo()
        {
            string answer;
            Console.WriteLine("What was the name of the fairy tale character who spun straw into gold?");
            do
            {
                answer = Console.ReadLine();
                if (answer.ToLower() != "rumpelstiltskin")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wrong! Try again!");
                    Console.ResetColor();
                }
            } while (answer.ToLower() != "rumpelstiltskin");

            Console.WriteLine("Correct! :)");
        } // end of DoWhileDemo() method

        private static void WhileDemo()
        {
            // Ask a question and the user must get the
            // right answer :)
            string answer;
            Console.WriteLine("What was the name of the fairy tale character who spun straw into gold?");
            answer = Console.ReadLine();

            while (answer.ToLower() != "rumpelstiltskin")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Wrong! Try again!");
                Console.ResetColor();
                answer = Console.ReadLine();
            }
            Console.WriteLine("Correct! :)");
        } // end of WhileDemo() method

        private static void ForDemo()
        {
            double total = 0;
            Random rnd = new Random();
            Console.WriteLine("Grab Bag Surprise!");
            for (int count = 0; count < 5; count++)
            {
                // Make a random cost of the item
                double cost = Math.Round(rnd.NextDouble(), 2);
                Console.WriteLine($"This grab-bag costs {cost:C}");

                Console.Write("How many do you want? ");
                string userInput = Console.ReadLine();
                int qty;
                while (!int.TryParse(userInput, out qty))
                {
                    Console.WriteLine("Try again. How many? ");
                    userInput = Console.ReadLine();
                }
                total += cost * qty;
            }
            Console.WriteLine("\tGreat! But we only accept loonies....");
            double modifiedTotal = (int)Math.Round(((total + .5) * 100), 0) / 100;
            double diff = modifiedTotal - total;
            Console.WriteLine($"Total: {total,12:C} Modified: {modifiedTotal,12:c}");
            if (diff > 0)
                Console.WriteLine($"(We will give {diff:C} to charity)");
        } // end of ForDemo() method

        private static void ForEachDemo()
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            foreach (char character in text)
                Console.WriteLine($"\t'{character}'");
        } // end of ForEachDemo() method
        #endregion
    } // end of Program class
} // end of namespace
