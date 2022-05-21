using OpenQA.Selenium;
using System;
using WebCollect.ConfigHelper;
using WebCollect.Interfaces;
using WebCollect.Settings;
using OpenQA.Selenium.Support.UI;

namespace WebCollect.WebDriverWaitHandler
{
    public class WebDriverWaitClass
    {
        static IConfig config { get; set; }

        static WebDriverWaitClass()
        {
            config = new ConfigReader();
        }
        public static void WebPageLoadTimeOut()
        {
            ObjectRepository.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(config.GetPageLoadTimeOut());
        }

        public static void ImplicitWait()
        {
            ObjectRepository.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(config.WebElementTimeOut());
        }

        public static WebDriverWait DriverWait(TimeSpan timeout)
        {
            ObjectRepository.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.driver, timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));

            return wait;
        }

        public static IWebElement WaitForWebElement(By locator, TimeSpan timeout)
        {
            ObjectRepository.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.driver, timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            if(wait.Until(waitForElement(locator)))
                return wait.Until(waitForWebElement(locator));
            return null;
        }

        public static Func<IWebDriver, bool> waitForElement(By locator)
        {
            return ((x) =>
            {
                if (x.FindElement(locator).Displayed)
                    return true;
                return false;

            });
        }

        public static Func<IWebDriver, IWebElement> waitForWebElement(By locator)
        {
            return ((x) =>
            {
                if (x.FindElement(locator).Displayed)
                    return x.FindElement(locator);
                return null;

            });
        }
    }
}
