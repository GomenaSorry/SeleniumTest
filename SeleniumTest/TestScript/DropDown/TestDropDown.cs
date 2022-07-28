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

namespace SeleniumTest.TestScript.DropDown
{
    [TestClass]
    public class TestDropDownList
    {
        [TestMethod]
        public void DropDownList()
        {
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite());

            // replaced by ComponentHelper.DropDownHelper
            //IWebElement element = ObjectRepository.Driver.FindElement(By.Name("dropdown"));
            //SelectElement select = new SelectElement(element);
            //select.SelectByIndex(1);
            //select.SelectByValue("dd5");
            //select.SelectByText("Drop Down Item 3");
            //Console.WriteLine("Selected value : {0}", select.SelectedOption.Text);
            //IList<IWebElement> list = select.Options;
            //foreach (IWebElement i in list)
            //{
            //    Console.WriteLine("Value : {0}, Text : {1}",i.GetAttribute("value"), i.Text);
            //}

            DropDownHelper.SelectElementByIndex(By.Name("dropdown"), 1);
            DropDownHelper.SelectElementByValue(By.Name("dropdown"), "dd5");
            DropDownHelper.SelectElementByText(By.Name("dropdown"), "Drop Down Item 3");
            foreach (string i in DropDownHelper.GetAllItems(By.Name("dropdown")))
            {
                Console.WriteLine("Text : {0}", i);
            }
        }
    }
}
