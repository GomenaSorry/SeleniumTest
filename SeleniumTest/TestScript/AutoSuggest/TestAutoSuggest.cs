using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.ComponentHelper;
using OpenQA.Selenium;
using SeleniumTest.Settings;

namespace SeleniumTest.TestScript.AutoSuggest
{
    [TestClass]
    public class TestAutoSuggest
    {
        [TestMethod]
        public void TestAutoSuggestText()
        {
            NavigationHelper.NavigateUrl("https://demos.telerik.com/kendo-ui/autocomplete/index");
            TextBoxHelper.TypeAutoSuggest(By.Id("countries"), By.XPath("//ul[@id='countries_listbox']/child::li"), "P", "Portugal");

            // replaced by TextBoxHelper.TypeAutoSuggest()
            //    IWebElement element = ObjectRepository.Driver.FindElement(By.Id("countries"));
            //    element.SendKeys("P");
            //    Thread.Sleep(1000);

            //    var wait = GenericHelper.GetWebDriverWait(TimeSpan.FromSeconds(40));
            //    IList<IWebElement> elements = wait.Until(GetAllElement(By.XPath("//ul[@id='countries_listbox']/child::li")));
            //    foreach (var ele in elements)
            //    {
            //        if (ele.Text.Equals("Portugal"))
            //        {
            //            ele.Click();
            //        }
            //    }

            //    Thread.Sleep(5000);
            //}

            //private Func<IWebDriver, IList<IWebElement>> GetAllElement(By locator)
            //{
            //    return ((x) =>
            //    {
            //        return x.FindElements(locator);
            //    });

            Thread.Sleep(5000);
        }
    }
}
