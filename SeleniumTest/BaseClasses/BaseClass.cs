using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.Settings;
using SeleniumTest.Configuration;
using SeleniumTest.CustomException;
using SeleniumTest.ComponentHelper;
using TechTalk.SpecFlow;

namespace SeleniumTest.BaseClasses
{
    [Binding]
    [TestClass]
    public class BaseClass
    {
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("start-maximized");
            //options.AddArgument("headless");
            //options.AddArgument("disable-gpu");
            return options;
        }
        public static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }

        public static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        public static IWebDriver GetIExplorerDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }

        [BeforeTestRun]
        public static void InitWebDriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;

                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIExplorerDriver();
                    break;

                default: throw new NoSuitableDriverFoundException("Driver not found : " + ObjectRepository.Config.GetBrowser().ToString());
            }
            ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut());
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
            BrowserHelper.BrowserMaximize();
        }

        [AfterTestRun]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}
