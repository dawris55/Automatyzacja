using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.ObjectModel;

namespace FollowTheTrainer
{
    internal class Browser
    {
        private static IWebDriver driver;

        internal static IWebElement FindElementById(string id)
        {
            return driver.FindElement(By.Id(id));
        }

        
        static Browser()
        {
            driver = new FirefoxDriver();
            driver.Manage()
                .Window
                .Maximize();
            driver.Manage()
                .Timeouts()
                .ImplicitWait = TimeSpan.FromMilliseconds(500);
        }

        internal static string ReturnPageSource()
        {
            string pagesource = driver.PageSource;
            return pagesource;
        }

        /*internal static void WaitForInvisible(By by)
{
   new WebDriverException(driver, TimeSpan.FromMilliseconds(double ))
}*/
        internal static ReadOnlyCollection<IWebElement> FindByXpath(string xpath)
        {
            return driver.FindElements(By.XPath(xpath));
        }

        internal static void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        internal static void Close()
        {
            driver.Quit();
        }
    }
}