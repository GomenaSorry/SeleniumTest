using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.ComponentHelper;
using SeleniumTest.Settings;

namespace SeleniumTest.TestScript.TextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox()
        {
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite());

            // replaced by ComponentHelper.TextBoxHelper
            //LinkHelper.ClickLink(By.LinkText(""));
            //IWebElement element = ObjectRepository.Driver.FindElement(By.Name("username")); // should be By.Id, not available
            //element.SendKeys(ObjectRepository.Config.GetUserName());
            //element = ObjectRepository.Driver.FindElement(By.Name("password")); // should be By.Id, not available
            //element.SendKeys(ObjectRepository.Config.GetPassword());
            //element.Clear();

            TextBoxHelper.TypeInTextBox(By.Name("username"), ObjectRepository.Config.GetUserName());
            TextBoxHelper.TypeInTextBox(By.Name("password"), ObjectRepository.Config.GetPassword());
            TextBoxHelper.ClearTextBox(By.Name("username"));
            TextBoxHelper.ClearTextBox(By.Name("password"));
        }
    }
}
