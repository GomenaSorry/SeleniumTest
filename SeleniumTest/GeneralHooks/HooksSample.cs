using TechTalk.SpecFlow;
using System;

namespace SeleniumTest.GeneralHooks
{
    [Binding]
    public sealed class HooksSample
    {

        // scenario and feature hooks can take tags to specify if the hook will run on the tag
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("BeforeTestRun Hook");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("AfterTestRun Hook");
        }

        [BeforeFeature()]
        public static void BeforeFeature()
        {
            Console.WriteLine("BeforeFeature Hook");
        }

        [AfterFeature()]
        public static void AfterFeature()
        {
            Console.WriteLine("AfterFeature Hook");
        }

        [BeforeScenarioBlock()]
        public static void BeforeScenario()
        {
            Console.WriteLine("BeforeScenario Hook");
        }

        [AfterScenarioBlock()]
        public static void AfterScenario()
        {
            Console.WriteLine("AfterScenario Hook");
        }
    }
}