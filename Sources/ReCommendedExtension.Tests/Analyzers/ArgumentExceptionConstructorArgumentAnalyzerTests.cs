﻿using JetBrains.Application.Settings;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Psi;
using NUnit.Framework;
using ReCommendedExtension.Highlightings;

namespace ReCommendedExtension.Tests.Analyzers
{
    [TestFixture]
    public sealed class ArgumentExceptionConstructorArgumentAnalyzerTests : HighlightingTestBaseWithAnnotationAssemblyReference
    {
        protected override string RelativeTestDataPath => @"Analyzers\ArgumentExceptionConstructorArgument";

        protected override bool HighlightingPredicate(IHighlighting highlighting, IPsiSourceFile sourceFile, IContextBoundSettingsStore settingsStore)
            => highlighting is ArgumentExceptionConstructorArgumentHighlighting;

        [Test]
        public void TestArgumentExceptionConstructorArgument() => DoNamedTest2();
    }
}