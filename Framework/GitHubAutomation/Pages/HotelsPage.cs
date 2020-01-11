using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using GitHubAutomation.Models;
using System.Threading;

namespace GitHubAutomation.Pages
{
    public class HotelsPage
    {
        private IWebDriver driver;

        public HotelsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@type = 'submit']")]
        IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'form-error-cont']")] //"//h2[@id = 'widget-overlay-title-1']"
        IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.Name, Using = "q-destination")]
        IWebElement CityDestinationField { get; set; } //widget-overlay-hd

        [FindsBy(How = How.XPath, Using = "//h2[@class = 'widget-overlay-hd']")] //"//h2[@id = 'widget-overlay-title-1']"
        IWebElement ErrorMessageWithWrongDestination { get; set; }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://hotels.ebooking.com/");
        }

        public string FindHotelsByDestination(Destination destination)
        {
            CityDestinationField.SendKeys(destination.WrongDestination);
            SearchButton.Click();
            return ErrorMessage.Text;
        }

        public string FindHotelsByWrongDestination(Destination destination)
        {
            CityDestinationField.SendKeys(destination.WrongCity);
            SearchButton.Click();
            return ErrorMessageWithWrongDestination.Text;
        }
    }
}
