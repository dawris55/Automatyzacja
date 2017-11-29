using System.Linq;

namespace FollowTheTrainer
{
    internal class MainPage
    {
        private static string Url = "https://autotestdotnet.wordpress.com/";
        internal static void Open()
        {
            Browser.NavigateTo(Url);
        }

        internal static void OpenFirstNote()
        {
            var element = Browser.FindByXpath("//article/header");
            element.First().Click();
        }
    }
}