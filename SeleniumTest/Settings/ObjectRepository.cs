using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTest.Interfaces;
using SeleniumTest.PageObject;
using OpenQA.Selenium;

namespace SeleniumTest.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
        public static HomePage homePage;
        public static HtmlFormPage htmlFormPage;
        public static FormProcessorPage formProcessorPage;
    }
}
