
using System;

namespace UnitTesting
{
    public class WasRun : TestCase
    {
        public string Log;
        
        public WasRun(string name) : base(name)
        {
            Log = "";
        }

        public override void SetUp()
        {
            Log += "SetUp ";
        }

        public override void TearDown()
        {
            Log += "TearDown ";
        }

        public void TestMethod()
        {
            Log += "Run ";
        }

        public void TestBrokenMethod()
        {
            throw new AssertionError("*** A fail that is expected and needed for the test ***");
        }

        public void ThrowingMethod()
        {
            throw new Exception("An Exceoption that is worse than an assertion failure, but expected here.");
        }
        
    }
}
