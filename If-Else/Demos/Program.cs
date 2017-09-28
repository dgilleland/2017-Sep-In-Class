using System;
using System.Linq; // needed for the .Reverse() function

namespace Demos
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
            Console.WriteLine("Demo Selection Statements");
            Console.WriteLine("=========================");

            // The main "work" of the driver
            DisplayMenu();
            menuChoice = Console.ReadLine().ToUpper(); // uppercase
            ProcessMenuChoice(menuChoice);
        } // end of Main() method

        private static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("A) Highest of Two");
            Console.WriteLine("B) Highest of Three");
            Console.WriteLine("C) Letter Grades");
            Console.WriteLine("D) Letter Grade to Range");
            Console.WriteLine("E) Palindrome");
            Console.WriteLine("F) Username and password");
            Console.WriteLine("G) Strong Password");
            Console.ResetColor();
            Console.Write("Select an option from the menu: ");
        }

        public static void ProcessMenuChoice(string choice)
        {
            switch(choice)
            {
                case "A":
                    HighestOfTwo();
                    break;
                case "B":
                    HighestOfThree();
                    break;
                case "C":
                    LetterGrades();
                    break;
                case "D":
                    LetterGradeToRange();
                    break;
                case "E":
                    Palindrome();
                    break;
                case "F":
                    UserNameAndPassword();
                    break;
                case "G":
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
        public static void StrongPassword()
        {
            // A strong password has
            // - a mixture of upper and lower case
            // - at least one digit
            // - some punctuation or symbol
            // - at least 6 characters long
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            int rating = 5;

            Console.ForegroundColor = ConsoleColor.DarkRed; // for errors
            if (password.Length < 6)
            {
                Console.WriteLine("Password is too short");
                rating--; // lost a point on the strength rating
            }

            // TODO: Checking upper lower case might need a "loop"
            //       or...
            if (password == password.ToUpper() ||
                password == password.ToLower())
            {
                Console.WriteLine("Must use a mixture of upper/lower case");
                rating--;
            }

            if (!password.Contains("0") &&
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

            Console.ResetColor();

            Console.WriteLine($"You scored a {rating}/5 for password strength");
        }

        public static void UserNameAndPassword()
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

        private static void Palindrome()
        {
            Console.WriteLine("Enter a word or a phrase (no punctuation):");
            string userInput = Console.ReadLine();
            // We can make use of string methods to convert the case
            userInput = userInput.ToLower();
            userInput = userInput.Replace(" ", ""); // remove spaces
            string reversed = 
              new string(userInput.ToCharArray().Reverse().ToArray());

            if (userInput == reversed)
                Console.WriteLine("Your text is a palindrome.");
            else
                Console.WriteLine("Your text is NOT a palindrome");
        }

        private static void LetterGradeToRange()
        {
            Console.Write("Enter a letter grade: ");
            string letterGrade = Console.ReadLine();

            switch (letterGrade.ToUpper()) // exact matches ONLY
            {
                case "A":
                    Console.WriteLine("This is from 85 - 100");
                    break;
                case "B":
                    Console.WriteLine("This is from 70 - 84");
                    break;
                case "C":
                    Console.WriteLine("This is from 55 - 69");
                    break;
                case "D":
                    Console.WriteLine("This is from 40 - 54");
                    break;
                default:
                    Console.WriteLine("This is from 0 - 39");
                    break;
            }
        }

        private static void LetterGrades()
        {
            Console.WriteLine("\n\nLetter Grades");
            Console.WriteLine("-------------");

            Console.Write("Enter a percentage grade (whole number): ");
            int grade = int.Parse(Console.ReadLine());

            // Find the correct range for the letter grade
            char letterGrade;
            if (grade >= 85)
                letterGrade = 'A'; // 85 - 100
            else if (grade >= 70)
                letterGrade = 'B'; // 70 - 84
            else if (grade >= 55)
                letterGrade = 'C'; // 55 - 69
            else if (grade >= 40)
                letterGrade = 'D'; // 40 - 54
            else
                letterGrade = 'F'; // 0 - 39

            Console.WriteLine($"The grade is a(n) '{letterGrade}'");
        }

        private static void HighestOfThree()
        {
            Console.WriteLine("\n\nHighest of Three");
            Console.WriteLine("----------------");

            int first, second, third, highest;
            Console.Write("Enter a whole number: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Enter another whole number: ");
            second = int.Parse(Console.ReadLine());
            Console.Write("Enter another whole number: ");
            third = int.Parse(Console.ReadLine());

            // Assume all numbers are different
            if (first > second)
            {
                highest = first;
            }
            else
            {
                highest = second;
            }

            if (third > highest)
            {
                highest = third;
            }

            Console.WriteLine($"The highest is {highest}");
        }

        private static void HighestOfTwo()
        {
            Console.WriteLine("Highest of Two");
            Console.WriteLine("--------------");

            int first, second;
            Console.Write("Enter a whole number: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Enter another whole number: ");
            second = int.Parse(Console.ReadLine());

            string message;
            if (first > second)
                message = $"The highest is {first}";
            else if (second > first)
                message = $"The highest is {second}";
            else
                message = "Both numbers are the same";

            Console.WriteLine(message);
        } // end of HighestOfTwo() method
    } // end of Program class
} // end of namespace
