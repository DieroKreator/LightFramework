using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleFramework1;

[TestClass]
[TestCategory("SampleApplicationOne")]  
public class SampleApplicationOneTests
{
    private IWebDriver Driver {get; set;}

    [TestMethod]
    public void Test1()
    {
        Driver = GetChromeDriver();
        var sampleApplicationPage = new SampleApplicationPage(Driver);
        sampleApplicationPage.GoTo();
        Assert.IsTrue(sampleApplicationPage.IsVisible, "Same application was not visible.");

        var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit("Alex");
        Assert.IsTrue(ultimateQAHomePage.IsVisible, "UltimateQA home page was not visible");
        Driver.Close();
        Driver.Quit();
    }

    [TestMethod]
    public void PretendTestNumber2()
    {
        Driver = GetChromeDriver();
        var sampleApplicationPage = new SampleApplicationPage(Driver);
        sampleApplicationPage.GoTo();
        Assert.IsTrue(sampleApplicationPage.IsVisible, "Same application was not visible.");

        var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit("Alex");
        Assert.IsTrue(ultimateQAHomePage.IsVisible, "UltimateQA home page was not visible");
        Driver.Close();
        Driver.Quit();
    }

    private IWebDriver GetChromeDriver()
    {
        //var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        return new ChromeDriver();
    }
}