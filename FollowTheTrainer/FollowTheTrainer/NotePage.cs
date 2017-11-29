using System;
using System.Linq;

namespace FollowTheTrainer
{
    internal class NotePage
    {
        internal static void AddComment(Comment TestData)
        {
            var commentbox = Browser.FindElementById("comment");
            commentbox.Click();
            commentbox.SendKeys(TestData.Text);

            var email = Browser.FindElementById("email");
            email.Click();
            email.SendKeys(TestData.Mail);

            var nameLabel = Browser.FindByXpath("//label[@for='author'");
            nameLabel.First().Click();

            var name = Browser.FindElementById("autor");
            name.Click();
            name.SendKeys(TestData.User);

            var submit = Browser.FindElementById("comment-submit");
            submit.Click();
           
        }
    }
}