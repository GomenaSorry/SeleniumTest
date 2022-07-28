using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTest.Settings;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest.ComponentHelper
{
    public class ComboBoxHelper
    {
        private static SelectElement select;

        public static void SelectElementByIndex(By locator, int index)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByIndex(index);
        }

        public static void SelectElementByValue(By locator, string value)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByValue(value);
        }

        public static void SelectElementByText(By locator, string text)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByText(text);
        }

        public static IList<string> GetAllItems(By locator)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }

        public static void SelectMultipleItems(By locator, string[] itemsByTextArray)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            foreach (string item in itemsByTextArray)
            {
                select.SelectByText(item);
            }
        }
    }
}
