using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleFramework1;

[TestClass]
[TestCategory("SampleApplicationOne")]
public class SampleApplicationOneTests
{
    private IWebDriver? Driver { get; set; }
    internal TestUser? TheTestUser { get; private set; }

    [TestMethod]
    [Description("Validate that user is able to fill out the form successfully using valid data.")]
    public void Test1()
    {
        var sampleApplicationPage = new SampleApplicationPage(Driver);
        sampleApplicationPage.GoTo();
        var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(TheTestUser);
        Assert.IsTrue(ultimateQAHomePage.IsVisible, "UltimateQA home page was not visible.");
    }

    [TestMethod]
    [Description("Fake 2nd test.")]
    public void PretendTestNumber2()
    {
        var sampleApplicationPage = new SampleApplicationPage(Driver);
        sampleApplicationPage.GoTo();
        var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(TheTestUser);
        Assert.IsFalse(!ultimateQAHomePage.IsVisible, "UltimateQA home page was not visible");
    }

    // Sprint 3 - Sample Application Lifecycle
    // More data added

    [TestCleanup]
    public void CleanUpAfterEveryTestMethod()
    {
        Driver.Close();
        Driver.Quit();
    }

    [TestInitialize]
    public void SetupForEverySingleTestMethod()
    {
        Driver = GetChromeDriver();
        TheTestUser = new TestUser();
        TheTestUser.FirstName = "Alex";
        TheTestUser.LastName = "Bullah";
        TheTestUser.GenderType = Gender.Female;
    }

    private IWebDriver GetChromeDriver()
    {
        //var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        return new ChromeDriver();
    }

}