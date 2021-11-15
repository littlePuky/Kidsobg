using OpenQA.Selenium;

namespace KidsoWeb.Login
{
    public partial class Login : Drivers
    {
        public static string loginPageUrl = "https://kidso.bg/vhod?back=my-account";
        public static string myProfileUrl = "https://kidso.bg/moqt-profil";

        public static IWebElement loginUsernameField
            => driver.FindElement(By.XPath("//form[@id='login-form']//input[@name='email']"));

        public static IWebElement loginPasswordField
            => driver.FindElement(By.XPath("//form[@id='login-form']//input[@name='password']"));

        public static IWebElement loginSubmitButton
            => driver.FindElement(By.Id("submit-login"));

        public static IWebElement wrongCredentialsMessage
            => driver.FindElement(By.CssSelector("#content .alert"));
    }
}