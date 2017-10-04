using System;

namespace UnitTestingz
{
    public class WasRun : TestCase
    {
        public WasRun(string name) : base(name)
        {
            wasSetUp = false;
        }

        public void testMethod()
        {
            wasRun = true;
        }

        public void setUp()
        {
            wasSetUp = true;
        }
    }

    public class TestCaseTest : TestCase
    {
        public TestCaseTest(string name) : base(name) {}

        public void TestRunning()
        {
            TestCase test = new WasRun("testMethod");
            AssertThat(! test.wasRun, "Test seemed to be run before it could have been.");
            test.run();
            AssertThat(test.wasRun, "Test testMethod wasn't run");
            Console.WriteLine("TestRunning har körts.");
        }

        public void TestSetup()
        {
            WasRun test = new WasRun("testMethod");
            test.run();
            AssertThat(test.wasSetUp, "No setUp in WasRun");
        }
    }
        
}