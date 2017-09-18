namespace OOPFundamentals
{
    public class Greeter
    {
        // Fields (to hold information)
        private string _WelcomeMessage;
        private string _FarewellMessage;

        // Constructor (to set up the data for Greeter objects)
        public Greeter(string welcomeMsg, string farewellMsg)
        {
            // Just store the incoming data in my fields...
            _WelcomeMessage = welcomeMsg;
            _FarewellMessage = farewellMsg;
        } // end of constructor

        // Methods (to allow Greeters to "speak")
        public string SayHello()
        {
            return _WelcomeMessage;
        } // end of SayHello() method

        public string SayGoodbye()
        {
            return _FarewellMessage;
        } // enf of SayGoodbye() method

    } // end of the class definition
} // end of namespace
