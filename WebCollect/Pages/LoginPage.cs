using OpenQA.Selenium;
using WebCollect.Settings;
using System.Threading;
using WebCollect.ConfigHelper;
using WebCollect.ComponentHelper;

namespace WebCollect.Pages
{
    public class LoginPage
    {
        ConfigReader configReader;
        
        string filePath = @"E:\Testing\Selenium\WC\WebCollect\WebCollect\WebElements\LoginPageWebElement.xml";
        private static string pageTitle= string.Empty;

        public LoginPage()
        {
            configReader = new ConfigReader();            
        }
        public HomePage LoginToWebCollect()
        {
            TextBoxHelper.TypeInTextBox(By.XPath(XPathHelper.GetXpath(filePath, ConfigKey.usernametextbox)),configReader.GetUsername());
            TextBoxHelper.TypeInTextBox(By.XPath(XPathHelper.GetXpath(filePath, ConfigKey.passwordtextbox)), configReader.GetPassword());
            ButtonHelper.ClickButton(By.XPath(XPathHelper.GetXpath(filePath, ConfigKey.loginbutton)));   
            return new HomePage();
        }

        public string VerifyLogin()
        {
            pageTitle = WindowsHelper.GetPageTitle();
            return pageTitle;
        }
    }
}
