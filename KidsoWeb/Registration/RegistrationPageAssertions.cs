using KidsoWeb.General;
using NUnit.Framework;

namespace KidsoWeb.Registration
{
    public partial class Registration
    {
        public void AssertCaptchaWarningIsDisplayed()
        {
            GeneralMethods.VerifyPageUrl(GeneralElements.campaignPageUrl);
        }
    }
}