using OpenQA.Selenium;

namespace SampleFramework1
{
    internal class SampleApplicationPage : BaseSampleApplicationPage
    {
        public SampleApplicationPage(IWebDriver driver) : base(driver){}

        public bool IsVisible { 
            get 
            {
                return Driver.Title.Contains("Sample Application Lifecycle - Sprint 1 - Ultimate QA");

            } 
            internal set {} 
        }

        public IWebElement FirstNameField => Driver.FindElement(By.Name("firstname"));

        public IWebElement SubmitButton => Driver.FindElement(By.XPath("//*[@type='submit']"));

        public IWebElement LastNameField => Driver.FindElement(By.Name("lastname"));

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("https://ultimateqa.com/sample-application-lifecycle-sprint-2/");
        }

        internal UltimateQAHomePage FillOutFormAndSubmit(TestUser user)
        {
            FirstNameField.SendKeys(user.FirstName);
            LastNameField.SendKeys(user.LastName);
            SubmitButton.Submit();
            return new UltimateQAHomePage(Driver);
        }
    }
}