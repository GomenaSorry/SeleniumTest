using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTest.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest.ComponentHelper
{
    public class PerformanceHelper
    {
        public static void GetPageLoadTime(int baselineTime)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)ObjectRepository.Driver;
            var responseTime = Convert.ToInt32(js.ExecuteScript("return window.performance.timing.domContentLoadedEventEnd-window.performance.timing.navigationStart;"));

            Console.WriteLine(string.Format("Page {0} loading time is {1} ms", ObjectRepository.Driver.Title, responseTime));

            Assert.IsTrue(baselineTime > responseTime);
        }

        public static void WaitForReady()
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromMilliseconds(4000));
            wait.Until(driver => (bool)((IJavaScriptExecutor)driver).ExecuteScript("return jQuery.active == 0"));
        }
    }
}
