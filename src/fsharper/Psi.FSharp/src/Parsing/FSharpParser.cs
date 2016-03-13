using System;
using System.Collections.Generic;
using JetBrains.Application;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.FSharp.Gen;
using JetBrains.ReSharper.Psi.FSharp.Impl.Tree;
using JetBrains.ReSharper.Psi.FSharp.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using JetBrains.Util;

namespace JetBrains.ReSharper.Psi.FSharp.Parsing
{  
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

  internal class FSharpMissingTokensInserter : MissingTokenInserterBase
  {
    private readonly ILexer lexer;

    private FSharpMissingTokensInserter(ILexer lexer, ITokenOffsetProvider offsetProvider, SeldomInterruptChecker interruptChecker)
      : base(offsetProvider, interruptChecker, myWhitespaceIntern)
    {
      this.lexer = lexer;
    }

    public static void Run(TreeElement node, ILexer lexer, ITokenOffsetProvider offsetProvider, bool trimTokens, SeldomInterruptChecker interruptChecker)
    {
      Assertion.Assert(node.parent != null, "node.parent!=null");
      var root = node as CompositeElement;
      if (root == null) return;
      var inserter = new FSharpMissingTokensInserter(lexer,
        offsetProvider, interruptChecker);
      lexer.Start();

      if (trimTokens)
      {
        using (var container = new DummyContainer(root))
          inserter.Run(container);
      }
      else
      {
        var terminator = new EofToken(lexer.Buffer);
        root.AppendNewChild(terminator);
        inserter.Run(root);
        root.DeleteChildRange(terminator, terminator);
      }
    }

    private sealed class EofToken : BindedToBufferLeafElement
    {
      public EofToken(IBuffer buffer)
        : base(FSharpTokenType.EOF, buffer, new TreeOffset(buffer.Length), new TreeOffset(buffer.Length))
      {
      }

      public override PsiLanguageType Language
      {
        get { return FSharpLanguage.Instance; }
      }
    }

    private sealed class DummyContainer : CompositeElement, IDisposable
    {
      public DummyContainer(TreeElement element)
      {
        AppendNewChild(element);
      }

      public override NodeType NodeType
      {
        get { return DummyNodeType.Instance; }
      }

      public override PsiLanguageType Language
      {
        get { return FSharpLanguage.Instance; }
      }

      public void Dispose()
      {
        DeleteChildRange(firstChild, firstChild);
      }

      private sealed class DummyNodeType : CompositeNodeType
      {
        public static readonly NodeType Instance = new DummyNodeType();

        private DummyNodeType()
          : base("DummyContainer", 0)
        {
        }

        //public override PsiLanguageType LanguageType { get { return UnknownLanguage.Instance; } }
        public override CompositeElement Create()
        {
          throw new InvalidOperationException();
        }
      }
    }

    protected override void ProcessLeafElement(TreeElement element)
    {
      int leafOffset = GetLeafOffset(element).Offset;

      // Check if some tokens are missed before this leaf
      if (lexer.TokenType != null && lexer.TokenStart < leafOffset)
      {
        // Find out the right place to insert tokens to
        TreeElement anchor = element;
        CompositeElement parent = anchor.parent;
        while (anchor == parent.firstChild && parent.parent != null)
        {
          anchor = parent;
          parent = parent.parent;
        }

        // proceed with inserting tokens
        while (lexer.TokenType != null && lexer.TokenStart < leafOffset)
        {
          LeafElementBase token = CreateMissingToken();

          parent.AddChildBefore(token, anchor);

          lexer.Advance();
        }
      }

      // skip all tokens which lie inside given leaf element
      int leafEndOffset = leafOffset + element.GetTextLength();
      if ((element is IClosedChameleonBody) && (lexer is CachingLexer))
      {
        ((CachingLexer)lexer).FindTokenAt(leafEndOffset);
      }
      else
      {
        while (lexer.TokenType != null && lexer.TokenStart < leafEndOffset)
        {
          lexer.Advance();
        }
      }
    }

    private LeafElementBase CreateMissingToken()
    {
      TokenNodeType tokenType = lexer.TokenType;
      if (tokenType == FSharpTokenType.WHITE_SPACE || tokenType == FSharpTokenType.NEW_LINE)
      {
        string text = lexer.GetCurrTokenText();
        if (tokenType == FSharpTokenType.WHITE_SPACE)
        {
          return new Whitespace(myWhitespaceIntern.Intern(text));
        }
        return new NewLine(text);
      }

      return TreeElementFactory.CreateLeafElement(lexer);
    }
  }
}