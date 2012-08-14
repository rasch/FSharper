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
      "module-decl-1",
      "module-decl-2",
      "namespace-decl-1",
      "namespace-decl-2",
      "open-directive-1",
      "open-directive-2",
      "open-directive-3",
      "raise",
      "test1",
      "union-type-1",
      "union-type-2-generic-recursive",
      "union-type-3-generic-recursive"
    };
  }
}