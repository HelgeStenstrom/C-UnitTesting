using System;
using System.Reflection;

namespace UnitTesting
{
    public class TestCase
    {
        public string name;
        public bool wasRun;
        public bool wasSetUp;

        public TestCase(string name)
        {
            this.name = name;
            wasRun = false;
        }

        public void run()
        {
            // Call by ref taken from https://stackoverflow.com/questions/540066/calling-a-function-from-a-string-in-c-sharp
            
            this.setUp();

            runMethod();
        }

        private void runMethod()
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(name);
            theMethod.Invoke(this, null);
        }

        public void setUp() {}
        
        public static void AssertThat(bool b, string explanation)
        {
            if (!b)
            {
                throw new Exception(explanation);
            }
        }
 
    }
}