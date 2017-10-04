
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

        public void DoTestResult()
        // page 106
        {
            WasRun test = new WasRun("TestMethod");
            TestResult result = test.Run();
            AssertEqual("1 run, 0 failed", result.Summary(), "Fel i resultat");            
        }

        public void DoTestFailedResult()
            // page 107
        {
            WasRun test = new WasRun("TestBrokenMethod");
            TestResult result = test.Run();
            AssertEqual("1 run, 1 failed", result.Summary(), "Fel i resultat");            
        }

        // public void Test
    }
}
