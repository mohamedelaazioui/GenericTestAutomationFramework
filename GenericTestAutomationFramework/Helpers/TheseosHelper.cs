using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTestAutomationFramework.Helpers
{
    public static class TheseosHelper
    {
        const string Url = @"http://fat02-theseos:8080/theseos/";
        const string Username = "camuc";
        const string Password = "pass";
        const int Delay = 30000;

        public static void LoginAndRedirect(IWebDriver browser)
        {
            var niss = "86.09.17-377.12";
            LoginAndRedirect(browser, niss);
        }

        public static void LoginAndRedirect(IWebDriver browser, string niss)
        {

            Login(browser);

            IWebElement dossier = browser.FindElement(By.Id("QuickDossierSearchComponent"));
            dossier.Click();
            browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            IWebElement searchNiss = browser.FindElement(By.Id("QuickDossierSearchComponent.id"));

            searchNiss.SendKeys(niss);
            searchNiss.SendKeys(Keys.Enter);

            IWebElement goToMyPension = browser.FindElement(By.XPath("//div[@id='Person._title']/div/div/div/div/div[3]/div"));
            goToMyPension.Click();

            GoToMyPension(browser);
        }

        public static void LoginForEditAndRedirect(IWebDriver browser)
        {
            var niss = "69.12.13-052.24";
            LoginForEditAndRedirect(browser, niss);
        }

        public static void LoginForEditAndRedirect(IWebDriver browser, string niss)
        {
            Login(browser);

            //TODO

            GoToMyPension(browser);
        }

        private static void Login(IWebDriver browser)
        {

            browser.Navigate().GoToUrl(Url);
            browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            browser.Manage().Window.Maximize();

            IWebElement EUsername = browser.FindElement(By.Id("j_username"));
            EUsername.SendKeys(Username);
            IWebElement EPassword = browser.FindElement(By.Id("j_password"));
            EPassword.SendKeys(Password);
            IWebElement ELogin = browser.FindElement(By.Id("login"));
            ELogin.Click();
            //browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(25));
        }

        private static void GoToMyPension(IWebDriver browser)
        {
            System.Threading.Thread.Sleep(Delay);
            browser.SwitchTo().Window(browser.WindowHandles.Last());
        }
    }
}
