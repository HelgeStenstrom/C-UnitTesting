namespace UnitTestingz
{
    public class WasRun
    {
        public bool wasRun = false;
        public WasRun(string name)
        {
        }

        public void testMethod()
        {
            wasRun = true;
        }
    }
}