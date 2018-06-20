using System;
using AutoFixture;

namespace AutofixtureSamples.Test.Customizations
{
    public class AdultUserCustomization : ICustomization
    {
       
        public void Customize(IFixture fixture)
        {
            fixture.Customize(new SpanishUserCustomization());
            fixture.Customize<User>(comp => comp.With(p => p.BornDate, new DateTime(1989, 1, 1)));
        }
    }
}
