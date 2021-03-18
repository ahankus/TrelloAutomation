using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TrelloAutomation;

namespace TestAutomation
{

    class SuccesfullLogin

    {


        [SetUp]
        public void Initialize()
        {
            GeneralActions.InitializeDriver();
            NavigateTo.MainPage();
        }

        [Test]
        public void ValidLogin()
        {

            LoginActions.TypeEmail(Config.Credentials.Valid.Email, Config.Credentials.Valid.Password);

            IWebElement TrelloHeader = Driver.driver.FindElement(By.Id("header"));
            Assert.IsTrue(TrelloHeader.Displayed);
            Thread.Sleep(5000);
        }


        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }


    }
}

