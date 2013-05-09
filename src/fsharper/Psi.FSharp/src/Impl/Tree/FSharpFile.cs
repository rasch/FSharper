namespace JetBrains.ReSharper.Psi.FSharp.Impl.Tree
{
    internal partial class FSharpFile
    {
        public override PsiLanguageType Language
        {
            get { return FSharpLanguage.Instance; }
        }
    }
}