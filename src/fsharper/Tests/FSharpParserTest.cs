using JetBrains.ReSharper.Psi.FSharp;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;

namespace Tests
{
    [TestFixture, Category("F# Parser")]
    [TestFileExtension(FSharpProjectFileType.FS_EXTENSION)]
    public class FSharpParserTest : ParserTestBase<FSharpLanguage>
    {
      protected override string RelativeTestDataPath
      {
        get { return @"parsing\fsharp"; }
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
      public void TestTypeDeclaration03_RecordType()
      {
        DoNamedTest();
      }
     
      [Test]
      public void TestTypeDeclaration04_UnionType()
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