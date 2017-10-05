using System.Collections.Generic;

namespace UnitTesting
{
    public class TestSuite
    {
        private readonly List<TestCase> _tests = new List<TestCase>();
        
        public void Add(TestCase test)
        {
            _tests.Add(test);
        }

        public void Run(TestResult result)
        {
            foreach (var test in _tests)
            {
                test.Run(result);
            }
        }
    }
}