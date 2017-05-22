using GenericTestAutomationFramework.Base;
using TodosAppTest.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TodosAppTest.Steps
{
    [Binding]
    internal class SearchSteps : BaseStep
    {

        [Given(@"I opened todos app")]
        public void GivenIOpenedTodosApp()
        {
            CurrentPage = GetInstance<TodosHomePage>();
        }

        [When(@"I fill in s in txtSearch element")]
        public void WhenIFillInCInTxtSearchElement()
        {
            CurrentPage.As<TodosHomePage>().SearchForTodoItem("s");
        }

        [Then(@"one todo item should be found")]
        public void ThenOneTodoItemShouldBeFound()
        {
            Assert.AreEqual(2, CurrentPage.As<TodosHomePage>().GetTodosListSize());
        }

    }
}
