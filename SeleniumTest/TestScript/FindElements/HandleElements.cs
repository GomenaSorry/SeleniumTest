using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTest.Settings;
using SeleniumTest.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace SeleniumTest.TestScript.FindElements
{
    [TestClass]
    public class HandleElements
    {
        [TestMethod]
        public void GetAllElements()
        {
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite());

            ReadOnlyCollection<IWebElement> elements = ObjectRepository.Driver.FindElements(By.XPath("//input"));
            ReadOnlyCollection<IWebElement> elementsTest = ObjectRepository.Driver.FindElements(By.Id("NotHere"));
            foreach (var element in elements)
            {
                Console.WriteLine("Value : {0}", element.GetAttribute("value"));
            }
        }
    }
}
