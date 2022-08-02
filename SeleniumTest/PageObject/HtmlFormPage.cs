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
        private readonly IWebDriver driver;

        public HtmlFormPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }


        #region WebElement
        private readonly By UsernameTextbox = By.XPath("//tbody/tr[1]/td[1]/input[1]");
        private readonly By PasswordTextbox = By.XPath("//tbody/tr[2]/td[1]/input[1]");
        private readonly By CommentTextbox = By.XPath("//textarea[contains(text(),'Comments...')]");
        private readonly By Checkbox1 = By.XPath("//input[@value='cb1']");
        private readonly By Checkbox2 = By.XPath("//input[@value='cb2']");
        private readonly By Checkbox3 = By.XPath("//input[@value='cb3']");
        private readonly By RadioButton1 = By.XPath("//input[@value='rd1']");
        private readonly By RadioButton2 = By.XPath("//input[@value='rd2']");
        private readonly By RadioButton3 = By.XPath("//input[@value='rd3']");
        private readonly By DropDown1 = By.Name("dropdown");
        private readonly By CancelButton = By.XPath("//tbody/tr[9]/td[1]/input[1]");
        private readonly By SubmitButton = By.XPath("//tbody/tr[9]/td[1]/input[2]");

        public IWebElement UsernameTextboxElement => driver.FindElement(UsernameTextbox);
        public IWebElement PasswordTextboxElement => driver.FindElement(PasswordTextbox);
        public IWebElement Checkbox1Element => driver.FindElement(Checkbox1);
        public IWebElement Checkbox2Element => driver.FindElement(Checkbox2);
        public IWebElement Checkbox3Element => driver.FindElement(Checkbox3);
        public IWebElement RadioButton1Element => driver.FindElement(RadioButton1);
        public IWebElement RadioButton2Element => driver.FindElement(RadioButton2);
        public IWebElement RadioButton3Element => driver.FindElement(RadioButton3);
        public IWebElement CancelButtonElement => driver.FindElement(CancelButton);
        public IWebElement SubmitButtonElement => driver.FindElement(SubmitButton);
        #endregion

        #region Actions
        public void Login(string username, string password)
        {
            TextBoxHelper.TypeInTextBox(UsernameTextbox, username);
            TextBoxHelper.TypeInTextBox(PasswordTextbox, password);
        }

        public FormProcessorPage ClickSubmitButton()
        {
            ButtonHelper.ClickButton(SubmitButton);
            return new FormProcessorPage(driver);
        }

        public void InputValues(By checkbox, By radiobutton, By commentbox, string commentText, By dropdown, string dropdownItemName)
        {
            CheckBoxHelper.ClickCheckBox(checkbox);
            RadioButtonHelper.ClickRadioButton(radiobutton);
            TextBoxHelper.ClearTextBox(commentbox);
            TextBoxHelper.TypeInTextBox(commentbox, commentText);
            DropDownHelper.SelectElementByValue(dropdown, dropdownItemName);
        }
        #endregion

        #region Navigation
        // Index navigation inherited from BasePage
        #endregion
    }
}
