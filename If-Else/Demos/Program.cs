using System;

namespace Demos
{
    public class Program
    {
        #region Driver Method
        public static void Main(string[] args)
        {
            string menuChoice;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Demo Selection Statements");
            Console.WriteLine("=========================");

            DisplayMenu();
            menuChoice = Console.ReadLine().ToUpper();
            ProcessMenuChoice(menuChoice);
        } // end of Main()

        #endregion

        #region General Purpose Methods
        private static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("A) Highest of Two");
            Console.WriteLine("B) Highest of Three");
            Console.WriteLine("C) Letter Grades");
            Console.WriteLine("D) Letter Grade to Range");
            Console.WriteLine("E) Username and Password");
            Console.WriteLine("F) Palindrome");
            Console.WriteLine("G) Strong Password");
            Console.WriteLine("H) Alphabetic Order");
            Console.WriteLine("X) eXit");
            Console.ResetColor();
            Console.Write("Select an option from the menu: ");
        }

        private static void ProcessMenuChoice(string choice)
        {
            switch (choice)
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
                    UserNameAndPassword();
                    break;
                case "F":
                    Palindrome();
                    break;
                case "G":
                    StrongPassword();
                    break;
                case "H":
                    AlphabeticOrder();
                    break;
                case "X":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid menu choice.");
                    break;
            }
            Pause();
            Console.ResetColor();
        }

        private static void Pause()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
        }
        #endregion

        #region Menu Processing Methods
        // TODO: Your specific menu processing methods.
        private static void AlphabeticOrder()
        {
            // Strings can be compared using the .Compare()
            // method.
            throw new NotImplementedException();
        }

        private static void StrongPassword()
        {
            // A strong password has
            // - a mixture of upper and lower case
            // - a number
            // - some punctuation or symbol
            throw new NotImplementedException();
        }

        private static void Palindrome()
        {
            // A palindrome is a word or phrase that is
            // the same as it is when printed in reverse.
            throw new NotImplementedException();
        }

        private static void UserNameAndPassword()
        {
            // This example checks a username and a password
            // to make sure that neither is "inside" the other.
            throw new NotImplementedException();
        }

        private static void LetterGradeToRange()
        {
            Console.Write("Enter a letter grade: ");
            string letterGrade = Console.ReadLine();

            switch (letterGrade) // exact matches ONLY
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
            Console.WriteLine("---------------");

            Console.Write("Enter a percentage grade (whole number: ");
            int grade = int.Parse(Console.ReadLine());

            // find the correct range for the letter grade
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

            Console.WriteLine($"The grade is an '{letterGrade}'");
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

            string message = "Both numbers are the same";
            if (first > second)
                message = $"The highest is {first}";
            else if (second > first)
                message = $"The highest is {second}";

            Console.WriteLine(message);
        } // end of HighestOfTwo() method
        #endregion
    }
}
