using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTest.ComponentHelper;
using SeleniumTest.BaseClasses;

namespace SeleniumTest.PageObject
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        public HomePage(IWebDriver _driver)
        {
            this.driver = _driver;
        }
        #region WebElement
        private readonly By HtmlFormPage = By.Id("htmlformtest");
        public IWebElement HtmlFormPageLinkElement => driver.FindElement(HtmlFormPage);
        #endregion

        #region Actions
        public bool CheckLinkHtmlFormPage()
        {
            return GenericHelper.IsElementPresent(HtmlFormPage);
        }
        #endregion

        #region Navigation
        public HtmlFormPage NavigateToHtmlFormPage(IWebDriver _driver)
        {
            LinkHelper.ClickLink(HtmlFormPage);
            return new HtmlFormPage(_driver);
        }
        #endregion
    }
}
