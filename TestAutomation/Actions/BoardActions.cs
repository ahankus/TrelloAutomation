using System.Threading;
using TrelloAutomation;

namespace TestAutomation
{
    public static class BoardActions
    {
        
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

