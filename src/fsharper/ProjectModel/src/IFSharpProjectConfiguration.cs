namespace JetBrains.ProjectModel
{
  using JetBrains.ProjectModel.Properties.Managed;

  public interface IFSharpProjectConfiguration :
    IManagedProjectConfiguration
  {
    VSFSharpLanguageVersion LanguageVersion { get; set; }
  }

  public enum VSFSharpLanguageVersion
  {
    FS10,
    FS20,
    FS30,
    Latest
  }
}