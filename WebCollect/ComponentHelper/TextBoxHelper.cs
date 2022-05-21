using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebCollect.ComponentHelper
{
    public class TextBoxHelper
    {
        private static bool IsTextBoxClear(IWebElement element)
        {
            if (element.Text == null)
                return true;
            else
                return false;
        }

        public static void TypeInTextBox(By locator, string value)
        {
            IWebElement textBox = GenericHelper.GetElement(locator);
            if (!IsTextBoxClear(textBox))
                textBox.Clear();
            textBox.SendKeys(value);
        }
    }
}
