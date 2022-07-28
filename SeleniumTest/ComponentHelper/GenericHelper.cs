using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumTest.Settings;
using SeleniumTest.CustomException;

namespace SeleniumTest.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IsElementPresent(By locator) // unique element only
        {
            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static IWebElement GetElement(By locator)
        {
            if (IsElementPresent(locator))
            {
                return ObjectRepository.Driver.FindElement(locator);
            }
            else
            {
                throw new NoSuchElementException("Element not found: " + locator.ToString());
            }
        }

        public static string GetElementText(By locator, string value)
        {
            if ((GetElement(locator).Text).Equals(value))
            {
                return ObjectRepository.Driver.FindElement(locator).Text.ToString();
            }
            else
            {
                throw new ElementTextMismatchException("Element text " + ObjectRepository.Driver.FindElement(locator).Text.ToString() + " is not equal to '{0}'" + value);
            }
        }

        public static void TakeScreenShot(string filename = "Screen")
        {
            Screenshot screen = ObjectRepository.Driver.TakeScreenshot();

            if (filename.Equals("Screen"))
            {
                filename = filename + DateTime.UtcNow.ToString("yyyy-MM-dd-ss") + ".jpeg";
                screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
                return;
            }
            screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
        }

        public static bool WaitForWebElement(By locator, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            bool flag = wait.Until(waitforwebelementDelegate(locator));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
            return flag;
        }

        private static Func<IWebDriver, bool> waitforwebelementDelegate(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
        }

        public static IWebElement WaitForWebElementInPage(By locator, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            IWebElement element = wait.Until(waitforwebelementinpageDelegate(locator));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
            return element;
        }

        private static Func<IWebDriver, IWebElement> waitforwebelementinpageDelegate(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count() == 1)
                {
                    return x.FindElement(locator);
                }
                else
                {
                    return null;
                }
            });
        }

        public static WebDriverWait GetWebDriverWait(TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout)
            {
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };
            wait.IgnoreExceptionTypes(typeof (NoSuchElementException), typeof(ElementNotVisibleException));
            return wait;
        }
    }
}
