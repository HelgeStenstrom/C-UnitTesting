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
            AssertEqual("SetUp Run TearDown ", test.Log, "SetUp Run TearDown skedde inte");
            // Console.WriteLine("TestSetup har körts.");
        }

        // public void Test
    }
}
