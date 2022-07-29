using System;
using TechTalk.SpecFlow;
using SeleniumTest.ComponentHelper;
using SeleniumTest.Settings;
using SeleniumTest.PageObject;

namespace SeleniumTest
{
    [Binding]
    public class SeleniumTestStepDefinitions
    {
        private HomePage homePage;
        private HtmlFormPage htmlFormPage;
        private FormProcessorPage formProcessorPage;

        #region Given
        [Given(@"the user is in the Home Page")]
        public void GivenTheUserIsInTheHomePage()
        {
            homePage = new HomePage();
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/index.html");
        }
        #endregion

        #region When
        [When(@"the user clicks the link HtmlFormPage")]
        public void WhenTheUserClicksTheLinkHtmlFormPage()
        {
            htmlFormPage = homePage.NavigateToHtmlFormPage();
        }

        [When(@"the user types the username and password")]
        public void WhenTheUserTypesTheUsernameAndPassword()
        {
            htmlFormPage.Login(ObjectRepository.Config.GetUserName(), ObjectRepository.Config.GetPassword());
        }

        [When(@"the user clicks the submit button")]
        public void WhenTheUserClicksTheSubmitButton()
        {
            formProcessorPage = htmlFormPage.ClickSubmitButton();
        }

        [When(@"the user inputs test values")]
        public void WhenTheUserInputsTestValues()
        {
            htmlFormPage.InputValues();
        }


        #endregion

        #region Then
        [Then(@"the user is on the HtmlFormPage")]
        public void ThenTheUserIsOnTheHtmlFormPage()
        {
            // pending
        }

        [Then(@"the user is the FormProcessorPage")]
        public void ThenTheUserIsTheFormProcessorPage()
        {
           // pending;
        }

        #endregion
    }
}
