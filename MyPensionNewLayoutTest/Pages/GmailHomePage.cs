using GenericTestAutomationFramework.Base;
using GenericTestAutomationFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MyPensionNewLayoutTest.Pages
{
    internal class GmailHomePage : BasePage
    {

        [FindsBy(How = How.Id, Using = "identifierId")]
        public IWebElement emailTxt;

        [FindsBy(How = How.Id, Using = "identifierNext")]
        public IWebElement btnNext;

        [FindsBy(How = How.XPath, Using = "//*[@id='password']/div[1]/div/div[1]/input")]
        public IWebElement passwordTxt;

        [FindsBy(How = How.Id, Using = "passwordNext")]
        public IWebElement btnSignIn;

        internal void FillInCredentials(string email, string password)
        {
            emailTxt.SendKeys(email);
            btnNext.Click();
            passwordTxt.SendKeys(password);
           
        }
        internal GmailHomePage LogIn()
        {
            btnSignIn.Click();

            return GetInstance<GmailHomePage>();
        }

        internal void CheckIfGmailHomePageExists()
        {
            emailTxt.AssertElementPresent();
            btnNext.AssertElementPresent();
        } 

    }
}
