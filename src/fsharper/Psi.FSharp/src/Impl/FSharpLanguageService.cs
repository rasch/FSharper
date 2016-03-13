namespace JetBrains.ReSharper.Psi.FSharp.Impl
{
  using System.Collections.Generic;
  using ExtensionsAPI.Caches2;
  using ExtensionsAPI.Tree;

  using JetBrains.ReSharper.Psi.Modules;

  using Parsing;
  using Psi.Parsing;
  using Psi.Tree;
  using Text;
  using JetBrains.Util;

  [Language(typeof(FSharpLanguage))]
  public class FSharpLanguageService : LanguageService
  {
    public FSharpLanguageService(PsiLanguageType psiLanguageType, IConstantValueService constantValueService)
      : base(psiLanguageType, constantValueService)
    {
    }

    public override ILexerFactory GetPrimaryLexerFactory()
    {
      return new FSharpLexerFactory();
    }

    public override ILexer CreateFilteringLexer(ILexer lexer)
    {
      return new FSharpFilteringLexerWithoutPreprocessorState(lexer);
    }

    public override IParser CreateParser(ILexer lexer, IPsiModule module, IPsiSourceFile sourceFile)
    {
      return CreateParser(lexer,
                          module == null || sourceFile == null
                            ? EmptyList<PreProcessingDirective>.InstanceList
                            : sourceFile.Properties.GetDefines());
    }

    public IFSharpParser CreateParser(ILexer lexer, IEnumerable<PreProcessingDirective> defines)
    {
      var typedLexer = (lexer as ILexer<int>) ?? lexer.ToCachingLexer();
      return new FSharpParser(typedLexer, defines);
    }

    public override ILanguageCacheProvider CacheProvider
    {
      get { return null; }
    }

    public override bool IsCaseSensitive
    {
        get { return true; }
    }

    public override bool SupportTypeMemberCache
    {
      get { return false; }
    }

    public override ITypePresenter TypePresenter
    {
      get { return null; }
    }

    private class FSharpLexerFactory : ILexerFactory
    {
      public ILexer CreateLexer(IBuffer buffer)
      {
        return new FSharpLexer(buffer);
      }
    }

    internal static readonly NodeTypeSet WHITESPACE_OR_COMMENT = new NodeTypeSet
      (
        FSharpTokenType.WHITE_SPACE,
        FSharpTokenType.NEW_LINE,
        FSharpTokenType.END_OF_LINE_COMMENT,
        FSharpTokenType.C_STYLE_COMMENT
      );

    private class FSharpFilteringLexerWithoutPreprocessorState : FilteringLexer
    {
      public FSharpFilteringLexerWithoutPreprocessorState(ILexer lexer)
        : base(lexer)
      {
      }

      protected override bool Skip(TokenNodeType tokenType)
      {
        return WHITESPACE_OR_COMMENT[tokenType];
      }
    }
  }
}