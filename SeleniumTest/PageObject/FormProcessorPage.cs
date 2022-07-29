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
    public class FormProcessorPage : BasePage
    {
        #region WebElement

        private By UserName = By.Id("_valueusername");
        private By Password = By.Id("_valuepassword");
        private By ReturnButton = By.XPath("//a[@id='back_to_form']");
        //private By IndexPage = By.LinkText("Index");

        #endregion

        #region Actions

        public bool CheckValues()
        {
            string usernameValue = GenericHelper.GetElement(UserName).Text;
            string passwordValue = GenericHelper.GetElement(Password).Text;
            if (usernameValue.Equals("MyUserName") && passwordValue.Equals("P@ssw0rd"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public HtmlFormPage ClickReturnToLoginPage()
        {
            ButtonHelper.ClickButton(ReturnButton);
            return new HtmlFormPage();
        }

        #endregion

        #region Navigation

        //public void NavigateToIndexPage()
        //{
        //    LinkHelper.ClickLink(IndexPage);
        //}

        #endregion
    }
}
