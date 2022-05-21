using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebCollect.ComponentHelper
{
    public class ButtonHelper
    {
        private static bool IsButtonEnabled(IWebElement element)
        {
            if (element.Enabled)
                return true;
            else
                return false;
        }

        public static void ClickButton(By locator)
        {
            IWebElement button = GenericHelper.GetElement(locator);
            if (IsButtonEnabled(button))
                button.Click();
            else
                throw new Exception("Button is not enable to click");
        }

        public static string GetButtonText(By locator)
        {
            IWebElement button = GenericHelper.GetElement(locator);
            return button.GetAttribute("value");
        }
    }
}
