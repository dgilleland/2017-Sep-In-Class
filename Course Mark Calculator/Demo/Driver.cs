using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Driver // by default, the Driver class is internal
    {
        private StudentMark _MyStudent; // field
        public void Run()
        {
            // 1) Create a StudentMark object
            GetCourseAndStudent();
            // 2) Configure it by creating EvaluationGroups/WeightedMarks
            ConfigureCourseEvaluations();
            // 3) Enter the student's marks so far
        }

        private void GetCourseAndStudent()
        {
            Console.Write("Enter your name: ");
            string student = Console.ReadLine();
            Console.Write("Enter the course name: ");
            string course = Console.ReadLine();
            _MyStudent = new StudentMark(student, course);
        }

        private void ConfigureCourseEvaluations()
        {
            while(RemainingCourseMarks() > 0)
            {
                // Get a group
                GetCourseGroup();
            }
        }

        private void GetCourseGroup()
        {
            Console.Write("Name a group of marks: ");
            string name = Console.ReadLine();
            Console.Write("Is a pass mark required for the group? (Y/N) ");
            string pass = Console.ReadLine().ToUpper();
            bool isPass = pass.Equals("Y");
            var evalGroup = new EvaluationGroup(name, isPass);
            _MyStudent.EvaluationItems.Add(evalGroup);
            GetWeightedMarks(evalGroup);
        }

        private void GetWeightedMarks(EvaluationGroup group)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            do
            {
                // Ask for a name/mark for an item in the group
                Console.Write($"Enter an item in {group.GroupName} (or blank to stop entering items in group): ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    break; // hacky way to exit loop
                double max = RemainingCourseMarks();
                Console.Write($"Enter a weight (up to {max}): ");
                double weight;
                while (!double.TryParse(Console.ReadLine(), out weight)
                      || weight <= 0 || weight > max)
                    Console.Write("\tTry again: ");
                var item = new WeightedMark(name, weight);
                group.Items.Add(item);
            } while (RemainingCourseMarks() > 0);
            Console.ResetColor();
        }

        private double RemainingCourseMarks()
        {
            double total = 0;
            foreach (var group in _MyStudent.EvaluationItems)
                total += group.TotalWeight;
            return 100 - total;
        }
    }
}
