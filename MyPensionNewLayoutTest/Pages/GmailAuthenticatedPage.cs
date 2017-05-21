using GenericTestAutomationFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MyPensionNewLayoutTest.Pages
{
    internal class GmailAuthenticatedPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=':io']/div/div")]
        public IWebElement btnCompose;


    }
}
