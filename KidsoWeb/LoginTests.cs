using System;
using AventStack.ExtentReports;
using KidsoWeb.General;
using KidsoWeb.Login;
using NUnit.Framework;

public class LoginTests : TestBase
{
    [SetUp]
    public void Start()
    {
        driver = new Drivers().InitChrome(driver);
        try
        {
            driver.Url = GeneralElements.pageUrl;
            GeneralElements.backToSiteButton.Click();
            new Login()
                .NavigateTologinPage()
                .AssertLoginPageIsLoaded();
        }
        catch (Exception)
        {
            Refresh();
            GeneralElements.backToSiteButton.Click();
            new Login()
                .NavigateTologinPage()
                .AssertLoginPageIsLoaded();
        }
    }

    [Test]
    public void SuccessfulLogin()
    {
        test = extent.CreateTest("SuccessfulLogin").Info("Enter login credentials and verify.");
        new Login()
            .ValidLogin()
            .AssertMyProfilePageIsLoaded();
        test.Log(Status.Pass, "Test Successful!");
    }

    [Test]
    public void LoginWithWrongCredentials()
    {
        test = extent.CreateTest("LoginWithWrongCredentials").Info("Enter login credentials and verify.");
        new Login()
            .WrongPassword()
            .AssertWrongCredentialsMessageIsDisplayed();
        test.Log(Status.Pass, "Test Successful!");
    }

    [Test]
    public void LoginWithoutCredentials()
    {
        test = extent.CreateTest("LoginWithoutCredentials").Info("Press verify button with no credentials entered.");

        new Login()
            .NoCredentialsLogin()
            .AssertValidationMessageIsDisplayed();
        test.Log(Status.Pass, "Test Successful!");
    }
}