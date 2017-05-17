using OpenQA.Selenium;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using GenericTestAutomationFramework.Base;
using GenericTestAutomationFramework.Extensions;

namespace MyPensionNewLayoutTest.PageObjects.Support
{
    class MyLegalPension : Base
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='aspnetForm']/toolbar/div/div[1]/div[2]/span")]
        public IWebElement ExpandLanguage;

        [FindsBy(How = How.XPath, Using = "//*[@id='aspnetForm']/toolbar/div/div[1]/div[1]/a[2]")]
        public IWebElement FrenchLanguage;

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByRepeater), Using = "link in $ctrl.jsonContext.header")]
        public IList<IWebElement> Links { get; set; }

        
        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByRepeater), Using = "link in $ctrl.jsonContext.navigation")]
        public IList<IWebElement> MyLegalPensionContextNavigation;
        
        NgWebDriver ngDriver;

        public MyLegalPension(IWebDriver driver)
        {
            ngDriver = new NgWebDriver(driver);

        }

        public MyLegalPension(IWebDriver driver, string url)
        {
            ngDriver = new NgWebDriver(driver);
            ngDriver.Navigate().GoToUrl(url);
        }

        //  french is selected  by default 
        public void SelectALanguage()
        {
            ExpandLanguage.Click();
            System.Threading.Thread.Sleep(10000);
            FrenchLanguage.Click();
        }
        public void ClickOnMyLegalPension()
        {
            Links[1].Click();
        }

        public string GetDriverTitle()
        {
            return ngDriver != null ? ngDriver.Title : string.Empty;
        }
      
        public void ClickOnMyData()
        {
            System.Console.WriteLine(MyLegalPensionContextNavigation.Count);
            MyLegalPensionContextNavigation[1].Click();
        }
    }
}
