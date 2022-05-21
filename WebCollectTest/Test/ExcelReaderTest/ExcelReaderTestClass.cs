using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebCollect.ExcelDataReader;

namespace WebCollectTest.Test.ExcelReaderTest
{
    [TestClass]
    public class ExcelReaderTestClass
    {
        [TestMethod]
        public void ExcelDataReaderTest()
        {
            Console.WriteLine(ExcelReader.GetCellData(@"E:\Testing\Selenium\ExcelDataReader.xlsx", "Credentials", 1, 0));
            Console.WriteLine(ExcelReader.GetCellData(@"E:\Testing\Selenium\ExcelDataReader.xlsx", "Credentials", 1, 1));
        }
    }
}
