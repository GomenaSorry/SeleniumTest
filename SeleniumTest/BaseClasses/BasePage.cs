using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTest.ComponentHelper;
using OpenQA.Selenium;
using SeleniumTest.PageObject;

namespace SeleniumTest.BaseClasses
{
    public class BasePage
    {
        #region WebElement

        private By IndexPage = By.LinkText("Index");

        #endregion

        #region Navigation
        public HomePage NavigateToIndexPage()
        {
            LinkHelper.ClickLink(IndexPage);
            return new HomePage();
        }
        #endregion
    }
}
