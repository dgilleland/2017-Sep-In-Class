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

        // Constructor
        public Person(string first, string last, DateTime dob)
        {
            // body of constructor
            FirstName = first;
            LastName = last;
            BirthDate = dob;
        }


    }
}
