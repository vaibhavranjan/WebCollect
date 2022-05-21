using System;
using WebCollect.Configuration;
using WebCollect.ComponentHelper;
using WebCollect.Interfaces;
using WebCollect.Settings;

namespace WebCollect.ConfigHelper
{
    public class ConfigReader : IConfig
    {
        const string configFilePath = @"E:\Testing\Selenium\WC\WebCollect\WebCollect\WebElements\Config.xml";
        public BrowserType GetBrowserType()
        {
            return (BrowserType) Enum.Parse(typeof(BrowserType), XPathHelper.GetXpath(configFilePath, ConfigKey.browser));
        }

        public int GetPageLoadTimeOut()
        {
            int timeout;
            int.TryParse(XPathHelper.GetXpath(configFilePath, ConfigKey.pageLoadTimeOut), out timeout);

            if (timeout.ToString() == null)
                return 30;
            else
                return timeout;
        }

        public string GetPassword()
        {
            return XPathHelper.GetXpath(configFilePath, ConfigKey.password);
        }
        public string GetUrl()
        {
            return XPathHelper.GetXpath(configFilePath, ConfigKey.url);
        }
        public string GetUsername()
        {
            return XPathHelper.GetXpath(configFilePath, ConfigKey.username);
        }

        public int WebElementTimeOut()
        {
            int timeout;
           int.TryParse(XPathHelper.GetXpath(configFilePath, ConfigKey.webElementTimeOut), out timeout);
            if (timeout.ToString() == null)
                return 30;
            else
                return timeout;
        }
    }
}
