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
  internal abstract partial class ConstructorReferenceStub : PatternBase, JetBrains.ReSharper.Psi.FSharp.Tree.IConstructorReferenceNode, JetBrains.ReSharper.Psi.FSharp.Tree.IConstructorReference {
    public const short QUALIFIER= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 1;
    public const short FSHARP_DOT= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.FSHARP_DOT;
    public const short REFERENCE_NAME= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 3;
    public ConstructorReferenceStub() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.CONSTRUCTOR_REFERENCE; }
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.ElementVisitor visitor) {
      visitor.VisitConstructorReference(this);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.ElementVisitor<TContext,TReturn> visitor, TContext context) {
      return visitor.VisitConstructorReference(this, context);
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor visitor) {
      visitor.VisitConstructorReferenceNode(this);
    }
    public override void Accept<TContext>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitConstructorReferenceNode(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitConstructorReferenceNode(this, context);
    }
    private static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short> CHILD_ROLES = new JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short>(
      new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>[]
      {
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_DOT_OP, FSHARP_DOT),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType._IDENTIFIER, REFERENCE_NAME),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.MODULE_REFERENCE, QUALIFIER),
      }
    );
    public override short GetChildRole (JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) {
      return CHILD_ROLES[child.NodeType];
    }
    public virtual JetBrains.ReSharper.Psi.ITokenNode Dot {
      get { return (JetBrains.ReSharper.Psi.ITokenNode) FindChildByRole(FSHARP_DOT); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReference Qualifier {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReference) FindChildByRole(QUALIFIER); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReferenceNode QualifierNode {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReferenceNode) FindChildByRole(QUALIFIER); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.IIdentifierNode ReferenceName {
      get { return (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode) FindChildByRole(REFERENCE_NAME); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReference SetQualifier (JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReference param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.MODULE_REFERENCE) {
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
        next = GetNextFilteredChild (current);
        if (next == null) {
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, TreeElementFactory.CreateErrorElement (string.Empty));
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_DOT_OP) {
            if (param != null) {
              current = next;
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReference)result;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReference)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReferenceNode SetQualifierNode (JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReferenceNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.MODULE_REFERENCE) {
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
        next = GetNextFilteredChild (current);
        if (next == null) {
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, TreeElementFactory.CreateErrorElement (string.Empty));
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_DOT_OP) {
            if (param != null) {
              current = next;
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReferenceNode)result;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReferenceNode)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.IIdentifierNode SetReferenceName (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next != null && (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.MODULE_REFERENCE)) {
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode)result;
          } else {
            if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.MODULE_REFERENCE) {
              current = next;
            } else {
              return (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode)result;
            }
          }
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode)result;
          } else {
            if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_DOT_OP) {
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
    JetBrains.ReSharper.Psi.FSharp.Tree.IConstructorReferenceNode JetBrains.ReSharper.Psi.FSharp.Tree.IConstructorReference.ToTreeNode() { return this; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode JetBrains.ReSharper.Psi.FSharp.Tree.IPattern.ToTreeNode() { return this; }
    public override string ToString() {
      return "IConstructorReference";
    }
  }
}
