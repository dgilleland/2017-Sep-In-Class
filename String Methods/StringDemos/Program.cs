using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemos
{
    public class Program
    {
        // #region is only there to "collapse" code in Visual Studio
        #region Driver Method
        public static void Main(string[] args)
        {
            // A driver is only concerned with "running" the program
            string menuChoice;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Demo String Methods");
            Console.WriteLine("===================");

            // The main "work" of the driver
            DisplayMenu();
            menuChoice = Console.ReadLine().ToUpper(); // uppercase
            ProcessMenuChoice(menuChoice);
        } // end of Main() method

        #region Supporting Driver Methods
        public static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("A) Username and Password");
            Console.WriteLine("B) Strong Password");
            Console.ResetColor(); // reset colors to defaults
            Console.Write("Select an option from the menu: ");
        }

        public static void ProcessMenuChoice(string choice)
        {
            switch(choice)
            {
                case "A":
                    UsernameAndPassword();
                    break;
                case "B":
                    StrongPassword();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid menu choice.");
                    Console.ResetColor();
                    break;
            }
        }
        #endregion
        #endregion

        #region String Demos
        private static void UsernameAndPassword()
        {
        }

        private static StrongPassword()
        {

        }
        #endregion
    }
}
