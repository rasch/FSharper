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
  public partial interface ITypeDeclarationNode : JetBrains.ReSharper.Psi.FSharp.Tree.IFSharpTreeNode,JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration {
    JetBrains.ReSharper.Psi.ITokenNode Eq { get; }
    JetBrains.ReSharper.Psi.FSharp.ITypeInformationNode TypeInformationNode { get; }
    JetBrains.ReSharper.Psi.FSharp.IIdentifierNode TypeName { get; }
    JetBrains.ReSharper.Psi.FSharp.ITypeParameterListNode TypeParameterList { get; }
    JetBrains.ReSharper.Psi.FSharp.ITypeInformationNode SetTypeInformationNode (JetBrains.ReSharper.Psi.FSharp.ITypeInformationNode param);
    JetBrains.ReSharper.Psi.FSharp.IIdentifierNode SetTypeName (JetBrains.ReSharper.Psi.FSharp.IIdentifierNode param);
    JetBrains.ReSharper.Psi.FSharp.ITypeParameterListNode SetTypeParameterList (JetBrains.ReSharper.Psi.FSharp.ITypeParameterListNode param);
  }
}
