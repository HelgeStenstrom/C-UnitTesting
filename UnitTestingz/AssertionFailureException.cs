using System;

namespace UnitTestingz
{
    public class AssertionFailureException : Exception
    {
        public AssertionFailureException() : base() {}
        
        public AssertionFailureException(String s) : base(s) {}

        public static int Xxx()
        {
            // new Exception().ToString()
            return 17;
        }

        public new string  ToString()
        {
            return Message;
        }
    }
}
