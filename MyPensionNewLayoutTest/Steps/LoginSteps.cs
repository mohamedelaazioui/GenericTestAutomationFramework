using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MyPensionNewLayoutTest.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        [Given(@"I open gmail website")]
        public void GivenIOpenGmailWebsite()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I entered my username and password")]
        public void WhenIEnteredMyUsernameAndPassword()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I clicked on next button")]
        public void WhenIClickedOnNextButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be see compose button")]
        public void ThenTheResultShouldBeSeeComposeButton()
        {
            ScenarioContext.Current.Pending();
        }

    }

}
