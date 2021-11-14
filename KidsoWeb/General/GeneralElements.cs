using System;
using OpenQA.Selenium;

namespace KidsoWeb.General
{
    public class GeneralElements : Drivers
    {
        public static string pageUrl = "https://www.kidso.bg/";
        public static string campaignPageUrl = "https://kidso.bg/campaign-colorful-week/#";
        public static string userFirstName = "TestUserName";
        public static string userLastName = "TestUserLast";
        public static string randomUserEmail = $"testemail{DateTime.Now.ToString("MMddyyyyhhmmtt")}@gmail.com";
        public static string userEmail = "testemail@gmail.com";
        public static string userPassword = "testPass";
        public static string ChildName = "Test Kid";
        
        
        public static IWebElement backToSiteButton
            => driver.FindElement(By.CssSelector(".backToSite span"));
        
        public static IWebElement registrationButton
            => driver.FindElement(By.XPath("//span[.='Регистрация']"));
        public static IWebElement loginButton
            => driver.FindElement(By.XPath("//span[.='Вход']"));
    }
}