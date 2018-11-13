﻿using System;
using System.Threading.Tasks;

namespace ReCommendedExtension.Tests.test.data.Analyzers.AwaitQuickFixes
{
    public class AwaitForLocalFunctions
    {
        void Method()
        {
            async Task LocalFunction_WithConfigureAwait()
            {
                if (Environment.UserInteractive)
                {
                    Console.WriteLine();
                }

                await{caret} Task.Delay(10).ConfigureAwait(false);
            }
        }
    }
}