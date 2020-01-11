using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using GitHubAutomation.Models;
using System.Threading;

namespace GitHubAutomation.Pages
{
    public class FindBookingPage
    {
        private IWebDriver driver;

        public FindBookingPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Name, Using = "confirmationNumber")]
        IWebElement BookingNumber { get; set; }

        [FindsBy(How = How.Name, Using = "lastName")]
        IWebElement BookingSurname { get; set; }

        [FindsBy(How = How.Name, Using = "findBooking")]
        IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//small[@class = 'error-message']")] //"//h2[@id = 'widget-overlay-title-1']"
        IWebElement ErrorMessage { get; set; } //smaill id conf-lastname-error

        [FindsBy(How = How.XPath, Using = "//small[@id = 'conf-lastname-error']")] //"//h2[@id = 'widget-overlay-title-1']"
        IWebElement ErrorMessageSurname { get; set; } //smaill id conf-lastname-error

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://hotels.ebooking.com/profile/findbookings.html");
        }

        public string FindBookingWithEmptyBookingNumber(Booking booking)
        {
            BookingNumber.SendKeys(booking.EmptyBooking);
            SearchButton.Click();
            return ErrorMessage.Text;
        }

        public string FindBookingWithWrongBookingNumber(Booking booking)
        {
            BookingNumber.SendKeys(booking.WrongBooking);
            SearchButton.Click();
            return ErrorMessage.Text;
        }

        public string FindBookingWithEmptySurname(Booking booking)
        {
            BookingSurname.SendKeys(booking.EmptySurname);
            SearchButton.Click();
            return ErrorMessageSurname.Text;
        }

        public string FindBookingWithWrongSurname(Booking booking)
        {
            BookingSurname.SendKeys(booking.WrongSurname);
            SearchButton.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            return ErrorMessage.Text;
        }

    }
}
