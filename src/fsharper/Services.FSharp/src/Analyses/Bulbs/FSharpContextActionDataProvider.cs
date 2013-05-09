<<<<<<< HEAD
using JetBrains.ReSharper.Feature.Services.Bulbs;

namespace JetBrains.ReSharper.Feature.Services.FSharp
{
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
=======
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
>>>>>>> f9cb6ea3b49c223cfca7bf3672a80c06167d33c1
}