using JetBrains.ReSharper.Psi.FSharp;
using JetBrains.ReSharper.PsiTests.parsing;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;

namespace Tests
{
  [TestFileExtension(FSharpProjectFileType.FS_EXTENSION)]
  public class FSharpParserTest : ParserTestBase
  {
    protected override string RelativeTestDataPath
    {
      get { return @"parsing"; }
    }

    [Test]
    public void TestModuleDeclaration01()
    {
      DoNamedTest();
    }

    [Test]
    public void TestTypeDeclaration01()
    {
      DoNamedTest();
    }

    [Test]
    public void TestTypeDeclaration02()
    {
      DoNamedTest();
    }

    [Test]
    public void TestTypeParameterConstraints01()
    {
      DoNamedTest();
    }

    [Test]
    public void TestUnfinishedConstructs01()
    {
      DoNamedTest();
    }
  }
}