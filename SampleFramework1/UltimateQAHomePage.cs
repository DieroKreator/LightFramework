using OpenQA.Selenium;

namespace SampleFramework1
{
    internal class UltimateQAHomePage
    {
        private IWebDriver Driver {get; set; }

        public UltimateQAHomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsVisible => FreeDiscoveryButton.Displayed;

        public IWebElement FreeDiscoveryButton => Driver.FindElement(By.LinkText("SCHEDULE A FREE DISCOVERY SESSION"));
    }
}