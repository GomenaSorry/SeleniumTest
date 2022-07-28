using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.ComponentHelper;
using SeleniumTest.Settings;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace SeleniumTest.TestScript.CheckBox
{
    [TestClass]
    public class TestCheckBox
    {
        [TestMethod]
        public void TestBox()
        {
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite());

            //replaced by ComponentHelper.CheckboxHelper
            //IWebElement element = ObjectRepository.Driver.FindElement(By.XPath("//input[@value='cb2']")); // no Id, used Xpath
            //element.Click();

            //cb1 = false, cb2 = false, cb3 = true

            CheckBoxHelper.IsCheckBoxChecked(By.XPath("//input[@value='cb1']"));
            CheckBoxHelper.IsCheckBoxChecked(By.XPath("//input[@value='cb2']"));
            CheckBoxHelper.IsCheckBoxChecked(By.XPath("//input[@value='cb3']"));

            CheckBoxHelper.ClickCheckBox(By.XPath("//input[@value='cb2']"));
            CheckBoxHelper.ClickCheckBox(By.XPath("//input[@value='cb3']"));

            CheckBoxHelper.IsCheckBoxChecked(By.XPath("//input[@value='cb1']"));
            CheckBoxHelper.IsCheckBoxChecked(By.XPath("//input[@value='cb2']"));
            CheckBoxHelper.IsCheckBoxChecked(By.XPath("//input[@value='cb3']"));
        }
    }
}
