using GenericTestAutomationFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static GenericTestAutomationFramework.Base.Browser;


namespace TodosAppTest
{
    [Binding]
    public class Hooks : TestInitializeHook
    {
        public Hooks() : base(BrowserType.Chrome)
        {
            InitializeSettings();
            NavigateSite();
        }

        [BeforeFeature]
        public static void TestStart()
        {
            Hooks init = new Hooks();
            

        }

        [AfterFeature]
        public static void TestEnd()
        {

        }
    }
}
