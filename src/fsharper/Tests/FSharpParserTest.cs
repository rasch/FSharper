﻿using JetBrains.ReSharper.Psi.FSharp;
using JetBrains.ReSharper.PsiTests.parsing;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;

namespace Tests
{
  [TestFileExtension(FSharpProjectFileType.FS_EXTENSION)]
  public class FSharpParserTest: ParserTestBase
  {
    protected override string RelativeTestDataPath
    {
      get { return @"parsing"; }

    }

    [Test]
    public void Test01()
    {
      this.DoNamedTest();
    }

    [Test]
    public void Test02()
    {
      this.DoNamedTest();
    }

    [Test]
    public void Test03()
    {
      this.DoNamedTest();
    }

    [Test]
    public void Test04()
    {
      this.DoNamedTest();
    }
  }
}