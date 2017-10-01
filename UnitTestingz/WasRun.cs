using System;
using System.Reflection;

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
            // Call by ref taken from https://stackoverflow.com/questions/540066/calling-a-function-from-a-string-in-c-sharp
            Console.WriteLine("Trying to call '{0}'.", name);
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(name);
            theMethod.Invoke(this, null);
        }

        public void testMethod()
        {
            wasRun = true;
        }
    }
}