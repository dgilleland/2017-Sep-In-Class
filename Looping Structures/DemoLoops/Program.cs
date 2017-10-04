﻿using System;
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
            // Clear the screen on each menu choice
            Console.Clear();
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
                case "E": // Validate Numeric Input
                    ValidateNumericInput();
                    break;
                case "F": // General user Input Validation
                    GeneralUserValidation();
                    break;
                case "G": // Fibonnacci Sequences
                    break;
                case "H": // Perfect Numbers
                    break;
                case "I": // Factorials
                    break;
                case "J": // Prime Numbers
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
            Console.WriteLine("E) Validate Numeric Input");
            Console.WriteLine("F) General User Input Validation");
            Console.WriteLine("G) Fibonnacci Sequences");
            Console.WriteLine("H) Perfect Numbers");
            Console.WriteLine("I) Factorials");
            Console.WriteLine("J) Prime Numbers");
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
                double cost = Math.Round(rnd.NextDouble(),2);
                Console.WriteLine($"This grab-bag costs {cost:C}");

                Console.Write("How many do you want? ");
                string userInput = Console.ReadLine();
                int qty;
                while(!int.TryParse(userInput, out qty))
                {
                    Console.WriteLine("Try again. How many? ");
                    userInput = Console.ReadLine();
                }
                total += cost * qty;
            }
            Console.WriteLine("\tGreat! But we only accept loonies....");
            double modifiedTotal = (int)Math.Round(((total + .5) * 100),0 ) / 100;
            double diff = modifiedTotal - total;
            Console.WriteLine($"Total: {total,12:C} Modified: {modifiedTotal,12:c}");
            if (modifiedTotal > 0)
                Console.WriteLine($"(We will give {diff:C} to charity)");
        }

        private static void ForEachDemo()
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            foreach (char character in text)
                Console.WriteLine($"\t'{character}'");
        } // end of ForEachDemo() method

        private static void ValidateNumericInput()
        {
            string userInput;
            // Getting integers
            int wholeNumber;
            Console.Write("Enter a whole number: ");
            userInput = Console.ReadLine(); // gets TEXT input
            while (!int.TryParse(userInput, out wholeNumber))
              // \                       \  indirect   //
              //  \                       \  return   //
              //   \                       \  value  //
              //    \                       =========/
              //     \  .TryParse() returns a bool  /
            {
                Console.Write("Try again. Enter a whole number: ");
                userInput = Console.ReadLine();
            }
            Console.WriteLine("Thanks! You entered " + wholeNumber);

            // Enter a real number
            double realNumber;
            Console.ForegroundColor = ConsoleColor.Cyan;
            do
                Console.Write("Enter a real number: ");
            while (!double.TryParse(Console.ReadLine(), out realNumber));
            Console.ResetColor();
            Console.WriteLine("Great! you entered " + realNumber);

        } // end of ValidateNumericInput() method

        private static void GeneralUserValidation()
        {
            // Allow only specific text input
            string userInput;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            do
            {
                Console.Write("Do you want to continue (Y/N)");
                userInput = Console.ReadLine();
            } while (userInput != "Y" && userInput != "N");
            Console.ResetColor();
            if (userInput.Equals("Y"))
                Console.WriteLine("Great! Let's continue...");
            else
                Console.WriteLine("Meh. I'll continue anyway...");
            Console.WriteLine(); // blank line...

            // Validate numeric input and an acceptable range
            int mark;
            do
                Console.Write("Enter a mark (0-100): ");
            while (!int.TryParse(Console.ReadLine(), out mark)
                   || mark < 0 || mark > 100);

            Console.WriteLine($"Ok. You get a {mark}% for the course. :)");

            // TODO: Write the code to ask the user for a price.
            //       Keep asking if the price is less than $25
            //       and greater than $50.
        }
        #endregion
    }
}
