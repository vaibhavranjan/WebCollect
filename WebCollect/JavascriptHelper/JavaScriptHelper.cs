using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCollect.Settings;

namespace WebCollect.JavascriptHelper
{
    public class JavaScriptHelper
    {
        private static bool isAlertPresent()
        {
            try
            {
                ObjectRepository.driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static string GetAlertText()
        {
            if (isAlertPresent())
            {
                return ObjectRepository.driver.SwitchTo().Alert().Text;
            }
            else
            {
                return String.Empty;
            }

        }
        public static void AcceptAlert()
        {
            try
            {
                if (isAlertPresent())
                {
                    IAlert alert = ObjectRepository.driver.SwitchTo().Alert();
                    alert.Accept();
                }
            }
            catch (NoAlertPresentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DismissAlert()
        {
            try
            {
                if (isAlertPresent())
                {
                    IAlert alert = ObjectRepository.driver.SwitchTo().Alert();
                    alert.Dismiss();
                }
            }
            catch (NoAlertPresentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void SendTextToAlertInput(string text)
        {
            try
            {
                if (isAlertPresent())
                {
                    IAlert alert = ObjectRepository.driver.SwitchTo().Alert();
                    alert.SendKeys(text);
                }
            }
            catch (NoAlertPresentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void ScrollTo(int x_axis, int y_axis)
        {
            IJavaScriptExecutor executor = ((IJavaScriptExecutor)ObjectRepository.driver);
            executor.ExecuteScript("window.scrollTo(" + x_axis + "," + y_axis + ")");
        }
        public static void ScrollTo(IWebElement element)
        {
            IJavaScriptExecutor executor = ((IJavaScriptExecutor)ObjectRepository.driver);
        }
    }
}
