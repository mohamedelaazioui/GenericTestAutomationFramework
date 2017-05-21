using GenericTestAutomationFramework.Base;
using GenericTestAutomationFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MyPensionNewLayoutTest.Pages
{
    internal class GmailAuthenticatedPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=':io']/div/div")]
        private IWebElement btnCompose;


        public void CheckSuccessfullLogin()
        {
            btnCompose.AssertElementPresent();
        }

    }
}
