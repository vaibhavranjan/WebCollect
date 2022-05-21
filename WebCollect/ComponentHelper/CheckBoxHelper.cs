using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WebCollect.Settings;

namespace WebCollect.ComponentHelper
{
    public class CheckBoxHelper
    {
        private static bool IsChecked(IWebElement element)
        {
            string isChecked = element.GetAttribute("checked").ToLower();
            if (isChecked != null)
                return isChecked.Equals("true") || isChecked.Equals("Checked");
            else
                return false;
        }

        public static void SelectCheckBox(By locator)
        {
            IWebElement checkBoxElement = GenericHelper.GetElement(locator);
            if (!IsChecked(checkBoxElement))
             checkBoxElement.Click();
        }
    }
}
