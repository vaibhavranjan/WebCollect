using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCollect.Settings;

namespace WebCollect.MouseActions
{
    public class MouseActions
    {
        public static void ContextClick()
        {
            Actions actions = new Actions(ObjectRepository.driver);
            actions.ContextClick().Build().Perform();
        }
        public static void ContextClick(IWebElement element)
        {
            Actions actions = new Actions(ObjectRepository.driver);
            actions.ContextClick(element).Build().Perform();
        }
        public static void DragandDrop(IWebElement sourceElement, IWebElement targetElement)
        {
            Actions actions = new Actions(ObjectRepository.driver);
            actions.DragAndDrop(sourceElement, targetElement).Build().Perform();
        }
        public static void MoveToElement(IWebElement sourceElement, IWebElement targetElement)
        {
            Actions actions = new Actions(ObjectRepository.driver);
            actions.ClickAndHold(sourceElement).MoveToElement(targetElement).Release().Build().Perform();
        }

    }
}
