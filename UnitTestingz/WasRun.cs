namespace UnitTestingz
{
    public class WasRun : TestCase
    {
        public WasRun(string name) : base(name)
        {
            WasSetUp = false;
        }

        public void TestMethod()
        {
            WasRun = true;
        }

        public override void SetUp()
        {
            WasSetUp = true;
        }
    }
}