using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.ComponentHelper;
using SeleniumTest.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest.TestScript.DefaultWait
{
    [TestClass]
    public class TestDefaultWait
    {
        [TestMethod]
        public void HandleDefaultWait()
        {
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite());

            // replaced by GenericHelper.WaitForWebElement and GenericHelper.WaitForWebElementInPage
            //DropDownHelper.SelectElementByIndex(By.Name("dropdown"), 1);
            //DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(GenericHelper.GetElement(By.XPath("//tbody/tr[8]/td[1]/select[1]")));
            //wait.PollingInterval = TimeSpan.FromMilliseconds(200);
            //wait.Timeout = TimeSpan.FromSeconds(50);
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            //Console.WriteLine("After default wait : {0}", wait.Until(changeofValue()));

            GenericHelper.WaitForWebElement(By.XPath("//tbody/tr[8]/td[1]/select[1]"), TimeSpan.FromSeconds(50));
            IWebElement element = GenericHelper.WaitForWebElementInPage(By.XPath("//tbody/tr[8]/td[1]/select[1]"), TimeSpan.FromSeconds(50));
        }

          // replaced by GenericHelper delegates
    //    private Func<IWebElement, string> changeofValue()
    //    {
    //        return ((x) =>
    //        {
    //            Console.WriteLine("Waiting for drop down element");
    //            SelectElement select = new SelectElement(x);
    //            if (select.SelectedOption.Text.Equals("Drop Down Item 1"))
    //            {
    //                return select.SelectedOption.Text;
    //            }
    //            return null;
    //        });
    //    }
    }
}
