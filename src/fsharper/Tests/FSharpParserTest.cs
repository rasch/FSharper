using JetBrains.ReSharper.Psi.CSharp;
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
    }
  }
}