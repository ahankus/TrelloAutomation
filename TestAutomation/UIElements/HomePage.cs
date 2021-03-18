using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace TrelloAutomation
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "body > header")]
        public IWebElement TrelloHeader { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > div.js-boards-page > div > div > div > div > div:nth-child(1) > nav > div:nth-child(1) > ul > li:nth-child(1) > a > span._3qwe2tMMFonNvf")]
        public IWebElement TabliceBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > div.js-boards-page > div > div > div > div > div:nth-child(1) > nav > div:nth-child(1) > ul > div > li")]
        public IWebElement SzablonyBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > div.js-boards-page > div > div > div > div > div:nth-child(1) > nav > div:nth-child(1) > ul > li:nth-child(3)")]
        public IWebElement StronaGlownaBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > div.js-boards-page > div > div > div > div > div:nth-child(1) > nav > div:nth-child(2) > div > ul > li")]
        public IWebElement TablicaZespoluBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#header > div.TMI28E0KnYSK9p > button._2ZNy4w8Nfa58d1.js-open-header-member-menu._3R2LYccoXhpfv9.voB8NatlbuEme5.YkLuOsDsiYKMs8 > div > span")]
        public IWebElement Konto { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.atlaskit-portal-container > div > section > div > nav > ul > li:nth-child(9) > button")]
        public IWebElement Wyloguj { get; set; }
    }
}
