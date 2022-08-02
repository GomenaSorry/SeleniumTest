using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTest.ComponentHelper;
using OpenQA.Selenium;
using SeleniumTest.PageObject;
using SeleniumTest.Settings;

namespace SeleniumTest.BaseClasses
{
    public class BasePage
    {
        private readonly IWebDriver driver;

        public BasePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        #region WebElement
        public By IndexPage = By.LinkText("Index");
        public IWebElement IndexPageElement => driver.FindElement(By.LinkText("Index"));
        #endregion

        #region Navigation
        public HomePage NavigateToIndexPage()
        {
            LinkHelper.ClickLink(IndexPage);
            return new HomePage(driver);
        }
        #endregion

        public string Title
        {
            get { return ObjectRepository.Driver.Title; }
        }
    }
}
