using JetBrains.ReSharper.PsiTests.Lexing;
using NUnit.Framework;

namespace Tests
{
  public class LexerTests : LexerTestBase
  {
    [Test, TestCaseSource("Files")]
    public void Test(string filename)
    {
      DoTestFile(filename);
    }

    public string[] Files =
      {
        //"lexer01.fs"
      };
  }
}