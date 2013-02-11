namespace JetBrains.ReSharper.Daemon.FSharp.Stages
{
  using System.Collections.Generic;
  using Application.Settings;
  using Psi;
  using Psi.FSharp;
  using Psi.Tree;

  public abstract class FSharpDaemonStageBase : IDaemonStage
  {
    protected static bool IsSupported(IPsiSourceFile sourceFile)
    {
      if (sourceFile == null || !sourceFile.IsValid())
        return false;
      var psiFile = sourceFile.GetNonInjectedPsiFile<FSharpLanguage>();
      return psiFile != null && psiFile.Language.Is<FSharpLanguage>();
    }

    public abstract IEnumerable<IDaemonStageProcess> CreateProcess(IDaemonProcess process, IContextBoundSettingsStore settings, DaemonProcessKind processKind);
    public abstract ErrorStripeRequest NeedsErrorStripe(IPsiSourceFile sourceFile, IContextBoundSettingsStore settingsStore);
  }
}
