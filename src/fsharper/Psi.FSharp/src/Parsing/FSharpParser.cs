using System;
using JetBrains.Application;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.FSharp.Gen;
using JetBrains.ReSharper.Psi.FSharp.Impl.Tree;
using JetBrains.ReSharper.Psi.FSharp.Tree;

namespace JetBrains.ReSharper.Psi.FSharp.Parsing
{
  using System.Collections.Generic;
  using Psi.Parsing;
  using Psi.Tree;

  internal class FSharpParser : FSharpParserGenerated, IFSharpParser
  {
    private readonly ILexer<int> myOriginalLexer;
    private readonly SeldomInterruptChecker myCheckForInterrupt;

    public FSharpParser(ILexer<int> lexer, IEnumerable<PreProcessingDirective> defines)
    {
      myOriginalLexer = lexer;
      myCheckForInterrupt = new SeldomInterruptChecker();
      setLexer(new FSharpFilteringLexer(lexer, null));
    }

    private void InsertMissingTokens(TreeElement result, bool trimMissingTokens)
    {
      FSharpMissingTokensInserter.Run(result, myOriginalLexer, this, trimMissingTokens, myCheckForInterrupt);
    }

    public IFile ParseFile()
    {
      var file = parseFSharpFile();
      InsertMissingTokens(file, false);
      return (IFSharpFile) file;
    }

    private static bool IsIdentifier(NodeType tokenType)
    {
      return tokenType == FSharpTokenType.IDENTIFIER;
    }

    public override TreeElement parseIdentifier()
    {
      if (!IsIdentifier(myLexer.TokenType))
        throw new UnexpectedToken(ParserMessages.GetExpectedMessage(ParserMessages.GetString(ParserMessages.IDS__IDENTIFIER)));
      return createToken();
    }

    public override TreeElement parseFSharpFile()
    {
      var result = TreeElementFactory.CreateCompositeElement(ElementType.F_SHARP_FILE);
      var tokenType = myLexer.TokenType;
      if (tokenType == FSharpTokenType.NAMESPACE_KEYWORD)
      {
        while (tokenType == FSharpTokenType.NAMESPACE_KEYWORD)
        {
          result.AppendNewChild(parseNamespaceDeclaration());
          tokenType = myLexer.TokenType;
        }
      }
      else if (tokenType == FSharpTokenType.MODULE_KEYWORD)
      {
        result.AppendNewChild(parsePrimaryModuleDeclaration());
      }
      else
      {
        result.AppendNewChild(parseAnonymousModuleDeclaration());
      }
      return result;
    }

    public override TreeElement parsePrimaryModuleDeclaration()
    {
      var result = TreeElementFactory.CreateCompositeElement(ElementType.PRIMARY_MODULE_DECLARATION);
      try
      {
        result.AppendNewChild(match(FSharpTokenType.MODULE_KEYWORD));
        var qualifiedNamespaceName = (IQualifiedNamespaceUsage)parseQualifiedNamespaceUsage();
        result.AppendNewChild((TreeElement)qualifiedNamespaceName.Qualifier);
        result.AppendNewChild((TreeElement)qualifiedNamespaceName.Dot);
        result.AppendNewChild((TreeElement)qualifiedNamespaceName.NameIdentifier);
        result.AppendNewChild(parseModuleBody());
      }
      catch (SyntaxError e)
      {
        if (e.ParsingResult != null)
          result.AppendNewChild(e.ParsingResult);
        e.ParsingResult = result;
        handleErrorInModuleDeclaration(result, e);
      }
      return result;
    }

    private CompositeElement parseAnyQualifiedUsage(CompositeNodeType compositeElementType)
    {
      var result = TreeElementFactory.CreateCompositeElement(compositeElementType);
      result.AppendNewChild(parseIdentifier());

      while (myLexer.TokenType == FSharpTokenType.DOT)
      {
        var qualifiedName = TreeElementFactory.CreateCompositeElement(compositeElementType);
        qualifiedName.AppendNewChild(result);
        qualifiedName.AppendNewChild(match(FSharpTokenType.DOT));
        qualifiedName.AppendNewChild(parseIdentifier());

        result = qualifiedName;
      }

      return result;
    }

    public override TreeElement parseQualifiedNamespaceUsage()
    {
      return parseAnyQualifiedUsage(ElementType.QUALIFIED_NAMESPACE_USAGE);
    }

    public override TreeElement parseQualifiedTypeUsage()
    {
      var result = parseAnyQualifiedUsage(ElementType.QUALIFIED_TYPE_USAGE);
      if (myLexer.TokenType == FSharpTokenType.LESS)
      {
        result.AppendNewChild(parseTypeArgumentList());
      }
      return result;
    }
  }

  internal class FSharpMissingTokensInserter
  {
    public static void Run(TreeElement result, ILexer<int> myOriginalLexer, FSharpParser fSharpParser, bool trimMissingTokens, SeldomInterruptChecker myCheckForInterrupt)
    {
      //TODO
    }
  }
}