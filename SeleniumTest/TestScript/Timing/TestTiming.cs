using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.ComponentHelper;
using SeleniumTest.Settings;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest.TestScript.Timing
{
    [TestClass]
    public class TestTiming
    {
        [TestMethod]
        public void TestPageLoadTime()
        {
            NavigationHelper.NavigateUrl("https://www.siliconera.com/");

            // replaced by PerformanceHelper.PageLoadTime()
            //IJavaScriptExecutor js = (IJavaScriptExecutor) ObjectRepository.Driver;
            //int baselineTime = 1250;
            //var responseTime = Convert.ToInt32(js.ExecuteScript("return window.performance.timing.domContentLoadedEventEnd-window.performance.timing.navigationStart;"));           
            //Console.WriteLine(string.Format("Page {0} loading time is {1} ms", ObjectRepository.Driver.Title, responseTime));
            //Assert.IsTrue(baselineTime > responseTime);

            PerformanceHelper.GetPageLoadTime(1520);
        }

        [TestMethod]
        public void DashboardLoadingTime()
        {
            NavigationHelper.NavigateUrl("https://guardianint.emerson.com/");
            TextBoxHelper.TypeInTextBox(By.Id("tbxEmailAddress"), "ruzzell.fernandez@emerson.com");
            TextBoxHelper.TypeInTextBox(By.Id("tbxPassword"), "ruzzellruzzell28");
            ButtonHelper.ClickButton(By.Id("btnSignIn"));
            PerformanceHelper.GetPageLoadTime(1520);
        }

        [TestMethod]
        public void KBALoadingTime()
        {
            NavigationHelper.NavigateUrl("https://guardianint.emerson.com/");
            TextBoxHelper.TypeInTextBox(By.Id("tbxEmailAddress"), "ruzzell.fernandez@emerson.com");
            TextBoxHelper.TypeInTextBox(By.Id("tbxPassword"), "ruzzellruzzell28");
            ButtonHelper.ClickButton(By.Id("btnSignIn"));
            WebDriverWait wait1 = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromMilliseconds(4000));
            wait1.Until(WaitForTitle("Dashboard"));

            PerformanceHelper.WaitForReady();
            LinkHelper.ClickLink(By.Id("tab_kba"));
 

            WebDriverWait wait2 = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromMilliseconds(4000));
            wait2.Until(WaitForTitle("Knowledge Base"));
            PerformanceHelper.GetPageLoadTime(4000);

        }



        private Func<IWebDriver, string> WaitForTitle(string title) // example 2, wait for title delegate
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for title");
                if (x.Title == title)
                {
                    return x.Title.ToString();
                }
                return null;
            });
        }
    }
}
