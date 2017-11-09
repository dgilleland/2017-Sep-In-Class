using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoSearchingArrays();
            DemoArrayAsReferenceType();
        }

        static void DemoArrayAsReferenceType()
        {
            // driver for the demo
            double[] data = GetNumbers();
            DoubleOrNothing(data);
            string numbers = string.Join(", ", data);
            Console.WriteLine($"The changed data is:\n\t{numbers}");
        }

        /// <summary>
        /// Modifies an array by doubling all positive values and
        /// setting all negative values to zero.
        /// </summary>
        /// <param name="values">The array that you want modified</param>
        private static void DoubleOrNothing(double[] values)
        {
            for (int index = 0; index < values.Length; index++)
                if (values[index] > 0)
                    values[index] = values[index] * 2;
                else
                    values[index] = 0;
        }

        static double[] GetNumbers()
        {
            double[] numbers = new double[5];
            double temp;
            for(int index = 0; index < numbers.Length; index++)
            {
                Console.Write("Enter a number: ");
                while (!double.TryParse(Console.ReadLine(), out temp))
                    Console.Write("  Try again: ");
                numbers[index] = temp;
            }
            return numbers;
        }

        static void DemoSearchingArrays()
        {
            // Searching un-sorted arrays
            // A) Searching an array of unique values
            string[] uniqueNames = { "Dan", "Don", "Phil", "Sam", "Gerry", "Jerry", "Lucy", "Annette", "Tim", "Bobby" };
            Console.Write("Enter a name to search for: ");
            string searchName = Console.ReadLine();
            string found = null; // we may or may not find the name
            int foundPosition = -1; // -1 is a "sentry" value for "not found"
            // searching is done by looping through the array
            for(int index = 0; index < uniqueNames.Length; index++)
            {
                if(uniqueNames[index] == searchName)
                {
                    found = uniqueNames[index];
                    foundPosition = index;
                    // Optionally, we can exit the loop as soon as we've found the searchName
                    break; // force-exits the loop
                }
            }
            if (foundPosition >= 0) // if (found != null // if(found == searchName)
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
                                 // in the searchResults
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
            {
                Console.Write(searchResults[index] + ", ");
                Console.Beep();
            }
            Console.WriteLine();
            Console.ResetColor();

            // B-2) We can "shrink" the results by copying to another array
            string[] temp = new string[logicalSize];
            for (int index = 0; index < logicalSize; index++)
                temp[index] = searchResults[index];
            // replace the original search results with the temp
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
    }
}
