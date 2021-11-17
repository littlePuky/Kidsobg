using KidsoWeb.General;
using NUnit.Framework;

namespace KidsoWeb.Registration
{
    public partial class Registration
    {
        public void AssertSuccessfulLogin()
        {
            GeneralMethods.VerifyPageUrl(Login.Login.loginPageUrl);
        }

        public void AssertCaptchaWarningIsDisplayed()
        {
            Assert.AreEqual("Моля попълнете полето антиспам верификация.", captchaWarningMessage.Text);
        }
    }
}