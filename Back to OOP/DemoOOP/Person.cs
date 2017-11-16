using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    public class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; private set; }
        public string Initials
        {
            get // We can calculate the value
            {
                return $"{FirstName[0]}.{LastName[0]}.";
            }
            // No setter is needed
        }
        public int Age
        {
            get
            {
                int years;
                years = DateTime.Today.Year - BirthDate.Year;
                // See if they haven't reached their
                // birthday for this year yet...
                if (DateTime.Today.Month - BirthDate.Month < 0 ||
                    (DateTime.Today.Month - BirthDate.Month == 0 &&
                     DateTime.Today.Day - BirthDate.Day < 0))
                    years--; // Take off a year
                return years;
            }
        }

        // Constructor
        public Person(string first, string last, DateTime dob)
        {
            FirstName = first;
            LastName = last;
            BirthDate = dob;
        }

        // Method(s)
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
