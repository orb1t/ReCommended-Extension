﻿using System;
using System.Threading.Tasks;

namespace ReCommendedExtension.Tests.test.data.Analyzers.AwaitQuickFixes
{
    public class AwaitForLocalFunctions
    {
        void Method()
        {
            async Task<int> LocalFunction2_AsExpressionBodied() => await{caret} Task.FromResult(3);
        }
    }
}