using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TrelloAutomation;

namespace TestAutomation
{

    class LoginFailed

    {


        [SetUp]
        public void Initialize()
        {
            GeneralActions.InitializeDriver();
            NavigateTo.MainPage();
        }

        [Test]
        public void WrongEmail()
        {

            LoginActions.TypeWrongEmail(Config.Credentials.Invalid.Email);

            IWebElement ErrorMsg = Driver.driver.FindElement(By.CssSelector("#error > p"));
            Assert.IsTrue(ErrorMsg.Displayed);

        }

        [Test]
        public void WrongPassword()
        {

            LoginActions.TypeEmail(Config.Credentials.Valid.Email, Config.Credentials.Invalid.Password);

            IWebElement TrelloHeader = Driver.driver.FindElement(By.Id("login-error"));
            Thread.Sleep(3000);
            Assert.IsTrue(TrelloHeader.Displayed);

        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }


    }
}

