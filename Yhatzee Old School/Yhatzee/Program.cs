using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yhatzee
{
    class Program
    {
        // Need a random number generator
        static Random rnd = new Random(); // (pst. this is an object.... ;)

        static void Main(string[] args)
        {
            int[] dice = new int[5];

            // "Roll" the die
            for (int index = 0; index < dice.Length; index++)
                dice[index] = rnd.Next(1, 7); // random number between 1 and 6

            // Show the die rolls.....
            string dieValues = string.Join(", ", dice);
            Console.WriteLine($"Rolled the following:\n\t{dieValues}");

            Reroll(dice);
        }

        static void Reroll(int[] dice)
        {
            Console.WriteLine("Enter an index of which die to change (zero-based, -1 to stop");
            int index;
            do
            {
                Console.Write("Die index: ");
                while (!int.TryParse(Console.ReadLine(), out index) || index >= dice.Length)
                    Console.Write("\tTry again: ");
                // reroll the specified die
                if (index >= 0)
                    dice[index] = rnd.Next(1, 7);
            } while (index >= 0);
            Console.WriteLine($"New die: {string.Join(", ", dice)}");
        }
    }
}
