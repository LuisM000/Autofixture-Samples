using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;

namespace AutofixtureSamples.Test.Customizations
{
    public class ExpensiveDummyProductCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customize<Product>(comp => 
                comp.With(p => p.Name, "Dummy Product").
                    With(p=>p.Cost, double.MaxValue));
        }
    }
}


