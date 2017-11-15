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
