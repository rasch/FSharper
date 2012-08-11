namespace JetBrains.ReSharper.Psi.FSharp
{
  using ProjectModel;

  [ProjectFileTypeDefinition(Name, Edition = "Csharp")]
  public class FSharpProjectFileType : KnownProjectFileType
  {
    public new const string Name = "FSHARP";
    private new const string PresentableName = "F#";

    public static readonly string FS_EXTENSION = ".fs";
    public static readonly string FSI_EXTENSION = ".fsi";
    public static readonly string ML_EXTENSION = ".ml";
    public static readonly string MLI_EXTENSION = ".mli";
    public static readonly string FSX_EXTENSION = ".fsx";
    public static readonly string FSSCRIPT_EXTENSION = ".fsscript";

    public new static readonly FSharpProjectFileType Instance;

    private FSharpProjectFileType()
      : base(Name, PresentableName, new[] { FS_EXTENSION, FSI_EXTENSION, ML_EXTENSION, MLI_EXTENSION, FSX_EXTENSION, FSSCRIPT_EXTENSION }) { }

    protected FSharpProjectFileType(string name) : base(name) { }
    protected FSharpProjectFileType(string name, string presentableName) : base(name, presentableName) { }
  }
}