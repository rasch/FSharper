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
  public partial interface IExpressionBlockNode : JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode,JetBrains.ReSharper.Psi.FSharp.IExpressionBlock {
    JetBrains.ReSharper.Psi.ITokenNode BeginKeyword { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode BlockNode { get; }
    JetBrains.ReSharper.Psi.ITokenNode EndKeyword { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetBlockNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param);
  }
}
