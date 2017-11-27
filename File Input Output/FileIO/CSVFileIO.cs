/* Code comes from
 * https://leanpub.com/programming0101/read#leanpub-auto-overview-14
 */
using System.Collections.Generic;
using System.IO; // Key for all file input/output

namespace FileIO
{
    /// <summary>
    /// The CSVFileStorage class provides simple reading of all the lines of text of a CSV(Comma-Separated-Values) file.
    /// </summary>
    public class CSVFileIO
    {
        public string FilePath { get; private set; }

        /// <summary>
        /// Initializes a new instance of the CSVFileStorage class.
        /// </summary>
        public CSVFileIO(string filePath)
        {
            FilePath = filePath;
        }

        public List<string> ReadAllLines()
        {
            List<string> lines = new List<string>();
            using (TextReader reader = new StreamReader(FilePath))
            {
                string aSingleLine = reader.ReadLine();
                while (aSingleLine != null)
                {
                    lines.Add(aSingleLine);
                    aSingleLine = reader.ReadLine();
                }
            }
            return lines;
        }

        public void WriteAllLines(List<string> lines, bool append)
        {
            using (TextWriter writer = new StreamWriter(FilePath, append))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}