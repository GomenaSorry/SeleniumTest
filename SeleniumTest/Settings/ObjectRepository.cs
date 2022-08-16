using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTest.Interfaces;
using SeleniumTest.PageObject;
using SeleniumTest.GuardianTest.PageObject;
using OpenQA.Selenium;

namespace SeleniumTest.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

        // SpecFlow dependency injection
        public static HomePage homePage;
        public static HtmlFormPage htmlFormPage;
        public static FormProcessorPage formProcessorPage;

        // Guardian demo
        public static GuardianLoginPage guardianLoginPage;
        public static GuardianDashboardPage guardianDashboardPage;
        public static GuardianKbaPage guardianKbaPage;
        public static GuardianAssetsPage guardianAssetsPage;
        public static GuardianMaintenanceServicesPage guardianMaintenanceServicesPage;
        public static GuardianSupportPage guardianSupportPage;
        public static GuardianSoftwareUpdatesPage guardianSoftwareUpdatesPage;
        public static GuardianPerformanceServicesPage guardianPerformanceServicesPage;
        public static GuardianDownloadsPage guardianDownloadsPage;
        public static GuardianSystemInfoPage guardianSystemInfoPage;


    }
}
