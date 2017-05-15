using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using GenericTestAutomationFramework.Helpers;
using MyPensionNewLayoutTest.PageObjects.Support;
using GenericTestAutomationFramework.Base;

namespace MyPensionNewLayoutTest.PageObjects
{
    [TestFixture]
    class PageObjects
    {
        private MyLegalPension _myLegalPension;
        NgWebDriver _ngDriver;

        [OneTimeSetUp]
        public void SetUp()
        {
            // using chrome
            DriverContext.Driver = new ChromeDriver("C:\\WebDrivers");
            _ngDriver = new NgWebDriver(DriverContext.Driver);
            Assert.DoesNotThrow(() =>
            {
                _ngDriver.IgnoreSynchronization = true;
                TheseosHelper.LoginAndRedirect(_ngDriver);
                _ngDriver.IgnoreSynchronization = false;
               
             });

            _myLegalPension = new MyLegalPension(_ngDriver);
            System.Threading.Thread.Sleep(10000);

            _myLegalPension.SelectALanguage();
            Assert.AreEqual("mypension.be", _myLegalPension.GetDriverTitle());
        }

        

        [Test(Description = "It Should consult my legal pension"), Order(1)]
        public void ShouldConsultMyLegalPension()
        {
            _myLegalPension.ClickOnMyLegalPension();
            System.Threading.Thread.Sleep(10000);

            Assert.AreEqual("Ma pension légale", _myLegalPension.GetDriverTitle());
            System.Threading.Thread.Sleep(30000);
        }

        [Test(Description = "It Should consult my data"), Order(2)]
        public void ShouldConsultMyLegalPensionMyData()
        {
            _myLegalPension.ClickOnMyData();
            Assert.AreEqual("Mes données", _myLegalPension.GetDriverTitle());
        }

        [Test(Description = "It Should validate my data"), Order(3)]
        public void ShouldValidateMyLegalPensionMyData()
        {
            // Todo
        }

        [Test(Description = "It Should redirect my profile to my legal pension my data"), Order(3)]
        public void ShouldRedirectMyProfileLinkIntoMyLegalPensionMyData()
        {
           // Todo
        }


        [OneTimeTearDown]
        public void TearDown()
        {
            if (_ngDriver != null)
                _ngDriver.Quit();
        }
        
    }
}
