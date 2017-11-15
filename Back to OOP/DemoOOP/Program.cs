using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();
            // comment out demos as needed
            app.DemoPerson();
        }

        #region Demo Methods
        private void DemoPerson()
        {
            // Declare a couple of Person variables
            Person fred, wilma;
            // Instantiate (create) my Person objects
            fred = new Person("Fred", "Flintstone", new DateTime(105, 9, 28));
            wilma = new Person("Wilma", "Slaghoople", new DateTime(107, 2, 24));
            // Use these people
            IntroduceSelf(fred);
            IntroduceSelf(wilma);
            // side note - what happens if we try to output the object
            Console.WriteLine(fred.ToString());
            Console.WriteLine(wilma);
            // At the end of college....
            MarryPeople(fred, wilma);
        }

        private void MarryPeople(Person husband, Person wife)
        {
            // Traditional marriage, taking of last name
            wife.LastName = husband.LastName;
            Console.WriteLine("I now pronouce you Husband and Wife!");
            Console.WriteLine($"May I introduce Mr. {husband} and Mrs. {wife}!");
        }

        private void IntroduceSelf(Person someone)
        {
            Console.WriteLine($"Hi, my name is {someone.FirstName}.");
        }
        #endregion
    }
}
