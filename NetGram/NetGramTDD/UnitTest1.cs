using System;
using Xunit;
using NetGram.Data;
using NetGram.Models;
using NetGram.Pages;
using NetGram.Models.Interfaces;
using NetGram.Models.Services;
using NetGram.Models.Utilities;
using Microsoft.EntityFrameworkCore;

namespace NetGramTDD
{
    public class UnitTest1
    {
        [Fact]
        public void something()
        {
            WorkGram workGram = new WorkGram();
            workGram.UserName = "user One";

            Assert.Equal("user One", workGram.UserName);
        }
        //***********************Get Set for WorkGram in Models********************//
        [Theory]
        [InlineData("user one", "user one")]
        [InlineData("user two", "user two")]
        [InlineData("Three", "Three")]
        public void CanGetNameOfUser(string input, string expected)
        {
            WorkGram workGram = new WorkGram();
            workGram.UserName = input;

            Assert.Equal(expected, workGram.UserName);
        }

        [Theory]
        [InlineData("https://www.bing.com/images/search?view", "https://www.bing.com/images/search?view")]
        [InlineData("/folder/pic2.jpg", "/folder/pic2.jpg")]
        [InlineData("~/directory/pic3.PNG", "~/directory/pic3.PNG")]
        public void CanGetURL(string input, string expected)
        {
            WorkGram workGram = new WorkGram();
            workGram.Comments = input;

            Assert.Equal(expected, workGram.Comments);
        }

        [Theory]
        [InlineData("title one", "title one")]
        [InlineData("Title two", "Title two")]
        [InlineData("BEST", "BEST")]
        public void CanGetTitleOfUser(string input, string expected)
        {
            WorkGram workGram = new WorkGram();
            workGram.Title = input;

            Assert.Equal(expected, workGram.Title);
        }

        [Theory]
        [InlineData("comments one", "comments one")]
        [InlineData("", "")]
        [InlineData("Really long comment because users like to leave a really long comments!!!!!!", "Really long comment because users like to leave a really long comments!!!!!!")]
        public void CanGetComments(string input, string expected)
        {
            WorkGram workGram = new WorkGram();
            workGram.Comments = input;

            Assert.Equal(expected, workGram.Comments);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(22, 22)]
        [InlineData(43987, 43987)]
        public void CanGetViewsCount(int input, int expected)
        {
            WorkGram workGram = new WorkGram();
            workGram.Views = input;

            Assert.Equal(expected, workGram.Views);
        }


        //*****************************Services*****************************************//
        [Fact]
        public async void CrudUsersInDb()
        {
            DbContextOptions<WorkGramDbContext> options = new DbContextOptionsBuilder<WorkGramDbContext>()
                .UseInMemoryDatabase("GetUserName")
                .Options;

            using (WorkGramDbContext context = new WorkGramDbContext(options))
            {
                //Arrange  (CREATE)
                WorkGram workGram = new WorkGram();
                workGram.UserName = "UserOne";

                context.WorkGrams.Add(workGram);
                context.SaveChanges();

                //Act (READ)
                var userName = await context.WorkGrams.FirstOrDefaultAsync(x => x.UserName == workGram.UserName);
                //Assert
                Assert.Equal("UserOne", workGram.UserName);

                //UPDATE
                workGram.UserName = "updated User";
                context.Update(userName);
                context.SaveChanges();
                var updateUser = await context.WorkGrams.FirstOrDefaultAsync(x => x.UserName == workGram.UserName);
                Assert.Equal("updated User", updateUser.UserName);

                //DELETE
                context.WorkGrams.Remove(updateUser);
                context.SaveChanges();
                var deleteUser = await context.WorkGrams.FirstOrDefaultAsync(x => x.UserName == workGram.UserName);
                Assert.True(deleteUser == null);
            }
        }

        [Fact]
        public async void CrudTitleInDb()
        {
            DbContextOptions<WorkGramDbContext> options = new DbContextOptionsBuilder<WorkGramDbContext>()
                .UseInMemoryDatabase("GetTitleName")
                .Options;

            using (WorkGramDbContext context = new WorkGramDbContext(options))
            {
                //Arrange  (CREATE)
                WorkGram workGram = new WorkGram();
                workGram.Title = "Big Title";

                context.WorkGrams.Add(workGram);
                context.SaveChanges();

                //Act (READ)
                var titleName = await context.WorkGrams.FirstOrDefaultAsync(x => x.Title == workGram.Title);
                //Assert
                Assert.Equal("Big Title", workGram.Title);

                //UPDATE
                workGram.Title = "updated Title";
                context.Update(titleName);
                context.SaveChanges();
                var updateTitle = await context.WorkGrams.FirstOrDefaultAsync(x => x.Title == workGram.Title);
                Assert.Equal("updated Title", updateTitle.Title);

                //DELETE
                context.WorkGrams.Remove(updateTitle);
                context.SaveChanges();
                var deleteTitle = await context.WorkGrams.FirstOrDefaultAsync(x => x.Title == workGram.Title);
                Assert.True(deleteTitle == null);
            }
        }

        [Fact]
        public async void CrudURLInDb()
        {
            DbContextOptions<WorkGramDbContext> options = new DbContextOptionsBuilder<WorkGramDbContext>()
                .UseInMemoryDatabase("GetURLname")
                .Options;

            using (WorkGramDbContext context = new WorkGramDbContext(options))
            {
                //Arrange  (CREATE)
                WorkGram workGram = new WorkGram();
                workGram.URL = "https://via.placeholder.com/250";

                context.WorkGrams.Add(workGram);
                context.SaveChanges();

                //Act (READ)
                var urlName = await context.WorkGrams.FirstOrDefaultAsync(x => x.URL == workGram.URL);
                //Assert
                Assert.Equal("https://via.placeholder.com/250", workGram.URL);

                //UPDATE
                workGram.URL = "https://via.placeholder.com/150";
                context.Update(urlName);
                context.SaveChanges();
                var updateURL = await context.WorkGrams.FirstOrDefaultAsync(x => x.URL == workGram.URL);
                Assert.Equal("https://via.placeholder.com/150", updateURL.URL);

                //DELETE
                context.WorkGrams.Remove(updateURL);
                context.SaveChanges();
                var deleteURL = await context.WorkGrams.FirstOrDefaultAsync(x => x.URL == workGram.URL);
                Assert.True(deleteURL == null);
            }
        }

        [Fact]
        public async void CrudViewsInDb()
        {
            DbContextOptions<WorkGramDbContext> options = new DbContextOptionsBuilder<WorkGramDbContext>()
                .UseInMemoryDatabase("GetViewsname")
                .Options;

            using (WorkGramDbContext context = new WorkGramDbContext(options))
            {
                //Arrange  (CREATE)
                WorkGram workGram = new WorkGram();
                workGram.Views = 1;

                context.WorkGrams.Add(workGram);
                context.SaveChanges();

                //Act (READ)
                var viewsName = await context.WorkGrams.FirstOrDefaultAsync(x => x.Views == workGram.Views);
                //Assert
                Assert.Equal(1, workGram.Views);

                //UPDATE
                workGram.Views = 456;
                context.Update(viewsName);
                context.SaveChanges();
                var updateViews = await context.WorkGrams.FirstOrDefaultAsync(x => x.Views == workGram.Views);
                Assert.Equal(456, updateViews.Views);

                //DELETE
                context.WorkGrams.Remove(updateViews);
                context.SaveChanges();
                var deleteViews = await context.WorkGrams.FirstOrDefaultAsync(x => x.Views == workGram.Views);
                Assert.True(deleteViews == null);
            }
        }

    }
}