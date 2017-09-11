namespace OOPFundamentals
{
    public class Greeter
    {
        // Fields (to hold information)
        private string _WelcomeMessage;
        private string _FarewellMessage;

        // Constructor (to set up the data for objects)
        public Greeter(string welcomeMsg, string farewellMsg)
        {
            // The job of a constructor is to make sure that
            // all the fields/properties have "meaningful" values

            // Here, I'm just taking the information passed in
            // through the parameters and storing them
            // inside my fields.
            _WelcomeMessage = welcomeMsg;
            _FarewellMessage = farewellMsg;
        } // end of the constructor

        // Methods
        public string SayHello()
        {
            return _WelcomeMessage;
        }

        public string SayGoodbye()
        {
            return _FarewellMessage;
        }
    } // end of the class definition
} // end of the namespace
