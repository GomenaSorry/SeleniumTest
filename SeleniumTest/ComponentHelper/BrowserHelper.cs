using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTest.Settings;
using System.Collections.ObjectModel;

namespace SeleniumTest.ComponentHelper
{
    public class BrowserHelper
    {
        public static void BrowserMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        public static void GoBack()
        {
            ObjectRepository.Driver.Navigate().Back();
        }

        public static void GoForward()
        {
            ObjectRepository.Driver.Navigate().Forward();
        }

        public static void RefreshPage()
        {
            ObjectRepository.Driver.Navigate().Refresh();
        }

        public static void SwitchToWindow(int index)
        {
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;

            if (windows.Count < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index " + index);
            }

            ObjectRepository.Driver.SwitchTo().Window(windows[index]);
        }

        public static void SwitchToParent()
        {
            var windowIds = ObjectRepository.Driver.WindowHandles;
            for (int i = windowIds.Count; i > 0; i--)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.SwitchTo().Window(windowIds[i]);
            }
            ObjectRepository.Driver.SwitchTo().Window(windowIds[0]);
        }

        public static void SwitchToFrame(By locator)
        {
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(locator));
        }
    }
}
