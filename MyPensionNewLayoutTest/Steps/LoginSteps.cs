using GenericTestAutomationFramework.Base;

using MyPensionNewLayoutTest.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MyPensionNewLayoutTest.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {
        [Given(@"I open gmail website")]
        public void GivenIOpenGmailWebsite()
        {
            
            CurrentPage = GetInstance<GmailHomePage>();
            
        }


        [When(@"I entered my Email and Password")]
        public void WhenIEnteredMyEmailAndPassword(Table table)
        {
            dynamic credentials = table.CreateDynamicInstance();
            CurrentPage.As<GmailHomePage>().FillInCredentials(credentials.Email, credentials.Password);
        }

        [When(@"I clicked on sign button")]
        public void WhenIClickedOnSignButton()
        {
            
            CurrentPage = CurrentPage.As<GmailHomePage>().LogIn();
        }

        [Then(@"the result should be see compose button")]
        public void ThenTheResultShouldBeSeeComposeButton()
        {
            CurrentPage.As<GmailAuthenticatedPage>().CheckSuccessfullLogin();
        }


    }
}
