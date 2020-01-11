using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using NUnit.Framework;

namespace SeleniumTest
{
    public abstract class Browser
    {
        public IWebDriver webDriver;

        [SetUp]
        public void OpenBrowserAndSite()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            webDriver.Navigate().GoToUrl("https://www.ebooking.com/ru/");
        }

        [TearDown]
        public void CloseBrowser()
        {
            webDriver.Quit();
        }

        protected IWebElement GetWebElementById(string Id)
        {
            return webDriver.FindElement(By.Id(Id));
        }

        protected IWebElement GetWebElementByXPath(string xPath)
        {
            return webDriver.FindElement(By.XPath(xPath));
        }

        protected IWebElement GetWebElementByName(string xName)
        {
            return webDriver.FindElement(By.Name(xName));
        }

        protected IWebElement GetWebElementByClass(string xClass)
        {
            return webDriver.FindElement(By.ClassName(xClass));
        }

    }
}
