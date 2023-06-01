using SpecFlowProject1.Pages;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class ContactPageStepDefinitions
    {
        ContactPage contactPage = new ContactPage();

        [Then(@"I see (.*) field are required")]
        public void ThenISeeFieldAreRequired(int numberOfReauiredFields)
        {
            contactPage.VerifyNumberOfReauiredFields(numberOfReauiredFields);
        }


    }
}