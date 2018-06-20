using System;
using AutoFixture;
namespace AutofixtureSamples.Test.Customizations
{
    public class DummyProductCustomization: ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customize<Product>(comp => comp.With(p => p.Name, "Dummy Product"));
        }
    }
}
