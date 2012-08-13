namespace JetBrains.ReSharper.Feature.Services.FSharp
{
  using DocumentModel;
  using ProjectModel;
  using Bulbs;
  using ReSharper.Psi;
  using ReSharper.Psi.FSharp;
  using ReSharper.Psi.FSharp.Tree;
  using TextControl;

  [ContextActionDataBuilder(typeof(IFSharpContextActionDataProvider))]
  public class FSharpContextActionDataBuilder : IContextActionDataBuilder
  {
    public IContextActionDataProvider Build(ISolution solution, ITextControl textControl)
    {
      if (!solution.GetPsiServices().CacheManager.IsIdle)
        return null;

      var projectFile = textControl.Document.GetPsiSourceFile(solution);
      if (projectFile == null || !projectFile.IsValid())
        return null;
      var psiFile = projectFile.GetPsiFile<FSharpLanguage>(new DocumentRange(textControl.Document, textControl.Caret.Offset())) as IFSharpFile;
      if (psiFile == null || !psiFile.IsValid() || !psiFile.Language.Is<FSharpLanguage>())
        return null;

      // todo
      //return new FSharpContextActionDataProvider(solution, textControl, psiFile);
      return null;
    }
  }
}