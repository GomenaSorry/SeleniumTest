using System;
using TechTalk.SpecFlow;
using SeleniumTest.ComponentHelper;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTest.PageObject;
using SeleniumTest.Settings;

namespace SeleniumTest.StepDefinitions
{
    [Binding]
    public class HookSampleStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        public HookSampleStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I have entered (.*) in the calculator")]
        public void GivenIHaveEnteredInTheCalculator(int number)
        {
            // throw new NotImplementedException();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            // pending
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            // pending
        }


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
           // pending
        }

        [AfterScenario()]
        public void AfterScenario()
        {
            Console.WriteLine("Title : {0}", _scenarioContext.ScenarioInfo.Title);
            // Console.WriteLine("Description : {0}", _scenarioContext.TestError);
            Console.WriteLine("Tags : {0}", _scenarioContext.ScenarioInfo.Tags);
            if (_scenarioContext.TestError != null)
            {
                string name = _scenarioContext.ScenarioInfo.Title + ".jpeg";
                GenericHelper.TakeScreenShot(name);
                Console.WriteLine(_scenarioContext.TestError.Message);
            }
        }
    }
}
