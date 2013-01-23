using JetBrains.Application;
using JetBrains.ReSharper;
using JetBrains.ReSharper.Psi.FSharp.Parsing;
using JetBrains.Threading;
using System.Reflection;
using System.Collections.Generic;
using NUnit.Framework;


[SetUpFixture]
public class IsolatedReSharperTestEnvironmentAssembly : ReSharperTestEnvironmentAssembly
{
    public override IApplicationDescriptor CreateApplicationDescriptor()
    {
        return new IsolatedReSharperApplicationDescriptor();
    }

    private class IsolatedReSharperApplicationDescriptor : ReSharperApplicationDescriptor
    {
        public override string ProductName
        {
            get
            {
                // The product name is used to find settings under APPDATA. Leaving it at
                // ReSharper would use your normal ReSharper settings (+plugins!) while
                // running tests. This keeps them isolated
                return base.ProductName + "_Isolated";
            }
        }
    }
}



/// <summary>
/// Test environment. Must be in the global namespace.
/// </summary>
[SetUpFixture]
// ReSharper disable CheckNamespace
public class TestEnvironmentAssembly : IsolatedReSharperTestEnvironmentAssembly
// ReSharper restore CheckNamespace
{
  /// <summary>
  /// Gets the assemblies to load into test environment.
  /// Should include all assemblies which contain components.
  /// </summary>
  private static IEnumerable<Assembly> GetAssembliesToLoad()
  {
    yield return Assembly.GetExecutingAssembly();
    yield return typeof (FSharpLexer).Assembly;
  }

  public override void SetUp()
  {
    base.SetUp();
    ReentrancyGuard.Current.Execute(
      "LoadAssemblies",
      () => Shell.Instance.GetComponent<AssemblyManager>().LoadAssemblies(
        GetType().Name, GetAssembliesToLoad()));
  }

  public override void TearDown()
  {
    ReentrancyGuard.Current.Execute(
      "UnloadAssemblies",
      () => Shell.Instance.GetComponent<AssemblyManager>().UnloadAssemblies(
        GetType().Name, GetAssembliesToLoad()));
    base.TearDown();
  }
}
