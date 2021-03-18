using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace TrelloAutomation
{
    public class LoginForm
    {
        public LoginForm()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

       

        [FindsBy(How = How.Id, Using = "user")]
        public IWebElement Email { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#login")]
        public IWebElement AttlasianLogin { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login-submit")]
        public IWebElement ZalogujSie { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement Zaloguj { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#header > div.TMI28E0KnYSK9p > button._2ZNy4w8Nfa58d1.js-open-header-member-menu._3R2LYccoXhpfv9.voB8NatlbuEme5.YkLuOsDsiYKMs8 > div > span")]
        public IWebElement Konto { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.atlaskit-portal-container > div > section > div > nav > ul > li:nth-child(9) > button")]
        public IWebElement Wyloguj { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#logout-submit > span > span")]
        public IWebElement WylogujPotwierdzenie { get; set; }


    }
}
