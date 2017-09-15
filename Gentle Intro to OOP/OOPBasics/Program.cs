using System; // contains classes such as Console and Math

namespace OOPBasics
{
    public class Program
    {
        public static void Main(string[] args) // entry point....
        {
            // Call a static method on a class
            string userName;
            userName = Program.Recap("Gentle Intro to C# Basics");
            // Create an instance of the Program class
            Program app; // declare the object variable
            app = new Program(); // creates the object instance
            app.Driver(userName); // Run the Driver 
        }

        private void Driver(string name) // non-static / instance
        {
            Console.WriteLine();
            Console.WriteLine("Today's topic is OOP Basics");
            // Demonstrate a Person class
            Person theUser;
            Person friend;
            // Create a Person object and set the name/age
            theUser = new Person();
            theUser.Name = name;
            theUser.Age = 40; // lying again.... :(

            // Another way to create a Person
            Console.Write("What is the name of your friend? ");
            name = Console.ReadLine();
            friend = new Person()
            { // Initialization List
                Name = name,
                Age = 38
            };

            string message;
            message = $"Say hi to {friend.Name} for me. You are {theUser.Age - friend.Age} years older than your friend.";
            Console.WriteLine(message);
        }

        private static string Recap(string topic) // static
        {
            Console.WriteLine(topic);
            // Prompt for user name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, and welcome to the C# OOP Basics!");
            // send back the kind of information my method says it returns
            return name;
        }
    }
}
