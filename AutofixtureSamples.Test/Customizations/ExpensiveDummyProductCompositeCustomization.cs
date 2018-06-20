using System;
using AutoFixture;

namespace AutofixtureSamples.Test.Customizations
{
    public class ExpensiveDummyProductCompositeCustomization : CompositeCustomization
    {
        public ExpensiveDummyProductCompositeCustomization() :
            base(new DummyProductCustomization(), new ExpensiveProductCustomization())
        {
        }
    }
}
