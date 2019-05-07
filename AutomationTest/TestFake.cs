using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationTest
{
    [TestClass]
    public class TestFake : TestBase
    {
        [TestMethod]
        [TestCategory("DummyTest")]
        
        public void Login()
        {
            Assert.Equals("sa", "sa");
        }

        [TestMethod]
        public void Register()
        {
            Assert.Equals("sa", "Deletea");

        }

        [TestMethod]
        public void Delete()
        {
           // ExtentReports.CreateTest("asas");
            Assert.Fail("Soory We dont like to go with Ashok");
        }
        [TestMethod]
        public void Sexy()
        {
            Assert.Fail("Soory We dont like to go with Ashok");

        }


    }
}
