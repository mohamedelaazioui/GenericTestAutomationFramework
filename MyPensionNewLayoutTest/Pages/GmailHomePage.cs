using GenericTestAutomationFramework.Base;
using GenericTestAutomationFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MyPensionNewLayoutTest.Pages
{
    internal class GmailHomePage : BasePage
    {

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement emailTxt;

        [FindsBy(How = How.Id, Using = "next")]
        public IWebElement btnNext;

        [FindsBy(How = How.Id, Using = "Passwd")]
        public IWebElement passwordTxt;

        [FindsBy(How = How.Id, Using = "signIn")]
        public IWebElement btnSignIn;

        public GmailAuthenticatedPage LogIn(string email, string password)
        {
            emailTxt.SendKeys(email);
            btnNext.Click();
            passwordTxt.SendKeys(password);
            btnSignIn.Click();

            return GetInstance<GmailAuthenticatedPage>();
        }

        internal void CheckIfGmailHomePageExists()
        {
            emailTxt.AssertElementPresent();
            btnNext.AssertElementPresent();
        } 

    }
}
