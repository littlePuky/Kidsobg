using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Drivers
{
    public static IWebDriver driver;

    public IWebDriver InitChrome(IWebDriver driver)
    {
        var options = new ChromeOptions();
        options.AddArgument("--disable-notifications");
        driver = new ChromeDriver(options );
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        return driver;
    }
    
}