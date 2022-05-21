using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCollect.Settings;

namespace WebCollect.BrowserNavigationHelper
{
    public class BrowserNavigationHelper
    {
        public static void Back()
        {
            ObjectRepository.driver.Navigate().Back();
        }

        public static void Forward()
        {
            ObjectRepository.driver.Navigate().Forward();
        }

        public static void Refresh()
        {
            ObjectRepository.driver.Navigate().Refresh();
        }

        public static void SwitchToWindow(string windowName)
        {
            IReadOnlyCollection<string> windows = ObjectRepository.driver.WindowHandles;
            if (windows.Count > 0)
            {
                ObjectRepository.driver.SwitchTo().Window(windowName);
            }
            else
            {
                throw new NoSuchWindowException("Invalid browser window name  " + windowName);
            }
        }

        public static void SwitchToFrame(int frameIndex)
        {
            ObjectRepository.driver.SwitchTo().Frame(frameIndex);
        }

        public static void SwitchToFrame(string frameName)
        {
            ObjectRepository.driver.SwitchTo().Frame(frameName);
        }

        public static void SwitchToFrame(IWebElement frameElement)
        {
            ObjectRepository.driver.SwitchTo().Frame(frameElement);
        }

        public static void SwitchToDefaultContent()
        {
            ObjectRepository.driver.SwitchTo().DefaultContent();
        }

        //Have doubt in this
        public static void SwitchToParentWindow(string windowName)
        {
            IReadOnlyCollection<string> windows = ObjectRepository.driver.WindowHandles;
            if(windows.Count>0)
            {
                        ObjectRepository.driver.Close();
                        ObjectRepository.driver.SwitchTo().Window(windowName);              
            }
            else
            {
                throw new NoSuchWindowException(windowName);
            }
        }
    }
}
