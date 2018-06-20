using AutoFixture;
using AutofixtureSamples.Test.Builders;

namespace AutofixtureSamples.Test.Customizations
{
    public class UserCustomization : ICustomization
    {       
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new PasswordSpecimenBuilder());
            fixture.Customizations.Add(new EmailSpecimenBuilder());
        }
    }
}
