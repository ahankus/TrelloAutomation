using System.Threading;
using TrelloAutomation;

namespace TestAutomation
{
    public static class LoginActions
    {
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

        public static void Logout()
        {
            LoginForm login = new LoginForm();
            login.Konto.Click();
            login.Wyloguj.Click();
            login.WylogujPotwierdzenie.Click();
            Thread.Sleep(5000);

        }


    }


}

