using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumTest.Settings;
using SeleniumTest.ComponentHelper;

namespace SeleniumTest.TestScript.HyperLink
{
    [TestClass]
    public class TestHyperLink
    {
        [TestMethod]
        public void ClickLink()
        {
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite());

            // replaced by LinkHelper.ClickLink()
            //IWebElement element = ObjectRepository.Driver.FindElement(By.LinkText("Index"));
            //IWebElement pelement = ObjectRepository.Driver.FindElement(By.PartialLinkText("Inde"));
            //pelement.Click();

            LinkHelper.ClickLink(By.LinkText("EvilTester.com"));
            //LinkHelper.ClickLink(By.PartialLinkText("er.com"));
        }
    }
}
