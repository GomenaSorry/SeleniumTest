using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTest.ComponentHelper;
using OpenQA.Selenium;
using SeleniumTest.GuardianTest.PageObject;
using SeleniumTest.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTest.GuardianTest.PageObject
{
    public class GuardianBasePage
    {
        private readonly IWebDriver driver;

        public GuardianBasePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        #region WebElement

        private readonly By DashboardTab = By.Id("tab_dashboard");
        private readonly By KbaTab = By.Id("tab_kba");
        private readonly By SoftwareUpdatesTab = By.Id("tab_updates");
        private readonly By AssetsTab = By.Id("tab_assets");
        private readonly By SupportTab = By.Id("tab_support");
        private readonly By SystemInfoTab = By.Id("tab_systemprofile");
        private readonly By MaintenanceServicesTab = By.Id("tab_remotemonitor");
        private readonly By PerformanceServicesTab = By.Id("tab_performanceservices");
        private readonly By DownloadsTab = By.Id("tab_downloads");

        public IWebElement DashboardTabElement => driver.FindElement(DashboardTab);
        public IWebElement KbaTabElement => driver.FindElement(KbaTab);
        public IWebElement SoftwareUpdatesTabElement => driver.FindElement(SoftwareUpdatesTab);
        public IWebElement AssetsTabElement => driver.FindElement(AssetsTab);
        public IWebElement SupportTabElement => driver.FindElement(SupportTab);
        public IWebElement SystemInfoTabElement => driver.FindElement(SystemInfoTab);
        public IWebElement MaintenanceServicesTabElement => driver.FindElement(MaintenanceServicesTab);
        public IWebElement PerformanceServicesTabElement => driver.FindElement(PerformanceServicesTab);
        public IWebElement DownloadsTabElement => driver.FindElement(DownloadsTab);

        #endregion

        #region Action
        // pending
        #endregion

        #region Navigation

        public GuardianDashboardPage NavigateToDashboardPage(IWebDriver webdriver)
        {
            LinkHelper.ClickLink(DashboardTab);
            return new GuardianDashboardPage(webdriver);
        }

        public GuardianKbaPage NavigateToKbaPage(IWebDriver webdriver)
        {
            LinkHelper.ClickLink(KbaTab);
            return new GuardianKbaPage(webdriver);
        }

        public GuardianSoftwareUpdatesPage NavigateToSoftwareUpdatesPage(IWebDriver webdriver)
        {
            LinkHelper.ClickLink(SoftwareUpdatesTab);
            return new GuardianSoftwareUpdatesPage(webdriver);
        }

        public GuardianAssetsPage NavigateToAssetsPage(IWebDriver webdriver)
        {
            LinkHelper.ClickLink(AssetsTab);
            return new GuardianAssetsPage(webdriver);
        }
        public GuardianSupportPage NavigateToSupportPage(IWebDriver webdriver)
        {
            LinkHelper.ClickLink(SupportTab);
            return new GuardianSupportPage(webdriver);
        }

        public GuardianSystemInfoPage NavigateToSystemInfoPage(IWebDriver webdriver)
        {
            LinkHelper.ClickLink(SupportTab);
            return new GuardianSystemInfoPage(webdriver);
        }

        public GuardianMaintenanceServicesPage NavigateToMaintenanceServicesPagePage(IWebDriver webdriver)
        {
            LinkHelper.ClickLink(MaintenanceServicesTab);
            return new GuardianMaintenanceServicesPage(webdriver);
        }

        public GuardianPerformanceServicesPage NavigateToPerformanceServicesPage(IWebDriver webdriver)
        {
            LinkHelper.ClickLink(PerformanceServicesTab);
            return new GuardianPerformanceServicesPage(webdriver);
        }

        public GuardianDownloadsPage NavigateToDownloadsPage(IWebDriver webdriver)
        {
            LinkHelper.ClickLink(DownloadsTab);
            return new GuardianDownloadsPage(webdriver);
        }

        #endregion

        public string Title
        {
            get { return ObjectRepository.Driver.Title; }
        }
    }

}
