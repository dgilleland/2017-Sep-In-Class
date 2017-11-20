using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Sandbox();
        }

        static void Sandbox() // TODO: Throw away when all done
        {
            try
            {
                // Play with WeightedMark objects
                EvaluationGroup quizzes = new EvaluationGroup("Quizzes", true);
                quizzes.Items.Add(new WeightedMark("Quiz 1", 5));
                quizzes.Items.Add(new WeightedMark("Quiz 2", 10));
                quizzes.Items.Add(new WeightedMark("Quiz 3", 5));

                Console.WriteLine($"There are {quizzes.Items.Count} quizzes that total a weight of {quizzes.TotalWeight}");

                //WeightedMark hackersMark;
                //Console.Write("Enter a quiz name: ");
                //string name = Console.ReadLine();
                //Console.Write("Enter a weight for the quiz: ");
                //double weight = double.Parse(Console.ReadLine());
                //hackersMark = new WeightedMark(name, weight);
            }
            catch(ArgumentNullException ex) // More "specific"
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Error with {ex.ParamName} - {ex.Message}");                
            }
            catch(ArgumentException ex) // Less "specific"
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Problem with {ex.ParamName} - {ex.Message}");
            }
            catch(FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Unable to format the input as a number.");
            }
            finally
            {
                Console.ResetColor();
            }
        }
    }
}
