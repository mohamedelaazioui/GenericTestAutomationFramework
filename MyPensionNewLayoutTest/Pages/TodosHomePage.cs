using GenericTestAutomationFramework.Base;
using GenericTestAutomationFramework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosAppTest.Pages
{
    internal class TodosHomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/todo-list/div/div/div/input")]
        private IWebElement txtSearch;

        [FindsBy(How = How.XPath, Using = "/html/body/div/todo-list/div/div/ul/li")]
        private IList<IWebElement> todosList;

        internal void SearchForTodoItem(string todo)
        {
            LogHelpers.Write("Searching for " + todo);
            txtSearch.SendKeys(todo);
            LogHelpers.Write(todo + " submitted");
        }

        internal int GetTodosListSize()
        {
            return todosList.Count();
        }
    }
}
