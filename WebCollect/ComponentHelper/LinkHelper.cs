using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebCollect.ComponentHelper
{
    public class LinkHelper
    {
        public static void ClickLink(By locator)
        {
            GenericHelper.GetElement(locator).Click();
        }
    }
}
