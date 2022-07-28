using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTest.ComponentHelper;

namespace SeleniumTest.PageObject
{
    public class HomePage
    {
        #region WebElement

        private By LoginPage = By.Id("htmlformtest");

        #endregion

        #region Actions

        public bool CheckLinkLoginPage()
        {
            return GenericHelper.IsElementPresent(LoginPage);
        }

        #endregion

        #region Navigation

        public LoginPage NavigateToLoginPage()
        {
            LinkHelper.ClickLink(LoginPage);
            return new LoginPage();
        }

        #endregion
    }
}
