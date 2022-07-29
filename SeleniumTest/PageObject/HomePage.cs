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

        private By HtmlFormPage = By.Id("htmlformtest");

        #endregion

        #region Actions

        public bool CheckLinkHtmlFormPage()
        {
            return GenericHelper.IsElementPresent(HtmlFormPage);
        }

        #endregion

        #region Navigation

        public HtmlFormPage NavigateToHtmlFormPage()
        {
            LinkHelper.ClickLink(HtmlFormPage);
            return new HtmlFormPage();
        }

        #endregion
    }
}
