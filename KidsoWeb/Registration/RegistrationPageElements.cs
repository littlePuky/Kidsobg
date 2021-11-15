using OpenQA.Selenium;

namespace KidsoWeb.Registration
{
    public partial class Registration : Drivers
    {
        public IWebElement MrRadioButton => driver.FindElement(By.XPath("//label[contains(.,'Г-н')]"));
        public IWebElement MrsRadioButton => driver.FindElement(By.XPath("//label[contains(.,'Г-жа')]"));
        public IWebElement firstNameField => driver.FindElement(By.CssSelector("[name='firstname']"));
        public IWebElement lastNameField => driver.FindElement(By.CssSelector("[name='lastname']"));
        public IWebElement emailField => driver.FindElement(By.CssSelector("[name='email']"));
        public IWebElement passwordField => driver.FindElement(By.CssSelector("[name='password']"));
        public IWebElement kidsAgeButton => driver.FindElement(By.Id("ihavekids"));
        public IWebElement kidsNameField => driver.FindElement(By.CssSelector("[placeholder='Име на детето']"));
        public IWebElement dateDayDropdown => driver.FindElement(By.CssSelector("[name='date_[day]']"));
        public IWebElement dateMonthDropdown => driver.FindElement(By.CssSelector("[name='date_[month]']"));
        public IWebElement dateYearDropdown => driver.FindElement(By.CssSelector("[name='date_[year]']"));
        public IWebElement boyRadioButton => driver.FindElement(By.Id("RadioBoy"));
        public IWebElement girlRadioButton => driver.FindElement(By.Id("RadioGirl"));
        public IWebElement agreeToTermsButton => driver.FindElement(By.Name("psgdpr"));
        public IWebElement submitButton => driver.FindElement(By.CssSelector(".form-control-submit"));
        public IWebElement captchaWarningMessage => driver.FindElement(By.Id("captcha"));

        public IWebElement captcha =>
            driver.FindElement(By.XPath(
                "//iframe[starts-with(@name, 'a-') and starts-with(@src, 'https://www.google.com/recaptcha')]"));
    }
}