namespace JetBrains.ReSharper.Feature.Services.FSharp
{
  using JetBrains.ReSharper.Feature.Services.ContextActions;
  using ProjectModel;
  using ReSharper.Psi.FSharp;
  using ReSharper.Psi.FSharp.Tree;
  using TextControl;

  public class FSharpContextActionDataProvider : CachedContextActionDataProviderBase<IFSharpFile>, IFSharpContextActionDataProvider
  {
    public FSharpContextActionDataProvider(ISolution solution, ITextControl textControl, IFSharpFile file)
      : base(solution, textControl, file)
    {
      
    }

    public FSharpElementFactory ElementFactory { get { return FSharpElementFactory.GetInstance(PsiModule); } }
  }
}