using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.Settings;
using OpenQA.Selenium;
using SeleniumTest.ComponentHelper;

namespace SeleniumTest.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            // replaced by ComponentHelper.NavigateHelper
            //ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());

            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine("Title of the webpage: {0}", WindowHelper.GetTitle());
        }
    }
}
