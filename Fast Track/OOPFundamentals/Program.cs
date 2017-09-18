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
            // Let's try creating a more "sophisticated"
            // Hello World program by using the Greeter class.

            // Declare an object based on the Greeter data type.
            Greeter walmartGreeter;
            // Create the Greeter object
            walmartGreeter = new Greeter("Welcome to Walmart!", "Have a nice day!");

            Greeter klingonCommander;
            klingonCommander = new Greeter("nuqneH!", "Qapla'!");

            // Have each Greeter object speak...
            Program.Speak(walmartGreeter);
            Program.Speak(klingonCommander);
        } // end of Main() 

        public static void Speak(Greeter person)
        {
            // With this object, I can call my methods to
            // say hello or goodbye
            Console.WriteLine(person.SayHello());
            Console.WriteLine(person.SayGoodbye());
        } // end of Speak()
    } // end of Program class
} // end of namespace
