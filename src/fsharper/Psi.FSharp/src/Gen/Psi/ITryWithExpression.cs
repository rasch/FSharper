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
  public partial interface ITryWithExpression : JetBrains.ReSharper.Psi.FSharp.Tree.IExpression {
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpression Expression { get; }
    JetBrains.ReSharper.Psi.FSharp.IPatternMatching PatternMatching { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpression SetExpression (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression param);
    JetBrains.ReSharper.Psi.FSharp.IPatternMatching SetPatternMatching (JetBrains.ReSharper.Psi.FSharp.IPatternMatching param);
    new JetBrains.ReSharper.Psi.FSharp.ITryWithExpressionNode ToTreeNode();
  }
}
