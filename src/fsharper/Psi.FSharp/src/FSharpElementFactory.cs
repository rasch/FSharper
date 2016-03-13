using JetBrains.Annotations;
using JetBrains.ReSharper.Psi.FSharp.Impl;

namespace JetBrains.ReSharper.Psi.FSharp
{
    using JetBrains.ReSharper.Psi.Modules;

    public abstract class FSharpElementFactory
  {
    public static FSharpElementFactory GetInstance([NotNull] IPsiModule module, bool applyCodeFormatter = true, bool throwOnParseError = true)
    {
      return new FSharpElementFactoryImpl(module, applyCodeFormatter, throwOnParseError);
    }

    //[NotNull]
    //public abstract IFSharpFile CreateFileImpl(string test, params object[] args);
  }
}