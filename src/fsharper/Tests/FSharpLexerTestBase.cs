using System;
using System.IO;
using System.Text;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.FSharp.Parsing;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.TestFramework;
using JetBrains.Text;
using JetBrains.Util;
using JetBrains.Util.Text;
using NUnit.Framework;

namespace Tests
{
  [Category("Lexer")]
  [TestFileExtension(".fs")]
  public abstract class FSharpLexerTestBase : BaseTestWithSingleProject
  {
    protected override String RelativeTestDataPath
    {
      get { return @"lexing\fsharp"; }
    }

    protected ILexer CreateLexer(StreamReader sr)
    {
      return new FSharpLexer(new StringBuffer(sr.ReadToEnd()));
    }

    protected ILexer CreateLexer(IProjectFile projectFile, StreamReader sr)
    {
      var lexer = CreateLexer(sr);
      if (lexer != null)
        return lexer;
      var buffer = new StringBuffer(sr.ReadToEnd());
      var sourceFile = projectFile.ToSourceFile();
      Assert.IsNotNull(sourceFile, "sourceFile == null");
      var lexerFactory = PsiProjectFileTypeCoordinator.Instance.CreateLexerFactory(Solution, sourceFile, buffer);
      Assert.IsNotNull(lexerFactory, "lexerFactory == null");
      return lexerFactory.CreateLexer(buffer);
    }

    private void CheckOutput(IProjectFile projectFile, Encoding encoding)
    {
      Assert.IsNotNull(projectFile, "projectFile == null");
      ExecuteWithGold(projectFile.Location.Name, sw =>
        {
          using (var sr = new StreamReader(projectFile.Location.OpenFileForReadingExclusive(), encoding, true))
          {
            var lexer = CreateLexer(projectFile, sr);
            int position = 0;
            lexer.Start();
            while (lexer.TokenType != null)
            {
              Assert.AreEqual(lexer.TokenStart, position, "Token start error. Expected: {0}, actual: {1}", position, lexer.TokenStart);
              position = lexer.TokenEnd;
              WriteToken(sw, lexer);
              lexer.Advance();
            }
            Assert.AreEqual(lexer.Buffer.Length, position, "position == lexer.Buffer.Length");
          }
        });
    }

    protected virtual void WriteToken(TextWriter writer, ILexer lexer)
    {
      writer.WriteLine(lexer.TokenType);
    }

    private string myFileName;
    private Encoding myEncoding;

    protected void DoTestFile(string filename, Encoding encoding = null)
    {
      myFileName = filename + Extension;
      myEncoding = encoding ?? EncodingUtil.CP1251;
      DoTestSolution(myFileName);
    }

    protected override void DoOneTest(string testName)
    {
      DoTestFile(testName);
    }

    protected override void DoTest(IProject testProject)
    {
      CheckOutput(GetProjectFile(myFileName), myEncoding);
    }
  }
}