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
    public class HtmlFormPage : BasePage
    {
        #region WebElement

        private By UserNameTextBox = By.XPath("//tbody/tr[1]/td[1]/input[1]");
        private By PasswordTextBox = By.XPath("//tbody/tr[2]/td[1]/input[1]");
        private By CommentBox = By.XPath("//textarea[contains(text(),'Comments...')]");
        private By CheckBox1 = By.XPath("//input[@value='cb1']");
        private By CheckBox2 = By.XPath("//input[@value='cb2']");
        private By CheckBox3 = By.XPath("//input[@value='cb3']");
        private By RadioButton1 = By.XPath("//input[@value='rd1']");
        private By RadioButton2 = By.XPath("//input[@value='rd2']");
        private By RadioButton3 = By.XPath("//input[@value='rd3']");
        private By DropDown1 = By.Name("dropdown");
        private By CancelButton = By.XPath("//tbody/tr[9]/td[1]/input[1]");
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
            CheckBoxHelper.ClickCheckBox(CheckBox2);
            RadioButtonHelper.ClickRadioButton(RadioButton1);
            TextBoxHelper.ClearTextBox(CommentBox);
            TextBoxHelper.TypeInTextBox(CommentBox, "This is an automated message");
            DropDownHelper.SelectElementByValue(DropDown1, "dd6");
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
