namespace OOPBasics
{
    public class Person
    {
        // Fields - member variable to hold information
        public string Name;
        // common convention to use underscores at the start of fields
        private int _Age; // A private field cannot be manipulated from the "outside"


        // Properties - look like fields but internally act like methods
        //            - Properties provide controlled access to data
        public int Age
        {
            get // The get runs when someone tries to "see" Age
            {
                return _Age;
            }
            set // The set runs when someone tries to "change" Age
            {
                // TODO: Prevent negative values for Age
                if (value < 0)
                    ; // deal with the problem
                _Age = value; // Value is a keyword for setters only
            }
        }

        // Constructors - ensure fields/properties have "meaningful" data

        // Methods - sets of instructions; represent what objects based on this class can "do"
    }
}
