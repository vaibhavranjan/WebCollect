using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebCollect.ComponentHelper
{
    public class RadioButtonHelper
    {
        private static IWebElement radioButton;
        public static void ClickRadioButton(By locator)
        {
            radioButton = GenericHelper.GetElement(locator);
            if (!IsRadioChecked(radioButton))
                radioButton.Click();
        }

        private static bool IsRadioChecked(IWebElement element)
        {
            string isChecked = element.GetAttribute("checked").ToLower();
            if (isChecked != null)
                return isChecked.Equals("true") || isChecked.Equals("Checked");
            else
                return false;
        }
    }
}
