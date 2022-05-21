using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCollect.ComponentHelper
{
    public class DropDownHelper
    {
        public static void SelectByIndex(By locator, int index)
        {
            SelectElement select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByIndex(index);
        }
        public static void SelectByText(By locator, string visibleText)
        {
            SelectElement select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByText(visibleText);
        }
        public static void SelectByValue(By locator, string value)
        {
            SelectElement select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByText(value);
        }
        public static IList<string> GetAllList(By locator)
        {
            SelectElement select = new SelectElement(GenericHelper.GetElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }
    }
}
