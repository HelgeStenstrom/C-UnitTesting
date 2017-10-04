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

        public new  void SetUp()
        {
            WasSetUp = true;
        }
    }
}