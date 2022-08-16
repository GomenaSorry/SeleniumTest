using System;
using TechTalk.SpecFlow;
using SeleniumTest.ComponentHelper;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.GuardianTest.PageObject;
using SeleniumTest.Settings;
using OpenQA.Selenium.Support.UI;


namespace SeleniumTest.StepDefinitions
{
    [Binding]
    public class GuardianPerformanceTestStepDefinitions
    {
        [Given(@"the user is a valid customer")]
        public void GivenTheUserIsAValidCustomer()
        {
            // placeholder
        }

        [When(@"the user navigates to the Guardian Log In Page")]
        public void WhenTheUserNavigatesToTheGuardianLogInPage()
        {
            ObjectRepository.guardianLoginPage = new GuardianLoginPage(ObjectRepository.Driver);
            NavigationHelper.NavigateUrl("https://guardianint.emerson.com/");
        }

        [When(@"the user types the ""([^""]*)"" in the ""([^""]*)""")]
        public void WhenTheUserTypesTheInThe(string input, string textbox)
        {
            TextBoxHelper.TypeInTextBox(By.Id(textbox), input);
        }

        [When(@"clicks the Sign In button to navigate to the Guardian Dashboard page")]
        public void WhenClicksTheSignInButtonToNavigateToTheGuardianDashboardPage()
        {
            ObjectRepository.guardianLoginPage.ClickSignInButton(ObjectRepository.Driver);
        }

        [When(@"the user clicks the Sign In button")]
        public void WhenTheUserClicksTheSignInButton()
        {
            ObjectRepository.guardianDashboardPage = new GuardianDashboardPage(ObjectRepository.Driver);
            ObjectRepository.guardianDashboardPage = ObjectRepository.guardianLoginPage.ClickSignInButton(ObjectRepository.Driver);
        }

        [When(@"the user clicks the ""([^""]*)"" tab in the Dashboard page")]
        public void WhenTheUserClicksTheTabInTheDashboardPage(string tab) 
        {
            switch (tab)
            {
                case "tab_dashboard":
                    LinkHelper.ClickLink(By.Id("tab_dashboard"));
                    return;

                case "tab_kba":
                    LinkHelper.ClickLink(By.Id("tab_kba"));
                    ObjectRepository.guardianKbaPage = new GuardianKbaPage(ObjectRepository.Driver);
                    ObjectRepository.guardianKbaPage = ObjectRepository.guardianDashboardPage.NavigateToKbaPage(ObjectRepository.Driver);
                    return;

                case "tab_updates":
                    LinkHelper.ClickLink(By.Id("tab_updates"));
                    ObjectRepository.guardianSoftwareUpdatesPage = new GuardianSoftwareUpdatesPage(ObjectRepository.Driver);
                    ObjectRepository.guardianSoftwareUpdatesPage = ObjectRepository.guardianDashboardPage.NavigateToSoftwareUpdatesPage(ObjectRepository.Driver);
                    return;

                case "tab_assets":
                    LinkHelper.ClickLink(By.Id("tab_assets"));
                    ObjectRepository.guardianAssetsPage = new GuardianAssetsPage(ObjectRepository.Driver);
                    ObjectRepository.guardianAssetsPage = ObjectRepository.guardianDashboardPage.NavigateToAssetsPage(ObjectRepository.Driver);
                    return;

                case "tab_support":
                    LinkHelper.ClickLink(By.Id("tab_support"));
                    ObjectRepository.guardianSupportPage = new GuardianSupportPage(ObjectRepository.Driver);
                    ObjectRepository.guardianSupportPage = ObjectRepository.guardianDashboardPage.NavigateToSupportPage(ObjectRepository.Driver);
                    return;

                case "tab_systemprofile":
                    LinkHelper.ClickLink(By.Id("tab_systemprofile"));
                    ObjectRepository.guardianSystemInfoPage = new GuardianSystemInfoPage(ObjectRepository.Driver);
                    ObjectRepository.guardianSystemInfoPage = ObjectRepository.guardianDashboardPage.NavigateToSystemInfoPage(ObjectRepository.Driver);
                    return;

                case "tab_remotemonitor":
                    LinkHelper.ClickLink(By.Id("tab_remotemonitor"));
                    ObjectRepository.guardianMaintenanceServicesPage = new GuardianMaintenanceServicesPage(ObjectRepository.Driver);
                    ObjectRepository.guardianMaintenanceServicesPage = ObjectRepository.guardianDashboardPage.NavigateToMaintenanceServicesPagePage(ObjectRepository.Driver);
                    return;

                case "tab_performanceservices":
                    LinkHelper.ClickLink(By.Id("tab_performanceservices"));
                    ObjectRepository.guardianPerformanceServicesPage = new GuardianPerformanceServicesPage(ObjectRepository.Driver);
                    ObjectRepository.guardianPerformanceServicesPage = ObjectRepository.guardianDashboardPage.NavigateToPerformanceServicesPage(ObjectRepository.Driver);
                    return;

                case "tab_downloads":
                    LinkHelper.ClickLink(By.Id("tab_downloads"));
                    ObjectRepository.guardianDownloadsPage = new GuardianDownloadsPage(ObjectRepository.Driver);
                    ObjectRepository.guardianDownloadsPage = ObjectRepository.guardianDashboardPage.NavigateToDownloadsPage(ObjectRepository.Driver);
                    return;
            }
        }



        [Then(@"the Guardian Log In page must load under (.*) milliseconds")]
        public void ThenTheGuardianLogInPageMustLoadUnderMilliseconds(int baseline)
        {
            ObjectRepository.guardianLoginPage.GetPageLoadTime(baseline, ObjectRepository.Driver);
        }


        [Then(@"the web element ""([^""]*)"" is present")]
        public void ThenTheWebElementIsPresent(string element, Table table)
        {
            foreach (var row in table.Rows)
            {
                Assert.IsTrue(GenericHelper.IsElementPresent(By.Id(row["element"])));
            }
        }

        [Then(@"the page should load not more than (.*) milliseconds")]
        public void ThenThePageShouldLoadNotMoreThanMilliseconds(int baseline)
        {
            PerformanceHelper.GetPageLoadTime(baseline);
        }

        [Then(@"the user should wait")]
        public void ThenTheUserShouldWait()
        {
            PerformanceHelper.WaitForReady();
        }


        [Then(@"the user is on the ""([^""]*)"" Page")]
        public void ThenTheUserIsOnThePage(string title)
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromMilliseconds(4000));
            wait.Until(waitForTitle(title));
        }

        private Func<IWebDriver, string> waitForTitle(string title) // example 2, wait for title delegate
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for title");
                if (x.Title == title)
                {
                    return x.Title.ToString();
                }
                return null;
            });
        }

    }
}
