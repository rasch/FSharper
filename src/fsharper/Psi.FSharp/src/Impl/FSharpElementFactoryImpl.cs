namespace JetBrains.ReSharper.Psi.FSharp.Impl
{
  using Annotations;
  using ProjectModel;
  using CodeStyle;

  using JetBrains.ReSharper.Psi.Modules;
  using JetBrains.Util;

  public class FSharpElementFactoryImpl : FSharpElementFactory
  {
    private readonly IPsiModule module;
    private readonly bool applyCodeFormatter;
    private readonly bool throwOnParseError;
    private readonly ISolution solution;
    private readonly IPsiServices psiServices;
    private readonly LanguageService languageService;
    private readonly IFSharpCodeFormatter codeFormatter;

    public FSharpElementFactoryImpl([NotNull] IPsiModule module, bool applyCodeFormatter, bool throwOnParseError)
    {
      this.module = module;
      this.applyCodeFormatter = applyCodeFormatter;
      this.throwOnParseError = throwOnParseError;
      solution = module.GetSolution();
      psiServices = solution.GetPsiServices();
      languageService = FSharpLanguage.Instance.LanguageService();
      Assertion.AssertNotNull(languageService, "languageService == null");
      codeFormatter = languageService.CodeFormatter as IFSharpCodeFormatter;
      Assertion.AssertNotNull(codeFormatter, "codeFormatter == null");
    }
  }
}