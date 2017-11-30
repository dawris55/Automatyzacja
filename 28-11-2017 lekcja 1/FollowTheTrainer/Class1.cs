using System;
using Xunit;

namespace FollowTheTrainer
{
    public class Class1
    {
        public class AddingBlogCommentsTests : IDisposable
        {
            [Fact]
            public void CanAddCommentToTheBlogNote()
            {                
                MainPage.Open();
                MainPage.OpenFirstNote();
                var koment = new Comment
                {
                    Text = Guid.NewGuid().ToString(),
                    Mail = "test@test.com",
                    User = "Jednak nie guid"
                };
                NotePage.AddComment(koment);
                Assert.Contains(koment.Text, Browser.ReturnPageSource());                            

                // dodaj komentarz
                // sprawdz ze komentarz sie dodal
            }
            public void Dispose()
            {
                Browser.Close();
            }
        }

    }
}
