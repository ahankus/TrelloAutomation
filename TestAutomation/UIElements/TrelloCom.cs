using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace TrelloAutomation
{
    public class TrelloCom
    {
        public TrelloCom()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "body > header > nav > div > a.btn.btn-sm.btn-link.text-primary")]
        public IWebElement Zaloguj { get; set; }
    }
}
