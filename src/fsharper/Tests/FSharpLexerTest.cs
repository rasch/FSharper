namespace Tests
{
  using System.IO;
  using JetBrains.ReSharper.Psi.FSharp.Parsing;
  using JetBrains.ReSharper.Psi.Parsing;
  using JetBrains.ReSharper.PsiTests.Lexing;
  using JetBrains.Text;
  using NUnit.Framework;

  [TestFixture]
  public class FSharpLexerTest : LexerTestBase
  {
    [Test] public void TestLexer()
    {
      DoTestFile(test1dot);
    }

    protected override ILexer CreateLexer(StreamReader sr)
    {
      return new FSharpLexer(new StringBuffer(sr.ReadToEnd()));
    }

    protected override string RelativeTestDataPath
    {
      get { return @"lexing\fsharp"; }
    }
  }
}