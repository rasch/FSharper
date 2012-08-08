using System;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.FSharp.Tree;

namespace JetBrains.ReSharper.Psi.FSharp.Parsing
{
  using System.Collections.Generic;
  using Psi.Parsing;
  using Psi.Tree;

  internal class FSharpParser : /* FSharpParserGenerated, */ IFSharpParser
  {
    private ILexer<int> originalLexer;
    private LexerTokenIntern lexerTokenIntern;

    public FSharpParser(ILexer<int> lexer, IEnumerable<PreProcessingDirective> defines)
    {
      originalLexer = lexer;
      lexerTokenIntern = new LexerTokenIntern();
    }

    public IFile ParseFile()
    {
      return null;
    }
  }
}