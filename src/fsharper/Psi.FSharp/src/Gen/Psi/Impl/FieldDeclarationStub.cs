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
  internal abstract partial class FieldDeclarationStub : JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpCompositeElement, JetBrains.ReSharper.Psi.FSharp.Tree.IFieldDeclarationNode, JetBrains.ReSharper.Psi.FSharp.Tree.IFieldDeclaration {
    public const short KEYWORD_MUTABLE= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 1;
    public const short FIELD= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 2;
    public const short FSHARP_COLON= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.FSHARP_COLON;
    public const short TYPE_SCHEME= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 4;
    public FieldDeclarationStub() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.FIELD_DECLARATION; }
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.ElementVisitor visitor) {
      visitor.VisitFieldDeclaration(this);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.ElementVisitor<TContext,TReturn> visitor, TContext context) {
      return visitor.VisitFieldDeclaration(this, context);
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor visitor) {
      visitor.VisitFieldDeclarationNode(this);
    }
    public override void Accept<TContext>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitFieldDeclarationNode(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitFieldDeclarationNode(this, context);
    }
    private static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short> CHILD_ROLES = new JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short>(
      new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>[]
      {
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_MUTABLE, KEYWORD_MUTABLE),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType._IDENTIFIER, FIELD),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.ARRAY_TYPE, TYPE_SCHEME),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.FOR_ALL_TYPE_EXPRESSION, TYPE_SCHEME),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.FUNCTION_TYPE, TYPE_SCHEME),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.LAZY_TYPE, TYPE_SCHEME),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.MULTI_PARAMETER_TYPE_REFERENCE, TYPE_SCHEME),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.ONE_PARAMETER_TYPE_REFERENCE, TYPE_SCHEME),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.PARENTHESIZED_TYPE, TYPE_SCHEME),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TUPLE_TYPE, TYPE_SCHEME),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TYPE_PARAMETER_REFERENCE, TYPE_SCHEME),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.UNDERLINE_TYPE, TYPE_SCHEME),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.WITHOUT_PARAMETER_TYPE_REFERENCE, TYPE_SCHEME),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_COLON_OP, FSHARP_COLON),
      }
    );
    public override short GetChildRole (JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) {
      return CHILD_ROLES[child.NodeType];
    }
    public virtual JetBrains.ReSharper.Psi.ITokenNode Colon {
      get { return (JetBrains.ReSharper.Psi.ITokenNode) FindChildByRole(FSHARP_COLON); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.IIdentifierNode FieldName {
      get { return (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode) FindChildByRole(FIELD); }
    }
    public virtual JetBrains.ReSharper.Psi.ITokenNode MutableKeyword {
      get { return (JetBrains.ReSharper.Psi.ITokenNode) FindChildByRole(KEYWORD_MUTABLE); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpression typeSchemeExpression {
      get { return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpression) FindChildByRole(TYPE_SCHEME); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode typeSchemeExpressionNode {
      get { return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode) FindChildByRole(TYPE_SCHEME); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.IIdentifierNode SetFieldName (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next != null && (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_MUTABLE)) {
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode)result;
          } else {
            if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_MUTABLE) {
              current = next;
            } else {
              return (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode)result;
            }
          }
        }  
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType._IDENTIFIER) {
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
        return (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpression SettypeSchemeExpression (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpression param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next != null && (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_MUTABLE)) {
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpression)result;
          } else {
            if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_MUTABLE) {
              current = next;
            } else {
              return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpression)result;
            }
          }
        }  
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpression)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType._IDENTIFIER) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpression)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpression)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_COLON_OP) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpression)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_4[next.NodeType]) {
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
        return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpression)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode SettypeSchemeExpressionNode (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next != null && (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_MUTABLE)) {
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode)result;
          } else {
            if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_MUTABLE) {
              current = next;
            } else {
              return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode)result;
            }
          }
        }  
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType._IDENTIFIER) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_COLON_OP) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_4[next.NodeType]) {
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
        return (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode)result;
      }
    }
    JetBrains.ReSharper.Psi.FSharp.Tree.IFieldDeclarationNode JetBrains.ReSharper.Psi.FSharp.Tree.IFieldDeclaration.ToTreeNode() { return this; }
    public override string ToString() {
      return "IFieldDeclaration";
    }
  }
}
