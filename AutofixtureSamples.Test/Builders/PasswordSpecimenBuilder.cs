﻿using System;
using System.Reflection;
using AutoFixture.Kernel;

namespace AutofixtureSamples.Test.Builders
{
    public class PasswordSpecimenBuilder: ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            if (request is ParameterInfo parameterInfo &&
                parameterInfo.ParameterType == typeof(string) &&
                parameterInfo.Name == "password")
            {
                return "leT455";
            }
            return new NoSpecimen();
        }
    }
}