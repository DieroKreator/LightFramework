using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleFramework1;

[TestClass]
[TestCategory("SampleApplicationOne")]
public class SampleApplicationOneTests
{
    private IWebDriver? Driver { get; set; }
    internal TestUser? TheTestUser { get; private set; }
    internal SampleApplicationPage? SampleAppPage { get; private set; }
    internal TestUser? EmergencyContactUser { get; private set; }

    [TestMethod]
    [Description("Validate that user is able to fill out the form successfully using valid data.")]
    public void Test1()
    {
        SetGenderTypes(Gender.Female, Gender.Female);
        EmergencyContactUser = new TestUser();

        SampleAppPage.GoTo();
        SampleAppPage.FillOutEmergencyContactForm(EmergencyContactUser);
        var ultimateQAHomePage = SampleAppPage.FillOutFormAndSubmit(TheTestUser);
        AssertPageVisible(ultimateQAHomePage);
    }

    [TestMethod]
    [Description("Fake 2nd test.")]
    public void PretendTestNumber2()
    {
        EmergencyContactUser = new TestUser();

        SampleAppPage.GoTo();
        SampleAppPage.FillOutEmergencyContactForm(EmergencyContactUser);
        var ultimateQAHomePage = SampleAppPage.FillOutFormAndSubmit(TheTestUser);
        AssertPageVisibleVariation2(ultimateQAHomePage);
    }

    /* Sprint 3 - Sample Application Lifecycle / More data added */
    [TestMethod]
    [Description("Validate that when selecting the Other gender type, the form is submitted successfully.")]
    public void Test3()
    {
        SetGenderTypes(Gender.Other, Gender.Other);
        EmergencyContactUser = new TestUser();

        SampleAppPage.GoTo();
        SampleAppPage.FillOutEmergencyContactForm(EmergencyContactUser);
        var ultimateQAHomePage = SampleAppPage.FillOutFormAndSubmit(TheTestUser);
        AssertPageVisibleVariation2(ultimateQAHomePage);
    }

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
        SampleAppPage = new SampleApplicationPage(Driver);

        TheTestUser = new TestUser();
        TheTestUser.FirstName = "Alex";
        TheTestUser.LastName = "Bullah";

        EmergencyContactUser = new TestUser();
        EmergencyContactUser.FirstName = "Emergency First Name";
        EmergencyContactUser.LastName = "Emergency Last Name";
    }

    private IWebDriver GetChromeDriver()
    {
        //var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        return new ChromeDriver();
    }

    private static void AssertPageVisible(UltimateQAHomePage ultimateQAHomePage)
    {
        Assert.IsTrue(ultimateQAHomePage.IsVisible, "UltimateQA home page was not visible.");
    }

    private static void AssertPageVisibleVariation2(UltimateQAHomePage ultimateQAHomePage)
    {
        Assert.IsFalse(!ultimateQAHomePage.IsVisible, "UltimateQA home page was not visible");
    }

    /* Sprint 4 - Sample Application Lifecycle / Emergency contact added */
    private void SetGenderTypes(Gender primaryContact, Gender emergencyContact)
    {
        EmergencyContactUser = new TestUser();

        TheTestUser.GenderType = primaryContact;
        EmergencyContactUser.GenderType = emergencyContact;
    }
}