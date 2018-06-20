using System;
using System.Reflection;
using AutoFixture.Kernel;

namespace AutofixtureSamples.Test.Builders
{
    public class SpanishCountrySpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
    {
        if (request is ParameterInfo parameterInfo &&
            parameterInfo.ParameterType == typeof(string) &&
            parameterInfo.Name == "name")
        {
            return "ES";
        }
        return new NoSpecimen();
    }
}
}