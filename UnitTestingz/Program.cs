using System;


// Done: Invoke test method
// Done: Invoke setUp first
// Done: Invoke tearDown afterward
// TODO: Invoke tearDown even if the test method fails
// TODO: Run multiple tests
// TODO: Report collected results
// Done: Log string in WasRun
// TODO: Report failed tests
// TODO: Catch and report setUp errors
// TODO: Create TestSuite from a TestCase class


namespace UnitTestingz
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RunTests();
        }

        static void RunTests()
        {
            new TestCaseTest("TestTemplateMethod").Run();
            new TestCaseTest("DoTestResult").Run();
            // new TestCaseTest("DoTestFailedResult").Run();
            
            Console.WriteLine("All tests done successfully.");
            // throw new Exception("ett undantag");
            Console.WriteLine();
            Console.WriteLine(new AssertionFailureException().ToString());
            Console.WriteLine(new Exception().ToString());
            // throw new AssertionFailureException("Ett assertion-fel");
        }

    }
}
