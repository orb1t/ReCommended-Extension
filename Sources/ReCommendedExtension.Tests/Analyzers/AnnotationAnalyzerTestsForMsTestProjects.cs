using System.Diagnostics.CodeAnalysis;
using JetBrains.Application.Settings;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.FeaturesTestFramework.Daemon;
using JetBrains.ReSharper.Psi;
using NUnit.Framework;
using ReCommendedExtension.Highlightings;

namespace ReCommendedExtension.Tests.Analyzers
{
    [TestFixture]
    public sealed class AnnotationAnalyzerTestsForMsTestProjects : CSharpHighlightingTestBase
    {
        protected override string RelativeTestDataPath => @"Analyzers\Annotation";

        protected override bool HighlightingPredicate(IHighlighting highlighting, IPsiSourceFile sourceFile, IContextBoundSettingsStore settingsStore)
            => highlighting is MissingSuppressionJustificationHighlighting;

        [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
        protected override void DoTest(IProject project)
        {
            project.PatchProjectAddMsTestProjectFlavor();

            base.DoTest(project);
        }

        [Test]
        public void TestSuppressMessage_TestProject() => DoNamedTest2();
    }
}