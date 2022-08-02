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
        private readonly IWebDriver driver;
        public FormProcessorPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region WebElement
        private readonly By UsernameValue = By.Id("_valueusername");
        private readonly By PasswordValue = By.Id("_valuepassword");
        private readonly By CommentValue = By.Id("_valuecomments");
        private readonly By CheckboxValue1 = By.Id("_valuecheckboxes0");
        private readonly By CheckboxValue2 = By.Id("_valuecheckboxes1");
        private readonly By CheckboxValue3 = By.Id("_valuecheckboxes2");
        private readonly By RadioButtonValue = By.Id("_valueradioval");
        private readonly By DropDownvalue = By.Id("_valuedropdown");
        private readonly By ReturnButton = By.Id("back_to_form");
        
        public IWebElement UsernameValueElement => driver.FindElement(UsernameValue);
        public IWebElement PasswordValueElement => driver.FindElement(PasswordValue);
        public IWebElement ReturnButtonElement => driver.FindElement(ReturnButton);


        #endregion

        #region Actions

        public bool CheckValues()
        {
            string usernameValue = GenericHelper.GetElement(UsernameValue).Text;
            string passwordValue = GenericHelper.GetElement(PasswordValue).Text;
            if (usernameValue.Equals("MyUserName") && passwordValue.Equals("P@ssw0rd"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public HtmlFormPage ClickReturnToHtmlFormPage()
        {
            ButtonHelper.ClickButton(ReturnButton);
            return new HtmlFormPage(driver);
        }

        #endregion

        #region Navigation
        // Index navigation inherited from BasePage
        #endregion
    }
}
