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

namespace class_selenium
{

    public class Example : IDisposable
    {
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

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
