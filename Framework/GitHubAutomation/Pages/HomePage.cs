using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using GitHubAutomation.Models;

namespace GitHubAutomation.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@class = 'destination-search__guests-input']")]
        IWebElement GuestDropDownList { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@class = 'room-block__num-adults-select']")]
        IWebElement NumberOfAdultsDropDownList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'button__confirm']")]
        IWebElement ConfirmButton { get; set; }

        [FindsBy(How = How.Name, Using = "q-destination")]
        IWebElement SearchInputLine { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class = 'destination-search__date-checkout']")]
        IWebElement ComeInDate { get; set; }

        [FindsBy(How = How.LinkText, Using = "25")]
        IWebElement ChosenData { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class = 'destination-search__button']")]
        IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class = 'icons icon--alert']")]
        IWebElement ErrorDiscovered { get; set; }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://www.ebooking.com/ru/");
        }

        public string FindHotelsByDestination(Destination destination)
        {
            GuestDropDownList.Click();
            NumberOfAdultsDropDownList.Click();
            NumberOfAdultsDropDownList.SendKeys(OpenQA.Selenium.Keys.Down);
            ConfirmButton.Click();
            SearchInputLine.SendKeys(destination.EmptyDestination);
            ComeInDate.Click();
            ChosenData.Click();
            SearchButton.Click();
            return ErrorDiscovered.Text;
        }

        public string FindHotelsByDestinationWithoutGuests(Destination destination)
        {
            SearchInputLine.SendKeys(destination.EmptyDestination);
            ComeInDate.Click();
            ChosenData.Click();
            SearchButton.Click();
            return ErrorDiscovered.Text;
        }
    }
}
