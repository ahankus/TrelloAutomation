using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TrelloAutomation;

namespace TestAutomation
{

    class OpenMainViews

    {


        [SetUp]
        public void Initialize()
        {
            GeneralActions.InitializeDriver();
            NavigateTo.MainPage();
            LoginActions.TypeEmail(Config.Credentials.Valid.Email, Config.Credentials.Valid.Password);
        }

        [Test]
        public void Tablice()
        {

            MainViewActions.TabliceView();

            IWebElement TablicePrywatneHeader = Driver.driver.FindElement(By.CssSelector("#content > div > div.js-boards-page > div > div > div > div > div.all-boards > div > div > div:nth-child(2) > div.boards-page-board-section-header > h3"));
            Assert.IsTrue(TablicePrywatneHeader.Displayed);

        }

        [Test]
        public void Szablony()
        {

            MainViewActions.SzablonyView();

            IWebElement BiznesIcon = Driver.driver.FindElement(By.CssSelector("#content > div > div.js-boards-page > div > div > div > div > div.all-boards > div > div > div > div > div > div._1A_iXVIE0SSny7._2jHgdiEk9Db9co > div:nth-child(1) > a"));
            Assert.IsTrue(BiznesIcon.Displayed);

        }

        [Test]
        public void StronaGlowna()
        {

            MainViewActions.StronaGlownaView();

            IWebElement OrganizujWszystko = Driver.driver.FindElement(By.CssSelector("#content > div > div.js-boards-page > div > div > div > div > div.home-main-content-container > div:nth-child(3) > div > div._1TlQW75feSfKxV > span._2q1pYXBwBrjhAV"));
            Thread.Sleep(3000);
            Assert.IsTrue(OrganizujWszystko.Displayed);

        }

        [Test]
        public void TablicaZespolu()
        {

            MainViewActions.TablicaZespoluView();

            IWebElement TwojaTablica = Driver.driver.FindElement(By.CssSelector("#content > div:nth-child(3) > div.tabbed-pane-nav.u-clearfix > ul > li:nth-child(1) > a"));
            Thread.Sleep(3000);
            Assert.IsTrue(TwojaTablica.Displayed);

        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }


    }
}

