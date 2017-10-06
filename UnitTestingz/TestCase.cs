using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Reflection;

namespace UnitTesting
{
    public class TestCase
    {
        protected string Name;

        public TestCase(string name)
        {
            Name = name;
        }

        public void Run(TestResult result)
        {
            result.TestStarted();
            
            SetUp();

            try
            {
                RunMethod();
            }
            catch (AssertionError ae)
            {
                var text = string.Format("Assertion Error on line {0}, file {1},", 
                    lineOf(ae), fileOf(ae));
                
                //Console.WriteLine(text);
                result.TestFailed();
            }
            catch (Exception e)
            {
                //Console.WriteLine("Annat fel än Assertion.");
                //Console.WriteLine("Line: " + lineOf(e));
                result.TestErrored();
            }

            TearDown();
        }

        private void RunMethod()
        {
            // Call by ref taken from 
            // https://stackoverflow.com/questions/540066/calling-a-function-from-a-string-in-c-sharp
            
            Type thisType = GetType();
            MethodInfo theMethod = thisType.GetMethod(Name);
            try
            {
                theMethod.Invoke(this, null);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public virtual void SetUp() {}
        public virtual void TearDown() {}
        
        public static void AssertThat(bool b, string explanation)
        {
            if (b) return;
            Console.WriteLine("Exception (undantag): {0}", explanation);
            throw new AssertionError(explanation);
        }

        public static void AssertEqual(string expected, string actual, string explanation)
        {
            string exp = string.Format(" Expected {0} but got {1}", expected, actual);
            AssertThat(expected==actual, string.Format("'{0}' != '{1}'. {2}.", expected, actual, explanation + exp));
        }

        public static void AssertEqual(int expected, int actual, string explanation)
        {
            string exp = $" Expected {expected} but got {actual}. {explanation}.";
            AssertThat(expected==actual, exp);
        }
        
        public static void AssertEqual(int expected, int actual)
        {
            AssertThat(expected==actual, "");
        }

        StackFrame frameOf(Exception e)
        {
           return new StackTrace(e, true).GetFrame(0);
        }
        
        int lineOf (Exception ex)
        {
            return frameOf(ex).GetFileLineNumber();
        }

        string fileOf(Exception ex)
        {
            return frameOf(ex).GetFileName();
        }
        
        public int GetLineNumber(Exception ex)
        {
            var lineNumber = 0;
            const string lineSearch = ":line ";
            var index = ex.StackTrace.LastIndexOf(lineSearch);
            if (index != -1)
            {
                var lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length);
                if (int.TryParse(lineNumberText, out lineNumber))
                {
                }
            }
            return lineNumber;
        }
        
    }
}
