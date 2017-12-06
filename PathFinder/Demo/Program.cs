using System;
using System.Collections.Generic;
using System.IO; // Makes life easier
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ente a path: ");
            string folder = Console.ReadLine();
            string filePath = Path.Combine(folder, "ReadMe.txt");
            var allLines = File.ReadAllLines(filePath);
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (string line in allLines)
                Console.WriteLine(line);
            Console.ResetColor();
        }
    }
}
