using System;
using OpenQA.Selenium;

namespace DotNetWikipediaTest.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;
        private readonly string initialURL = "https://en.wikipedia.org";

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement loginPageLink => driver.FindElement(By.Id("pt-login"));

        public void Launch()
        {
            driver.Navigate().GoToUrl(initialURL);
        }

        public LoginPage ClickLoginLink()
        {
            loginPageLink.Click();
            return new LoginPage(driver);
        }
    }
}
