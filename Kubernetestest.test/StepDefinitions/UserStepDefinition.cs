using AutoFixture;

namespace Kubernetestest.test.StepDefinitions
{
    [Binding]
    public class UserStepDefinition
    {
        [Given(@"I Enter Random User Data")]
        public void GivenIEnterRandomUserData()
        {
            var Person = new Fixture().Create<User>();
            Console.WriteLine($"The user {Person.Name} has email {Person.Email} With the address {Person.Address} and phone is {Person.Phone}");
        }

        [Given(@"I Input dynamic domain for (.*) email")]
        public void GivenIInputDynamicDomainForKamyarGmail_Com_InEmail(string email)
        {
            Console.WriteLine($"The random email is {email}");
        }
    }
    public record User
    {
        public string Name { get; init; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Phone{ get; set; }
    }
}
