using System;

namespace UnitTestingz
{
    public class TestCaseTest : TestCase
    {
        public TestCaseTest(string name) : base(name) {}

        public void TestTemplateMethod()
        // page 201
        {
            WasRun test = new WasRun("TestMethod");
            test.Run();
            AssertEqual("SetUp Run ", test.Log, "SetUp Run skedde inte");
            // Console.WriteLine("TestSetup har körts.");
        }

        // public void Test
    }
}
