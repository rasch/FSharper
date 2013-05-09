namespace JetBrains.ReSharper.Feature.Services.FSharp
{
  using ReSharper.Psi.FSharp;

  public interface IFSharpContextActionDataProvider /* : IContextActionDataProvider<IFSharpFile> */
  {
    FSharpElementFactory ElementFactory { get; }
    // todo: control flow graphs
  }
}