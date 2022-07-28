using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumTest.Settings;
using SeleniumTest.ComponentHelper;

namespace SeleniumTest.TestScript.ScreenShot
{
    [TestClass]
    public class TakeScreenShots
    {
        [TestMethod]
        public void ScreenShot()
        {
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite());

            // replaced by GenericHelper.TakeScreenShot()
            //Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            //screen.SaveAsFile("Screen.jpeg", ScreenshotImageFormat.Jpeg);

            GenericHelper.TakeScreenShot();
            GenericHelper.TakeScreenShot("Test.jpeg");
        }
    }
}
