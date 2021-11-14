using KidsoWeb.General;
using NUnit.Framework;

namespace KidsoWeb.Login
{
    public partial class Login
    {
        public void AssertMyProfilePageIsLoaded()
        {
            GeneralMethods.VerifyPageUrl(myProfileUrl);
        }
        public void AssertWrongCredentialsMessageIsDisplayed()
        {
            Assert.AreEqual(wrongCredentialsMessage.Text,"Невалиден e-mail или парола");
        }

        public void AssertValidationMessageIsDisplayed()
        {
            Assert.AreEqual(loginUsernameField.GetAttribute("validationMessage"), "Задължително поле");
        }

        public void AssertLoginPageIsLoaded()
        {
            GeneralMethods.VerifyPageUrl(loginPageUrl);
        }
    }
}