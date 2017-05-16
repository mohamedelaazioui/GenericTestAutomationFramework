using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenericTestAutomationFramework.Base.Browser;

namespace GenericTestAutomationFramework.Config
{
    public class Settings
    {
        internal static string IsReporting;

        public static string TestType { get; set; }
        public static string AUT { get; set; }
        public static string BuildName { get; set; }
        public static BrowserType BrowserType { get; set; }

        public static string IsLog { get; set; }
        public static string LogPath { get; set; }

    }
}
