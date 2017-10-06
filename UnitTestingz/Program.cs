using System;





namespace UnitTesting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RunTests();
        }

        private static void RunTests()
        {
            TestResult result = new TestResult();
            new TestCaseTest("TestTemplateMethod").Run(result);
            new TestCaseTest("TestTestResult").Run(result);
            new TestCaseTest("TestTestFailedResult").Run(result);
            new TestCaseTest("TestTestSuite").Run(result);
            new TestCaseTest("TestErroredResult").Run(result);
            
            TestSuite formatting = new TestSuite();
            formatting.Add(new TestCaseTest("TestResultSummaryFormat"));
            formatting.Run(result);
            
            Console.WriteLine(result.Summary());
                
            // ignore tills vidare
            //new TestCaseTest("TestErroredResult").Run(result);
            
            Console.WriteLine("All tests done.");
        }

        private static void play()
        {
            // throw new Exception("ett undantag");
            Console.WriteLine();
            Console.WriteLine(new AssertionError().ToString());
            Console.WriteLine(new Exception().ToString());
            // throw new AssertionFailureException("Ett assertion-fel");
            
        }
    }
}
