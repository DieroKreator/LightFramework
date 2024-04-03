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
        Assert.IsTrue(sampleApplicationPage.IsVisible);

        var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit("Alex");
        Assert.IsTrue(ultimateQAHomePage.IsVisible);
        Driver.Close();
        Driver.Quit();
    }

    private IWebDriver GetChromeDriver()
    {
        //var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        return new ChromeDriver();
    }
}