using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCollect.Log4Net;

namespace WebCollectTest.Test.Log4NetTest
{
    [TestClass]
    public class Log4NetTestCalss
    {
        [TestMethod]
        public void TestLog4Net()
        {
            Log4NetClass.ConsoleAppenderLog();
        }
    }
}
