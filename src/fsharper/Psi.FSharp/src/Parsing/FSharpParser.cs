using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.FSharp.Tree.Impl;

namespace JetBrains.ReSharper.Psi.FSharp.Parsing
{
  using System.Collections.Generic;
  using Psi.Parsing;
  using Psi.Tree;

  internal class FSharpParser : FSharpParserGenerated, IFSharpParser
  {
    private readonly ILexer<int> originalLexer;

    public FSharpParser(ILexer<int> lexer, IEnumerable<PreProcessingDirective> defines)
    {
      originalLexer = lexer;

      setLexer(originalLexer);
    }

    public IFile ParseFile()
    {
      return (FSharpFile)parseFSharpFile();
    }

    // TODO: Not really sure why this has to be abstract
    // but changing it changes the interface that gets generated
    public override TreeElement parseIdentifier()
    {
      if (myLexer.TokenType != FSharpTokenType.IDENTIFIER)
        throw new UnexpectedToken(ParserMessages.GetExpectedMessage(ParserMessages.GetString(ParserMessages.IDS__IDENTIFIER)));
      return createToken();
    }
  }
}