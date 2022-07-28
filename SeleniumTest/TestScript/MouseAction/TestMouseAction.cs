using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumTest.Settings;
using SeleniumTest.ComponentHelper;

namespace SeleniumTest.TestScript.MouseAction
{
    [TestClass]
    public class TestMouseAction
    {
        [TestMethod]
        public void TestContextClick()
        {
            NavigationHelper.NavigateUrl("https://demos.telerik.com/kendo-ui/dragdrop/index");
            Actions mouseAction = new Actions(ObjectRepository.Driver);
            IWebElement element = ObjectRepository.Driver.FindElement(By.Id("draggable"));
            mouseAction.ContextClick(element)
                .Build()
                .Perform();

            Thread.Sleep(5000);
        }

        [TestMethod]
        public void TestDragDrop()
        {
            NavigationHelper.NavigateUrl("https://demos.telerik.com/kendo-ui/dragdrop/index");
            Actions mouseAction = new Actions(ObjectRepository.Driver);
            IWebElement source = ObjectRepository.Driver.FindElement(By.Id("draggable"));
            IWebElement target = ObjectRepository.Driver.FindElement(By.Id("droptarget"));
            mouseAction.DragAndDrop(source, target)
                .Build()
                .Perform();

            Thread.Sleep(5000);
        }

        [TestMethod]
        public void TestClickHold()
        {
            NavigationHelper.NavigateUrl("https://demos.telerik.com/kendo-ui/sortable/index");
            Actions mouseAction = new Actions(ObjectRepository.Driver);
            IWebElement element = ObjectRepository.Driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[8]"));
            IWebElement target = ObjectRepository.Driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[2]/span"));
            mouseAction.ClickAndHold(element)
                .MoveToElement(target,0,30)
                .Release()
                .Build()
                .Perform();

            Thread.Sleep(10000);

        }

        [TestMethod]
        public void TestKeyboard()
        {
            NavigationHelper.NavigateUrl("https://demos.telerik.com/kendo-ui/sortable/index");
            Actions keyboardAction = new Actions(ObjectRepository.Driver);
            keyboardAction.KeyDown(Keys.LeftControl).SendKeys("T").KeyUp(Keys.LeftControl).Build().Perform();

            Thread.Sleep(10000);
         }
    }
}
