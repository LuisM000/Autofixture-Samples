using System;
using AutoFixture;

namespace AutofixtureSamples.Test.Customizations
{
    public class ExpensiveProductCustomization: ICustomization
    {

        public void Customize(IFixture fixture)
        {
            fixture.Customize<Product>(comp => comp.With(p => p.Cost, double.MaxValue));
        }
    }
}
