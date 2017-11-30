using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;
using Xunit;

namespace Wordpress
{
    public class Wordpress
    {

        public class AddingBlogCommentsTests : IDisposable
        {
            private static string url = "https://autotestdotnet.wordpress.com/wp-admin/";
            private static string user = "autotestdotnet@gmail.com";
            private static string pass = "P@ssw0rd1";
            private static string title = Guid.NewGuid().ToString();
            private static string content = Guid.NewGuid().ToString();
            [Fact]
            public void LogingIn()
            {
                Browser.NavigateTo(url);
                var logInField = Browser.FindByXpath("//*[@name='usernameOrEmail']").First();
                logInField.Click();
                logInField.SendKeys(user);
                var passField = Browser.FindByXpath("//*[@name='password']").First();
                passField.Click();
                passField.SendKeys(pass);
                var LogInButon = Browser.FindByXpath("//button[contains(text(),'Log In')]").First();
                LogInButon.Click();
                Thread.Sleep(3000);
                var Pagesbutton = Browser.FindByXpath("//*[@class='wp-menu-name' and text()='Posts']").First();
                Pagesbutton.Click();
                Thread.Sleep(3000);
                var AddNew = Browser.FindByXpath("//*[@class='page-title-action' and text()='Add New']").First();
                AddNew.Click();
                var TitleOfNote = Browser.FindElementById("title-prompt-text");
                TitleOfNote.Click();
                TitleOfNote.SendKeys(title);
                var ContentOfNote = Browser.FindElementById("content");
                ContentOfNote.Click();
                ContentOfNote.SendKeys(title);
                //var EditButton = Browser.FindByXpath("//button[contains(text(),'Edit')]").First();
                //EditButton.Browser.WaitForClickable(By.LinkText("Edit"), 11);
                

            }

            public void Dispose()
            {
                Browser.Close();
            }
        }
    }
}