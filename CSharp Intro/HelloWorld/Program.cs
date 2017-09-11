/* This is an example of a
 * Multi-line Comment
 */

// You can write single-line comments by starting with double-slashes

// We can include all the classes in a namespace
// with the "using" keyword
using System; // The Console class is inside the System namespace

// A namespace is like a "container" to hold classes.
// Each class, within its namespace, must have a unique name.
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console is a class that supports text input/output
            // WriteLine() is a static member of the Console class
            // used to output text in the console window.
            Console.WriteLine("Hello World");
            //      \ Method Call          /

            // The . after Console is called the Member Access Operator

            // I can use the Console class with its Fully Qualified Name
            System.Console.WriteLine("Hello back!");

            // Print a blank line
            Console.WriteLine();

            // We can run our program by pressing [Ctrl] + [F5]

            // declare a string variable
            string message; // Create a string variable called message
            // Assign some text to the string
            message = "Some Text"; // This is an Assignment Statement

            Console.WriteLine(message); // "Some Text" will appear on the screen

            // Any time I change the value in a variable, the old value is "lost"
            message = "Hello World";
            Console.WriteLine(message);
        }
    }
}
