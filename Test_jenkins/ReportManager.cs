using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Model;
using MongoDB.Bson;

namespace Test_jenkins
{
   public class ReportManager : ExtentHtmlReporter
    {
        public ExtentHtmlReporter _extentHtmlReporter;
        public static ExtentTest Log;
        public ExtentReports reports;

        public ReportManager(string filePath): base(filePath)
        {
            _extentHtmlReporter = new ExtentHtmlReporter(filePath);
           
            reports = new ExtentReports();
           
            //reports.CreateTest("Dummy", "aa");
            reports.AttachReporter(_extentHtmlReporter);
           
        }

        public override void Start()
        {
            //Log.Log(Status.Info, "aaa");
         //  var attributes =  extentReports.SystemAttributeContext.SystemAttributeCollection;
            _extentHtmlReporter.Configuration().ChartVisibilityOnOpen = true;
            _extentHtmlReporter.Configuration().DocumentTitle = "Testing Game Changer";
            _extentHtmlReporter.Configuration().ReportName = "Ranjit Sexy";
            _extentHtmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            _extentHtmlReporter.Configuration().Protocol = AventStack.ExtentReports.Reporter.Configuration.Protocol.HTTP;
            _extentHtmlReporter.Configuration().ChartLocation = AventStack.ExtentReports.Reporter.Configuration.ChartLocation.Top;
            //Log.("The Report Manager: Start Method is called");
            base.Start();
                      
        }

        public override void Stop()
        {

            base.Stop();
            base.Flush();
        }


    }
}
