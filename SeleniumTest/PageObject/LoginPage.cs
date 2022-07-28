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
    public class LoginPage : BasePage
    {
        #region WebElement

        private By UserNameTextBox = By.XPath("//tbody/tr[1]/td[1]/input[1]");
        private By PasswordTextBox = By.XPath("//tbody/tr[2]/td[1]/input[1]");
        private By SubmitButton = By.XPath("//tbody/tr[9]/td[1]/input[2]");
        //private By IndexPage = By.LinkText("Index");

        #endregion

        #region Actions

        public void Login(string username, string password)
        {
            TextBoxHelper.TypeInTextBox(UserNameTextBox, username);
            TextBoxHelper.TypeInTextBox(PasswordTextBox, password);
        }

        public FormProcessorPage ClickSubmitButton()
        {
            ButtonHelper.ClickButton(SubmitButton);
            return new FormProcessorPage();
        }

        public void InputValues()
        {
            CheckBoxHelper.ClickCheckBox(By.XPath("//input[@value='cb2']"));
            RadioButtonHelper.ClickRadioButton(By.XPath("//input[@value='rd1']"));
            TextBoxHelper.TypeInTextBox(By.XPath("//textarea[contains(text(),'Comments...')]"), "This is an automated message");
        }

        public HomePage GoToIndexpage()
        {
            NavigateToIndexPage();
            return new HomePage();
        }

  

        #endregion

        #region Navigation

        //public HomePage NavigateToIndexPage()
        //{
        //    LinkHelper.ClickLink(IndexPage);
        //    return new HomePage();
        //}

        #endregion
    }
}
