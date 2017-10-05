using System;

namespace UnitTestingz
{
    public class TestResult
    {
        private int _runCount;
        private int _errorCount;

        public void TestStarted()
        {
            _runCount += 1;
        }

        public void TestFailed()
        {
            _errorCount += 1;
        }

        public string Summary()
        {
            return string.Format("{0} run, {1} failed", _runCount, _errorCount);
        }
    }
}