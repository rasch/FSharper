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
  public partial interface IValueReferenceExpression : JetBrains.ReSharper.Psi.FSharp.Tree.IExpression {
    JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReference Qualifier { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReference SetQualifier (JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReference param);
    new JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpressionNode ToTreeNode();
  }
}
