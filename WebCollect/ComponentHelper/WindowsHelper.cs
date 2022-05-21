using System;
using System.Collections.Generic;
using System.Text;
using WebCollect.Settings;

namespace WebCollect.ComponentHelper
{
    public class WindowsHelper
    {
        public static string GetPageTitle()
        {
            return ObjectRepository.driver.Title;
        }
    }
}
