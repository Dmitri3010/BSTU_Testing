using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumWebDriver
{
    public partial class Form1 : Form
    {
        IWebDriver BrouserGoogleChrome;
        IWebDriver BrouserGoogleChromeSecondTest;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartFirstTestButtonClick_Click(object sender, EventArgs e)
        {
            BrouserGoogleChrome = new OpenQA.Selenium.Chrome.ChromeDriver();
            BrouserGoogleChrome.Manage().Window.Maximize();
            BrouserGoogleChrome.Navigate().GoToUrl("https://www.ebooking.com/ru/");

            IWebElement SearhInputLine = BrouserGoogleChrome.FindElement(By.Name("q-destination"));

            SearhInputLine.SendKeys("Минск Берлин Париж Варшава" + OpenQA.Selenium.Keys.Enter);
        }

        private void StopFirstTestButton_Click(object sender, EventArgs e)
        {
            BrouserGoogleChrome.Quit();
        }

        private void StartSecondTestButton_Click(object sender, EventArgs e)
        {
            BrouserGoogleChromeSecondTest = new OpenQA.Selenium.Chrome.ChromeDriver();
            BrouserGoogleChromeSecondTest.Manage().Window.Maximize();
            BrouserGoogleChromeSecondTest.Navigate().GoToUrl("https://www.ebooking.com/ru/");

            IWebElement SearhInputLine = BrouserGoogleChromeSecondTest.FindElement(By.Name("q-destination"));

            SearhInputLine.SendKeys("" + OpenQA.Selenium.Keys.Enter);


            var element = BrouserGoogleChromeSecondTest.FindElement(By.XPath("//span[@class = 'icons icon--alert']"));
            String elementErr = element.Text;
            if(elementErr.Length > 0)
            {
                Test2TextBox.Text = elementErr;
            }
            
        }

        private void StopSecondTestButton_Click(object sender, EventArgs e)
        {
            BrouserGoogleChromeSecondTest.Quit();
        }
    }
}
