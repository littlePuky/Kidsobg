using System;
using System.Threading;
using KidsoWeb.General;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace KidsoWeb.Registration
{
    public partial class Registration
    {
        public Registration EnterCredentials()
        {
            GeneralElements.registrationButton.Click();
            MrRadioButton.Click();
            firstNameField.SendKeys(GeneralElements.userFirstName);
            lastNameField.SendKeys(GeneralElements.userLastName);
            emailField.SendKeys(GeneralElements.randomUserEmail);
            passwordField.SendKeys(GeneralElements.userPassword);
            kidsNameField.SendKeys(GeneralElements.ChildName);
            dateDayDropdown.SendKeys("01");
            dateMonthDropdown.SendKeys("Февруари");
            SelectElement element = new SelectElement(dateYearDropdown);
            element.SelectByText("2020");
            boyRadioButton.Click();
            agreeToTermsButton.Click();
            captcha.Click();
            try
            {
                Thread.Sleep(2000);
                submitButton.Click();
            }
            catch (Exception e)
            {
            }

            return this;
        }

        public Registration PressSubmitButtonWithNoCredentialsEntered()
        {
            GeneralElements.registrationButton.Click();
            var actions = new Actions(driver);
            actions.MoveToElement(agreeToTermsButton);
            actions.Perform();
            submitButton.Click();
            return this;
        }
    }
}