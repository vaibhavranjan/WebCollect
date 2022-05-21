using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCollect.Pages;

namespace WebCollectTest.Test.Pages
{
    [TestClass]
    public class LoginPageTest
    {
        private string expectedTitle = "Webcollect Home";
        private LoginPage lp;
        private HomePage hp;
        public LoginPageTest()
        {
            lp = new LoginPage();
        }

        [TestMethod]
        public void LoginToWebCollect()
        {
            hp = lp.LoginToWebCollect();
            string actualTitle = lp.VerifyLogin();
            Assert.AreEqual(expectedTitle, actualTitle);
            hp.LogoutFromWebCollect();
        }
        [TestMethod]
        public void LoginToWebCollect2()
        {
            hp = lp.LoginToWebCollect();
        }

        

        
    }
}
