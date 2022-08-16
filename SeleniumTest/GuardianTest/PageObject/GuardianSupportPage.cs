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
    public class GuardianSupportPage : GuardianBasePage
    {
        private readonly IWebDriver driver;
        public GuardianSupportPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }
    }
}
