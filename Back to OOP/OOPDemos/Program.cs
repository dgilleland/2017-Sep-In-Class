using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();
            // directly call demos as-needed
            app.DemoPerson();
        }

        #region Demos
        private void DemoPerson()
        {
            // Show how the Person class can be used
            // Declare my variables
            Person fred, wilma;
            // Create (instantiate) my objects
            fred = new Person("Fred", "Flintstone", new DateTime(105, 6, 30));
            wilma = new Person("Wilma", "Slaghoople", new DateTime(107, 2, 24));
            // They meet in college
            IntroduceSelf(fred);
            IntroduceSelf(wilma);

            // Try outputting the objects themselves
            Console.WriteLine(fred);
            Console.WriteLine(wilma);

            MarryThem(fred, wilma);
        }

        private void MarryThem(Person husband, Person wife)
        {
            // Traditional marriage in the cartoon series
            wife.LastName = husband.LastName;
            Console.WriteLine($"I now pronounce you husband and wife!");
            Console.WriteLine($"Let me introduce Mr. {husband} and Mrs. {wife}.");
        }

        private void IntroduceSelf(Person someone)
        {
            string message = $"Hi. I'm {someone.FirstName}.";
            Console.WriteLine(message);
        }
        #endregion
    }
}
