using System;

namespace PrimitiveDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Textual Information
            string message = "Hello World!"; // Initialization Statment
            char gender = 'M'; // a char can hold a single character

            // Numeric Information (more to come)
            // - Whole Numbers
            int classSize = 22;

            Console.WriteLine("The largest int value is " + int.MaxValue);
            Console.WriteLine("The smallest int value is " + int.MinValue);
            
            // Here, I'm using a long data type because it has a higher upper-value
            // than int.MaxValue (which I'll need to calculate how many possible
            // values an integer has).
            long possibleValues = (long)int.MaxValue - int.MinValue;
            //                    \ Casting to long /

            Console.WriteLine("An integer can hold " + possibleValues + " values.");

            // - Real Numbers (they have a fractional component)
            double pi = 3.1415926;
            double radius = 10;
            double area;
            area = pi * radius * radius;

            // Use string interpolation to build a string with variables
            Console.WriteLine($"The area is {area} for a circle with radius {radius}");
            // String interpolation is possible by
            // - putting the dollar sign before the first double-quote
            // - Any variable you want to inject into your string can be
            //   placed inside curly braces.

            // Print a blank line
            Console.WriteLine();

            // Recalculate using a more precise value for PI
            area = Math.PI * radius * radius;
            Console.WriteLine($"A more precise area is {area}");

            // Here is an object based on the Person class
            Person instructor;
            // Next, I need to actually create the object (instantiation)
            instructor = new Person(); // Notice the new keyword
            // Assign some information to this object
            instructor.Name = "Dan Gilleland";
            instructor.Age = 40; // Not the truth.....

            Console.WriteLine(); // blank line
            Console.WriteLine($"I am being taught by {instructor.Name}.");
        }
    }
}
