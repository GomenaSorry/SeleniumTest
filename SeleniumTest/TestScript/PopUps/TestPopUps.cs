using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumTest.Settings;
using SeleniumTest.ComponentHelper;


namespace SeleniumTest.TestScript.PopUps
{
    [TestClass]
    public class TestPopUps
    {
        [TestMethod]
        public void TestAlert()
        {
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/alerts/alert-test.html");
            ButtonHelper.ClickButton(By.XPath("//input[@id='alertexamples']"));
            
            // replaced by JavaScriptPopUpHelper.GetPopUpText()
            //IAlert alert = ObjectRepository.Driver.SwitchTo().Alert();
            //var alertText = alert.Text;
            var alertText = JavaScriptPopUpHelper.GetPopUpText();

            //replaced by JavaScriptPopUpHelper.ClickAcceptPopUp()
            //alert.Accept();
            JavaScriptPopUpHelper.ClickAcceptPopUp();
            ObjectRepository.Driver.SwitchTo().DefaultContent();

        }

        [TestMethod]
        public void TestConfirmPopUp()
        {
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/alerts/alert-test.html");
            ButtonHelper.ClickButton(By.XPath("//input[@id='confirmexample']"));

            // replaced by JavaScriptPopUpHelper.ClickAcceptPopUp()
            //IAlert popUp = ObjectRepository.Driver.SwitchTo().Alert();
            //popUp.Accept();
            JavaScriptPopUpHelper.ClickAcceptPopUp();

            // replaced by JavaScriptPopUpHelper.ClickDismissPopUp()
            ButtonHelper.ClickButton(By.XPath("//input[@id='confirmexample']"));
            //popUp = ObjectRepository.Driver.SwitchTo().Alert();
            //popUp.Dismiss();
            JavaScriptPopUpHelper.ClickDismissPopUp();
        }

        [TestMethod]
        public void TestSendKeysPopUp()
        {
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/alerts/alert-test.html");
            ButtonHelper.ClickButton(By.XPath("//input[@id='promptexample']"));

            // replaced by JavaScriptPopUpHelper.SendKeysToPopUp()
            //IAlert popUp = ObjectRepository.Driver.SwitchTo().Alert();
            //popUp.SendKeys("Let's go!");
            //popUp.Accept();
            var text = "Let's go!";
            JavaScriptPopUpHelper.SendKeysToPopUp(text);
            JavaScriptPopUpHelper.ClickAcceptPopUp();

            ButtonHelper.ClickButton(By.XPath("//input[@id='promptexample']"));

            //popUp = ObjectRepository.Driver.SwitchTo().Alert();
            //popUp.Dismiss();
                JavaScriptPopUpHelper.ClickDismissPopUp();


        }
    }
}
