using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationTest
{
   public class TestBase
    {
        public const string filePath = @"C:\Users\rsharma\Desktop\log1.html";

        public ExtentHtmlReporter htmlReporter;
        public ExtentReports ExtentReports;

        [TestInitialize]
        public void TestInitialize()
        {
            htmlReporter = new ExtentHtmlReporter(filePath);
            ExtentReports = new ExtentReports();
            ExtentReports.AttachReporter(htmlReporter);
             htmlReporter.Start();


        }

        [TestCleanup]
        public void TestFinish()
        {

            htmlReporter.Stop();
            htmlReporter.Flush();
        }

    }
}
