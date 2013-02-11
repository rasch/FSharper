namespace JetBrains.ReSharper.Feature.Services.FSharp
{
  using System;
  using ProjectModel;
  using ReSharper.Psi;
  using ReSharper.Psi.FSharp;
  using ReSharper.Psi.FSharp.Tree;
  using TextControl;

  public class FSharpContextActionDataProvider : /* CachedContextActionDataProvider<IFSharpFile>, */ IFSharpContextActionDataProvider
  {
    public FSharpContextActionDataProvider(ISolution solution, ITextControl textControl, IFSharpFile psiFile)
    {
      // todo
    }

    public FSharpElementFactory ElementFactory { get { return FSharpElementFactory.GetInstance(PsiModule); } }

    public IPsiModule PsiModule
    {
      get
      {
        throw new NotImplementedException();
      }
    }

  }
}