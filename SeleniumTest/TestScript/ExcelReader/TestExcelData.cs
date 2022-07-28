using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using ExcelDataReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTest.ExcelReader
{
    [TestClass]
    public class TestExcelData
    {
        [TestMethod]
        public void TestReadExcel()
        {
            FileStream stream = new FileStream(@"C:\SampleDataDrivenTest.xlsx", FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataTable table = reader.AsDataSet().Tables["TestData"];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var col = table.Rows[i];
                for (int j = 0; j < col.ItemArray.Length; j++)
                {
                    Console.WriteLine("Data : {0}", col.ItemArray[j]);
                }
            }
        }

        [TestMethod]
        public void TestDataReaderHelper()
        {
            string excelPath = "C:\\SampleDataDrivenTest.xlsx";
            Console.WriteLine(ExcelReaderHelper.GetCellData(excelPath, "TestDataTypeHandling", 1, 0));
            Console.WriteLine(ExcelReaderHelper.GetCellData(excelPath, "TestDataTypeHandling", 1, 1));
            Console.WriteLine(ExcelReaderHelper.GetCellData(excelPath, "TestDataTypeHandling", 1, 2));
            Console.WriteLine(ExcelReaderHelper.GetCellData(excelPath, "TestDataTypeHandling", 2, 0));
            Console.WriteLine(ExcelReaderHelper.GetCellData(excelPath, "TestDataTypeHandling", 2, 1));
            Console.WriteLine(ExcelReaderHelper.GetCellData(excelPath, "TestDataTypeHandling", 2, 2));
            Console.WriteLine(ExcelReaderHelper.GetCellData(excelPath, "TestDataTypeHandling", 3, 0));
            Console.WriteLine(ExcelReaderHelper.GetCellData(excelPath, "TestDataTypeHandling", 3, 1));
            Console.WriteLine(ExcelReaderHelper.GetCellData(excelPath, "TestDataTypeHandling", 3, 2));
            Console.WriteLine(ExcelReaderHelper.GetCellData(excelPath, "TestDataTypeHandling", 4, 0));
            Console.WriteLine(ExcelReaderHelper.GetCellData(excelPath, "TestDataTypeHandling", 4, 1));
            Console.WriteLine(ExcelReaderHelper.GetCellData(excelPath, "TestDataTypeHandling", 4, 2));
        }
    }
}
