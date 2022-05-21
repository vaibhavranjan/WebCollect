using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCollect.Settings;
using WebCollect.WebDriverWaitHandler;

namespace WebCollect.ComponentHelper
{
    public class AutoSuggestHelper
    {
        public static void AutoSegestSelection(By searchLocator, By autoSuggestLocator,string searchText,string selection)
        {
            ObjectRepository.driver.FindElement(searchLocator).SendKeys(searchText);
            WebDriverWait wait = WebDriverWaitClass.DriverWait(TimeSpan.FromSeconds(50));
            IList<IWebElement> elements = wait.Until(GetAllElement(autoSuggestLocator));
            foreach(IWebElement element in elements)
            {
                if(element.Text.Equals(selection))
                {
                    element.Click();
                }
            }
        }

        private static Func<IWebDriver,IList<IWebElement>> GetAllElement(By locator)
        {
            return((x) =>
           {
               return x.FindElements(locator);
           });
        }
    }
}
