
namespace UnitTestingz
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
            throw new AssertionFailureException("*** A fail that is expected and needed for the test ***");
        }
        
    }
}
