using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.ComponentHelper;
using SeleniumTest.Settings;
using OpenQA.Selenium;

namespace SeleniumTest.TestScript.Button
{
    [TestClass]
    public class TestButton
    {
        [TestMethod]
        public void TestButtonHandle()
        {
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite());

            // replaced by ComponentHelper.ButtonHelper
            //    IWebElement element = ObjectRepository.Driver.FindElement(By.XPath("//input[@value='submit']"));
            //    element.Click();
            //

            Console.WriteLine("Button Enabled: {0}", ButtonHelper.IsButtonEnabled(By.XPath("//input[@value='submit']")));
            Console.WriteLine("Button Text: {0}", ButtonHelper.GetButtonText(By.XPath("//input[@value='submit']")));
            ButtonHelper.ClickButton(By.XPath("//input[@value='submit']"));
        }
    }
}
