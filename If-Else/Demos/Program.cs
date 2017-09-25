using System;

namespace Demos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HighestOfTwo();
            //HighestOfThree();
            //LetterGrades();
        } // end of Main() method

        private static void LetterGrades()
        {
            throw new NotImplementedException();
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
