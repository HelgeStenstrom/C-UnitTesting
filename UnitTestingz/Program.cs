using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;

// TODO: Invoke test method
// TODO: Invoke setUp first
// TODO: Invoke tearDown afterward
// TODO: Invoke tearDown even if the test method fails
// TODO: Run multiple tests
// TODO Report collected results


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
            // Console.WriteLine("Kör tester");
            InvokeTestMethod();
        }

        static void InvokeTestMethod()
        {
            WasRun test = new WasRun("testMethod");
            Console.WriteLine(test.wasRun);
            test.testMethod();
            Console.WriteLine(test.wasRun);
        }
    }
}