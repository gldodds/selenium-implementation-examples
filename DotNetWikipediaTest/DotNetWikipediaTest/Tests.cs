using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

using DotNetWikipediaTest.PageObjects;
using DotNetWikipediaTest.Data;

namespace DotNetWikipediaTest
{
    [TestClass]
    public class Tests
    {
        private IWebDriver driver;
        private const string browser = "Chrome";

        [TestMethod]
        public void InvalidLogin()
        {
            var homePage = new HomePage(driver);
            homePage.Launch();

            var loginPage = homePage.ClickLoginLink();
            loginPage.EnterCredentials(LoginData.InvalidUsername, LoginData.InvalidPassword);
            loginPage.ClickLoginButton();

            var errorText = loginPage.GetErrorText();
            Assert.IsTrue(errorText == LoginData.InvalidUserErrorText);
        }

        [TestInitialize()]
        public void Setup()
        {
            driver = browser switch
            {
                "Chrome" => new ChromeDriver(),
                "Firefox" => new FirefoxDriver(),
                "IE" => new InternetExplorerDriver(),
                _ => new ChromeDriver(),
            };

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
