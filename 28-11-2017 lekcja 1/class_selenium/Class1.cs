using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using Xunit;
using System.Linq;
using System.Threading;
using System.Collections.ObjectModel;

namespace SeleniumTests
{
    public class Example : IDisposable
    {
        private const string SearchTextBoxId = "lst-ib";
        private const string CodeSprintersPageTitle = "Code Sprinters -";
        private const string TextToSearch = "Dlaczego Code Sprinters";
        private const string ButtonToFind = "Poznaj nasze podejście";
        private const string CookieClicker = "Akceptuję";
        private const string Stopka = "Automatyzacja testów Java";
        private const string Cel = "WIEDZA NA PIERWSZYM MIEJSCU";
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        public Example()
        {
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            baseURL = "https://www.google.pl/";
            verificationErrors = new StringBuilder();
        }

        [Fact]
        public void TheExampleTest()
        {
            GoToGoogle();
            Search();
            OpenSearchResultByPageTitle(CodeSprintersPageTitle);

            Assert.Equal(CodeSprintersPageTitle, driver.Title);
            IWebElement element = LookingForButton();

            Assert.NotNull(element);
            Assert.Single(GetElements(ButtonToFind));
            GettingRidOfCookies(CookieClicker);
            WaitForInvisible(CookieClicker);

            OpenSearchResultByPageTitle(ButtonToFind);
            

            WaitForClickable(By.LinkText(Stopka), 11);
            Assert.Contains(Cel, driver.PageSource);
            
        }

        private void WaitForInvisible(string linktext)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(11));
            wait.Until(ExpectedConditions.InvisibilityOfElementWithText(By.LinkText(linktext), linktext));
        }

        private ReadOnlyCollection<IWebElement> GetElements(string linktext)
        {
            return driver.FindElements(By.LinkText(linktext));
        }

        private void GettingRidOfCookies(string linktext)
        {
            driver.FindElement(By.LinkText(linktext)).Click();
        }

        private IWebElement LookingForButton()
        {
            return driver.FindElement(By.LinkText(ButtonToFind));
        }

        private void Search()
        {
            IWebElement searchbox = GetSearchBox();
            searchbox.Clear();
            searchbox.SendKeys(TextToSearch);
            searchbox.Submit();
        }

        private void OpenSearchResultByPageTitle(string title)
        {
            driver.FindElement(By.LinkText(title)).Click();
        }
        private IWebElement GetSearchBox()
        {
            return driver.FindElement(By.Id(SearchTextBoxId));
        }

        private void GoToGoogle()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
           catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        protected void WaitForClickable(By by, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected void WaitForElementPresent(IWebElement by, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }
        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
                public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                 //Ignore errors if unable to close the browser
            }
            Assert.Equal("", verificationErrors.ToString());

        }
    }
}