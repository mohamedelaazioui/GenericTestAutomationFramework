using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;
using System.Xml.XPath;
using System.IO;


namespace GenericTestAutomationFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {

            XPathItem aut;
            XPathItem testtype;
            XPathItem islog;
            XPathItem isreport;
            XPathItem buildname;
            XPathItem logPath;
            
            string strFileName = Environment.CurrentDirectory.ToString() + "\\GenericTestAutomationFramework\\Config\\GlobalConfig.xml";
            
            FileStream stream = new FileStream(strFileName, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            aut = navigator.SelectSingleNode("//AUT");
            buildname = navigator.SelectSingleNode("//BuildName");
            testtype = navigator.SelectSingleNode("//TestType");
            islog = navigator.SelectSingleNode("//IsLog");
            isreport = navigator.SelectSingleNode("//IsReport");
            logPath = navigator.SelectSingleNode("//LogPath");

            //Set XML Details in the property to be used accross framework
            Settings.AUT = aut.Value.ToString();
            Settings.BuildName = buildname.Value.ToString();
            Settings.TestType = testtype.Value.ToString();
            Settings.IsLog = islog.Value.ToString();
            Settings.IsReporting = isreport.Value.ToString();
            Settings.LogPath = logPath.Value.ToString();
        }

        
    }
}
