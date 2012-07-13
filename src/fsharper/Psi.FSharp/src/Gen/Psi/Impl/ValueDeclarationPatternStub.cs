//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using System;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.FSharp;
namespace JetBrains.ReSharper.Psi.FSharp.Impl.Tree {
  internal abstract partial class ValueDeclarationPatternStub : PatternBase, JetBrains.ReSharper.Psi.FSharp.Tree.IValueDeclarationPatternNode, JetBrains.ReSharper.Psi.FSharp.Tree.IValueDeclarationPattern {
    public const short VALUE= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 1;
    public ValueDeclarationPatternStub() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.VALUE_DECLARATION_PATTERN; }
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.ElementVisitor visitor) {
      visitor.VisitValueDeclarationPattern(this);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.ElementVisitor<TContext,TReturn> visitor, TContext context) {
      return visitor.VisitValueDeclarationPattern(this, context);
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor visitor) {
      visitor.VisitValueDeclarationPatternNode(this);
    }
    public override void Accept<TContext>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitValueDeclarationPatternNode(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitValueDeclarationPatternNode(this, context);
    }
    private static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short> CHILD_ROLES = new JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short>(
      new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>[]
      {
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType._IDENTIFIER, VALUE),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.OPERATOR_NAME, VALUE),
      }
    );
    public override short GetChildRole (JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) {
      return CHILD_ROLES[child.NodeType];
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IValueNameNode Value {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueNameNode) FindChildByRole(VALUE); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IValueNameNode SetValue (JetBrains.ReSharper.Psi.FSharp.Tree.IValueNameNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.OPERATOR_NAME
            ||next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType._IDENTIFIER) {
            if (param != null) {
              result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            if (param == null) return null;
            result = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueNameNode)result;
      }
    }
    JetBrains.ReSharper.Psi.FSharp.Tree.IValueDeclarationPatternNode JetBrains.ReSharper.Psi.FSharp.Tree.IValueDeclarationPattern.ToTreeNode() { return this; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode JetBrains.ReSharper.Psi.FSharp.Tree.IPattern.ToTreeNode() { return this; }
    public override string ToString() {
      return "IValueDeclarationPattern";
    }
  }
}
