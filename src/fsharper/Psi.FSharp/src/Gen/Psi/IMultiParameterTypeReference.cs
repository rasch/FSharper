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
  public partial interface IMultiParameterTypeReference : JetBrains.ReSharper.Psi.FSharp.Tree.IParameterizedTypeReference, JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression {
    JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression> Parameters { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression AddParameterBefore (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression param, JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression anchor);
    JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression AddParameterAfter (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression param, JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression anchor);
    void RemoveParameter (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression param);
    new JetBrains.ReSharper.Psi.FSharp.Tree.IMultiParameterTypeReferenceNode ToTreeNode();
  }
}
