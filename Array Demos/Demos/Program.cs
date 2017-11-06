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
            //DemoArrayAsReferenceType();
            DemoSearchingArrays();
        } // end of main()

        static void DemoSearchingArrays()
        {
            // Searching un-sorted arrays
            // A) Searching an array of unique values
            string[] uniqueNames = { "Dan", "Don", "Phil", "Sam", "Gerry", "Jerry", "Lucy", "Annette", "Tim", "Bobby" };
            Console.Write("Enter a name to search for: ");
            string searchName = Console.ReadLine();
            string found = null; // we may or may not find the name
            int foundPosition = -1; // -1 is a "sentry" value for "not found"
            for(int index = 0; index < uniqueNames.Length; index++)
            {
                if(uniqueNames[index] == searchName)
                {
                    found = uniqueNames[index];
                    foundPosition = index;
                    // Optionally, we can exit the loop as soon as we've
                    // found the searchName
                    break; // force-exits the loop
                }
            }

            if (foundPosition >= 0) // if (found != null) // if (found == searchName)
                Console.WriteLine($"We found {found} at position {foundPosition}");
            else
                Console.WriteLine("Name was not found");

            // B) Searching an array for non-unique values (possible duplicates)
            Console.WriteLine();
            Console.Write("Enter the length of the name you want: ");
            int searchLength;
            while (!int.TryParse(Console.ReadLine(), out searchLength))
                Console.Write("\tTry again: ");
            // Allow for a possible 100% match...
            string[] searchResults = new string[uniqueNames.Length];
            int logicalSize = 0; // Logical size will tell us a) how many we've found
                                 // and b) the position of the next available element
                                 // in the searchResults.
            for(int index = 0; index < uniqueNames.Length; index++)
            {
                if(uniqueNames[index].Length == searchLength)
                {
                    searchResults[logicalSize] = uniqueNames[index];
                    // increment my logical size
                    logicalSize++;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Found the following names: ");
            for (int index = 0; index < logicalSize; index++)
                Console.Write(searchResults[index] + ", ");
            Console.WriteLine();
            Console.ResetColor();

            // B-2) We can "shring" the results by copying to another array
            string[] temp = new string[logicalSize];
            for (int index = 0; index < logicalSize; index++)
                temp[index] = searchResults[index];
            // replaced the original search results with the temp
            searchResults = temp;

            Console.WriteLine("\nWe can join the string array elements into a single string, with a delimiter.");
            Console.Write("Enter a delimiter: ");
            string delimiter = Console.ReadLine();

            // Use the string.Join() method to create a string from an array
            string results = string.Join(delimiter, searchResults);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(results);
            Console.ResetColor();
        }

        static void DemoArrayAsReferenceType()
        {
            double[] data = GetNumbers();
            DoubleOrNothing(data);
            // Easy way to display all the data....
            foreach (int item in data)
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
            double[] data = GetNumbers(); // call a method
            // display the data
            for (int index = 0; index < data.Length; index++)
                Console.WriteLine($"\t- {data[index]}");
            double max = FindLargestNumber(data);
            Console.WriteLine($"The largest number was {max}");
        }

        static double FindLargestNumber(double[] values)
        {
            double biggest = values[0]; // take the first as the starting higest;
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
                // Store the number entered
                numbers[index] = temp;
            }
            return numbers; // send back the array of values
        }

        static void TotalNumbers()
        {
            int[] numbers = { 45, 12, 36, 92, -4, 8, 13 };
            Console.WriteLine($"There are {numbers.Length} numbers:");
            // We can loop to add up all the numbers
            int total = 0;
            for (int indexPosition = 0; indexPosition < numbers.Length; indexPosition++)
                total += numbers[indexPosition];
            Console.WriteLine($"The total is {total}");
            Console.WriteLine($"The integer average is {total / numbers.Length}");
            Console.WriteLine($"The real average is {(double)total / numbers.Length}");
        }

    }
}
