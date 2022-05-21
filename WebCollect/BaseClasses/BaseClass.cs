using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using WebCollect.ComponentHelper;
using WebCollect.Configuration;
using WebCollect.CustomException;
using WebCollect.ConfigHelper;
using WebCollect.Interfaces;
using WebCollect.Settings;
using WebCollect.WebDriverWaitHandler;

namespace WebCollect.BaseClasses
{
    public class BaseClass
    {
        static IConfig config;
        public static void LoadDriver()
        {
            config = new ConfigReader();
            switch (config.GetBrowserType())
            {
                case BrowserType.Chrome:
                    ObjectRepository.driver = GetChromeDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRepository.driver = GetChromeDriver();
                    break;

                default:
                    throw new NoSuitableDriverFound("No suitable driver found");
            }

        }
        public static void LoadDriverAndWebsite()
        {
            LoadDriver();
            WebDriverWaitClass.WebPageLoadTimeOut();
            WebDriverWaitClass.ImplicitWait();
            NavigationHelper.LoadWebSite();
        }

        #region helper
        public static IWebDriver GetFirefoxDriver()
        {
            return new FirefoxDriver();
        }
        public static IWebDriver GetChromeDriver()
        {
            return new ChromeDriver(GetChromeOptions());
        }
        public static ChromeOptions GetChromeOptions()
        {
            ChromeOptions chromeOption = new ChromeOptions();
            chromeOption.AddArgument("start-maximized");
            return chromeOption;
        }

        #endregion
    }
}
