﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTestAutomationFramework.Helpers
{
    public class LogHelpers
    {
        // Global Declaration of Log fileName 
        private static string _logFileName = string.Format("{0:ddmmyyyyhhmmss}", DateTime.Now);
        public static StreamWriter _streamw = null;

        // Create a file which can store the log information
        public static void CreateLogFile()
        {
            string dir = @"c:\GenericFreameworkLog\";
            if(Directory.Exists(dir))
            {
                _streamw = File.AppendText(dir + _logFileName + ".log");
            } else
            {
                Directory.CreateDirectory(dir);
                _streamw = File.AppendText(dir + _logFileName + ".log");
            }
        }
        
        // Create a method which can write the text in the file
        public static void Write(string logMessage)
        {
            _streamw.Write("{0} {1}",DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamw.WriteLine("     {0}", logMessage);
            _streamw.Flush();

        }
    }
}
