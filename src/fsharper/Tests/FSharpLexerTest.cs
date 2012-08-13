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
      "raise",
      "test1",
      "union-type-1",
      "union-type-2-generic-recursive",
      "union-type-3-generic-recursive"
    };
  }
}