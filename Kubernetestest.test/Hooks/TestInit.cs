using TechTalk.SpecFlow;

namespace Kubernetestest.test.Hooks
{
    [Binding]
    public sealed class TestInit
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void InitializeTest()
        {
            Console.WriteLine("Before test");
        }

        [BeforeFeature("myTableTest")]
        public static void BeforeFeatureTest()
        {
            Console.WriteLine("Before Feature Of Table Scenario");
        }

        [BeforeScenario("myTableTest")]
        public static void BeforeScenarioWithTag()
        {
            Console.WriteLine("Before my Table Scenario");
        }

        [AfterScenario("myTableTest")]
        public static void AfterScenario()
        {
            Console.WriteLine("After my Table Scenario");
        }
    }
}