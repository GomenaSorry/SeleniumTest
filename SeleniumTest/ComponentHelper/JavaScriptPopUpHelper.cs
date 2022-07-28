using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTest.Settings;


namespace SeleniumTest.ComponentHelper
{
    public class JavaScriptPopUpHelper
    {
        public static bool IsPopUpPresent()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        public static string GetPopUpText()
        {
            if (!IsPopUpPresent())
            {
                return "";
            }
            return ObjectRepository.Driver.SwitchTo().Alert().Text;
        }

        public static void ClickAcceptPopUp()
        {
            if (!IsPopUpPresent())
            {
                return;
            }
            ObjectRepository.Driver.SwitchTo().Alert().Accept();
        }
        public static void ClickDismissPopUp()
        {
            if (!IsPopUpPresent())
            {
                return;
            }
            ObjectRepository.Driver.SwitchTo().Alert().Dismiss();
        }

        public static void SendKeysToPopUp(string text)
        {
            if (!IsPopUpPresent())
            {
                return;
            }
            ObjectRepository.Driver.SwitchTo().Alert().SendKeys(text);
        }
    }
}
