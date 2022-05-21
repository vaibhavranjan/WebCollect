using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using WebCollect.Settings;

namespace WebCollect.ComponentHelper
{
    public class GenericHelper
    {
        private static string fileName = DateTime.Now.ToString("MM/dd/yyyy HH-mm-ss" + ".png");
        private static bool IsElementPresent(By locator)
        {
            try
            {
                return ObjectRepository.driver.FindElements(locator).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static IWebElement GetElement(By locator)
        {
            if (IsElementPresent(locator))
                return ObjectRepository.driver.FindElement(locator);
            else
                throw new NoSuchElementException();

        }

        public static void TakeScreenshot()
        {
            Screenshot imageCaptured = ObjectRepository.driver.TakeScreenshot();
            imageCaptured.SaveAsFile(fileName, ScreenshotImageFormat.Png);
        }


    }
}
