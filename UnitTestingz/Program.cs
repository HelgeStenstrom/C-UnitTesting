using System;


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


namespace UnitTesting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RunTests();
        }

        static void RunTests()
        {
            TestResult result = new TestResult();
            new TestCaseTest("TestTemplateMethod").Run(result);
            new TestCaseTest("TestTestResult").Run(result);
            new TestCaseTest("TestTestFailedResult").Run(result);
            new TestCaseTest("TestTestSuite").Run(result);
            
            Console.WriteLine("All tests done successfully.");
            // throw new Exception("ett undantag");
            Console.WriteLine();
            Console.WriteLine(new AssertionFailureException().ToString());
            Console.WriteLine(new Exception().ToString());
            // throw new AssertionFailureException("Ett assertion-fel");
        }

    }
}
