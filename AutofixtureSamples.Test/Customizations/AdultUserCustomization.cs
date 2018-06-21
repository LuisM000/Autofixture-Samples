using System;
using AutoFixture;

namespace AutofixtureSamples.Test.Customizations
{
    public class AdultUserCustomization : ICustomization
    {
       
        public void Customize(IFixture fixture)
        {
            fixture.Customize(new SpanishUserCustomization());
            fixture.Customize<User>(comp => comp.With(p => p.BornDate, 
                                    DateTime.Now.AddYears(-25)));
        }
    }
}
