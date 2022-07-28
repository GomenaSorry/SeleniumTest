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

namespace SeleniumTest.TestScript.MultipleBrowser
{
    [TestClass]
    public class TestMultipleBrowserWindow
    {
        [TestMethod]
        public void TestMultipleWindow()
        {
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/windows-test.html");
            LinkHelper.ClickLink(By.XPath("//a[@id='goalerts']"));

            // replaced by BrowserHelper.SwitchToWindow()
            //ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;
            //ObjectRepository.Driver.SwitchTo().Window(windows[1]);

            BrowserHelper.SwitchToWindow(1);
            ButtonHelper.ClickButton(By.XPath("//div[@class='page-navigation']/descendant::a"));
        }

        [TestMethod]
        public void TestFrame()
        {
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/iframes-test.html");
            //ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(By.Id("thedynamichtml")));
            BrowserHelper.SwitchToFrame(By.Id("thedynamichtml"));
            ObjectRepository.Driver.FindElement(By.Id("iframe6"));

            

        }
    }
}
