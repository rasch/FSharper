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
  internal partial class ForAllTypeExpression : JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpCompositeElement, JetBrains.ReSharper.Psi.FSharp.IForAllTypeExpressionNode, JetBrains.ReSharper.Psi.FSharp.IForAllTypeExpression {
    public const short PARAMETER= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 1;
    public const short FSHARP_DOT= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.FSHARP_DOT;
    public const short PARAMETERIZED_TYPE_EXPRESSION= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 3;
    internal ForAllTypeExpression() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.FOR_ALL_TYPE_EXPRESSION; }
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.ElementVisitor visitor) {
      visitor.VisitForAllTypeExpression(this);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.ElementVisitor<TContext,TReturn> visitor, TContext context) {
      return visitor.VisitForAllTypeExpression(this, context);
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor visitor) {
      visitor.VisitForAllTypeExpressionNode(this);
    }
    public override void Accept<TContext>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitForAllTypeExpressionNode(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitForAllTypeExpressionNode(this, context);
    }
    private static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short> CHILD_ROLES = new JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short>(
      new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>[]
      {
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_DOT_OP, FSHARP_DOT),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.ARRAY_TYPE, PARAMETERIZED_TYPE_EXPRESSION),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.FUNCTION_TYPE, PARAMETERIZED_TYPE_EXPRESSION),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.LAZY_TYPE, PARAMETERIZED_TYPE_EXPRESSION),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.MULTI_PARAMETER_TYPE_REFERENCE, PARAMETERIZED_TYPE_EXPRESSION),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.ONE_PARAMETER_TYPE_REFERENCE, PARAMETERIZED_TYPE_EXPRESSION),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.PARENTHESIZED_TYPE, PARAMETERIZED_TYPE_EXPRESSION),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TUPLE_TYPE, PARAMETERIZED_TYPE_EXPRESSION),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TYPE_PARAMETER_REFERENCE, PARAMETERIZED_TYPE_EXPRESSION),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.UNDERLINE_TYPE, PARAMETERIZED_TYPE_EXPRESSION),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.WITHOUT_PARAMETER_TYPE_REFERENCE, PARAMETERIZED_TYPE_EXPRESSION),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TYPE_PARAMETER_DECLARATION, PARAMETER),
      }
    );
    public override short GetChildRole (JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) {
      return CHILD_ROLES[child.NodeType];
    }
    public virtual JetBrains.ReSharper.Psi.ITokenNode Dot {
      get { return (JetBrains.ReSharper.Psi.ITokenNode) FindChildByRole(FSHARP_DOT); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.ITypeParameterDeclarationNode Parameter {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeParameterDeclarationNode) FindChildByRole(PARAMETER); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression ParameterizedTypeExpression {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression) FindChildByRole(PARAMETERIZED_TYPE_EXPRESSION); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpressionNode ParameterizedTypeExpressionNode {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpressionNode) FindChildByRole(PARAMETERIZED_TYPE_EXPRESSION); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.ITypeParameterDeclarationNode SetParameter (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeParameterDeclarationNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TYPE_PARAMETER_DECLARATION) {
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
        return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeParameterDeclarationNode)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression SetParameterizedTypeExpression (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TYPE_PARAMETER_DECLARATION) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_DOT_OP) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_2[next.NodeType]) {
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
        return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpressionNode SetParameterizedTypeExpressionNode (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpressionNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpressionNode)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TYPE_PARAMETER_DECLARATION) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpressionNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpressionNode)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_DOT_OP) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpressionNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_2[next.NodeType]) {
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
        return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpressionNode)result;
      }
    }
    JetBrains.ReSharper.Psi.FSharp.IForAllTypeExpressionNode JetBrains.ReSharper.Psi.FSharp.IForAllTypeExpression.ToTreeNode() { return this; }
    JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpression.ToTreeNode() { return this; }
    public override string ToString() {
      return "IForAllTypeExpression";
    }
  }
}
