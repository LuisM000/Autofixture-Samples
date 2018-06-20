using System;
using AutoFixture.Kernel;
using System.Reflection;

namespace AutofixtureSamples.Test.Builders
{
    public class UserSpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            if(request is ParameterInfo parameterInfo &&
               parameterInfo.ParameterType == typeof(string))
            {
                if(parameterInfo.Name == "password")
                    return "leT455";
                if (parameterInfo.Name == "email")
                    return "emailAddress@email.com";
            }
            return new NoSpecimen();
        }
    }
}
