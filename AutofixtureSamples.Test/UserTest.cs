using AutofixtureSamples.Test.AutoDataAttributes;
using AutoFixture;
using AutofixtureSamples.Test.Builders;
using AutofixtureSamples.Test.Customizations;
using Xunit;


namespace AutofixtureSamples.Test
{
    public class UserTest
    {
        [Fact]
        public void UserIsCreated_With_UserSpecimenBuilder_Test()
        {
            Fixture fixture = new Fixture();
            fixture.Customizations.Add(new UserSpecimenBuilder());

            User user = fixture.Create<User>();

            Assert.NotNull(user);
        }

        [Fact]
        public void UserIsCreated_With_MultipleSpecimenBuilder_Test()
        {
            Fixture fixture = new Fixture();
            fixture.Customizations.Add(new PasswordSpecimenBuilder());
            fixture.Customizations.Add(new EmailSpecimenBuilder());

            User user = fixture.Create<User>();

            Assert.NotNull(user);
        }

        [Fact]
        public void UserIsCreated_With_UserCustomization_Test()
        {
            IFixture fixture = new Fixture().Customize(new UserCustomization());

            User user = fixture.Create<User>();

            Assert.NotNull(user);
        }


        [Theory,UserDataAttribute]
        public void UserIsCreated_With_UserDataAttribute_Test(User user)
        {
            Assert.NotNull(user); 
        }


        [Fact]
        public void CreateSpanishUser_Test()
        {
            IFixture fixture = new Fixture().Customize(new SpanishUserCustomization());

            User user = fixture.Create<User>();

            Assert.Equal("ES", user.Country.Name);
        }


        [Fact]
        public void CreateAdultUser_Test()
        {
            IFixture fixture = new Fixture().Customize(new AdultUserCustomization());

            User user = fixture.Create<User>();

            Assert.True(user.IsAdult());
        }

        [Fact]
        public void CreateUser_With_DummyProduct_Test()
        {
            IFixture fixture = new Fixture().Customize(new UserWithDummyProductCustomization());

            User user = fixture.Create<User>();

            Assert.Equal("Dummy Product", user.Product.Name);
        }

    }
 
}
