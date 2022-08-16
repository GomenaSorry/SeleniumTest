using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTest.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.Settings;


namespace SeleniumTest.GuardianTest.PageObject
{
    public class GuardianLoginPage
    {
        private readonly IWebDriver driver;
        public GuardianLoginPage(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        #region WebElement

        private readonly By SignInButton = By.Id("btnSignIn");
        private readonly By TextboxEmailAddress = By.Id("tbxEmailAddress");
        private readonly By TextboxPassword = By.Id("tbxPassword");

        public IWebElement SignInButtonElement => driver.FindElement(SignInButton);
        public IWebElement TextboxEmailAddressElement => driver.FindElement(TextboxEmailAddress);
        public IWebElement TextboxPasswordElement => driver.FindElement(TextboxPassword);

        #endregion

        #region Actions
        public void GetPageLoadTime(int baselineTime, IWebDriver _driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            var responseTime = Convert.ToInt32(js.ExecuteScript("return window.performance.timing.domContentLoadedEventEnd-window.performance.timing.navigationStart;"));

            Console.WriteLine(string.Format("Page {0} loading time is {1} ms", _driver.Title, responseTime));

            Assert.IsTrue(baselineTime > responseTime);
        }

        public void SignIn(string email, string password, IWebDriver _driver)
        {
            TextBoxHelper.TypeInTextBox(TextboxEmailAddress, email);
            TextBoxHelper.TypeInTextBox(TextboxPassword, password);
            ClickSignInButton(_driver);
        }

        public GuardianDashboardPage ClickSignInButton(IWebDriver _driver)
        {
            ButtonHelper.ClickButton(SignInButton);
            return new GuardianDashboardPage(_driver);
        }

        #endregion
    }
}
