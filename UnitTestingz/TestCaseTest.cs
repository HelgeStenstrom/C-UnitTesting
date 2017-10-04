using System;

namespace UnitTestingz
{
    public class TestCaseTest : TestCase
    {
        public TestCaseTest(string name) : base(name) {}

        public void TestRunning()
        {
            TestCase test = new WasRun("TestMethod");
            AssertThat(! test.WasRun, "Test seemed to be run before it could have been.");
            test.Run();
            AssertThat(test.WasRun, "Test testMethod wasn't run");
            Console.WriteLine("TestRunning har körts.");
        }

        public void TestSetup()
        {
            WasRun test = new WasRun("TestMethod");
            test.Run();
            if (! test.WasSetUp) Console.WriteLine("Rätt SetUp kördes inte.");
            AssertThat(test.WasSetUp, "No setUp in WasRun");
        }

        public override void SetUp()
        {
            // Console.WriteLine("SetUp in TestCaseTest");
        }
    }
}