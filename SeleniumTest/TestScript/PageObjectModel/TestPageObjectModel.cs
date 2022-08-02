using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.ComponentHelper;
using SeleniumTest.PageObject;
using SeleniumTest.Settings;

namespace SeleniumTest.TestScript.PageObjectModel
{
    [TestClass]
    public class TestPageObjectModel
    {
        [TestMethod]
        public void TestPage()
        {
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/index.html");
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            HtmlFormPage loginPage = homePage.NavigateToHtmlFormPage(ObjectRepository.Driver);
            loginPage.Login("MyUserName", "P@ssw0rd");
            FormProcessorPage formProcessorPage = loginPage.ClickSubmitButton();
            formProcessorPage.CheckValues();
        }

        [TestMethod]
        public void HtmlFormPageToHomePage()
        {
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/index.html");
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            HtmlFormPage loginPage = homePage.NavigateToHtmlFormPage(ObjectRepository.Driver);
            loginPage.NavigateToIndexPage();
        }

        [TestMethod]
        public void FormProcessorPageToHomePage()
        {
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/index.html");
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            HtmlFormPage loginPage = homePage.NavigateToHtmlFormPage(ObjectRepository.Driver);
            loginPage.Login("MyUserName", "P@ssw0rd");
            FormProcessorPage formProcessorPage = loginPage.ClickSubmitButton();
            formProcessorPage.NavigateToIndexPage();
        }
    }
}
