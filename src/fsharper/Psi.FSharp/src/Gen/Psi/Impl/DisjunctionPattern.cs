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
  internal partial class DisjunctionPattern : PatternBase, JetBrains.ReSharper.Psi.FSharp.IDisjunctionPatternNode, JetBrains.ReSharper.Psi.FSharp.IDisjunctionPattern {
    public const short LEFT_PATTERN= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 1;
    public const short FSHARP_OR= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.FSHARP_OR;
    public const short RIGHT_PATTERN= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 3;
    internal DisjunctionPattern() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.DISJUNCTION_PATTERN; }
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.ElementVisitor visitor) {
      visitor.VisitDisjunctionPattern(this);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.ElementVisitor<TContext,TReturn> visitor, TContext context) {
      return visitor.VisitDisjunctionPattern(this, context);
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor visitor) {
      visitor.VisitDisjunctionPatternNode(this);
    }
    public override void Accept<TContext>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitDisjunctionPatternNode(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitDisjunctionPatternNode(this, context);
    }
    private static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short> CHILD_ROLES = new JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short>(
      new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>[]
      {
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_OR_OP, FSHARP_OR),
      }
    );
    public override short GetChildRole (JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) {
      short role = CHILD_ROLES[child.NodeType];
      if (role != 0) return role;
      JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement current = GetNextFilteredChild(null);
      if (current == null) return 0;
      if (child.parent != this) return 0;
      if (TokenBitsets.ElementBitset_1[current.NodeType]) {
        if (current == child) return LEFT_PATTERN;
        current = GetNextFilteredChild(current);
        if (current == null) return 0;
      } else return 0;
      if (current.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_OR_OP) {
        if (current == child) return FSHARP_OR;
        current = GetNextFilteredChild(current);
        if (current == null) return 0;
      } else return 0;
      if (TokenBitsets.ElementBitset_1[current.NodeType]) {
        if (current == child) return RIGHT_PATTERN;
        current = GetNextFilteredChild(current);
        if (current == null) return 0;
      } else return 0;
      return 0;
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IPattern LeftPattern {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern) FindChildByRole(LEFT_PATTERN); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode LeftPatternNode {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode) FindChildByRole(LEFT_PATTERN); }
    }
    public virtual JetBrains.ReSharper.Psi.ITokenNode Or {
      get { return (JetBrains.ReSharper.Psi.ITokenNode) FindChildByRole(FSHARP_OR); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IPattern RightPattern {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern) FindChildByRole(RIGHT_PATTERN); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode RightPatternNode {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode) FindChildByRole(RIGHT_PATTERN); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IPattern SetLeftPattern (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_1[next.NodeType]) {
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
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode SetLeftPatternNode (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_1[next.NodeType]) {
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
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IPattern SetRightPattern (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern)result;
        } else {
          if (TokenBitsets.ElementBitset_1[next.NodeType]) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_OR_OP) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_1[next.NodeType]) {
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
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode SetRightPatternNode (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode)result;
        } else {
          if (TokenBitsets.ElementBitset_1[next.NodeType]) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_OR_OP) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_1[next.NodeType]) {
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
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode)result;
      }
    }
    JetBrains.ReSharper.Psi.FSharp.IDisjunctionPatternNode JetBrains.ReSharper.Psi.FSharp.IDisjunctionPattern.ToTreeNode() { return this; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode JetBrains.ReSharper.Psi.FSharp.Tree.IPattern.ToTreeNode() { return this; }
    public override string ToString() {
      return "IDisjunctionPattern";
    }
  }
}
