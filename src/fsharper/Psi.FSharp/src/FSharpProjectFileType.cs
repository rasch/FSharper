namespace JetBrains.ReSharper.Psi.FSharp
{
  using ProjectModel;

  [ProjectFileTypeDefinition(Name, Edition = "Csharp")]
  public class FSharpProjectFileType : KnownProjectFileType
  {
    public new const string Name = "FSHARP";
    private new const string PresentableName = "F#";

    public const string FS_EXTENSION = ".fs";
    public const string FSI_EXTENSION = ".fsi";
    public const string ML_EXTENSION = ".ml";
    public const string MLI_EXTENSION = ".mli";
    public const string FSX_EXTENSION = ".fsx";
    public const string FSSCRIPT_EXTENSION = ".fsscript";

    public new static readonly FSharpProjectFileType Instance;

    private FSharpProjectFileType()
      : base(Name, PresentableName, new[] { FS_EXTENSION, FSI_EXTENSION, ML_EXTENSION, MLI_EXTENSION, FSX_EXTENSION, FSSCRIPT_EXTENSION }) { }

    protected FSharpProjectFileType(string name) : base(name) { }
    protected FSharpProjectFileType(string name, string presentableName) : base(name, presentableName) { }
  }
}