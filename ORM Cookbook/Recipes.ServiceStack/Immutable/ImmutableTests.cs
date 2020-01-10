﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes.Immutable;

namespace Recipes.ServiceStack.Immutable
{
    [TestClass]
    public class ImmutableTests : ImmutableTests<ReadOnlyEmployeeClassification>
    {
        protected override ReadOnlyEmployeeClassification CreateWithValues(string name, bool isExempt, bool isEmployee)
        {
            return new ReadOnlyEmployeeClassification(0, name, isExempt, isEmployee);
        }

        protected override IImmutableRepository<ReadOnlyEmployeeClassification> GetRepository()
        {
            return new ImmutableRepository(Setup.DbConnectionFactory);
        }

        protected override ReadOnlyEmployeeClassification UpdateWithValues(ReadOnlyEmployeeClassification original, string name, bool isExempt, bool isEmployee)
        {
            if (original == null)
                throw new ArgumentNullException(nameof(original), $"{nameof(original)} is null.");

            return new ReadOnlyEmployeeClassification(original.Id, name, isExempt, isEmployee);
        }
    }
}