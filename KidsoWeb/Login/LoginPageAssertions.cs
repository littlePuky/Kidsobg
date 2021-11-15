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
            Assert.AreEqual("Невалиден e-mail или парола", wrongCredentialsMessage.Text);
        }

        public void AssertValidationMessageIsDisplayed()
        {
            Assert.AreEqual("Задължително поле", loginUsernameField.GetAttribute("validationMessage"));
        }

        public void AssertLoginPageIsLoaded()
        {
            GeneralMethods.VerifyPageUrl(loginPageUrl);
        }
    }
}