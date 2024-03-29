﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTest.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.Settings;

namespace SeleniumTest.GuardianTest.PageObject
{
    public class GuardianSystemInfoPage : GuardianBasePage
    {
        private readonly IWebDriver driver;
        public GuardianSystemInfoPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }
    }
}
