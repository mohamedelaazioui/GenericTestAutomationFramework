using EAAutoFramework.Config;
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
        public readonly BrowserType Browser;

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

            LogHelpers.Write("Initialized Framework");
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
            LogHelpers.Write("Opened the browser !!!");
        }
       

        
    }
}
