using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumTest.ComponentHelper;
using SeleniumTest.Settings;

namespace SeleniumTest.TestScript.RadioButton
{
    [TestClass]
    public class TestRadioButton
    {
        [TestMethod]
        public void RadioButton()
        {
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite());

            // replaced by RadioButtonHelper
            //IWebElement element = ObjectRepository.Driver.FindElement(By.XPath("//input[@value='rd1']"));
            //element.Click();

            Console.WriteLine("Radio Button 1 Selected: {0}", RadioButtonHelper.IsRadioButtonSelected(By.XPath("//input[@value='rd1']")));
            Console.WriteLine("Radio Button 2 Selected: {0}", RadioButtonHelper.IsRadioButtonSelected(By.XPath("//input[@value='rd2']")));
            Console.WriteLine("Radio Button 3 Selected: {0}", RadioButtonHelper.IsRadioButtonSelected(By.XPath("//input[@value='rd3']")));

            RadioButtonHelper.ClickRadioButton(By.XPath("//input[@value='rd1']"));

            Console.WriteLine("Radio Button 1 Selected: {0}", RadioButtonHelper.IsRadioButtonSelected(By.XPath("//input[@value='rd1']")));
            Console.WriteLine("Radio Button 2 Selected: {0}", RadioButtonHelper.IsRadioButtonSelected(By.XPath("//input[@value='rd2']")));
            Console.WriteLine("Radio Button 3 Selected: {0}", RadioButtonHelper.IsRadioButtonSelected(By.XPath("//input[@value='rd3']")));
        }
    }
}
