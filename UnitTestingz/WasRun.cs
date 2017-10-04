using System;

namespace UnitTestingz
{
    public class WasRun : TestCase
    {
        public string Log;
        
        public WasRun(string name) : base(name)
        {
            Log = "";
        }

        public void TestMethod()
        {
            Log += "Run ";
        }

        public override void SetUp()
        {
            Log += "SetUp ";
        }

        public override void TearDown()
        {
            Log += "TearDown ";
        }
        
    }
}
