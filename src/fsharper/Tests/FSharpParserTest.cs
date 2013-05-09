<<<<<<< HEAD
﻿using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.Psi.ExtensionsAPI;
using JetBrains.ReSharper.Psi.FSharp;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;


namespace Tests
{
  [TestFixture, Category("F# Parser")]
  public class FSharpParserTest  : BaseTestWithSingleProject
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
      var sourceFile = ParserService.ParseFileDebug(GetTestDataFilePath2(filename + Extension), 
        FSharpLanguage.Instance, Solution.PsiModules().GetPrimaryPsiModule(project));
      
      ExecuteWithGold(filename, sw =>
      {
        if (sourceFile != null && !DebugUtil.HasErrorElements(sourceFile))
          sw.WriteLine("SUCCESS");
        else
          sw.WriteLine("FAILURE");
      });
=======
﻿using JetBrains.ReSharper.Psi.FSharp;
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
>>>>>>> f9cb6ea3b49c223cfca7bf3672a80c06167d33c1
    }
  }
}