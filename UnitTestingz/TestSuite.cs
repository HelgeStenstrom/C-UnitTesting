using System.Collections.Generic;
using System.Reflection.Emit;

namespace UnitTestingz
{
    public class TestSuite
    {
        private TestResult _result = new TestResult();
        private List<TestCase> _tests = new List<TestCase>();
        
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