using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCollectTest.Test.DataSourceTest
{
    [TestClass]
    public class DataSourceTestClass
    {
        private TestContext testContext;
        public TestContext TestContext
        {
            get
            {
                return testContext;
            }
            set
            {
                testContext = value;
            }
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"E:\Testing\Selenium\WC\WebCollect\WebCollect\DataSource\Data.csv","Data#csv",DataAccessMethod.Sequential)]
        public void CSV_DS_Test()
        {
            Console.WriteLine(TestContext.DataRow["Field1"].ToString());
            Console.WriteLine(TestContext.DataRow["Field2"].ToString());
            Console.WriteLine(TestContext.DataRow["Field3"].ToString());
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=E:\Testing\Selenium\WC\WebCollect\WebCollect\DataSource\Data.xlsx;", "Data$", DataAccessMethod.Sequential)]
        public void XL_DS_Test()
        {
            Console.WriteLine(TestContext.DataRow["Field1"].ToString());
            Console.WriteLine(TestContext.DataRow["Field2"].ToString());
            Console.WriteLine(TestContext.DataRow["Field3"].ToString());
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"E:\Testing\Selenium\WC\WebCollect\WebCollect\DataSource\Data.xml", "Row", DataAccessMethod.Sequential)]
        public void XML_DS_Test()
        {
            Console.WriteLine(TestContext.DataRow["Field1"].ToString());
            Console.WriteLine(TestContext.DataRow["Field2"].ToString());
            Console.WriteLine(TestContext.DataRow["Field3"].ToString());
        }
    }
}
