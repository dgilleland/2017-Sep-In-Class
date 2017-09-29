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

        }

        public static void ProcessMenuChoice(string choice)
        {

        }
        #endregion
        #endregion
    }
}
