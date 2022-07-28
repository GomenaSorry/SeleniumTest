using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SeleniumTest.ComponentHelper;
using SeleniumTest.Settings;
using SeleniumTest.PageObject;

namespace SeleniumTest.StepDefinitions
{
    [Binding]
    public sealed class SeleniumTest
    {
        private HomePage homePage;
        private LoginPage loginPage;
        private FormProcessorPage formProcessorPage;

        #region Given

        [Given(@"User is at Home page")]
        public void GivenUserIsAtHomePage()
        {
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetWebsite());
        }

        [Given(@"Header element is visible")]
        public void GivenHeaderElementIsVisible()
        {
            // pending
        }

        #endregion

        #region When

        [When(@"User clicks the HTML Form Example Link")]
        public void WhenUserClicksTheHTMLFormExampleLink()
        {
            homePage = new HomePage();
            loginPage = homePage.NavigateToLoginPage();
        }

        [When(@"User provides the username and password")]
        public void WhenUserProvidesTheUsernameAndPassword()
        {
            loginPage.Login(ObjectRepository.Config.GetUserName(), ObjectRepository.Config.GetPassword());
        }

        [When(@"User clicks the button LoginButton")]
        public void WhenUserClicksTheButtonLoginButton()
        {
            loginPage.ClickSubmitButton();
        }

        [When(@"User clicks the button ReturnButton")]
        public void WhenUserClicksTheButtonReturnButton()
        {
           formProcessorPage.ClickReturnToLoginPage();
        }



        #endregion

        #region Then

        [Then(@"User should be at Basic HTML Form Example Page")]
        public void ThenUserShouldBeAtBasicHTMLFormExamplePage()
        {
            // pending
        }

        [Then(@"User should be at Form Processing Page")]
        public void ThenUserShouldBeAtFormProcessingPage()
        {
            // pending
        }



        #endregion
    }
}
