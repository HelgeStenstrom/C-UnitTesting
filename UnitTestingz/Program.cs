using System;
using System.Data.Odbc;
using System.Diagnostics;

//using System.Collections.Generic;
//using System.Runtime.InteropServices;

// TODO: Invoke test method
// TODO: Invoke setUp first
// TODO: Invoke tearDown afterward
// TODO: Invoke tearDown even if the test method fails
// TODO: Run multiple tests
// TODO Report collected results


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
            new TestCaseTest("TestRunning").run();
            Console.WriteLine("All tests done successfully.");
        }

    }
}