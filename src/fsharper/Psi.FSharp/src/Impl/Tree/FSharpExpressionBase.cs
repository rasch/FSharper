using JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.Managed;
using JetBrains.ReSharper.Psi.FSharp.Tree;
using JetBrains.ReSharper.Psi.FSharp.Tree.Impl;
using JetBrains.ReSharper.Psi.Resolve;

namespace JetBrains.ReSharper.Psi.FSharp.Tree.Impl
{
  abstract class FSharpExpressionBase : FSharpCompositeElement, IFSharpExpression//, IManagedExpressionImpl, IAccessContext
  {
  }

  internal abstract class ReferenceExpressionBase : FSharpExpressionBase
  {
  }

  internal abstract class OperatorExpressionBase : FSharpExpressionBase
  {
  }

  internal abstract class TypeExpressionBase : FSharpExpressionBase
  {
  }

  // TODO: Is this an expression?
  internal abstract class PatternBase : FSharpExpressionBase
  {
  }
}