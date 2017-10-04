using System;

namespace UnitTestingz
{
    public class TestCaseTest : TestCase
    {
        private WasRun _test;
        
        public TestCaseTest(string name) : base(name) {}

        public override void SetUp()
        {
            _test = new WasRun("TestMethod");
        }

        public void TestRunning()
        {
            AssertThat(! _test.WasRun, "Test seemed to be run before it could have been run.");
            _test.Run();
            // AssertEqual("SetUp Run ", _test.Log, "Test testMethod wasn't run");
            AssertThat(_test.WasRun, "Test testMethod wasn't run");
            Console.WriteLine("TestRunning har körts.");
        }

        public void TestSetup()
        // page 201
        {
            _test.Run();
            AssertThat("SetUp ".Equals(_test.Log), "Log kördes inte");
            AssertEqual("SetUp ", _test.Log, "SetUp skedde inte");
        }

        // public void Test
    }
}
