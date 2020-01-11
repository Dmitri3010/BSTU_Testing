using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTest
{
    [TestClass]
    public class Tests : Browser
    {

        IWebDriver BrouserGoogleChrome;
        IWebDriver BrouserGoogleChromeSecondTest;

        [TestMethod]
        public void SearchWithErrorDestination()
        {
            BrouserGoogleChrome = new OpenQA.Selenium.Chrome.ChromeDriver();
            BrouserGoogleChrome.Manage().Window.Maximize();
            BrouserGoogleChrome.Navigate().GoToUrl("https://www.ebooking.com/ru/");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            IWebElement SearhInputLine = BrouserGoogleChrome.FindElement(By.Name("q-destination"));
            SearhInputLine.SendKeys("Минск Берлин Париж Варшава" + Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(5));

            BrouserGoogleChrome.Quit();

        }

        [TestMethod]
        public void Search()
        {
            BrouserGoogleChromeSecondTest = new OpenQA.Selenium.Chrome.ChromeDriver();
            BrouserGoogleChromeSecondTest.Manage().Window.Maximize();
            BrouserGoogleChromeSecondTest.Navigate().GoToUrl("https://www.ebooking.com/ru/");

            IWebElement SearhInputLine = BrouserGoogleChromeSecondTest.FindElement(By.Name("q-destination"));

            SearhInputLine.SendKeys("" + OpenQA.Selenium.Keys.Enter);


            var element = BrouserGoogleChromeSecondTest.FindElement(By.XPath("//span[@class = 'icons icon--alert']"));
            String elementErr = element.Text;
            if (elementErr.Length > 0)
            {
                NUnit.Framework.TestContext.WriteLine($"Message...{elementErr}");
                Console.WriteLine(elementErr);
            }
            Thread.Sleep(TimeSpan.FromSeconds(5));

            BrouserGoogleChromeSecondTest.Quit();
        }
    }
}
