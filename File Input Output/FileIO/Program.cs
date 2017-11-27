using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoReadingSourceCode();
            DemoAdvancedPortfolioFileRead();
        }

        static void DemoAdvancedPortfolioFileRead()
        {
            var nameReader = new CSVFileIO("Names.txt");
            var lines = nameReader.ReadAllLines();
            // "Parse" the lines into three parallel arrays
            string[] names = new string[lines.Count];
            string[] genders = new string[lines.Count];
            int[] counts = new int[lines.Count];

            // loop through all the lines of text from the file
            // and populate the three parallel arrays
            for(int index = 0; index < lines.Count; index++)
            {
                // Split a line
                string[] data = lines[index].Split(',');

                names[index] = data[0]; // the first item
                genders[index] = data[1]; // the second item
                counts[index] = int.Parse(data[2]);
            }

            // TODO: Write a loop that will output the data in the
            //       parallel arrays with "labels". e.g.:
            //           Name: Mary    Gender: F      Count: 7065
            //           Name: Anna    Gender: F      Count: 2604

        }

        static void DemoReadingSourceCode()
        {
            var inputReader = new CSVFileIO("CSVFileIO.cs");
            List<string> lines = inputReader.ReadAllLines();
            // display all the lines slowly
            foreach(string lineOfText in lines)
            {
                //Console.WriteLine(lineOfText);
                foreach (char letter in lineOfText)
                {
                    Console.Write(letter);
                    System.Threading.Thread.Sleep(50); // 50 milliseconds
                }
                Console.WriteLine();
            }
        }
    }
}
