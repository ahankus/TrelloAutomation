using OpenQA.Selenium;
using System.Linq;
using TrelloAutomation;

namespace TestAutomation
{
    public static class Helpers
    {
        public static IWebElement FindBoard(string boardname) 
        {
            IWebElement Board = Driver.driver.FindElements(By.ClassName("boards-page-board-section-list-item")).FirstOrDefault(x => x.Text == boardname);
            return Board;
        }
        
    }
}
