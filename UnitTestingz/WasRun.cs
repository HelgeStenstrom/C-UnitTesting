namespace UnitTestingz
{
    public class WasRun : TestCase
    {
        public string Log;
        
        public WasRun(string name) : base(name)
        {
            WasSetUp = false;
        }

        public void TestMethod()
        {
            WasRun = true;
            // Log += "TestMethod ";
        }

        public override void SetUp()
        {
            WasSetUp = true;
            Log = "SetUp ";
        }
    }
}
