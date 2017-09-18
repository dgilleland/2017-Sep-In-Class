using System;


namespace OOPFundamentals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Let's make a more "sophisticated" Hello World program
            // Declare an object variable based on the Greeter data type.
            Greeter walmartGreeter;
            // Create (instantiate) the Greeter object
            walmartGreeter = new Greeter("Welcome to Walmart!", "Thank you for shopping at Walmart!");

            Greeter klingonCommander;
            klingonCommander = new Greeter("nuqneH!", "Qapla'!");

            // Have each Greeter object speak....
            Program.Speak(walmartGreeter);
            Program.Speak(klingonCommander);
        } // end of Main() method

        public static void Speak(Greeter person)
        {
            // With this object, I can call my methods to
            // say hello or goodbye
            Console.WriteLine(person.SayHello());
            Console.WriteLine(person.SayGoodbye());
        } // end of Speak() method
    } // end of Program class definition
} // end of namespace
