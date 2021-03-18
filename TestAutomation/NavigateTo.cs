using TrelloAutomation;

namespace TestAutomation
{
    public static class NavigateTo
    {
        public static void MainPage()
        {
            TrelloCom trellocom = new TrelloCom();
            trellocom.Zaloguj.Click();
        }

        /*public static void TrelloPage()
        {
            LoginForm loginform = new LoginForm();
            loginform.AttlasianLogin.Click();
        }*/


    }

}
