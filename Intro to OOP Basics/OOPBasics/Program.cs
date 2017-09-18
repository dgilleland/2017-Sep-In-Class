/* File: Program.cs
 * Author: Dan Gilleland
 * Purpose: Drivers to demonstrate various OOP Examples
 */
using System;

namespace OOPBasics
{
    public class Program
    {
        // Here's a method for my first console in/out demo
        public void DemoUserInputOutput()
        {
            // todo....
            Console.WriteLine("Hello OOP Basics!");

            string name; // Declaring a variable
            // Prompt - asking the user to enter some information
            Console.Write("What is your name? ");
            // Read the user's input
            name = Console.ReadLine(); // Capture the user's input

            // String interpolation allows me to inject my variable
            // values directly inside a string.
            Console.WriteLine($"Hello {name}!");

            Console.WriteLine("Good to meet you {0}", name);
        }

        public static void DemoSimplePerson()
        {
            // Demonstrate using the Person data type (class)
            // to create variables (objects)
            Person me;
            Person myFriend;
            // Instantiate (create new) Person objects
            me = new Person("Dan Gilleland", 40); // new is a keyword
            // Assign what my name/age is
            //me.Name = "Dan Gilleland";
            //me.Age = 40; // that's a lie....
            Console.WriteLine($"My age is {me.Age}");

            // Instantiate another Person object
            myFriend = new Person("Fred Flintstone", 43);
            //{ // initialization list..
            //    Name = "Fred Flintstone",
            //    Age = 43
            //};


            string message;
            message = $"My name is {me.Name} and my friend is {myFriend.Name}";
            Console.WriteLine(message);


        }

        public static void Main(string[] args) // method header
        {   // Open curly brace is the start of the body
            // Run the first demo
            Program app = new Program(); // Create a Program object
            app.DemoUserInputOutput(); // Call the Instance Method
            DemoSimplePerson(); // Call the Static Method
        }   // end of Main() method body
    }
}
