using TechTalk.SpecFlow.Assist;

namespace Kubernetestest.test.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            throw new PendingStepException();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }

      

        [Given(@"I Input the following numbers to the calculator")]
        public void GivenIInputTheFollowingNumbersToTheCalculator(Table table)
        {
            dynamic datas = table.CreateDynamicSet();
            foreach (dynamic data in datas) {
                Console.WriteLine($"The number is {data.Numbers}");
            }
        }

        [When(@"the Three numbers are added")]
        public void WhenTheThreeNumbersAreAdded()
        {
            Console.WriteLine($"{nameof(WhenTheThreeNumbersAreAdded)}");
        }

        [Then(@"I see the result and few more details")]
        public void ThenISeeTheResultAndFewMoreDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine($"the result is {data.Result} with the logo {data.Logo}");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            Console.WriteLine($"{nameof(ThenTheResultShouldBe)}");
        }
    }
}