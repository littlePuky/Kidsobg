using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Text.RegularExpressions;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using OpenQA.Selenium.Support.UI;

public class TestBase : Drivers
{
    public static ExtentReports extent;
    public static ExtentReports report;
    public static ExtentV3HtmlReporter htmlReporter;
    public static ExtentTest test;
    public string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;

    [OneTimeSetUp]
    public void setUp()
    {
        htmlReporter = new ExtentV3HtmlReporter(@$"{path}/{TestContext.CurrentContext.Test.Name}-Result{DateTime.Now.ToString("MMddyyyyhhmmtt")}.html");
        extent = new ExtentReports();
        extent.AttachReporter(htmlReporter);
    }

    [OneTimeTearDown]
    public void Flush()
    {
        extent.Flush();
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
        {
            string fileName = Regex.Replace(TestContext.CurrentContext.Test.Name, "[^a-zA-Z0-9_]+", "");
            var ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(path + "\\" + fileName + ".png");
            TestContext.AddTestAttachment(path + "\\" + fileName + ".png");
            test.AddScreenCaptureFromPath(path + "\\" + fileName + ".png");
        }
        driver.Quit();
    }
    public static void Refresh() => driver.Navigate().Refresh();
}