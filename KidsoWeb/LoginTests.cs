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
        try
        {
            driver = new Drivers().InitChrome(driver);
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
        try
        {
            
            new Login()
                .ValidLogin()
                .AssertMyProfilePageIsLoaded();
        }
        catch (Exception)
        {
            test.Log(Status.Fail, "The Test failed");
            throw;
        }
    }

    [Test]
    public void LoginWithWrongCredentials()
    {
        test = extent.CreateTest("LoginWithWrongCredentials").Info("Enter login credentials and verify.");
        try
        {
            new Login()
                .WrongPassword()
                .AssertWrongCredentialsMessageIsDisplayed();
        }
        catch (Exception)
        {
            test.Log(Status.Fail, "The Test failed");
            throw;
        }
    }

    [Test]
    public void LoginWithoutCredentials()
    {
        test = extent.CreateTest("LoginWithoutCredentials").Info("Press verify button with no credentials entered.");
        try
        {
            new Login()
                .NoCredentialsLogin()
                .AssertValidationMessageIsDisplayed();
        }
        catch (Exception)
        {
            test.Log(Status.Fail, "The Test failed");
            throw;
        }
    }
    
}