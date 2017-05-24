using GenericTestAutomationFramework.Config;
using GenericTestAutomationFramework.Helpers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenericTestAutomationFramework.Base.Browser;
using GenericTestAutomationFramework.Extensions;

namespace GenericTestAutomationFramework.Base
{
    public abstract class TestInitializeHook
    {
        private readonly BrowserType Browser;

        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
        }
        public void InitializeSettings()
        {
            ConfigReader.SetFrameworkSettings();
            // Set Log
            LogHelpers.CreateLogFile();
            // Open Browser
            OpenBrowser(Browser);
            LogHelpers.Write("*********************");
            LogHelpers.Write("Initialized Framework!");
            LogHelpers.Write(String.Format("System Under Test {0}", Settings.AUT));
        }

        public void TerminateSettings()
        {
            CloseSite();
            LogHelpers.Write("Framework closed");
            LogHelpers.Write("*********************");
            LogHelpers.CloseLogFile();

        }
        private void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;

                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver(@"C:\webdrivers");
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;

                case BrowserType.Firefox:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }

        public virtual void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            DriverContext.Driver.WaitForPageLoaded();
            LogHelpers.Write("Opened the browser!!!");
        }

        public virtual void CloseSite()
        {
            LogHelpers.Write("Closing the browser!!!");
            DriverContext.Driver.Dispose();
            LogHelpers.Write("Browser was closed!!!");

        }


    }
}