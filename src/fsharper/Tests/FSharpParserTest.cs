using JetBrains.ReSharper.Psi.ExtensionsAPI;
using JetBrains.ReSharper.Psi.FSharp;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;
using System.Linq;
using JetBrains.ReSharper.Psi.Modules;

namespace Tests
{
    using JetBrains.ReSharper.Psi;

    [TestFixture, Category("F# Parser")]
    [TestFileExtension(FSharpProjectFileType.FS_EXTENSION)]
    public class FSharpParserTest : ParserTestBase<FSharpLanguage>
    {
      private string filename;
      protected override string RelativeTestDataPath
      {
        get { return @"parsing\fsharp"; }
      }

      protected override void DoOneTest(string filename)
      {
        this.filename = filename;
        DoTestSolution(filename);
      }

      protected override void DoTest(JetBrains.ProjectModel.IProject project)
      {
        var sourceFile = ParserService.ParseFileDebug(
          GetTestDataFilePath2(TestName),
          FSharpLanguage.Instance,
          Solution.PsiModules().GetPrimaryPsiModule(null, project.TargetFrameworkIds.Single()));

         ExecuteWithGold(
          filename,
          sw =>
          {
            if (sourceFile != null && !DebugUtil.HasErrorElements(sourceFile)) sw.WriteLine("SUCCESS");
            else sw.WriteLine("FAILURE");
          });
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