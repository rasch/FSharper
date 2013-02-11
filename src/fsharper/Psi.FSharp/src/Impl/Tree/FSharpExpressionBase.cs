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

  internal abstract class TypeVariableScopeBase : FSharpCompositeElement
  {
      // TODO: What should this class do?
  }
}

// TODO: Define this to do something useful!
namespace JetBrains.ReSharper.Psi.FSharp.Impl.InferenceCacheSupport
{
  abstract class InferenceErrorBase : FSharpCompositeElement
  {
  }

  abstract class InferenceTypeBase : FSharpCompositeElement
  {
  }
}