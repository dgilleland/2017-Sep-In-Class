using System;

namespace Demos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //HighestOfTwo();
            //HighestOfThree();
            //LetterGrades();
            LetterGradeToRange();
        } // end of Main() method

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
