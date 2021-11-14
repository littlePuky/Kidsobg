using System;
using KidsoWeb.General;

namespace KidsoWeb.Login
{
    public partial class Login
    {
        public Login NavigateTologinPage()
        {
            GeneralElements.loginButton.Click();
            return this;
        }
        public Login ValidLogin()
        {
            loginUsernameField.SendKeys(GeneralElements.userEmail);
            loginPasswordField.SendKeys(GeneralElements.userPassword);
            loginSubmitButton.Click();
            return this;
        }

        public Login WrongPassword()
        {
            loginUsernameField.SendKeys(GeneralElements.userEmail);
            loginPasswordField.SendKeys("password");
            loginSubmitButton.Click();
            return this;
        }

        public Login NoCredentialsLogin()
        {
            loginSubmitButton.Click();
            return this;
        }
    }
}