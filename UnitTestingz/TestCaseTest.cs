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
            _test.Run();
            AssertEqual("SetUp Run ", _test.Log, "SetUp och Run skedde inte");
            Console.WriteLine("TestRunning har körts.");
        }

        public void TestSetup()
        // page 201
        {
            _test.Run();
            AssertEqual("SetUp Run ", _test.Log, "SetUp skedde inte");
            Console.WriteLine("TestSetup har körts.");
        }

        // public void Test
    }
}
