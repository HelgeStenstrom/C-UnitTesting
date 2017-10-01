using System;
using System.Reflection;

namespace UnitTesting
{
    public class WasRun : TestCase
    {
        public WasRun(string name) : base(name)
        {
            wasRun = false;
        }

        public void testMethod()
        {
            wasRun = true;
        }
    }

    public class TestCaseTest : TestCase
    {
        public TestCaseTest(string name) : base(name)
        {
        }

        public void TestRunning()
        {
            TestCase test = new WasRun("testMethod");
            AssertThat(! test.wasRun, "Test seemed to be run before it could have been.");
            test.run();
            AssertThat(test.wasRun, "Test wasn't run");
            Console.WriteLine("TestRunning har körts.");
        }
    }
        
}