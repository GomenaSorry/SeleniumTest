using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using SeleniumTest.Configuration;
using SeleniumTest.Interfaces;

namespace SeleniumTest.TestScript.PageNavigation
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("http://www.google.com");
        //    driver.Close();
        //    driver.Quit();
        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    IConfig config = new AppConfigReader();
        //    Console.WriteLine("Browser : {0}", config.GetBrowser());
        //    Console.WriteLine("Username : {0}", config.GetUserName());
        //    Console.WriteLine("Password : {0}", config.GetPassword());
        //}

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Test");
        }
    }
}
