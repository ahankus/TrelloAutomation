using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TrelloAutomation;

namespace TestAutomation
{
    public static class GeneralActions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);            
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
        }

        

        public static void TypeEmail(string username, string password)
        {
            LoginForm login = new LoginForm();
            login.Email.SendKeys(username);
            login.AttlasianLogin.Click();
            Thread.Sleep(2000);
            login.Password.SendKeys(password);
            login.ZalogujSie.Click();
        }

        public static void TypeWrongEmail(string username)
        {
            LoginForm login = new LoginForm();
            login.Email.SendKeys(username);
            Thread.Sleep(1000);
            login.Zaloguj.Click();
            Thread.Sleep(2000);

        }

        public static void TypeWrongPassword(string username, string password)
        {
            LoginForm login = new LoginForm();
            login.Email.SendKeys(username);
            login.AttlasianLogin.Click();
            Thread.Sleep(2000);
            login.Password.SendKeys(password);
            login.ZalogujSie.Click();
            Thread.Sleep(5000);

        }

        public static void CreateNewBoard(string board)
        {
            Boards boards = new Boards();
            boards.MenuButton.Click();
            boards.UtworzTablice.Click();
            boards.NazwaTablicy.SendKeys(board);
            Thread.Sleep(1000);
            boards.ZapiszTablice.Click();
            Thread.Sleep(2000);
        }

        public static void DeletingBoard()
        {
            Boards boards = new Boards();
            boards.Wiecej.Click();
            boards.ZamknijTablice.Click();
            boards.PotwierdzenieZamkniecia.Click();
            boards.UsunTablice.Click();
            boards.PotwierdzenieUsuniecia.Click();
            boards.HomeIcon.Click();
        }

        
    }

    
}

