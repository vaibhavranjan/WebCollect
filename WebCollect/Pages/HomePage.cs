using OpenQA.Selenium;
using WebCollect.ComponentHelper;
using WebCollect.ConfigHelper;
using WebCollect.Settings;

namespace WebCollect.Pages
{
    public class HomePage
    {
        ConfigReader configReader;

        string filePath = @"E:\Testing\Selenium\WC\WebCollect\WebCollect\WebElements\HomePageWebElement.xml";
        private IWebElement logoutButton;

        public HomePage()
        {
            configReader = new ConfigReader();            
            logoutButton = ObjectRepository.driver.FindElement(By.XPath(XPathHelper.GetXpath(filePath, ConfigKey.logoutButton)));
        }
        public void LogoutFromWebCollect()
        {
            logoutButton.Click();
        }
    }
}
