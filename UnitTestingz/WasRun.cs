using System;

namespace UnitTestingz
{
    public class WasRun : TestCase
    {
        public WasRun(string name) : base(name)
        {
            wasSetUp = false;
        }

        public void TestMethod()
        {
            wasRun = true;
        }

        public void SetUp()
        {
            wasSetUp = true;
        }
    }

    public class TestCaseTest : TestCase
    {
        public TestCaseTest(string name) : base(name) {}

        public void TestRunning()
        {
            TestCase test = new WasRun("TestMethod");
            AssertThat(! test.wasRun, "Test seemed to be run before it could have been.");
            test.Run();
            AssertThat(test.wasRun, "Test testMethod wasn't run");
            Console.WriteLine("TestRunning har körts.");
        }

        public void TestSetup()
        {
            WasRun test = new WasRun("TestMethod");
            test.Run();
            AssertThat(test.wasSetUp, "No setUp in WasRun");
        }
    }
        
}