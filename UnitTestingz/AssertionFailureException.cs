using System;

namespace UnitTestingz
{
    public class AssertionFailureException : Exception
    {
        public AssertionFailureException()  {}
        
        public AssertionFailureException(string s) : base(s) {}

        public override string  ToString()
        {
            return Message;
        }
    }
}
