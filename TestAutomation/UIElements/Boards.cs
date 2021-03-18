using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace TrelloAutomation
{
    public class Boards
    {
        public Boards()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#header > div.TMI28E0KnYSK9p > button:nth-child(1)")]
        public IWebElement MenuButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.atlaskit-portal-container > div > section > div > nav > ul > li:nth-child(1) > button")]
        public IWebElement UtworzTablice { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#layer-manager-overlay > div > div > div._2RESlz4Z1kkkKj > div > input")]
        public IWebElement NazwaTablicy { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#layer-manager-overlay > div > div > div._1yEjNgzkJX0P_O > div > button")]
        public IWebElement ZapiszTablice { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > div.js-boards-page > div > div > div > div > div.all-boards > div > div > div:nth-child(2) > div:nth-child(2) > ul > li:nth-child(1) > a")]
        public IWebElement PierwszaTablica { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > div.board-menu.js-fill-board-menu > div > div > div.board-menu-content.u-fancy-scrollbar.js-board-menu-content-wrapper > div > ul:nth-child(2) > li:nth-child(5) > a")]
        public IWebElement Wiecej { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > div.board-menu.js-fill-board-menu > div > div > div.board-menu-content.u-fancy-scrollbar.js-board-menu-content-wrapper > div > ul:nth-child(5) > li > a")]
        public IWebElement ZamknijTablice { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#chrome-container > div.pop-over.is-shown > div > div:nth-child(2) > div > div > div > input")]
        public IWebElement PotwierdzenieZamkniecia { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > div > div > p.delete-container > a")]
        public IWebElement UsunTablice { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#chrome-container > div.pop-over.is-shown > div > div:nth-child(2) > div > div > div > input")]
        public IWebElement PotwierdzenieUsuniecia { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#header > div._1ZG6N6wwI3fkaY > a > span")]
        public IWebElement HomeIcon { get; set; }


    }
}
