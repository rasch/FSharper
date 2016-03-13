using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;

using NUnit.Framework;

[ZoneDefinition]
public interface IFSharperTestZone : ITestsZone, IRequire<PsiFeatureTestZone>
{
}


[SetUpFixture]
public class IsolatedReSharperTestEnvironmentAssembly : ExtensionTestEnvironmentAssembly<IFSharperTestZone>
{
}