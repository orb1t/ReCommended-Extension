﻿using System;
using System.Threading.Tasks;

namespace ReCommendedExtension.Tests.test.data.Analyzers.AwaitQuickFixes
{
    public class AwaitForLambdaFields
    {
        Func<Task<int>> LambdaField2_AsExpressionBodied_WithConfigureAwait = async () => await{caret} Task.FromResult(3).ConfigureAwait(false);
    }
}