//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
namespace JetBrains.ReSharper.Psi.FSharp {
  public partial interface IDisjunctionPatternNode : JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode,JetBrains.ReSharper.Psi.FSharp.IDisjunctionPattern {
    JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode LeftPatternNode { get; }
    JetBrains.ReSharper.Psi.ITokenNode Or { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode RightPatternNode { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode SetLeftPatternNode (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode param);
    JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode SetRightPatternNode (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode param);
  }
}
