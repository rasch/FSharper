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
  public partial interface IFieldDeclarationNode : JetBrains.ReSharper.Psi.FSharp.Tree.IFSharpTreeNode,JetBrains.ReSharper.Psi.FSharp.Tree.IFieldDeclaration {
    JetBrains.ReSharper.Psi.ITokenNode Colon { get; }
    JetBrains.ReSharper.Psi.FSharp.IIdentifierNode FieldName { get; }
    JetBrains.ReSharper.Psi.ITokenNode MutableKeyword { get; }
    JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode typeSchemeExpressionNode { get; }
    JetBrains.ReSharper.Psi.FSharp.IIdentifierNode SetFieldName (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode param);
    JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode SettypeSchemeExpressionNode (JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode param);
  }
}
