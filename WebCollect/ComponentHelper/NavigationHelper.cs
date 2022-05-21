using System.Collections.ObjectModel;
using WebCollect.ConfigHelper;
using WebCollect.Settings;

namespace WebCollect.ComponentHelper
{
    public class NavigationHelper
    {
        private static string url = @"E:\Testing\Selenium\WC\WebCollect\WebCollect\WebElements\Config.xml";
        public static void LoadWebSite()
        {
            ObjectRepository.driver.Navigate().GoToUrl(XPathHelper.GetXpath(url, ConfigKey.url));
        }
    }
}
