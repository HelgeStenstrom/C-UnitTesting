namespace UnitTesting
{
    public class WasRun
    {
        public bool wasRun;
        public string name;
        public WasRun(string name)
        {
            wasRun = false;
            this.name = name;
        }

        public void run()
        {
            testMethod();
        }

        void testMethod()
        {
            wasRun = true;
        }
    }
}