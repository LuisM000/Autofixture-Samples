using AutoFixture;
using AutofixtureSamples.Test.Builders;


namespace AutofixtureSamples.Test.Customizations
{
    public class SpanishUserCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new SpanishCountrySpecimenBuilder());
            fixture.Customize(new UserCustomization());
        }
    }
}
