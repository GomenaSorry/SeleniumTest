using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumTest.ComponentHelper
{
    public class TextBoxHelper
    {
        private static IWebElement element;

        public static void TypeInTextBox(By locator, string Text)
        {
            element = GenericHelper.GetElement(locator);
            element.SendKeys(Text);
        }

        public static void ClearTextBox(By locator)
        {
            element = GenericHelper.GetElement(locator);
            element.Clear();
        }

        public static void TypeAutoSuggest(By locator, By listLocator ,string partialString, string targetText)
        {
            IWebElement element = GenericHelper.GetElement(locator);
            element.SendKeys(partialString);
            var wait = GenericHelper.GetWebDriverWait(TimeSpan.FromSeconds(10));
            IList<IWebElement> elements = wait.Until(GetAllElement(listLocator));
            foreach (var ele in elements)
            {
                if (ele.Text.Equals(targetText))
                {
                    ele.Click();
                }
            }
        }

        private static Func<IWebDriver, IList<IWebElement>> GetAllElement(By listLocator)
        {
            return ((x) =>
            {
                return x.FindElements(listLocator);
            });

        }
    }

}
