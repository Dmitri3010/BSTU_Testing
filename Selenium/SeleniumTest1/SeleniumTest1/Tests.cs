using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumTest1
{
    [TestClass]
    public class Tests
    {
        IWebDriver BrouserGoogleChrome;

        [TestMethod]
        public void SearchEmptyDestination()
        {
            #region VariablesAndBrowserStart
            const String errorToFind = "Пожалуйста, введите место назначения для начала поиска.";
            const String EmptyField = "";

            BrouserGoogleChrome = new OpenQA.Selenium.Chrome.ChromeDriver();
            BrouserGoogleChrome.Manage().Window.Maximize();
            BrouserGoogleChrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            BrouserGoogleChrome.Navigate().GoToUrl("https://www.ebooking.com/ru/");
            #endregion

            Thread.Sleep(TimeSpan.FromSeconds(4));

            IWebElement Guest = BrouserGoogleChrome.FindElement(By.XPath("//input[@class = 'destination-search__guests-input']"));
            Guest.Click();

            Thread.Sleep(TimeSpan.FromSeconds(4));

            IWebElement NumberOfAdults = BrouserGoogleChrome.FindElement(By.XPath("//select[@class = 'room-block__num-adults-select']"));
            NumberOfAdults.Click();

            Thread.Sleep(TimeSpan.FromSeconds(4));

            NumberOfAdults.SendKeys(OpenQA.Selenium.Keys.Down);

            Thread.Sleep(TimeSpan.FromSeconds(4));

            IWebElement ButtonConfirm = BrouserGoogleChrome.FindElement(By.XPath("//div[@class = 'button__confirm']"));
            ButtonConfirm.Click();

            Thread.Sleep(TimeSpan.FromSeconds(4));

            IWebElement SearhInputLine = BrouserGoogleChrome.FindElement(By.Name("q-destination"));
            SearhInputLine.SendKeys(EmptyField);

            Thread.Sleep(TimeSpan.FromSeconds(4));

            IWebElement ComeInDate = BrouserGoogleChrome.FindElement(By.XPath("//input[@class = 'destination-search__date-checkout']"));
            ComeInDate.Click();

            Thread.Sleep(TimeSpan.FromSeconds(4));

            IWebElement ChosenData = BrouserGoogleChrome.FindElement(By.LinkText("18"));
            ChosenData.Click();

            Thread.Sleep(TimeSpan.FromSeconds(4));

            IWebElement ButtonSearch = BrouserGoogleChrome.FindElement(By.XPath("//button[@class = 'destination-search__button']"));
            ButtonSearch.Click();

            Thread.Sleep(TimeSpan.FromSeconds(4));

            var errorMessage = BrouserGoogleChrome.FindElement(By.XPath("//span[@class = 'icons icon--alert']"));
            string errorDiscovered = errorMessage.Text;

            Assert.AreEqual(errorToFind, errorDiscovered);

            Thread.Sleep(TimeSpan.FromSeconds(4));

            BrouserGoogleChrome.Quit();
        }

        [TestMethod]
        public void SearchWrongBooking()
        {
            #region VariablesAndBrowserStart
            const String errorToFind = "Не удалось найти ваше бронирование. Проверьте правильность номера подтверждения и фамилии, указанных в подтверждении.Если у вас все еще возникают проблемы с доступом к бронированию, свяжитесь с нами по телефону 0499 271 85 08.";
            const String WrongSurname = "Топкек";
            const String WrongConfirmationNumber = "809382083028302";

            BrouserGoogleChrome = new OpenQA.Selenium.Chrome.ChromeDriver();
            BrouserGoogleChrome.Manage().Window.Maximize();
            BrouserGoogleChrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            BrouserGoogleChrome.Navigate().GoToUrl("https://hotels.ebooking.com/profile/findbookings.html?_ga=2.267176206.1626617198.1572362204-850875168.1572362204");
            #endregion

            IWebElement ConfirmationNumber = BrouserGoogleChrome.FindElement(By.Id("fb-conf-num"));
            ConfirmationNumber.SendKeys(WrongConfirmationNumber);

            IWebElement Surname = BrouserGoogleChrome.FindElement(By.Id("fb-conf-lastname"));
            Surname.SendKeys(WrongSurname + OpenQA.Selenium.Keys.Enter);

            var errorMessage = BrouserGoogleChrome.FindElement(By.XPath("//div[@class = 'msg-error mb-spider']"));
            string errorDiscovered = errorMessage.Text;

            Assert.AreEqual(errorToFind, errorDiscovered);

            BrouserGoogleChrome.Quit();

        }

        [TestMethod]
        public void SearchWrongDestination()
        {
            #region VariablesAndBrowserStart
            const String errorToFind = "No hemos entendido mklsvmkvlmdlkmdlkbmkldmbkldmbldasd";
            const String WrongDestination = "Минск";

            BrouserGoogleChrome = new OpenQA.Selenium.Chrome.ChromeDriver();
            BrouserGoogleChrome.Manage().Window.Maximize();
            BrouserGoogleChrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            BrouserGoogleChrome.Navigate().GoToUrl("https://hotels.ebooking.com/");
            #endregion

            Thread.Sleep(TimeSpan.FromSeconds(10));

            IWebElement CityDestination = BrouserGoogleChrome.FindElement(By.Name("q-destination"));
            CityDestination.SendKeys(WrongDestination);

            Thread.Sleep(TimeSpan.FromSeconds(5));

            IWebElement SearchButton = BrouserGoogleChrome.FindElement(By.XPath("//button[@type = 'submit']"));
            SearchButton.Click();

            Thread.Sleep(TimeSpan.FromSeconds(5));

            var errorMessage = BrouserGoogleChrome.FindElement(By.XPath("//h2[@id = 'widget-overlay-title-1']"));
            string errorDiscovered = errorMessage.Text;

            Assert.AreEqual(errorToFind, errorDiscovered);

            BrouserGoogleChrome.Quit();

        }
    }
}
