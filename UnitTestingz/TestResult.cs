namespace UnitTesting
{
    public class TestResult
    {
        private int _runCount;
        private int _failCount;
        private int _errorCount;

        public int RunCount => _runCount;
        public int FailCount => _failCount;
        public int ErrorCount => _errorCount;


        public void TestStarted()
        {
            _runCount += 1;
        }

        public void TestFailed()
        {
            _failCount += 1;
        }

        public void TestErrored()
        {
            _errorCount += 1;
        }

        public string Summary()
        {
            string verdict = ((_failCount == 0) && (_errorCount == 0)) ? "PASSED" : "FAILED";
            return $"{verdict} (runs={_runCount}, failures={_failCount}, errors={_errorCount})";
        }
    }
}