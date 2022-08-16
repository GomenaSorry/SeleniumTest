using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTest.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTest.GuardianTest.PageObject
{
    public class GuardianKbaPage : GuardianBasePage
    {
        private readonly IWebDriver driver;
        public GuardianKbaPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }
    }
}
