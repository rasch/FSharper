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
  public partial interface IForStatementExpressionNode : JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode,JetBrains.ReSharper.Psi.FSharp.Tree.IForStatementExpression {
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode BodyNode { get; }
    JetBrains.ReSharper.Psi.ITokenNode DoKeyword { get; }
    JetBrains.ReSharper.Psi.ITokenNode DoneKeyword { get; }
    JetBrains.ReSharper.Psi.ITokenNode DowntoKeyword { get; }
    JetBrains.ReSharper.Psi.ITokenNode Eq { get; }
    JetBrains.ReSharper.Psi.ITokenNode ForKeyword { get; }
    JetBrains.ReSharper.Psi.FSharp.IIdentifierNode LoopVariable { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode LowerBoundNode { get; }
    JetBrains.ReSharper.Psi.ITokenNode ToKeyword { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode UpperBoundNode { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetBodyNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param);
    JetBrains.ReSharper.Psi.FSharp.IIdentifierNode SetLoopVariable (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode param);
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetLowerBoundNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param);
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetUpperBoundNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param);
  }
}
