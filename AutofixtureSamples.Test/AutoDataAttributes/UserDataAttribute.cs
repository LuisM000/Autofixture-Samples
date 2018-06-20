using AutofixtureSamples.Test.Customizations;
using AutoFixture;
using AutoFixture.Xunit2;


namespace AutofixtureSamples.Test.AutoDataAttributes
{
    public class UserDataAttribute: AutoDataAttribute
    {
        public UserDataAttribute():
            base(()=>new Fixture().Customize(new UserCustomization()))
        {
        }
    }
}