using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Demos");
            Console.WriteLine("===========\n\n");
            // TODO: Set up menu, and a ProcessMenuChoice method
            //TotalNumbers();
            //DemoLargest();
            DemoArrayAsReferenceType();
        } // end of the Main() method

        static void DemoArrayAsReferenceType()
        {
            double[] data = GetNumbers();
            DoubleOrNothing(data);
            // Easy way to display all the data....
            foreach (double item in data)
                Console.WriteLine(item);
        }

        /// <summary>
        /// Modifies an array by doubling all positive values and
        /// setting all negative values to zero.
        /// </summary>
        /// <param name="values">The array that you want modified</param>
        static void DoubleOrNothing(double[] values)
        {
            for (int index = 0; index < values.Length; index++)
                if (values[index] > 0)
                    values[index] = values[index] * 2;
                else
                    values[index] = 0;
        }





        static void DemoLargest()
        {
            double[] data = GetNumbers();
            // display the data
            for (int index = 0; index < data.Length; index++)
                Console.WriteLine($"\t\t data[{index}] is {data[index]}");
            double max = FindLargestNumber(data);
            Console.WriteLine($"the largest number was {max}");
        }

        static double FindLargestNumber(double[] values)
        {
            double biggest = values[0]; // take the first as the biggest to start with
            for (int index = 1; index < values.Length; index++)
                if (values[index] > biggest) // if this is bigger
                    biggest = values[index]; // then "remember" it
            return biggest;
        }

        // A method that will get an array of numbers from the user
        static double[] GetNumbers()
        {
            double[] numbers = new double[5]; // an array of 5 numbers
            for(int index = 0; index < numbers.Length; index++)
            {
                Console.Write("Enter a number: ");
                // Validate that a number is entered
                double temp;
                while (!double.TryParse(Console.ReadLine(), out temp))
                    Console.Write(" - try again: ");
                // Store the number into the array
                numbers[index] = temp;
            }
            return numbers; // send back the array of values
        }

        static void TotalNumbers()
        {
            int[] numbers = { 45, 12, 36, 92, -4, 8, 13 };
            Console.WriteLine($"There are {numbers.Length} numbers");
            // We can loop to add up all the numbers
            int total = 0;
            for (int indexPosition = 0; indexPosition < numbers.Length; indexPosition++)
                total += numbers[indexPosition];
            Console.WriteLine($"the total is {total}");
            Console.WriteLine($"the integer average is {total / numbers.Length}");
            Console.WriteLine($"the real average is {(double)total / numbers.Length}");
        }
    }
}
