using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using GenericTestAutomationFramework.Base;

namespace MyPensionNewLayoutTest.BasicTests
{
    [TestFixture]
    public class Google : Hooks
    {

        [Test]
        public void OpenGoogleDotCom()
        {
            Hooks testSetUp = new MyPensionNewLayoutTest.Hooks();
            testSetUp.InitializeSettings();
            testSetUp.NavigateSite();

        }
    }
}
