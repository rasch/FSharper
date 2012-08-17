namespace JetBrains.ReSharper.Psi.FSharp.Impl
{
  public static class ChildRole
  {
    // general common roles
    public const short NONE = 0;

    // C# common roles :
    public const short CSHARP_NAME = 1; // identifier in declaration and type parameter
    public const short CSHARP_LABEL_NAME = 2; // label declaration in labeled statement
    public const short CSHARP_BLOCK = 3; // any place where "{...}" construction may occur except places where CSHARP_BODY is used
    public const short CSHARP_LBRACE = 4; // '{'
    public const short CSHARP_RBRACE = 5; // '}'
    public const short CSHARP_LPAR = 6; // '('
    public const short CSHARP_RPAR = 7; // ')'
    public const short CSHARP_LBRACKET = 8; // '['
    public const short CSHARP_RBRACKET = 9; // ']'
    public const short CSHARP_LANGLE = 10; // '['
    public const short CSHARP_RANGLE = 11; // ']'
    public const short CSHARP_COMMA = 12; // ','
    public const short CSHARP_TILDE = 13;// '~'
    public const short CSHARP_DOT = 14; // '.'
    public const short CSHARP_DOUBLE_COLON = 15; // '::'
    public const short CSHARP_COLON = 16; // ':'
    public const short CSHARP_QUEST = 17; // ? (in ternary expression)
    public const short CSHARP_BASE = 18; // extends lists and enum bases
    public const short CSHARP_SEMICOLON = 19; // ';' except second in for statement
    public const short CSHARP_SEMICOLON2 = 20; // second ';' in for statement
    public const short CSHARP_TYPE = 21; // any type usage or declared type usage
    public const short CSHARP_OPERAND_TYPE = 22; // type usage in cast expression
    public const short CSHARP_BODY = 23; // any place where embedded statement is expected except then and else branches
    public const short CSHARP_THEN = 24; // then branch in if statement
    public const short CSHARP_ELSE = 25; // else branch in if statement
    public const short CSHARP_EQ = 26; // '='

    public const short CSHARP_REFERENCE = 27; // identifier in right part of reference name or other places where member name or something similar expected
    public const short CSHARP_LABEL_REFERENCE = 28; // label reference in goto statement
    public const short CSHARP_NAMESPACE_REFERENCE = 29; // reference name in using namespace directive

    public const short CSHARP_PARAMETER = 30; // parameter declaration, type parameter
    public const short CSHARP_ARGUMENT = 31; // argument

    public const short CSHARP_OP1 = 32; // first operator expression operand
    public const short CSHARP_OP2 = 33; // second operator expression operand
    public const short CSHARP_OP3 = 34; // third operator exression operand

    public const short CSHARP_INITIALIZER = 35; // initializers in declarations where initializers are allowed

    public const short CSHARP_CONSTANT_EXPRESSION = 36; // any place in the grammar where contant expression is expected (constant/local constant declaration, switch label, goto case)

    public const short CSHARP_ATTRIBUTES = 37; // list of attribute sections where expected
    public const short CSHARP_QUALIFIER = 38; // namespace qualification in namespace declaration, interface qualification in overridable member declaration
    public const short CSHARP_KEYWORD = 39; // keyword

    // general common roles
    public const short LAST = 100;
  }

}