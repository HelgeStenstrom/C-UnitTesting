using System;

namespace UnitTesting
{
    public class AssertionError : Exception
    {
        public AssertionError()  {}
        
        public AssertionError(string s) : base(s) {}

        public override string  ToString()
        {
            return Message;
        }
    }
}
