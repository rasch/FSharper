namespace JetBrains.ReSharper.Feature.Services.FSharp
{
  using DocumentModel;
  using ProjectModel;

  using JetBrains.ReSharper.Feature.Services.ContextActions;
  using JetBrains.ReSharper.Psi.Files;

  using ReSharper.Psi;
  using ReSharper.Psi.FSharp;
  using ReSharper.Psi.FSharp.Tree;
  using TextControl;

  [ContextActionDataBuilder(typeof(IFSharpContextActionDataProvider))]
  public class FSharpContextActionDataBuilder : IContextActionDataBuilder
  {
    public IContextActionDataProvider Build(ISolution solution, ITextControl textControl)
    {
      if (!solution.GetPsiServices().CachesState.IsIdle.Value)
        return null;

      var projectFile = textControl.Document.GetPsiSourceFile(solution);
      if (projectFile == null || !projectFile.IsValid())
        return null;
      var psiFile = projectFile.GetPsiFile<FSharpLanguage>(new DocumentRange(textControl.Document, textControl.Caret.Offset())) as IFSharpFile;
      if (psiFile == null || !psiFile.IsValid() || !psiFile.Language.Is<FSharpLanguage>())
        return null;

      return new FSharpContextActionDataProvider(solution, textControl, psiFile);
    }
  }
}