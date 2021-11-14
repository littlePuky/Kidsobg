using System;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace KidsoWeb.General
{
    public class GeneralMethods : Drivers
    {
        public static void VerifyPageUrl(string expectedUrl)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(d =>
                    driver.Url.Equals(expectedUrl));
            }
            catch (Exception)
            {
                Assert.Fail($"Did not navigate to {expectedUrl}.");
            }
        }
    }
}