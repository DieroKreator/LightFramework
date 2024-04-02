using OpenQA.Selenium;

namespace SampleFramework1
{
    class UltimateQAHomePage
    {
        private IWebDriver driver;

        public UltimateQAHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsVisible => driver.FindElement(By.LinkText("SCHEDULE A FREE DISCOVERY SESSION")).Displayed;
    }
}