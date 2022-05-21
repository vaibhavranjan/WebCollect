using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCollect.BaseClasses;

namespace WebCollectTest.Test.TestInitialize
{
    [TestClass]
    public class TestInit
    {
        [AssemblyInitialize]
        public static void InitializeTestEnv(TestContext tc)
        {
            BaseClass.LoadDriverAndWebsite();
        }
        

    }
}
