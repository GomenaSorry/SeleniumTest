using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.ComponentHelper;
using SeleniumTest.Settings;
using OpenQA.Selenium;

namespace SeleniumTest.TestScript.BrowserActions
{
    [TestClass]
    public class TestBrowserActions
    {
        [TestMethod]
        public void TestActions()
        {
            NavigationHelper.NavigateUrl("https://www.google.com");
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/index.html");
            // replaced by ComponentHelper.BrowserHelper, added to BaseClass AssemblyInitialize
            //ObjectRepository.Driver.Manage().Window.Maximize();
            LinkHelper.ClickLink(By.XPath("//a[@id='htmlformtest']"));
            // replaced by ComponentHelper.BrowserHelper
            //ObjectRepository.Driver.Navigate().Back();
            //ObjectRepository.Driver.Navigate().Back();
            //ObjectRepository.Driver.Navigate().Forward();
            //ObjectRepository.Driver.Navigate().Refresh();
            BrowserHelper.GoBack();
            BrowserHelper.GoBack();
            BrowserHelper.GoForward();
            BrowserHelper.RefreshPage();
        }
    }
}
