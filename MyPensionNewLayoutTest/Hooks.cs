using GenericTestAutomationFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenericTestAutomationFramework.Base.Browser;

namespace MyPensionNewLayoutTest
{
    public class Hooks : TestInitializeHook
    {
        public Hooks() : base(BrowserType.Chrome)
        {

        }
    }
}
