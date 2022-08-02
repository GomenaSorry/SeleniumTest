using System;
using TechTalk.SpecFlow;
using SeleniumTest.ComponentHelper;
using SeleniumTest.Settings;
using SeleniumTest.PageObject;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.BaseClasses;

namespace SeleniumTest.StepDefinitions
{
    [Binding]
    public class SeleniumTestStepDefinitions
    {
        private HomePage homePage;
        private HtmlFormPage htmlFormPage;
        private FormProcessorPage formProcessorPage;

        #region Given
        [Given(@"the user is in the HomePage")]
        public void GivenTheUserIsInTheHomePage()
        {
            // replaced by dependency injection
            //homePage = new HomePage(ObjectRepository.Driver);
            ObjectRepository.homePage = new HomePage(ObjectRepository.Driver);
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/index.html");
        }

        [Given(@"the HomePage header is present")]
        public void GivenTheHomePageHeaderIsPresent()
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//h1[contains(text(),'Test Pages For Automating')]")));
        }

        #endregion

        #region When
        [When(@"the user clicks the link HtmlFormPage")]
        public void WhenTheUserClicksTheLinkHtmlFormPage()
        {
            // replaced by dependency injection
            //htmlFormPage = new HtmlFormPage(ObjectRepository.Driver);
            //htmlFormPage = homePage.NavigateToHtmlFormPage(ObjectRepository.Driver);
            ObjectRepository.htmlFormPage = new HtmlFormPage(ObjectRepository.Driver);
            ObjectRepository.htmlFormPage = ObjectRepository.homePage.NavigateToHtmlFormPage(ObjectRepository.Driver);

        }

        [When(@"the user types the username and password")]
        public void WhenTheUserTypesTheUsernameAndPassword()
        {
            htmlFormPage.Login(ObjectRepository.Config.GetUserName(), ObjectRepository.Config.GetPassword());
        }

        [When(@"the user clicks the submit button")]
        public void WhenTheUserClicksTheSubmitButton()
        {
            formProcessorPage = new FormProcessorPage(ObjectRepository.Driver);
            formProcessorPage = htmlFormPage.ClickSubmitButton();
        }

        [When(@"the user clicks the return button")]
        public void WhenTheUserClicksTheReturnButton()
        {
            htmlFormPage = formProcessorPage.ClickReturnToHtmlFormPage();
        }

        [When(@"the user inputs test values")]
        public void WhenTheUserInputsTestValues()
        {
            htmlFormPage.InputValues(By.XPath("//input[@value='cb1']"), By.XPath("//input[@value='rd3']"), By.XPath("//textarea[contains(text(),'Comments...')]"), "This is automated", By.Name("dropdown"), "dd5");
        }
        #endregion

        #region Then
        [Then(@"the user is on the HtmlFormPage")]
        public void ThenTheUserIsOnTheHtmlFormPage()
        {
            Assert.AreEqual("HTML Form Elements", htmlFormPage.Title);
        }

        [Then(@"the user is on the FormProcessorPage")]
        public void ThenTheUserIsTheFormProcessorPage()
        {
            Assert.AreEqual("Processed Form Details", formProcessorPage.Title);
        }

        [Then(@"the username value is equal to input")]
        public void ThenTheUsernameValueIsEqualToInput()
        {
           Assert.AreEqual(ObjectRepository.Config.GetUserName(), GenericHelper.GetElement(By.Id("_valueusername")).Text);
        }

        [Then(@"the password value is equal to input")]
        public void ThenThePasswordValueIsEqualToInput()
        {
            Assert.AreEqual(ObjectRepository.Config.GetPassword(), GenericHelper.GetElement(By.Id("_valuepassword")).Text);
        }

        [Then(@"the first checkbox value is equal to input")]
        public void ThenTheCheckboxValueIsEqualToInput()
        {
            Assert.AreEqual("cb2", GenericHelper.GetElement(By.Id("_valuecheckboxes0")).Text);
        }

        [Then(@"the second checkbox value is equal to input")]
        public void ThenTheSecondCheckboxValueIsEqualToInput()
        {
            Assert.AreEqual("cb3", GenericHelper.GetElement(By.Id("_valuecheckboxes1")).Text);
        }

        [Then(@"the radio value is equal to input")]
        public void ThenTheRadioValueIsEqualToInput()
        {
            Assert.AreEqual("rd1", GenericHelper.GetElement(By.Id("_valueradioval")).Text);
        }

        [Then(@"the comment is equal to input")]
        public void ThenTheCommentIsEqualToInput()
        {
            Assert.AreEqual("This is an automated message", GenericHelper.GetElement(By.Id("_valuecomments")).Text);
        }

        [Then(@"the dropdown item selected is equal to input")]
        public void ThenTheDropdownItemSelectedIsEqualToInput()
        {
            Assert.AreEqual("dd6", GenericHelper.GetElement(By.Id("_valuedropdown")).Text);
        }



        #endregion
    }
}
