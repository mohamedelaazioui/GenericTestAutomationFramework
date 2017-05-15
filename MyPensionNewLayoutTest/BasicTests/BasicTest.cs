using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using Protractor;
using GenericTestAutomationFramework.Helpers;

namespace MyPensionNewLayoutTest.BasicTests
{
    [TestFixture]
    class BasicTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver("C:\\WebDrivers");

            // Using Internet Explorer
            //var options = new InternetExplorerOptions() { IntroduceInstabilityByIgnoringProtectedModeSettings = true };
            //_driver = new InternetExplorerDriver(options);

            // Required for TestForAngular and WaitForAngular scripts
            //_driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(120));
            
        }

        [TearDown]
        public void TearDown()
        {
            if (_driver != null)
                _driver.Quit();
        }

        [Test]
        public void ShouldGreetUsingBinding()
        {
            var ngDriver = new NgWebDriver(_driver);
            ngDriver.Navigate().GoToUrl("http://www.angularjs.org");
            // to be refactored for performance reasons
            System.Threading.Thread.Sleep(30000);
            ngDriver.FindElement(NgBy.Model("yourName")).SendKeys("Julie");
            Assert.AreEqual("Hello Julie!", ngDriver.FindElement(NgBy.Binding("yourName")).Text);
        }

        [Test(Description = "Should be possible to login via theseos")]
        public void NonAngularPageShouldBeSupported()
        {
            
  
            Assert.DoesNotThrow(() =>
            {
                var ngDriver = new NgWebDriver(_driver);
                ngDriver.IgnoreSynchronization = true;
                TheseosHelper.LoginAndRedirect(ngDriver);
                ngDriver.IgnoreSynchronization = false;
            });
           
        }

    }
}
