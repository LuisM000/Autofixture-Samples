using AutoFixture;

namespace AutofixtureSamples.Test.Customizations
{
    public class UserWithDummyProductCustomization : CompositeCustomization
    {
        public UserWithDummyProductCustomization() :
            base(new UserCustomization(), new DummyProductCustomization())
        {

        }

    }
}