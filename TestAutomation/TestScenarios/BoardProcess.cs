using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TrelloAutomation;

namespace TestAutomation
{
    class BoardProcess
    {
        [SetUp]
        public void Initialize()
        {
            GeneralActions.InitializeDriver();
            NavigateTo.MainPage();
            LoginActions.TypeEmail(Config.Credentials.Valid.Email, Config.Credentials.Valid.Password);
        }

        [Test]
        public void NewPrivateBoard()
        {
            BoardActions.CreateNewBoard(Config.BoardNames.NazwaTablicy);
            string BoardName = Driver.driver.FindElement(By.CssSelector("#content > div > div.board-main-content > div.board-header.u-clearfix.js-board-header > div.board-header-btn.mod-board-name.inline-rename-board.js-rename-board > h1")).Text;
            Assert.AreEqual(Config.BoardNames.NazwaTablicy, BoardName);

        }

        [Test]
        public void DeleteBoard()
        {
            
            IWebElement BoardName = Helpers.FindBoard(Config.BoardNames.NazwaTablicy);
            BoardName.Click();
            
            BoardActions.DeletingBoard();
            Thread.Sleep(4000);
            IWebElement DeletedBoard = Helpers.FindBoard(Config.BoardNames.NazwaTablicy);
            Assert.IsNull(DeletedBoard);
        }



        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
