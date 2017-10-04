namespace UnitTestingz
{
    public class TestResult
    {
        private int _runCount = 0;

        public void TestStarted()
        {
            _runCount += 1;
        }

        public string Summary()
        {
            return $"{_runCount} run, 0 failed";
        }
    }
}