using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCollect.Settings;

namespace WebCollectTest.Test.TestInitialize
{
    [TestClass]
    public class TestCleanUp
    {
        [AssemblyCleanup]
        public static void Cleaner()
        {
            ObjectRepository.driver.Close();
            ObjectRepository.driver.Quit();
        }
    }
}
