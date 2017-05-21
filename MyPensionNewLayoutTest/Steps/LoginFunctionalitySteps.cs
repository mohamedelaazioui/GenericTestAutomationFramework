using GenericTestAutomationFramework.Base;
using MyPensionNewLayoutTest.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MyPensionNewLayoutTest.Steps
{
    [Binding]
    public class LoginFunctionalitySteps : BaseStep
    {
        [Given(@"I open gmail website")]
        public void GivenIOpenGmailWebsite()
        {
            
            CurrentPage = GetInstance<GmailHomePage>();
            
        }


        [When(@"I entered my Email and Password")]
        public void WhenIEnteredMyEmailAndPassword(Table table)
        {
            Assert.AreEqual(true, true);
        }

        [When(@"I clicked on sign button")]
        public void WhenIClickedOnSignButton()
        {
            Assert.AreEqual(true, true);
        }

        [Then(@"the result should be see compose button")]
        public void ThenTheResultShouldBeSeeComposeButton()
        {
            Assert.AreEqual(true, true);
        }


    }
}
