using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TrelloAutomation;

namespace TestAutomation
{
    class Logout
    {
        [SetUp]
        public void Initialize()
        {
            GeneralActions.InitializeDriver();
            NavigateTo.MainPage();
            LoginActions.TypeEmail(Config.Credentials.Valid.Email, Config.Credentials.Valid.Password);
        }

        [Test]
        public void UserLogout()
        {
            LoginActions.Logout();

            IWebElement Dziekujemy = Driver.driver.FindElement(By.CssSelector("body > div.layout-centered.u-center-text > div > h1"));
            Assert.IsTrue(Dziekujemy.Displayed);
            Thread.Sleep(2000);

        }

        
        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
