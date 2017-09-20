using System; // for the Console class
namespace Expressions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Automatic Type Conversions");
            Console.WriteLine();
            // 1)  10.0 + 15 / 2 + 4.3
            Console.Write("#1)  10.0 + 15 / 2 + 4.3 = ");
            Console.WriteLine(10.0 + 15 / 2 + 4.3);
            //                \  EXPRESSION     /

            //  2)  8 / 5 + 1.25
            Console.Write("#2)  8 / 5 + 1.25 = ");
            Console.WriteLine(8 / 5 + 1.25);

            //  3)  10.0 + 15.0 / 2 + 4.3
            Console.Write("#3)  10.0 + 15.0 / 2 + 4.3 = ");
            Console.WriteLine(10.0 + 15.0 / 2 + 4.3);

            //  4)  3.0 * 4 / 6 + 6
            Console.Write("#4)  3.0 * 4 / 6 + 6 = ");
            Console.WriteLine(3.0 * 4 / 6 + 6);

            //  5)  3.0 * (4 % 6) + 6
            Console.Write("#5)  3.0 * (4 % 6) + 6 = ");
            Console.WriteLine(3.0 * (4 % 6) + 6);

            //  6)  3 * 4.0 / 6 + 6
            Console.Write("#6)  3 * 4.0 / 6 + 6 = ");
            Console.WriteLine(3 * 4.0 / 6 + 6);

            //  7)  20.0 - 2 / 6 + 3
            Console.Write("#7)  20.0 - 2 / 6 + 3 = ");
            Console.WriteLine(20.0 - 2 / 6 + 3);

            //  8)  10 + 17 % 3 + 4
            Console.Write("#8)  10 + 17 % 3 + 4 = ");
            Console.WriteLine(10 + 17 % 3 + 4);

            //  9)  (10 + 17) % 3 +4.0
            Console.Write("#9)  (10 + 17) % 3 +4.0 = ");
            Console.WriteLine((10 + 17) % 3 + 4.0);

            // 10)  10 + 17 / 4.0 + 4
            Console.Write("#10)  10 + 17 / 4.0 + 4 = ");
            Console.WriteLine(10 + 17 / 4.0 + 4);

        }
    }
}
