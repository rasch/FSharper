using JetBrains.Annotations;
using JetBrains.ReSharper.Psi.FSharp.Impl;
using JetBrains.ReSharper.Psi.Parsing;

namespace JetBrains.ReSharper.Psi.FSharp.Parsing
{
  internal class FSharpFilteringLexer : FilteringLexer, ILexer<int>
  {
    private readonly FSharpPreprocessor myPreprocessor;

    public FSharpFilteringLexer(ILexer<int> lexer, [CanBeNull] FSharpPreprocessor preProcessor)
      : base(lexer)
    {
      myPreprocessor = preProcessor;
    }

    protected override bool Skip(TokenNodeType tokenType)
    {
      return FSharpLanguageService.WHITESPACE_OR_COMMENT[tokenType];
      //|| myPreprocessor != null && (...);
    }

    public ILexer OriginalLexer
    {
      get { return myLexer; }
    }

    int ILexer<int>.CurrentPosition
    {
      get { return ((ILexer<int>)myLexer).CurrentPosition; }
      set { ((ILexer<int>)myLexer).CurrentPosition = value; }
    }
  }

  //TODO
  internal class FSharpPreprocessor
  {
  }
}