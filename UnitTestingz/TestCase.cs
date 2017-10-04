using System;
using System.Reflection;

namespace UnitTestingz
{
    public class TestCase
    {
        protected string Name;
        public bool WasRun;
        public bool WasSetUp;

        public TestCase(string name)
        {
            Name = name;
            WasRun = false;
        }

        public void Run()
        {
            // Call by ref taken from https://stackoverflow.com/questions/540066/calling-a-function-from-a-string-in-c-sharp
            
            SetUp();

            RunMethod();
        }

        private void RunMethod()
        {
            Type thisType = GetType();
            MethodInfo theMethod = thisType.GetMethod(Name);
            theMethod.Invoke(this, null);
        }

        public virtual void SetUp() {}
        public virtual void TearDown() {}
        
        public static void AssertThat(bool b, string explanation)
        {
            if (!b)
            {
                throw new Exception(explanation);
            }
        }
 
    }
}