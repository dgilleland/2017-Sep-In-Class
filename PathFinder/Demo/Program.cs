using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // For all things Input/Output

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoFileIO();
            DemoStringTesting();
        }

        #region Super-Simple File I/O
        private static void DemoFileIO()
        {
            // build a path to a file
            Console.Write(@"Enter a folder-path on your C:\ drive: ");
            string folder = Console.ReadLine();
            string fileName = "ReadMe.md";
            var path = Path.Combine(@"C:\", folder, fileName);
            Console.WriteLine(path);

            // Ensure the folder exists
            if (!Directory.Exists(Path.GetDirectoryName(path)))
                Directory.CreateDirectory(Path.GetDirectoryName(path));

            // Write to the file
            var myFile = File.CreateText(path);
            myFile.WriteLine("# I am writing from C-Sharp");
            myFile.WriteLine("What do you think?");
            myFile.Flush();
            myFile.Close();

            // Read the file contents
            var lines = File.ReadAllLines(path);
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var line in lines)
                Console.WriteLine(line);
            Console.ResetColor();
        }
        #endregion

        #region String Testing
        private static void DemoStringTesting()
        {
            Console.Write("Enter some phrase: ");
            string phrase = Console.ReadLine();
            if (phrase.All(IsLetterOrSpace))
                Console.WriteLine("Good");
            else
                Console.WriteLine("Uhm. You included something other than letters and spaces...");
        }

        public static bool IsLetterOrSpace(char character)
        {
            return char.IsLetter(character) || char.IsWhiteSpace(character);
        }
        #endregion
    }
}
