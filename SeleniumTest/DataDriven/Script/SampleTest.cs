using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.ComponentHelper;
using SeleniumTest.PageObject;
using SeleniumTest.Settings;
using OpenQA.Selenium;
using SeleniumTest.ExcelReader;

namespace SeleniumTest.DataDriven.Script
{


    [TestClass]
    public class SampleTest
    {
        [TestInitialize]
        public void TestInitialize()
        {
            NavigationHelper.NavigateUrl("https://testpages.herokuapp.com/styled/index.html");
        }

        private TestContext _testcontext;

        public TestContext TestContext
        {
            get { return _testcontext; }
            set { _testcontext = value; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"C:\SampleDataDrivenTest.csv", "SampleDataDrivenTest#csv", DataAccessMethod.Sequential)]
        public void DataDrivenTestCsv()
        {
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            HtmlFormPage loginPage = homePage.NavigateToHtmlFormPage(ObjectRepository.Driver);

            TextBoxHelper.TypeInTextBox(By.XPath("//tbody/tr[1]/td[1]/input[1]"), TestContext.DataRow["Username"].ToString());
            TextBoxHelper.TypeInTextBox(By.XPath("//tbody/tr[2]/td[1]/input[1]"), TestContext.DataRow["Password"].ToString());
            CheckBoxHelper.ClickCheckBox(By.XPath(TestContext.DataRow["CheckBox"].ToString()));
            RadioButtonHelper.ClickRadioButton(By.XPath(TestContext.DataRow["Radio"].ToString()));
            TextBoxHelper.TypeInTextBox(By.XPath("//textarea[contains(text(),'Comments...')]"), TestContext.DataRow["Comments"].ToString());
            DropDownHelper.SelectElementByText(By.Name("dropdown"), TestContext.DataRow["DropDown"].ToString());
            FormProcessorPage formProcessorPage = loginPage.ClickSubmitButton();
            formProcessorPage.ClickReturnToHtmlFormPage();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\SampleDataDrivenTest.xml", "Row", DataAccessMethod.Sequential)]
        public void DataDrivenTestXml()
        {
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            HtmlFormPage loginPage = homePage.NavigateToHtmlFormPage(ObjectRepository.Driver);

            TextBoxHelper.TypeInTextBox(By.XPath("//tbody/tr[1]/td[1]/input[1]"), TestContext.DataRow["Username"].ToString());
            TextBoxHelper.TypeInTextBox(By.XPath("//tbody/tr[2]/td[1]/input[1]"), TestContext.DataRow["Password"].ToString());
            CheckBoxHelper.ClickCheckBox(By.XPath(TestContext.DataRow["CheckBox"].ToString()));
            RadioButtonHelper.ClickRadioButton(By.XPath(TestContext.DataRow["Radio"].ToString()));
            TextBoxHelper.TypeInTextBox(By.XPath("//textarea[contains(text(),'Comments...')]"), TestContext.DataRow["Comments"].ToString());
            DropDownHelper.SelectElementByText(By.Name("dropdown"), TestContext.DataRow["DropDown"].ToString());
            FormProcessorPage formProcessorPage = loginPage.ClickSubmitButton();
            formProcessorPage.ClickReturnToHtmlFormPage();
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", "Dsn=Excel Files;dbq=C:\\SampleDataDrivenTest.xlsx", "TestData$", DataAccessMethod.Sequential)]
        public void DataDrivenTestExcel()
        {
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            HtmlFormPage loginPage = homePage.NavigateToHtmlFormPage(ObjectRepository.Driver);

            TextBoxHelper.TypeInTextBox(By.XPath("//tbody/tr[1]/td[1]/input[1]"), TestContext.DataRow["Username"].ToString());
            TextBoxHelper.TypeInTextBox(By.XPath("//tbody/tr[2]/td[1]/input[1]"), TestContext.DataRow["Password"].ToString());
            CheckBoxHelper.ClickCheckBox(By.XPath(TestContext.DataRow["CheckBox"].ToString()));
            RadioButtonHelper.ClickRadioButton(By.XPath(TestContext.DataRow["Radio"].ToString()));
            TextBoxHelper.TypeInTextBox(By.XPath("//textarea[contains(text(),'Comments...')]"), TestContext.DataRow["Comments"].ToString());
            DropDownHelper.SelectElementByText(By.Name("dropdown"), TestContext.DataRow["DropDown"].ToString());
            FormProcessorPage formProcessorPage = loginPage.ClickSubmitButton();
            formProcessorPage.ClickReturnToHtmlFormPage();
        }

        [TestMethod]
        public void NonDataDrivenTest()
        {
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            HtmlFormPage loginPage = homePage.NavigateToHtmlFormPage(ObjectRepository.Driver);

            TextBoxHelper.TypeInTextBox(By.XPath("//tbody/tr[1]/td[1]/input[1]"), "MyUserName");
            TextBoxHelper.TypeInTextBox(By.XPath("//tbody/tr[2]/td[1]/input[1]"), "P@ssw0rd");
            CheckBoxHelper.ClickCheckBox(By.XPath("//input[@value='cb2']"));
            RadioButtonHelper.ClickRadioButton(By.XPath("//input[@value='rd1']"));
            TextBoxHelper.TypeInTextBox(By.XPath("//textarea[contains(text(),'Comments...')]"), "This is an automated message");
            DropDownHelper.SelectElementByText(By.Name("dropdown"), "Drop Down Item 6");
            FormProcessorPage formProcessorPage = loginPage.ClickSubmitButton();
            loginPage = formProcessorPage.ClickReturnToHtmlFormPage();
        }

        [TestMethod]
        public void DataDrivenTestExcelHelper()
        {
            string filePath = "C:\\SampleDataDrivenTest.xlsx";
            string sheetName = "TestData";
            string userNameXpath = "//tbody/tr[1]/td[1]/input[1]";
            string passwordXpath = "//tbody/tr[2]/td[1]/input[1]";


            HomePage homePage = new HomePage(ObjectRepository.Driver);
            HtmlFormPage loginPage = homePage.NavigateToHtmlFormPage(ObjectRepository.Driver);

            TextBoxHelper.TypeInTextBox(By.XPath(userNameXpath), ExcelReaderHelper.GetCellData(filePath, sheetName, 1, 0).ToString());
            TextBoxHelper.TypeInTextBox(By.XPath(passwordXpath), ExcelReaderHelper.GetCellData(filePath, sheetName, 1, 1).ToString());
            CheckBoxHelper.ClickCheckBox(By.XPath(ExcelReaderHelper.GetCellData(filePath, sheetName, 1, 2).ToString()));
            RadioButtonHelper.ClickRadioButton(By.XPath(ExcelReaderHelper.GetCellData(filePath, sheetName, 1, 3).ToString()));
            TextBoxHelper.TypeInTextBox(By.XPath("//textarea[contains(text(),'Comments...')]"), ExcelReaderHelper.GetCellData(filePath, sheetName, 1, 4).ToString());
            DropDownHelper.SelectElementByText(By.Name("dropdown"), ExcelReaderHelper.GetCellData(filePath, sheetName, 1, 5).ToString());
            FormProcessorPage formProcessorPage = loginPage.ClickSubmitButton();
            formProcessorPage.ClickReturnToHtmlFormPage();
        }
    }

}
