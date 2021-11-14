using System;
using AventStack.ExtentReports;
using KidsoWeb.General;
using KidsoWeb.Registration;
using NUnit.Framework;

public class RegistrationTests : TestBase
{
    [SetUp]
    public void Start()
    {
        try
        {
            driver = new Drivers().InitChrome(driver);
            driver.Url = GeneralElements.pageUrl;
            GeneralElements.backToSiteButton.Click();
        }
        catch (Exception)
        {
            Refresh();
            GeneralElements.backToSiteButton.Click();
        }
    }

    [Test]
    public void SuccessfulRegistration()
    {
        test = extent.CreateTest("SuccessfulRegistration").Info("Enter registration credentials and verify.");
        try
        {
            new Registration()
                .enterCredentials()
                .AssertCaptchaWarningIsDisplayed();
            test.Log(Status.Pass);
        }
        catch (Exception)
        {
            test.Log(Status.Fail, "The Test failed");
            throw;
        }
    }

}