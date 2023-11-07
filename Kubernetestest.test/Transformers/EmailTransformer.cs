using AutoFixture;
using System.Net.Mail;

namespace Kubernetestest.test.Transformers
{
    [Binding]
    public class EmailTransformer
    {
        [StepArgumentTransformation("(.*) email")]
        public string GenerateDynamicEmailAddress(string email)
        {
            return email.Split('@')[0] +'@'+ GetRandomDomain();
        }

        private string GetRandomDomain() => new Fixture().Create<MailAddress>().Host;
    }
}
