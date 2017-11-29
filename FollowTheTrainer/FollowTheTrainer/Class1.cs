﻿using System;
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
                NotePage.AddComment(new Comment
                {
                    Text = "Lorem ipsum dolor sit",
                    Mail = "test@test.com",
                    User = "białko"
                });
                    
            

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
