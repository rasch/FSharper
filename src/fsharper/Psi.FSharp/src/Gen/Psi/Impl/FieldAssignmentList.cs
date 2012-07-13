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
  internal partial class FieldAssignmentList : JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpCompositeElement, JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentListNode, JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentList {
    public const short FIELD_ASSIGNMENT= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 1;
    public const short FSHARP_SEMICOLON= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.FSHARP_SEMICOLON;
    internal FieldAssignmentList() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.FIELD_ASSIGNMENT_LIST; }
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.ElementVisitor visitor) {
      visitor.VisitFieldAssignmentList(this);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.ElementVisitor<TContext,TReturn> visitor, TContext context) {
      return visitor.VisitFieldAssignmentList(this, context);
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor visitor) {
      visitor.VisitFieldAssignmentListNode(this);
    }
    public override void Accept<TContext>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitFieldAssignmentListNode(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitFieldAssignmentListNode(this, context);
    }
    private static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short> CHILD_ROLES = new JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short>(
      new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>[]
      {
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_SEMICOLON_OP, FSHARP_SEMICOLON),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.FIELD_ASSIGNMENT, FIELD_ASSIGNMENT),
      }
    );
    public override short GetChildRole (JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) {
      return CHILD_ROLES[child.NodeType];
    }
    public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.FSharp.IFieldAssignment> FieldAssignments {
      get { return FindListOfChildrenByRole<JetBrains.ReSharper.Psi.FSharp.IFieldAssignment>(FIELD_ASSIGNMENT); }
    }
    public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode> FieldAssignmentsNode {
      get { return FindListOfChildrenByRole<JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode>(FIELD_ASSIGNMENT); }
    }
    public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.ITokenNode> Semicolon {
      get { return FindListOfChildrenByRole<JetBrains.ReSharper.Psi.ITokenNode>(FSHARP_SEMICOLON); }
    }
    /*
    public virtual JetBrains.ReSharper.Psi.FSharp.IFieldAssignment AddFieldAssignmentBefore (JetBrains.ReSharper.Psi.FSharp.IFieldAssignment param, JetBrains.ReSharper.Psi.FSharp.IFieldAssignment anchor)
    {
      throw new NotImplementedException ("AddFieldAssignmentBefore");
      using (Shell.WriteLockCookie.Create ())
      {
        TreeElement current = null, next, result = null;
        TreeElement childToAddBefore = null;
        $rule
        return (JetBrains.ReSharper.Psi.FSharp.IFieldAssignment)result;
      }
    }
    */
    /*
    public virtual JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode AddFieldAssignmentsNodeBefore (JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode param, JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode anchor)
    {
      throw new NotImplementedException ("AddFieldAssignmentsNodeBefore");
      using (Shell.WriteLockCookie.Create ())
      {
        TreeElement current = null, next, result = null;
        TreeElement childToAddBefore = null;
        $rule
        return (JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode)result;
      }
    }
    */
    /*
    public virtual JetBrains.ReSharper.Psi.FSharp.IFieldAssignment AddFieldAssignmentAfter (JetBrains.ReSharper.Psi.FSharp.IFieldAssignment param, JetBrains.ReSharper.Psi.FSharp.IFieldAssignment anchor)
    {
      throw new NotImplementedException ("AddFieldAssignmentAfter");
      using (Shell.WriteLockCookie.Create ())
      {
        TreeElement current = null, next, result = null;
        TreeElement childToAddAfter = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.IFieldAssignment)result;
        } else {
          current = next;
        }
        while (current.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_SEMICOLON_OP) {
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.IFieldAssignment)result;
          } else {
            current = next;
          }
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.IFieldAssignment)result;
          } else {
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.IFieldAssignment)result;
      }
    }
    */
    /*
    public virtual JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode AddFieldAssignmentsNodeAfter (JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode param, JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode anchor)
    {
      throw new NotImplementedException ("AddFieldAssignmentsNodeAfter");
      using (Shell.WriteLockCookie.Create ())
      {
        TreeElement current = null, next, result = null;
        TreeElement childToAddAfter = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode)result;
        } else {
          current = next;
        }
        while (current.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_SEMICOLON_OP) {
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode)result;
          } else {
            current = next;
          }
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode)result;
          } else {
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode)result;
      }
    }
    */
    /*
    public virtual void RemoveFieldAssignment (JetBrains.ReSharper.Psi.FSharp.IFieldAssignment param)
    {
      throw new NotImplementedException ("RemoveFieldAssignment");
    }
    */
    /*
    public virtual void RemoveFieldAssignmentsNode (JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode param)
    {
      throw new NotImplementedException ("RemoveFieldAssignmentsNode");
    }
    */
    JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentListNode JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentList.ToTreeNode() { return this; }
    public override string ToString() {
      return "IFieldAssignmentList";
    }
  }
}
