using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        #region Driver
        static void Main(string[] args)
        {
            Console.WriteLine("Assorted Demos for Validation, Exception Handling, and Methods");
            Console.WriteLine("=====================================");

            // Main loop
            char menuChoice = '-';
            do
            {
                try
                {
                    DisplayMenu();
                    menuChoice = GetMenuChoice();
                    ProcessMenuChoice(menuChoice);
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"ERROR: {ex.Message}");
                    Console.ResetColor();
                }
            } while (menuChoice != 'X');
        }

        static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("A) Area of a Square");
            Console.WriteLine("B) Assessment Prep");
            Console.WriteLine("D) Die Roll (multi-sided)");
            Console.WriteLine("X) eXit");
            Console.Write("\tChoose a menu option: ");
            Console.ResetColor();
        }

        static void ProcessMenuChoice(char choice)
        {
            switch(choice)
            {
                case 'A':
                    DemoSquareArea();
                    break;
                case 'B':
                    SentenceBuilder();
                    break;
                case 'D':
                    break;
                case 'X':
                    Console.WriteLine("\nGoodbye!");
                    break;
                // TODO: Fill in cases here
                default:
                    throw new Exception("Invalid menu choice.");
            }
        }

        static char GetMenuChoice()
        {
            string userInput = Console.ReadLine().ToUpper();
            if (userInput.Length != 1)
                throw new Exception("Menu options are a single character");
            // return the first character of the user input
            return userInput[0]; // A string is an "array" of characters
        }
        #endregion

        #region Demos
        static void DemoSquareArea()
        {
            Console.Clear(); // clear the screen
            // Get user input
            double sideLength;
            Console.Write("Enter the side length of the square");
            while (!double.TryParse(Console.ReadLine(), out sideLength)
                  || sideLength <= 0)
                Console.Write("Invalid length; try again: ");

            Console.WriteLine($"The area of a {sideLength} ft square is {sideLength * sideLength} square feet.");

        }

        static void SentenceBuilder()
        {
            // Instructions
            Console.Clear();
            Console.WriteLine("Enter in one word at a time, and I will build the sentence.");
            Console.WriteLine("Just press [Enter] on a line to stop building.");
            string sentence = "";
            string word = "";
            do
            {
                word = Console.ReadLine();
                if (!word.Contains(" "))
                    sentence += " " + word;
            } while (!string.IsNullOrEmpty(word));
            Console.WriteLine(sentence + ".");
        }
        #endregion
    }
}
