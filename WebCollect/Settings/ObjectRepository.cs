using OpenQA.Selenium;
using WebCollect.Interfaces;

namespace WebCollect.Settings
{
    public static class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver driver { get; set; }
    }
}
