using System;
using TechTalk.SpecFlow;
using SeleniumTest.ComponentHelper;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.PageObject;
using SeleniumTest.Settings;

namespace SeleniumTest.StepDefinitions
{
    [Binding]
    public class ArgumentSampleStepDefinitions
    {
        // dependency injection demo
        //HtmlFormPage htmlFormPage = new HtmlFormPage(ObjectRepository.Driver);

        #region Given
        [Given(@"the user is in the HomePage with URL ""([^""]*)""")]
        public void GivenTheUserIsInTheHomePageWithURL(string url)
        {
            NavigationHelper.NavigateUrl(url);
        }

        [Given(@"the ""([^""]*)"" header element is present")]
        public void GivenTheElementIsPresent(string text)
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath($"//h1[contains(text(), '{text}')]")));
        }
        #endregion

        #region When
        [When(@"the user types the username ""([^""]*)"" and password ""([^""]*)""")]
        public void WhenTheUserTypesTheUsernameAndPassword(string username, string password)
        {
            // replaced by dependency injection
            //htmlFormPage.Login(username, password);
            ObjectRepository.htmlFormPage.Login(username, password);
        }

        [When(@"the user clicks the ""([^""]*)"" button")]
        public void WhenTheUserClicksTheButton(string button)
        {
            ButtonHelper.ClickButton(By.XPath($"//input[@value='{button}']"));
        }

        [When(@"the user clicks the ""([^""]*)"" link")]
        public void WhenTheUserClicksTheLink(string linkText)
        {
            LinkHelper.ClickLink(By.LinkText(linkText));
        }

        [When(@"the user provides the comment, checkbox, radio button, drop down items")]
        public void WhenTheUserProvidesTheCommentCheckboxRadioButtonDropDownItems(Table table)
        {
           foreach (var row in table.Rows)
           {
                // reference temporarily change to check dependency injection for DependencyInjection.feature
                //htmlFormPage.InputValues(By.XPath(row["Checkbox"]), By.XPath(row["Radio Button"]), By.XPath(row["Comment Box"]), row["Comment Message"], By.Name(row["Drop Down"]), row["Drop Down Item"]);
                ObjectRepository.htmlFormPage.InputValues(By.XPath(row["Checkbox"]), By.XPath(row["Radio Button"]), By.XPath(row["Comment Box"]), row["Comment Message"], By.Name(row["Drop Down"]), row["Drop Down Item"]);
            }
        }

        [When(@"the user provides the ""([^""]*)"" in ""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)"" in ""([^""]*)"" items")]
        public void WhenTheUserProvidesTheInInItems(string comment, string commentBox, string checkbox, string radioButton, string dropDown, string dropDownItem)
        {
            // reference temporarily change to check dependency injection for DependencyInjection.feature
            // htmlFormPage.InputValues(By.XPath(checkbox), By.XPath(radioButton), By.XPath(commentBox), comment, By.Name(dropDown), dropDownItem);
            ObjectRepository.htmlFormPage.InputValues(By.XPath(checkbox), By.XPath(radioButton), By.XPath(commentBox), comment, By.Name(dropDown), dropDownItem);
        }

        #endregion

        #region Then
        [Then(@"the ""([^""]*)"" header element should be present")]
        public void ThenTheHeaderElementShouldBePresent(string text)
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath($"//h1[contains(text(), '{text}')]")));
        }
        #endregion
    }
}
