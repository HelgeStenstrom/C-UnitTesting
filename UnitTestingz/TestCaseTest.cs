
using System;
using System.Collections.Concurrent;

namespace UnitTestingz
{
    public class TestCaseTest : TestCase
    {
        TestResult result = new TestResult();
        
        public TestCaseTest(string name) : base(name) {}

        public override void SetUp()
        {
            
        }

        public void TestTemplateMethod()
        // page 201
        {
            WasRun test = new WasRun("TestMethod");
            test.Run(result);
            AssertEqual("SetUp Run TearDown ", test.Log, "SetUp Run TearDown skedde inte");
            // Console.WriteLine("TestSetup har körts.");
        }

        public void TestTestResult()
        // page 106
        {
            WasRun test = new WasRun("TestMethod");
            test.Run(this.result);
            AssertEqual("1 run, 0 failed", result.Summary(), "Fel i resultat");            
        }

        public void TestTestFailedResult()
            // page 107
        {
            WasRun test = new WasRun("TestBrokenMethod");
            test.Run(this.result);
            AssertEqual("1 run, 1 failed", result.Summary(), "Fel i resultat");            
        }

        public void TestTestSuite()
        {
            TestSuite suite = new TestSuite();
            suite.Add(new WasRun("TestMethod"));
            suite.Add(new WasRun("TestBrokenMethod"));
            suite.Run(this.result);
            AssertEqual("2 run, 1 failed", result.Summary(), "fel i Suite-resultat");
        }

        // public void Test
    }
}
