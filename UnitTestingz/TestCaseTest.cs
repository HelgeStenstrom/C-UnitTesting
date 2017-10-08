// Done: Invoke test method
// Done: Invoke setUp first
// Done: Invoke tearDown afterward
// TODO: Invoke tearDown even if the test method fails
// Done: Run multiple tests
// Done: Report collected results
// Done: Log string in WasRun
// Done: Report failed tests
// TODO: Catch and report setUp errors
// TODO: Create TestSuite from a TestCase class
// --
// Done: Test error and fail counts directly, not via summary
// Done: Test Result summary of fails
// TODO: Test Result summary of PASS
// TODO: Suite of Suites
// Done: Report Fails and Errors separately
// TODO: Line numbers for fails and errors


using System;

namespace UnitTesting
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
            test.Run(result);
            //AssertEqual("1 run, 0 failed", result.Summary(), "Fel i resultat");
            AssertEqual(1, result.RunCount, "Fel antal körda test");
            AssertEqual(0, result.FailCount, "Fel antal Fails");
            AssertEqual(0, result.ErrorCount, "Fel antal Error");
        }

        public void TestTestFailedResult()
            // page 107
        {
            WasRun test = new WasRun("TestBrokenMethod");
            test.Run(result);
            AssertEqual("FAILED (runs=1, failures=1, errors=0)", result.Summary(), "Fel i resultat");
            AssertEqual(1, result.RunCount, "Fel antal körda test");
            AssertEqual(1, result.FailCount, "Fel antal Fails");
            AssertEqual(0, result.ErrorCount, "Fel antal Error");
        }

        public void TestTestSuite()
        {
            TestSuite suite = new TestSuite();
            suite.Add(new WasRun("TestMethod"));
            suite.Add(new WasRun("TestBrokenMethod"));
            suite.Run(result);
            AssertEqual("FAILED (runs=2, failures=1, errors=0)", result.Summary(), "fel i Suite-resultat");
            AssertEqual(2, result.RunCount, "Fel antal körda test");
            AssertEqual(1, result.FailCount, "Fel antal Fails");
            AssertEqual(0, result.ErrorCount, "Fel antal Error");
        }
        
        // ----- all of the book is done. the rest is mine

        public void TestErroredResult()
        {
            WasRun test = new WasRun("ThrowingMethod");
            test.Run(result);
            AssertEqual("FAILED (runs=1, failures=0, errors=1)", result.Summary(), "Fel antal fail eller error");
            AssertEqual(1, result.RunCount, "Fel antal körda test");
            AssertEqual(0, result.FailCount, "Fel antal Fails");
            AssertEqual(1, result.ErrorCount, "Fel antal Error 87");
        }

        public void TestResultSummaryFormat()
        {
            // Setup the SUT and DOCs.
            TestSuite suite = new TestSuite();
            suite.Add(new WasRun("TestMethod"));
            suite.Add(new WasRun("TestMethod"));
            suite.Add(new WasRun("TestMethod"));
            suite.Add(new WasRun("TestBrokenMethod"));
            suite.Add(new WasRun("TestBrokenMethod"));
            suite.Add(new WasRun("ThrowingMethod"));
            // Exercise the SUT
            suite.Run(this.result);
            // Just an extra check.
            AssertEqual(6, result.RunCount, "Fel antal körda test");
            AssertEqual(2, result.FailCount, "Fel antal Fails");
            AssertEqual(1, result.ErrorCount, "Fel antal Error 105");
            // The actual purpose of the unit test.
            AssertEqual("FAILED (runs=6, failures=2, errors=1)", result.Summary(), "fel i Suite-resultat");
        }

        public void TestThatShouldFail()
        {
            AssertThat(false, "keep this failing!");
            Console.WriteLine("This can't happen, because an exception is thown on the line above.");
        }

    }
}
