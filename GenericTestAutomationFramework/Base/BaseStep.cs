using GenericTestAutomationFramework.Config;
using GenericTestAutomationFramework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTestAutomationFramework.Base
{
    public class BaseStep : BasePage
    {
        public virtual void TestStart()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelpers.Write("Opened the browser!!!");
        }
    }
}
