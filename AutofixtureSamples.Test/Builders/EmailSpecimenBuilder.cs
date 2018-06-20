using System;
using System.Reflection;
using AutoFixture.Kernel;

namespace AutofixtureSamples.Test.Builders
{
    public class EmailSpecimenBuilder: ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            if (request is ParameterInfo parameterInfo &&
                parameterInfo.ParameterType == typeof(string) &&
                parameterInfo.Name == "email")
            {
                return "emailAddress@email.com";
            }
            return new NoSpecimen();
        }
    }
}
