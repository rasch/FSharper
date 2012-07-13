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
  internal abstract partial class MemberAccessExpressionStub : ReferenceExpressionBase, JetBrains.ReSharper.Psi.FSharp.Tree.IMemberAccessExpressionNode, JetBrains.ReSharper.Psi.FSharp.Tree.IMemberAccessExpression {
    public const short QUALIFIER= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 1;
    public const short FSHARP_DOT= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.FSHARP_DOT;
    public const short REFERENCE_NAME= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 3;
    public MemberAccessExpressionStub() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.MEMBER_ACCESS_EXPRESSION; }
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.ElementVisitor visitor) {
      visitor.VisitMemberAccessExpression(this);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.ElementVisitor<TContext,TReturn> visitor, TContext context) {
      return visitor.VisitMemberAccessExpression(this, context);
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor visitor) {
      visitor.VisitMemberAccessExpressionNode(this);
    }
    public override void Accept<TContext>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitMemberAccessExpressionNode(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitMemberAccessExpressionNode(this, context);
    }
    private static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short> CHILD_ROLES = new JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short>(
      new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>[]
      {
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_DOT_OP, FSHARP_DOT),
      }
    );
    public override short GetChildRole (JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) {
      short role = CHILD_ROLES[child.NodeType];
      if (role != 0) return role;
      JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement current = GetNextFilteredChild(null);
      if (current == null) return 0;
      if (child.parent != this) return 0;
      if (TokenBitsets.ElementBitset_0[current.NodeType]) {
        if (current == child) return QUALIFIER;
        current = GetNextFilteredChild(current);
        if (current == null) return 0;
      } else return 0;
      if (current.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_DOT_OP) {
        if (current == child) return FSHARP_DOT;
        current = GetNextFilteredChild(current);
        if (current == null) return 0;
      } else return 0;
      if (current.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.VALUE_REFERENCE_EXPRESSION) {
        if (current == child) return REFERENCE_NAME;
        current = GetNextFilteredChild(current);
        if (current == null) return 0;
      } else return 0;
      return 0;
    }
    public virtual JetBrains.ReSharper.Psi.ITokenNode Dot {
      get { return (JetBrains.ReSharper.Psi.ITokenNode) FindChildByRole(FSHARP_DOT); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpression Qualifier {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression) FindChildByRole(QUALIFIER); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode QualifierNode {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode) FindChildByRole(QUALIFIER); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpression ReferenceName {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpression) FindChildByRole(REFERENCE_NAME); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpressionNode ReferenceNameNode {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpressionNode) FindChildByRole(REFERENCE_NAME); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpression SetQualifier (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
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
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetQualifierNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
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
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpression SetReferenceName (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpression param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpression)result;
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpression)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpression)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_DOT_OP) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpression)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.VALUE_REFERENCE_EXPRESSION) {
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
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpression)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpressionNode SetReferenceNameNode (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpressionNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpressionNode)result;
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpressionNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpressionNode)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_DOT_OP) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpressionNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.VALUE_REFERENCE_EXPRESSION) {
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
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpressionNode)result;
      }
    }
    JetBrains.ReSharper.Psi.FSharp.Tree.IMemberAccessExpressionNode JetBrains.ReSharper.Psi.FSharp.Tree.IMemberAccessExpression.ToTreeNode() { return this; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode JetBrains.ReSharper.Psi.FSharp.Tree.IExpression.ToTreeNode() { return this; }
    public override string ToString() {
      return "IMemberAccessExpression";
    }
  }
}
