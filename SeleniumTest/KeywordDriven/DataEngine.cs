using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTest.ComponentHelper;
using SeleniumTest.CustomException;
using SeleniumTest.ExcelReader;

namespace SeleniumTest.KeywordDriven
{
    public class DataEngine
    {
        private readonly int _keywordColumn;
        private readonly int _locatorTypeColumn;
        private readonly int _locatorValueColumn;
        private readonly int _parameterColumn;

        public DataEngine(int keywordColumn = 2, int locatorTypeColumn = 3, int locatorValueColumn = 4, int parameterColumn = 5)
        {
            this._keywordColumn = keywordColumn;
            this._locatorTypeColumn = locatorTypeColumn;
            this._locatorValueColumn = locatorValueColumn;
            this._parameterColumn = parameterColumn;
        }

        private By GetElementLocator(string locatorType, string locatorValue)
        {
            switch (locatorType)
            {
                case "ClassName":
                    return By.ClassName(locatorValue);

                case "CssSelector":
                    return By.CssSelector(locatorValue);

                case "Id":
                    return By.Id(locatorValue);

                case "LinkText":
                    return By.LinkText(locatorValue);

                case "Name":
                    return By.Name(locatorValue);

                case "PartialLinkText":
                    return By.PartialLinkText(locatorValue);

                case "TagName":
                    return By.TagName(locatorValue);

                case "XPath":
                    return By.XPath(locatorValue);

                default:
                    return By.Name(locatorValue);
            }
        }

        public void PerformAction(string keyword, string locatorType, string locatorValue, params string[] args)
        {
            switch (keyword)
            {
                case "Click":
                   ButtonHelper.ClickButton(GetElementLocator(locatorType, locatorValue));
                   break;

                case "SendKeys":
                    TextBoxHelper.TypeInTextBox(GetElementLocator(locatorType, locatorValue), args[0]);
                    break;

                case "Clear":
                    TextBoxHelper.ClearTextBox(GetElementLocator(locatorType, locatorValue));
                    break;

                case "Select":
                    DropDownHelper.SelectElementByValue(GetElementLocator(locatorType, locatorValue), args[0]);
                    break;

                case "WaitForElement":
                    GenericHelper.WaitForWebElementInPage(GetElementLocator(locatorType, locatorValue), TimeSpan.FromSeconds(15));
                    break;

                case "GetElement":
                    GenericHelper.GetElementText(GetElementLocator(locatorType, locatorValue), args[0]);
                    break;

                case "Navigate":
                    NavigationHelper.NavigateUrl(args[0]);
                    break;

                default:
                    throw new NoSuchKeywordFoundException("Keyword not found : " + keyword);
            }
        }

        public void ExecuteScript(string filePath, string sheetName)
        {
            int totalRows = ExcelReaderHelper.GetTotalRows(filePath, sheetName);
            for (int i = 1; i < totalRows; i++)
            {
                var fileLocatorType = ExcelReaderHelper.GetCellData(filePath, sheetName, i, _locatorTypeColumn).ToString();
                var fileLocatorValue = ExcelReaderHelper.GetCellData(filePath, sheetName, i, _locatorValueColumn).ToString();
                var fileKeyword = ExcelReaderHelper.GetCellData(filePath, sheetName, i, _keywordColumn).ToString();
                var fileParameter = ExcelReaderHelper.GetCellData(filePath, sheetName, i, _parameterColumn).ToString();

                PerformAction(fileKeyword, fileLocatorType, fileLocatorValue, fileParameter);
            }
        }
    }
}
