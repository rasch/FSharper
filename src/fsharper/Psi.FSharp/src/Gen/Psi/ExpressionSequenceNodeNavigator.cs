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
  public static partial class ExpressionSequenceNodeNavigator {
    [JetBrains.Annotations.Pure]
    [JetBrains.Annotations.CanBeNull]
    [JetBrains.Annotations.ContractAnnotation("null <= null")]
    public static JetBrains.ReSharper.Psi.FSharp.IExpressionSequenceNode GetByExpression1Node (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param) {
      if (param == null) return null;
      TreeElement current = (TreeElement)param;
      if (current.parent is JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ExpressionSequence) {
        if (current.parent.GetChildRole (current) != JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ExpressionSequence.EXPRESSION1) return null;
        current = current.parent;
      } else return null;
      return (JetBrains.ReSharper.Psi.FSharp.IExpressionSequenceNode) current;
    }
    [JetBrains.Annotations.Pure]
    [JetBrains.Annotations.CanBeNull]
    [JetBrains.Annotations.ContractAnnotation("null <= null")]
    public static JetBrains.ReSharper.Psi.FSharp.IExpressionSequenceNode GetByExpression2Node (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param) {
      if (param == null) return null;
      TreeElement current = (TreeElement)param;
      if (current.parent is JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ExpressionSequence) {
        if (current.parent.GetChildRole (current) != JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ExpressionSequence.EXPRESSION2) return null;
        current = current.parent;
      } else return null;
      return (JetBrains.ReSharper.Psi.FSharp.IExpressionSequenceNode) current;
    }
  }
}
