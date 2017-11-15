using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemos
{
    public class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; private set; }
        public string Initials
        {
            get
            {
                return $"{FirstName[0]}.{LastName[0]}.";
            }
        }
        public int Age
        {
            get
            {
                int result = 0;
                // What should the calculation be??
                var yearDiff = DateTime.Today.Year - BirthDate.Year;
                var monthDiff = DateTime.Today.Month - BirthDate.Month;
                var dayDiff = DateTime.Today.Day - BirthDate.Day;
                if (monthDiff > 0 || (monthDiff == 0 && dayDiff >=0))
                    result = yearDiff;
                else
                    result = yearDiff - 1;
                return result;
            }
        }

        // Constructor
        public Person(string first, string last, DateTime dob)
        {
            // body of constructor
            FirstName = first;
            LastName = last;
            BirthDate = dob;
        }

        // Methods
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
