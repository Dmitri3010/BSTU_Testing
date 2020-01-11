using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using GitHubAutomation.Driver;
using GitHubAutomation.Pages;
using GitHubAutomation.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.Extensions;

namespace GitHubAutomation.Tests
{
    [TestFixture]
    public class WebTests : GeneralConfig
    {
        public Logger logger = new Logger();

        [Test]
        public void SearchWithWrongDestination()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                HotelsPage hotels = new HotelsPage(Driver);
                hotels.GoToPage();
                logger.Log("Test- Search with wrong destination, time: ");
                Assert.AreEqual( "Dinos qué destino, hotel o punto de referencia estás buscando", hotels.FindHotelsByDestination(InAccessibleDestination.WithWronDestination()));
            });
        }

        [Test]
        public void SearchHotelWithWrongDestination()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                HotelsPage hotels = new HotelsPage(Driver);
                hotels.GoToPage();
                logger.Log("Test- Search hotel with wrong destination, time: ");
                Assert.AreEqual("Dinos qué destino, hotel o punto de referencia estás buscando", hotels.FindHotelsByWrongDestination(InAccessibleDestination.WithWronDestination()));
            });
        }

        [Test]
        public void SearchWithEmptyDestination()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                HomePage home = new HomePage(Driver);
                home.GoToPage();
                logger.Log("Test- Search with empty destination, time: ");
                Assert.AreEqual("Пожалуйста, введите место назначения для начала поиска.", home.FindHotelsByDestination(InAccessibleDestination.WithWronDestination()));
            });
        }

        [Test]
        public void SearchWithEmptyDestinationWithoutGuests()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                HomePage home = new HomePage(Driver);
                home.GoToPage();
                logger.Log("Test- Search with empty destination without guests, time: ");
                Assert.AreEqual("Пожалуйста, введите место назначения для начала поиска.", home.FindHotelsByDestinationWithoutGuests(InAccessibleDestination.WithWronDestination()));
            });
        }

        [Test]
        public void SearchWithEmptyBookingNumber()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                FindBookingPage booking = new FindBookingPage(Driver);
                booking.GoToPage();
                logger.Log("Test- Search with empty booking number , time: ");
                Assert.AreEqual("Introduce tu número de confirmación", booking.FindBookingWithEmptyBookingNumber(InAccessibleBookingCreator.WithWronBooking()));
            });
        }

        [Test]
        public void SearchWithWrongBookingNumber()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                FindBookingPage booking = new FindBookingPage(Driver);
                booking.GoToPage();
                logger.Log("Test- Search with wrong booking number, time: ");
                Assert.AreEqual("Introduce tus apellidos", booking.FindBookingWithWrongBookingNumber(InAccessibleBookingCreator.WithWronBooking()));
            });
        }

        [Test]
        public void SearchBookingWithEmptySurname()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                FindBookingPage booking = new FindBookingPage(Driver);
                booking.GoToPage();
                logger.Log("Test- Search with empty surname, time: ");
                Assert.AreEqual("Introduce tus apellidos", booking.FindBookingWithEmptySurname(InAccessibleBookingCreator.WithWronBooking()));
            });
        }

        [Test]
        public void SearchBookingWithWrongSurname()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                FindBookingPage booking = new FindBookingPage(Driver);
                booking.GoToPage();
                logger.Log("Test- Search with wrong surname, time: ");
                Assert.AreEqual("Introduce tu número de confirmación", booking.FindBookingWithWrongSurname(InAccessibleBookingCreator.WithWronBooking()));
            });
        }

        [Test]
        public void SearchBookingWithEmptySurnameRiseError()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                FindBookingPage booking = new FindBookingPage(Driver);
                booking.GoToPage();
                logger.Log("Test- Search with empty surname(Rise error to take screen ), time: ");
                Assert.AreEqual("Introduce tus apellido", booking.FindBookingWithEmptySurname(InAccessibleBookingCreator.WithWronBooking()));
            });
        }

        [Test]
        public void SearchBookingWithWrongSurnameRiseError()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                FindBookingPage booking = new FindBookingPage(Driver);
                booking.GoToPage();
                logger.Log("Test- Search with wrong surname(Rise error to take screen), time: ");
                Assert.AreEqual("Introduce tu número de confirmació", booking.FindBookingWithWrongSurname(InAccessibleBookingCreator.WithWronBooking()));
            });
        }
    }
}
