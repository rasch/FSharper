//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using System.Collections;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.FSharp.Impl.Tree;
namespace JetBrains.ReSharper.Psi.FSharp {
  public static partial class LocalDeclarationsInExpressionNavigator {
    [JetBrains.Annotations.Pure]
    [JetBrains.Annotations.CanBeNull]
    [JetBrains.Annotations.ContractAnnotation("null <= null")]
    public static JetBrains.ReSharper.Psi.FSharp.Tree.ILocalDeclarationsInExpressionNode GetByBinding (JetBrains.ReSharper.Psi.FSharp.Tree.IBinding param) {
      if (param == null) return null;
      TreeElement current = (TreeElement)param;
      if (current.parent is JetBrains.ReSharper.Psi.FSharp.Impl.Tree.LocalDeclarationsInExpressionStub) {
        if (current.parent.GetChildRole (current) != JetBrains.ReSharper.Psi.FSharp.Impl.Tree.LocalDeclarationsInExpressionStub.BINDING) return null;
        current = current.parent;
      } else return null;
      return (JetBrains.ReSharper.Psi.FSharp.Tree.ILocalDeclarationsInExpressionNode) current;
    }
    [JetBrains.Annotations.Pure]
    [JetBrains.Annotations.CanBeNull]
    [JetBrains.Annotations.ContractAnnotation("null <= null")]
    public static JetBrains.ReSharper.Psi.FSharp.Tree.ILocalDeclarationsInExpressionNode GetByExpression (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression param) {
      if (param == null) return null;
      TreeElement current = (TreeElement)param;
      if (current.parent is JetBrains.ReSharper.Psi.FSharp.Impl.Tree.LocalDeclarationsInExpressionStub) {
        if (current.parent.GetChildRole (current) != JetBrains.ReSharper.Psi.FSharp.Impl.Tree.LocalDeclarationsInExpressionStub.EXPRESSION) return null;
        current = current.parent;
      } else return null;
      return (JetBrains.ReSharper.Psi.FSharp.Tree.ILocalDeclarationsInExpressionNode) current;
    }
  }
}
