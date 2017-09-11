using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // This Main method is the entry point
            // for this program. As such, it's the
            // one method that we really must be
            // making "static".
            // By declaring it as "static", we are
            // saying that this method can be called
            // directly by the operating system as it
            // starts up our program.

            // A method contains a "set of instructions"
            // that will run.

            // You can write single-line comments in your code
            // by starting the comment with a "double-slash"
            // just like these statement here.
            // Comments don't "run" - they are there just to
            // provide extra information to the programmer
            // reading this code.

            // Declaring a variable inside a method will give
            // me a "place" to hold information
            int myAge = 32; // Variable Initialization Statement
            int averageClassAge; // Variable declaration statement

            // Assignment statement
            averageClassAge = 23; // This stores the value 23

            // Display the values on the screen
            Console.WriteLine(myAge);
            Console.WriteLine(averageClassAge);

            // To run this program, I can press [Ctrl] + [F5]

            // Our traditional "Hello World"
            Console.WriteLine("Hello World"); // displayed on screen

            // Let's try creating a more "sophisticated"
            // Hello World program by using the Greeter class.

            // Declare an object based on the Greeter data type.
            Greeter walmartGreeter;
            // Create the Greeter object
            walmartGreeter = new Greeter("Welcome to Walmart!", "Have a nice day!");
            // With this object, I can call my methods to
            // say hello or goodbye
            Console.WriteLine(walmartGreeter.SayHello());
            Console.WriteLine(walmartGreeter.SayGoodbye());


        }
    }
}
