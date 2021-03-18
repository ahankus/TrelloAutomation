using TrelloAutomation;

namespace TestAutomation
{
    public static class MainViewActions
    {
      
        public static void TabliceView()
        {
            HomePage homepage = new HomePage();
            homepage.TabliceBtn.Click();

        }
        public static void SzablonyView()
        {
            HomePage homepage = new HomePage();
            homepage.SzablonyBtn.Click();

        }

        public static void StronaGlownaView()
        {
            HomePage homepage = new HomePage();
            homepage.StronaGlownaBtn.Click();

        }

        public static void TablicaZespoluView()
        {
            HomePage homepage = new HomePage();
            homepage.TablicaZespoluBtn.Click();

        }
    }


}

