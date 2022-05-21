using WebCollect.Configuration;

namespace WebCollect.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowserType();
        string GetUrl();
        string GetUsername();
        string GetPassword();
        int GetPageLoadTimeOut();
        int WebElementTimeOut();
    }
}
