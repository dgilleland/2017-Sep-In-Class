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
            // This example checks a username and a password
            // to make sure that neither is "inside" the other.
            Console.Write("Enter your username: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (userName.Contains(password))
                Console.WriteLine("Your password is part of your username");
            else if (password.Contains(userName))
                Console.WriteLine("Your username is part of your password");
            else
                Console.WriteLine("Good! Your username/password don't overlap");
        } // end of UserNameAndPassword() method

        private static void StrongPassword()
        {
            // A strong password has
            // - at least 6 characters long
            // - a mixture of upper and lower case
            // - at least one digit
            // - some punctuation or symbol
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            int rating = 5; // assume a 5/5 rating to start with

            Console.ForegroundColor = ConsoleColor.DarkRed; // errors

            if (password.Length < 6)
            {
                Console.WriteLine("Password is too short");
                rating--; // lost a point on the strength rating
            }

            if (password == password.ToUpper() ||
                password == password.ToLower())
            {
                Console.WriteLine("Must use a mixture of upper/lower case");
                rating--;
            }

            if (!password.Contains("0") && // && means "and"
                !password.Contains("1") &&
                !password.Contains("2") &&
                !password.Contains("3") &&
                !password.Contains("4") &&
                !password.Contains("5") &&
                !password.Contains("6") &&
                !password.Contains("7") &&
                !password.Contains("8") &&
                !password.Contains("9"))
            {
                Console.WriteLine("Password must contain a digit");
                rating--;
            }

            if (!password.Contains("!") &&
                !password.Contains(".") &&
                !password.Contains("$")) // I could do others
            {
                Console.WriteLine("Passwords must contain either '!', '.', or '$'");
                rating--;
            }

            // Report the results of checking for a strong password
            Console.ResetColor();
            Console.WriteLine($"You scored a {rating}/5 for password strength");
        }
        #endregion
    }
}
