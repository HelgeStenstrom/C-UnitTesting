using System;
using System.Reflection;

namespace UnitTestingz
{
    public class TestCase
    {
        protected string Name;

        public TestCase(string name)
        {
            Name = name;
        }

        public void Run()
        {
            SetUp();

            RunMethod();
            
            TearDown();
        }

        private void RunMethod()
        {
            // Call by ref taken from 
            // https://stackoverflow.com/questions/540066/calling-a-function-from-a-string-in-c-sharp
            
            Type thisType = GetType();
            MethodInfo theMethod = thisType.GetMethod(Name);
            theMethod.Invoke(this, null);
        }

        public virtual void SetUp() {}
        public virtual void TearDown() {}
        
        public static void AssertThat(bool b, string explanation)
        {
            if (b) return;
            Console.WriteLine("Exception: {0}", explanation);
            // throw new AssertionFailureException(explanation);
        }

        public static void AssertEqual(string a, string b, string explanation)
        {
            AssertThat(a==b, $"'{a}' != '{b}'. {explanation}.");
        }
    }
}
