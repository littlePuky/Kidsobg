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
        driver = new Drivers().InitChrome(driver);
        try
        {
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
        new Registration()
            .enterCredentials()
            .AssertSuccessfulLogin();
        test.Log(Status.Pass, "Test Successful!");
    }

    [Test]
    public void TestCaptchaWarning()
    {
        test = extent.CreateTest("TestCaptchaWarning").Info("Press submit and verify.");
        new Registration()
            .PressSubmitButtonWithNoCredentialsEntered()
            .AssertCaptchaWarningIsDisplayed();
        test.Log(Status.Pass, "Test Successful!");
    }
}