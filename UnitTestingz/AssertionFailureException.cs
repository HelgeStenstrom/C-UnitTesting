using System;

namespace UnitTestingz
{
    public class AssertionFailureException : Exception
    {
        public AssertionFailureException() : base() {}
        
        public AssertionFailureException(String s) : base(s) {}

        public static int Xxx()
        {
            return 17;
        }

        public string ToString()
        {
            return Message;
        }
    }
}
