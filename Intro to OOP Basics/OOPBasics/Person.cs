namespace OOPBasics
{
    // This is a very simple class with two "fields" that hold information.
    // When I declare a class, I'm designing a new "data type".
    public class Person
    {
        // Declare a couple of "fields" to hold information
        // A field is simply a "variable" that belongs to the class/object
        // Also known as "member variables"
        // The data inside is "vulnerable"
        public string Name;
        private int _Age; // "hidden" from outside access

        // Properties "look like" fields (from the outside),
        // but act like methods on the inside.
        // Properties provide "controlled access" to the data
        // stored in the underlying fields.
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                // The "set" and the "get are like the bodies of
                // methods.
                _Age = value;
            }
        }
    }
}
