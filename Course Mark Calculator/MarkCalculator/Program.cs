using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Purpose - to model the idea of a course that has a number
            //           of weighted items that are evaluated as a group

            //SandBox();
            Console.WriteLine($"I am about to call the method {nameof(TheSecondSandbox)}");
            TheSecondSandbox();
        }

        private static void TheSecondSandbox()
        {
            // Quickly demo the EvaluationGroup class.
            EvaluationGroup quizzes = new EvaluationGroup("Quizzes", true);
            WeightedMark something;
            something = new WeightedMark("Quiz 1", 5);
            quizzes.Items.Add(something);
            something = new WeightedMark("Quiz 2", 10);
            quizzes.Items.Add(something);
            Console.WriteLine($"So far, there are {quizzes.Items.Count} {quizzes.GroupName} that have a total weight of {quizzes.TotalWeight}%");

            Console.ForegroundColor = ConsoleColor.Cyan;
            quizzes.Items.Add(new WeightedMark("Quiz 3", 5));
            Console.WriteLine($"So far, there are {quizzes.Items.Count} {quizzes.GroupName} that have a total weight of {quizzes.TotalWeight}%");
            foreach (var item in quizzes.Items)
                Console.WriteLine($"\t{item.Name} is {item.Weight} %");
        }

        static void SandBox()
        {
            WeightedMark[] quizzes = new WeightedMark[3];
            int index = 0;
            while(index < quizzes.Length)
            {
                try
                {
                    // Get a quiz name/weight from the user
                    Console.Write("Enter a quiz name: ");
                    string name = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Enter a weight: ");
                    double quizWeight = double.Parse(Console.ReadLine());

                    // Store that in the array
                    quizzes[index] = new WeightedMark(name, quizWeight);

                    index++;
                }
                catch(FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Unable to create a number from your input.");
                }
                catch(ArgumentNullException ex) // More specific
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Error with {ex.ParamName} - {ex.Message}");
                }
                catch(ArgumentException ex) // less specific
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error - {ex.Message}");
                }
                finally
                {
                    Console.ResetColor();
                }
            }

            double total = 0;
            foreach (WeightedMark item in quizzes)
                total += item.Weight;
            Console.WriteLine($"There are {quizzes.Length} quizzes that total {total}%.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            foreach (var item in quizzes)
                Console.WriteLine($"\t{item.Weight} % - {item.Name}");

            // Enter some marks
            foreach (var quiz in quizzes)
            {
                Console.Write($"Enter a mark for {quiz.Name} (or leave blank): ");
                double mark;
                if (double.TryParse(Console.ReadLine(), out mark))
                    quiz.EarnedMark = mark;
            }
            double earned = 0;
            foreach (var item in quizzes)
                if (item.EarnedMark.HasValue)
                    earned += item.EarnedMark.Value;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You have earned {earned}/{total} on your quizzes.");
        }
    }
}
