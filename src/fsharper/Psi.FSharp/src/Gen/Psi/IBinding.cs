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
  public partial interface IBinding : JetBrains.ReSharper.Psi.FSharp.IBindingScheme {
    JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.FSharp.IAttribute> Attributes { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IBindingSource Source { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpression Target { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IBindingSource SetSource (JetBrains.ReSharper.Psi.FSharp.Tree.IBindingSource param);
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpression SetTarget (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression param);
    JetBrains.ReSharper.Psi.FSharp.IAttribute AddAttributeBefore (JetBrains.ReSharper.Psi.FSharp.IAttribute param, JetBrains.ReSharper.Psi.FSharp.IAttribute anchor);
    JetBrains.ReSharper.Psi.FSharp.IAttribute AddAttributeAfter (JetBrains.ReSharper.Psi.FSharp.IAttribute param, JetBrains.ReSharper.Psi.FSharp.IAttribute anchor);
    void RemoveAttribute (JetBrains.ReSharper.Psi.FSharp.IAttribute param);
    new JetBrains.ReSharper.Psi.FSharp.Tree.IBindingNode ToTreeNode();
  }
}
