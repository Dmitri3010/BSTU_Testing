
using log4net;
using log4net.Config;
using System;
using System.IO;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using GitHubAutomation.Pages;
using GitHubAutomation.Driver;

namespace GitHubAutomation
{
    public class Logger
    {
        //static private ILog log = LogManager.GetLogger(typeof(Logger));
        //public static ILog Log
        //{
        //    get { return log; }
        //}

        public void Log(string test)
        {
            var logFolder = AppDomain.CurrentDomain.BaseDirectory + @"\Logs";
            Directory.CreateDirectory(logFolder);
            string fileName = logFolder + @"\logfile.txt";
            FileStream aFile = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(aFile);
            aFile.Seek(0, SeekOrigin.End);
            sw.WriteLine(test + DateTime.Now.ToString("yy-MM-dd_hh-mm-ss"));
            sw.Close();
        }
    }
}
