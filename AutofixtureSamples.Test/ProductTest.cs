using System;
using AutoFixture;
using AutofixtureSamples.Test.Customizations;
using Xunit;
using Xunit.Sdk;

namespace AutofixtureSamples.Test
{
    public class ProductTest
    {
        [Fact]
        public void AllProducts_Are_DummyProduct_Test()
        {
            IFixture fixture = new Fixture().Customize(new DummyProductCustomization());

            var product = fixture.Create<Product>();

            Assert.Equal("Dummy Product", product.Name);
        }

        [Fact]
        public void AllProducts_Are_Not_DummyProductAndExpensive_Test()
        {
            IFixture fixture = new Fixture().Customize(new ExpensiveDummyProductCompositeCustomization());

            var product = fixture.Create<Product>();

            Assert.Throws<EqualException>(() =>
            {
                Assert.True(product.IsExpensive());
                Assert.Equal("Dummy Product", product.Name);
            });
        }

        [Fact]
        public void AllProducts_Are_DummyProductAndExpensive_Test()
        {
            IFixture fixture = new Fixture().Customize(new ExpensiveDummyProductCustomization());

            var product = fixture.Create<Product>();

            Assert.True(product.IsExpensive());
            Assert.Equal("Dummy Product", product.Name);
        }
    }
}
