using SpecFlowProject1.Pages;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class EpamStepDefinitions
    {
        private HomePage homePage = new HomePage();

        [Given("I open 'epam.com' home page")]
        public void OpenHomePage()
        {
            homePage.OpenPage();
        }

        [When(@"I choose '([^']*)' language")]
        public void WhenIChooseLanguage(string language)
        {
            homePage.ClickOnButtonLanguage();
            homePage.ClickOnLanguage(language); ;
        }

        [Then(@"I see '([^']*)' menu")]
        public void ThenISeeButton(string nemuCompany)
        {
            homePage.verifyTextInButtonSubscribe(nemuCompany);
        }


        [When(@"I submit empty contact form")]
        public void WhenISubmitEmptyContactForm()
        {
            homePage.clickOnContactUs();
            new ContactPage().ClickOnButtonSubmit();
        }

    }
}