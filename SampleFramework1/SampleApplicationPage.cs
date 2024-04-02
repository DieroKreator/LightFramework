using OpenQA.Selenium;

namespace SampleFramework1
{
    internal class SampleApplicationPage
    {
        public IWebDriver Driver { get; set; }

        public SampleApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsVisible { 
            get 
            {
                return Driver.Title.Contains("Sample Application Lifecycle - Sprint 1 - Ultimate QA");

            } 
            internal set {} 
        }

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("https://www.ultimateqa.com/sample-application-lifecycle-sprint-1/");
        }

        internal UltimateQAHomePage FillOutFormAndSubmit(string firstName)
        {
            Driver.FindElement(By.XPath("//*[@name='firstname']")).SendKeys(firstName);
            Driver.FindElement(By.XPath("//*[@type='submit']")).Submit();
            return new UltimateQAHomePage(Driver);
        }
    }
}