using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTesting
{
    public class TestResult
    {
        // TODO: Collect exceptions of failed and errored tests in two lists
        
        private int _runCount;
        private int _failCount;
        private List<Exception> errors = new List<Exception>();
        private List<AssertionError> fails = new List<AssertionError>();

        public int RunCount => _runCount;
        public int FailCount => _failCount;
        public int ErrorCount { get; private set; }


        public void TestStarted()
        {
            _runCount += 1;
        }

        public void TestFailed(AssertionError ae, string name)
        {
            _failCount += 1;
            fails.Add(ae);
            var st0 = new StackTrace(ae, 0);
            var stFalse = new StackTrace(ae, false);
            var stTrue = new StackTrace(ae, true);
            
        }

        public void TestErrored(Exception e)
        {
            ErrorCount += 1;
            errors.Add(e);
        }

        public string allFails()
        {
            string failText = "";
            foreach (var fail in fails)
            {
                failText += "-------------------\n";
                failText += fail.StackTrace;
                failText += "\n===================\n";
            }
            return failText;
        }
        
        public string Summary()
        {
            string verdict = ((_failCount == 0) && (ErrorCount == 0)) ? "PASSED" : "FAILED";
            return $"{verdict} (runs={_runCount}, failures={_failCount}, errors={ErrorCount})";
        }

        private static StackFrame FrameOf(Exception e)
        {
            return new StackTrace(e, true).GetFrame(0);
        }
        
        int LineOf (Exception ex)
        {
            return FrameOf(ex).GetFileLineNumber();
        }

        string FileOf(Exception ex)
        {
            return FrameOf(ex).GetFileName();
        }

    }
}