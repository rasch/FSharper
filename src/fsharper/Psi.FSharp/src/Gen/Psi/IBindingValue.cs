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
  public partial interface IBindingValue : JetBrains.ReSharper.Psi.FSharp.IBindingValueScheme {
    JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.FSharp.Tree.IPattern> Parameters { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression TypeExpression { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression SetTypeExpression (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression param);
    JetBrains.ReSharper.Psi.FSharp.Tree.IPattern AddParameterBefore (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern param, JetBrains.ReSharper.Psi.FSharp.Tree.IPattern anchor);
    JetBrains.ReSharper.Psi.FSharp.Tree.IPattern AddParameterAfter (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern param, JetBrains.ReSharper.Psi.FSharp.Tree.IPattern anchor);
    void RemoveParameter (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern param);
    new JetBrains.ReSharper.Psi.FSharp.Tree.IBindingValueNode ToTreeNode();
  }
}
