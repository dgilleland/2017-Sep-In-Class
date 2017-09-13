/* File: Program.cs
 * Author: Dan Gilleland
 * Purpose: To demonstrate the very basic parts of a C# program.
 */
// A using statement allows us access to all the classes in a
// particular namespace
using System;

namespace Basics
{
    public class Program // At a minimum, every C# program needs one class
    {
        // The following is a static method.
        // A method is simply a set of instructions.
        // The Main() method is the entry point for our program.
        static void Main(string[] args) // Our driver
        { 
            // Display the text "Hello World" on the screen
            Console.WriteLine("Hello World");

            // Create a variable and give it a starting value
            string message = "Hello"; // Initialization Statement
            Console.WriteLine(message);
            string name; // Declaration Statement
            name = "Dan"; // Assignment Statement

            // String Concatenation
            message = message + " " + name;
            Console.WriteLine(message);

            Console.WriteLine(); // Blank line
            // Prompt the user to enter information
            Console.Write("What is your name? ");
            // Grab the response
            name = Console.ReadLine(); // Read a line of text
            // Say hello to the user!
            Console.WriteLine("Hello " + name);

            // Create a variable to hold whole numbers
            int amountOfTime = 2; // for 2 weeks....
            // Do concatenation of a string and an integer
            Console.WriteLine("I have been coding for " + amountOfTime + " weeks");

            int max = int.MaxValue;
            Console.WriteLine("The largest int is " + max);
            Console.WriteLine("The smallest in is " + int.MinValue);

            long totalPossibleValues = 
                (long) int.MaxValue - int.MinValue;

            // Another way of building strings is using
            // String Interpolation
            message = $"The number of unique int values is {totalPossibleValues}";
            Console.WriteLine(message);


            // Real Numbers (they have a fractional component)
            double pi = 3.14159;
            double radius = 10;
            double area;
            area = pi * radius * radius;

            message = $"The area is {area} for a circle with radius {radius}.";
            Console.WriteLine(message);

            area = Math.PI * radius * radius;
            message = $"The area is {area} for a circle with radius {radius}.";
            Console.WriteLine(message);

            char areWeThereYet = 'Y';
            Console.WriteLine($"Are we done today? {areWeThereYet}");
        }
    }
}
