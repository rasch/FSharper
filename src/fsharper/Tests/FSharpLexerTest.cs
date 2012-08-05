namespace Tests
{
  using NUnit.Framework;


  [TestFixture]
  public class FSharpLexerTest : FSharpLexerTestBase
  {
    [Test, TestCaseSource("files")]
    public void TestLexer(string file)
    {
      DoTestFile(file);
    }

    private readonly string[] files = new[]
      {
        "test1"
      };
  }
}