using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
        // public bool IsVisible{
        //     get 
        //     {
        //         try
        //         {
        //             WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //             IWebElement FreeDiscoveryButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[@href='/selenium-java']")));
        //             return FreeDiscoveryButton.Displayed;
        //         }
        //         catch (System.Exception)
        //         {
                    
        //             throw;
        //         }
        //     }
        // }
        public IWebElement FreeDiscoveryButton => Driver.FindElement(By.LinkText("SCHEDULE A FREE DISCOVERY SESSION"));
    }
}