using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.Settings;
using SeleniumTest.ComponentHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest.TestScript.TestWait
{
    [TestClass]
    public class TestWebDriverWait
    {
        [TestMethod]
        public void TestWait()
        {
            // replaced by AppConfigReader.GetPageLoadTimeOut()
            //ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(3);

            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite()); // breakpoint
            NavigationHelper.NavigateUrl("https://www.udemy.com/"); //step over and go back to the previous page

            // replaced by AppConfigReader.GetElementLoadTimeOut()
            //ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            TextBoxHelper.TypeInTextBox(By.XPath("//input[@placeholder='Search for anything']"), "C#");
        }

        [TestMethod]
        public void TestDynamicWait()
        {
            NavigationHelper.NavigateUrl("https://www.google.com/"); // go to Google first
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/index.html"); // go to Udemy next
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(50)); // max waiting time
            wait.PollingInterval = TimeSpan.FromMilliseconds(250); // evaluate wait.Until() the every 250ms
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException)); // ignore exceptions while waiting
            //wait.Until(waitforSearchBox()); // example 1, breakpoint here, test waiting for an element
            //Console.WriteLine(wait.Until(waitforTitle())); // example 2, breakpoint here, test waiting for an title
            //IWebElement element = wait.Until(waitforElement()); // example 3, breakpoint here, test waiting for an element
            //element.SendKeys("C#"); // cont., example 3

            // demo test, sample scenario, demo delegates
            wait.Until(demowaitforfirstPageLink()).Click();
            wait.Until(demowaitforbuttonElement()).Click();
            Console.WriteLine("Title : {0}", wait.Until(demowaitforTitle()));
        }

        private Func<IWebDriver, bool> waitforSearchBox() // example 1, wait for search box delegate
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for Search Box"); // debug message to check if the delegate is executed
                return x.FindElements(By.XPath("//input[@placeholder='Search for anything']")).Count == 1;
            });
        }

        private Func<IWebDriver, string> waitforTitle() // example 2, wait for title delegate
        {
            return ((x) =>
            {
                if (x.Title.Contains("ogle")) // check if the title has "ogle" substring
                {
                    return x.Title;
                }
                return null;
            });
        }

        private Func<IWebDriver, IWebElement> waitforElement() // example 3, wait for element delegate
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for element"); // debug message to check if the delegate is executed
                if (x.FindElements(By.XPath("//input[@placeholder='Search for anything']")).Count == 1)
                {
                    return x.FindElement(By.XPath("//input[@placeholder='Search for anything']"));
                }
                return null;
            });
        }

        // demo scenario delegates

        private Func<IWebDriver, IWebElement> demowaitforfirstPageLink()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for page link");
                if (x.FindElements(By.XPath("//a[@id='htmlformtest']")).Count == 1)
                {
                    return x.FindElement(By.XPath("//a[@id='htmlformtest']"));
                }
                return null;
            });
        }

        private Func<IWebDriver, IWebElement> demowaitforbuttonElement()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for submit button element");
                if (x.FindElements(By.XPath("//input[@value='submit']")).Count == 1)
                {
                    return x.FindElement(By.XPath("//input[@value='submit']"));
                }
                return null;
            });
        }

        private Func<IWebDriver, string> demowaitforTitle() // example 2, wait for title delegate
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for title");
                if (x.FindElement(By.XPath("//h1[contains(text(),'Processed Form Details')]")).Text.Contains("Form Details"))
                {
                    return x.FindElement(By.XPath("//h1[contains(text(),'Processed Form Details')]")).Text;
                }
                return null;
            });
        }
    }
}
