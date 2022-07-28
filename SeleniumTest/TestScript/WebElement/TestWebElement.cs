using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.Settings;
using SeleniumTest.ComponentHelper;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace SeleniumTest.TestScript.WebElement
{
    [TestClass]
    public class TestWebElement
    {
        [TestMethod]
        public void GetElement()
        {
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite());
            try
            {

                ReadOnlyCollection<IWebElement> col = ObjectRepository.Driver.FindElements(By.TagName("p"));
                Console.WriteLine("Size: {0}", col.Count());
                Console.WriteLine("Element at 0: {0}", col.ElementAt(0));
                //ObjectRepository.Driver.FindElement(By.TagName("p"));
                //ObjectRepository.Driver.FindElement(By.ClassName("normal"));
                //ObjectRepository.Driver.FindElement(By.CssSelector("#p5"));
                //ObjectRepository.Driver.FindElement(By.LinkText("jump to para 0"));
                //ObjectRepository.Driver.FindElement(By.PartialLinkText(" para 2"));
                //ObjectRepository.Driver.FindElement(By.Name("pName8"));
                //ObjectRepository.Driver.FindElement(By.Id("a4"));
                //ObjectRepository.Driver.FindElement(By.XPath("//p[@id='a3']"));
                //ObjectRepository.Driver.FindElement(By.XPath("//p[@id='NotThere']"));
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
