using System;
using OpenQA.Selenium;

namespace DotNetWikipediaTest.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement usernameField => driver.FindElement(By.Id("wpName1"));
        private IWebElement passwordField => driver.FindElement(By.Id("wpPassword1"));
        private IWebElement loginButton => driver.FindElement(By.Id("wpLoginAttempt"));
        private IWebElement errorBanner => driver.FindElement(By.ClassName("mw-message-box-error"));

        public void EnterCredentials(string username, string password)
        {
            usernameField.SendKeys(username);
            passwordField.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            loginButton.Click();
        }

        public string GetErrorText()
        {
            return errorBanner.Text;
        }
    }
}
