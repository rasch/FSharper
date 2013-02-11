namespace JetBrains.ReSharper.Psi.FSharp.Tree.Impl
{
    internal partial class FSharpFile
    {
        public override PsiLanguageType Language
        {
            get { return FSharpLanguage.Instance; }
        }
    }
}