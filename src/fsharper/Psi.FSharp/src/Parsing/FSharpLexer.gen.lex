using JetBrains;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using JetBrains.Util;
using System.Collections;

%%

%unicode

%namespace JetBrains.ReSharper.Psi.FSharp.Parsing
%class FSharpLexerGenerated
%public
%implements ILexer
%function _locateToken
%type TokenNodeType
%eofval{ 
  currTokenType = null; return currTokenType;
%eofval}

NULL_CHAR=\u0000
CARRIAGE_RETURN_CHAR=\u000D
LINE_FEED_CHAR=\u000A
NEW_LINE_PAIR={CARRIAGE_RETURN_CHAR}{LINE_FEED_CHAR}
NEW_LINE_CHAR=({CARRIAGE_RETURN_CHAR}|{LINE_FEED_CHAR}|(\u0085)|(\u2028)|(\u2029))
NOT_NEW_LINE=([^\u0085\u2028\u2029\u000D\u000A])
NOT_NEW_LINE_NUMBER_WS=([^\#\u0085)\u2028\u2029\n\r\ \t\f\u0009\u000B\u000C])


INPUT_CHARACTER={NOT_NEW_LINE}
ASTERISKS="*"+

%include ../../../../../tools/UnicodeGroupGenerator/Unicode.lex

WHITE_SPACE_CHAR=({UNICODE_ZS}|(\u0009)|(\u000B)|(\u000C)|(\u200B)|(\uFEFF)|{NULL_CHAR})

DELIMITED_COMMENT_SECTION=([^\*]|({ASTERISKS}[^\*\/]))
UNFINISHED_DELIMITED_COMMENT="(*"{DELIMITED_COMMENT_SECTION}*
DELIMITED_COMMENT={UNFINISHED_DELIMITED_COMMENT}{ASTERISKS}"/"

SINGLE_LINE_COMMENT=("//"{INPUT_CHARACTER}*)

DECIMAL_DIGIT=[0-9]
HEX_DIGIT=({DECIMAL_DIGIT}|[A-Fa-f])
OCT_DIGIT=[0-7]
BIN_DIGIT=[0-1]
INTEGER_TYPE_SUFFIX=([UuLl]|UL|Ul|uL|ul|LU|lU|Lu|lu)


DECIMAL_INTEGER_LITERAL=({DECIMAL_DIGIT}+{INTEGER_TYPE_SUFFIX}?)
HEXADECIMAL_INTEGER_LITERAL=(0[Xx]({HEX_DIGIT})*{INTEGER_TYPE_SUFFIX}?)


EXPONENT_PART=([eE](([+-])?({DECIMAL_DIGIT})*))
REAL_TYPE_SUFFIX=[FfDdMm]
REAL_LITERAL=({DECIMAL_DIGIT}*"."{DECIMAL_DIGIT}+({EXPONENT_PART})?{REAL_TYPE_SUFFIX}?)|({DECIMAL_DIGIT}+({EXPONENT_PART}|({EXPONENT_PART}?{REAL_TYPE_SUFFIX})))

SINGLE_CHARACTER=[^\'\\\u0085\u2028\u2029\u000D\u000A]
SIMPLE_ESCAPE_SEQUENCE=(\\[\'\"\\0abfnrtv])
HEXADECIMAL_ESCAPE_SEQUENCE=(\\x{HEX_DIGIT}({HEX_DIGIT}|{HEX_DIGIT}{HEX_DIGIT}|{HEX_DIGIT}{HEX_DIGIT}{HEX_DIGIT})?)
UNICODE_ESCAPE_SEQUENCE=((\\u{HEX_DIGIT}{HEX_DIGIT}{HEX_DIGIT}{HEX_DIGIT})|(\\U{HEX_DIGIT}{HEX_DIGIT}{HEX_DIGIT}{HEX_DIGIT}{HEX_DIGIT}{HEX_DIGIT}{HEX_DIGIT}{HEX_DIGIT}))
CHARACTER=({SINGLE_CHARACTER}|{SIMPLE_ESCAPE_SEQUENCE}|{HEXADECIMAL_ESCAPE_SEQUENCE}|{UNICODE_ESCAPE_SEQUENCE})
BAD_ESCAPE_SEQUENCE=((\\u)|(\\[^\'\"\\0abfnrtv]))
CHARACTER_LITERAL=\'({CHARACTER})\'
UNFINISHED_CHARACTER_LITERAL=\'(({CHARACTER})|({BAD_ESCAPE_SEQUENCE}(\'?))|\')
EXCEEDING_CHARACTER_LITERAL=\'{CHARACTER}({CHARACTER}|{BAD_ESCAPE_SEQUENCE})+\'

DECIMAL_DIGIT_CHARACTER={UNICODE_ND}
CONNECTING_CHARACTER={UNICODE_PC}
COMBINING_CHARACTER=({UNICODE_MC}|{UNICODE_MN})
FORMATTING_CHARACTER={UNICODE_CF}
LETTER_CHARACTER=({UNICODE_LL}|{UNICODE_LM}|{UNICODE_LO}|{UNICODE_LT}|{UNICODE_LU}|{UNICODE_NL}|{UNICODE_ESCAPE_SEQUENCE})

SINGLE_QUOTE=\'
IDENTIFIER_SURROUNDED_BY_DOUBLE_BACKTICK=``([^`\n\r\t]|`[^`\n\r\t])+``
IDENTIFIER_START_CHARACTER=({LETTER_CHARACTER}|(\u005F))
IDENTIFIER_PART_CHARACTER=({LETTER_CHARACTER}|{DECIMAL_DIGIT_CHARACTER}|{CONNECTING_CHARACTER}|{COMBINING_CHARACTER}|{FORMATTING_CHARACTER}|{SINGLE_QUOTE})
IDENTIFIER=({LETTER_CHARACTER}|{IDENTIFIER_START_CHARACTER}{IDENTIFIER_PART_CHARACTER}+|{IDENTIFIER_SURROUNDED_BY_DOUBLE_BACKTICK})

TYPE_VARIABLE=\'{IDENTIFIER}

REGULAR_STRING_LITERAL_CHARACTER=({SINGLE_REGULAR_STRING_LITERAL_CHARACTER}|{SIMPLE_ESCAPE_SEQUENCE}|{HEXADECIMAL_ESCAPE_SEQUENCE}|{UNICODE_ESCAPE_SEQUENCE})
SINGLE_REGULAR_STRING_LITERAL_CHARACTER=[^\"\\\u0085\u2028\u2029\u000D\u000A]
REGULAR_STRING_LITERAL=(\"{REGULAR_STRING_LITERAL_CHARACTER}*\")

VERBATIM_STRING_LITERAL=(\@\"{VERBATIM_STRING_LITERAL_CHARACTER}*\")
VERBATIM_STRING_LITERAL_CHARACTER=({SINGLE_VERBATIM_STRING_LITERAL_CHARACTER}|{QUOTE_ESCAPE_SEQUENCE})
SINGLE_VERBATIM_STRING_LITERAL_CHARACTER=[^\"]
QUOTE_ESCAPE_SEQUENCE=(\"\")

TRIPLE_QUOTED_STRING=\"\"\"{SIMPLE_CHAR_OR_QUOTE_CHAR_SEQUENCE}*\"\"\"
SIMPLE_CHAR_OR_QUOTE_CHAR_SEQUENCE=([^\"]|(\"[^\"])|(\"\"[^\"]))

STRING_LITERAL=({REGULAR_STRING_LITERAL}|{VERBATIM_STRING_LITERAL}|{TRIPLE_QUOTED_STRING})
UNFINISHED_REGULAR_STRING_LITERAL=(\"{REGULAR_STRING_LITERAL_CHARACTER}*)
UNFINISHED_VERBATIM_STRING_LITERAL=(@\"{VERBATIM_STRING_LITERAL_CHARACTER}*)
ERROR_REGULAR_STRING_LITERAL=(\"{REGULAR_STRING_LITERAL_CHARACTER}*{BAD_ESCAPE_SEQUENCE}({BAD_ESCAPE_SEQUENCE}|{REGULAR_STRING_LITERAL_CHARACTER})*\"?)
ERROR_STRING_LITERAL=({UNFINISHED_REGULAR_STRING_LITERAL}|{UNFINISHED_VERBATIM_STRING_LITERAL}|{ERROR_REGULAR_STRING_LITERAL})

HEX_LITERAL=(0[xX]{HEX_DIGIT}+)
OCT_LITERAL=(0[oO]{OCT_DIGIT}+)
BIN_LITERAL=(0[bB]{BIN_DIGIT}+)
UINT_LITERAL = (({DECIMAL_DIGIT}+)|{HEX_LITERAL}|{OCT_LITERAL}|{BIN_LITERAL})
INT_LITERAL = -?{UINT_LITERAL}

INT8_LITERAL = {INT_LITERAL}y
UINT8_LITERAL = {UINT_LITERAL}uy

INT16_LITERAL = {INT_LITERAL}s
UINT16_LITERAL = {UINT_LITERAL}us
INT32_LITERAL = {INT_LITERAL}l
UINT32_LITERAL = {UINT_LITERAL}ul?
NATIVEINT_LITERAL = {INT_LITERAL}n
UNATIVEINT_LITERAL = {UINT_LITERAL}un
INT64_LITERAL = {INT_LITERAL}L
UINT64_LITERAL = {UINT_LITERAL}[uU]L

BIGNUM_LITERAL=({DECIMAL_DIGIT}+[QRZING])

DECIMAL_LITERAL=((-?{DECIMAL_DIGIT}+)|{FLOAT_LITERAL})[Mm]

FLOAT_LITERAL = ((-?{DECIMAL_DIGIT}+"."{DECIMAL_DIGIT}*)|(-?{DECIMAL_DIGIT}+("."{DECIMAL_DIGIT}*)?([eE])(([+-])?){DECIMAL_DIGIT}+))
			
FLOAT32_LITERAL = (({FLOAT_LITERAL}[fF])|({HEX_LITERAL}lf)|({OCT_LITERAL}lf)|({BIN_LITERAL}lf))
FLOAT64_LITERAL = (({FLOAT_LITERAL})|({HEX_LITERAL}LF)|({OCT_LITERAL}LF)|({BIN_LITERAL}LF))

NOT_NUMBER_SIGN=[^#]
PP_NUMBER_SIGN=#

PP_BAD_DIRECTIVE=(define|undef|if|elif|else|endif|error|warning|region|endregion|line|pragma)({IDENTIFIER}|{DECIMAL_DIGIT})

PP_FILENAME_CHARACTER=[^\"\r\n\u0085\u2028\u2029]

PP_FILENAME=(\"{PP_FILENAME_CHARACTER}+\")
PP_BAD_FILENAME=(\"{PP_FILENAME_CHARACTER}+)
PP_DEC_DIGITS={DECIMAL_DIGIT}+

PP_CONDITIONAL_SYMBOL={IDENTIFIER}

WHITE_SPACE=({WHITE_SPACE_CHAR}+)
END_LINE={NOT_NEW_LINE}*(({PP_NEW_LINE_PAIR})|({PP_NEW_LINE_CHAR}))

%% 

<YYINITIAL> {INT_LITERAL} { currTokenType = makeToken (FSharpTokenType.INT_LITERAL); return currTokenType; }
<YYINITIAL> {INT8_LITERAL} { currTokenType = makeToken (FSharpTokenType.INT8_LITERAL); return currTokenType; }
<YYINITIAL> {UINT8_LITERAL} { currTokenType = makeToken (FSharpTokenType.UINT8_LITERAL); return currTokenType; }
<YYINITIAL> {INT16_LITERAL} { currTokenType = makeToken (FSharpTokenType.INT16_LITERAL); return currTokenType; }
<YYINITIAL> {UINT16_LITERAL} { currTokenType = makeToken (FSharpTokenType.UINT16_LITERAL); return currTokenType; }
<YYINITIAL> {INT32_LITERAL} { currTokenType = makeToken (FSharpTokenType.INT32_LITERAL); return currTokenType; }
<YYINITIAL> {UINT32_LITERAL} { currTokenType = makeToken (FSharpTokenType.UINT32_LITERAL); return currTokenType; }
<YYINITIAL> {NATIVEINT_LITERAL} { currTokenType = makeToken (FSharpTokenType.NATIVEINT_LITERAL); return currTokenType; }
<YYINITIAL> {UNATIVEINT_LITERAL} { currTokenType = makeToken (FSharpTokenType.UNATIVEINT_LITERAL); return currTokenType; }
<YYINITIAL> {INT64_LITERAL} { currTokenType = makeToken (FSharpTokenType.INT64_LITERAL); return currTokenType; }
<YYINITIAL> {UINT64_LITERAL} { currTokenType = makeToken (FSharpTokenType.UINT64_LITERAL); return currTokenType; }

<YYINITIAL> {BIGNUM_LITERAL} { return makeToken(FSharpTokenType.BIGNUM_LITERAL); }
<YYINITIAL> {DECIMAL_LITERAL} { return makeToken(FSharpTokenType.DECIMAL_LITERAL); }

<YYINITIAL> {FLOAT32_LITERAL} { currTokenType = makeToken (FSharpTokenType.FLOAT_LITERAL); return currTokenType; }
<YYINITIAL> {FLOAT64_LITERAL} { currTokenType = makeToken (FSharpTokenType.FLOAT_LITERAL); return currTokenType; }

<YYINITIAL> {NEW_LINE_PAIR} { yybegin(YYINITIAL); return makeToken(FSharpTokenType.NEW_LINE); }
<YYINITIAL> {NEW_LINE_CHAR} { yybegin(YYINITIAL); return makeToken(FSharpTokenType.NEW_LINE); }

<YYINITIAL> {DELIMITED_COMMENT}  { return makeToken(FSharpTokenType.C_STYLE_COMMENT); }
<YYINITIAL> {SINGLE_LINE_COMMENT}  { yybegin(YYINITIAL); return makeToken(FSharpTokenType.END_OF_LINE_COMMENT); }
<YYINITIAL> {UNFINISHED_DELIMITED_COMMENT} { return makeToken(FSharpTokenType.C_STYLE_COMMENT); }

<YYINITIAL> {CHARACTER_LITERAL} { currTokenType = makeToken (FSharpTokenType.CHARACTER_LITERAL); return currTokenType; }
<YYINITIAL> {TYPE_VARIABLE} { currTokenType = makeToken (FSharpTokenType.TYPE_VARIABLE); return currTokenType; }
<YYINITIAL> {STRING_LITERAL} { currTokenType = makeToken (FSharpTokenType.STRING_LITERAL); return currTokenType; }

<YYINITIAL> {WHITE_SPACE} { currTokenType = makeToken(FSharpTokenType.WHITE_SPACE); return currTokenType; }

<YYINITIAL> {IDENTIFIER} { currTokenType = makeToken(getKeyword() ?? FSharpTokenType.IDENTIFIER); return currTokenType; }

<YYINITIAL> "@" { currTokenType = makeToken(FSharpTokenType.AT); return currTokenType; }
<YYINITIAL> "_" { currTokenType = makeToken(FSharpTokenType.UNDERSCORE); return currTokenType; }
<YYINITIAL> "<@" { currTokenType = makeToken(FSharpTokenType.LQUOTE); return currTokenType; }
<YYINITIAL> "<@@" { currTokenType = makeToken(FSharpTokenType.LDQUOTE); return currTokenType; }
<YYINITIAL> "<|" { currTokenType = makeToken(FSharpTokenType.BACKWARD_PIPE); return currTokenType; }
<YYINITIAL> "|>" { currTokenType = makeToken(FSharpTokenType.FORWARD_PIPE); return currTokenType; }
<YYINITIAL> "@>" { currTokenType = makeToken(FSharpTokenType.RQUOTE); return currTokenType; }
<YYINITIAL> "@@>" { currTokenType = makeToken(FSharpTokenType.RDQUOTE); return currTokenType; }
<YYINITIAL> "#" { currTokenType = makeToken(FSharpTokenType.HASH); return currTokenType; }
<YYINITIAL> "&" { currTokenType = makeToken(FSharpTokenType.AMP); return currTokenType; }
<YYINITIAL> "&&" { currTokenType = makeToken(FSharpTokenType.AMP_AMP); return currTokenType; }
<YYINITIAL> "||" { currTokenType = makeToken(FSharpTokenType.BAR_BAR); return currTokenType; }
<YYINITIAL> "\'" { currTokenType = makeToken(FSharpTokenType.QUOTE); return currTokenType; }
<YYINITIAL> "(" { currTokenType = makeToken(FSharpTokenType.LPAREN); return currTokenType; }
<YYINITIAL> ")" { currTokenType = makeToken(FSharpTokenType.RPAREN); return currTokenType; }
<YYINITIAL> "**" { currTokenType = makeToken(FSharpTokenType.STAR_STAR); return currTokenType; }
<YYINITIAL> "*" { currTokenType = makeToken(FSharpTokenType.STAR); return currTokenType; }
<YYINITIAL> "," { currTokenType = makeToken(FSharpTokenType.COMMA); return currTokenType; }
<YYINITIAL> "->" { currTokenType = makeToken(FSharpTokenType.RARROW); return currTokenType; }
<YYINITIAL> "?" { currTokenType = makeToken(FSharpTokenType.QMARK); return currTokenType; }
<YYINITIAL> "??" { currTokenType = makeToken(FSharpTokenType.QMARK_QMARK); return currTokenType; }
<YYINITIAL> ".." { currTokenType = makeToken(FSharpTokenType.DOT_DOT); return currTokenType; }
<YYINITIAL> "." { currTokenType = makeToken(FSharpTokenType.DOT); return currTokenType; }
<YYINITIAL> ":" { currTokenType = makeToken(FSharpTokenType.COLON); return currTokenType; }
<YYINITIAL> "::" { currTokenType = makeToken(FSharpTokenType.COLON_COLON); return currTokenType; }
<YYINITIAL> ":>" { currTokenType = makeToken(FSharpTokenType.COLON_GREATER); return currTokenType; }
<YYINITIAL> "@>." { currTokenType = makeToken(FSharpTokenType.RQUOTE_DOT); return currTokenType; }
<YYINITIAL> "@@>." { currTokenType = makeToken(FSharpTokenType.RDQUOTE_DOT); return currTokenType; }
<YYINITIAL> ">|]" { currTokenType = makeToken(FSharpTokenType.GREATER_BAR_RBRACK); return currTokenType; }
<YYINITIAL> ":?>" { currTokenType = makeToken(FSharpTokenType.COLON_QMARK_GREATER); return currTokenType; }
<YYINITIAL> ":?" { currTokenType = makeToken(FSharpTokenType.COLON_QMARK); return currTokenType; }
<YYINITIAL> ":=" { currTokenType = makeToken(FSharpTokenType.COLON_EQUALS); return currTokenType; }
<YYINITIAL> ";;" { currTokenType = makeToken(FSharpTokenType.SEMICOLON_SEMICOLON); return currTokenType; }
<YYINITIAL> ";" { currTokenType = makeToken(FSharpTokenType.SEMICOLON); return currTokenType; }
<YYINITIAL> "<-" { currTokenType = makeToken(FSharpTokenType.LARROW); return currTokenType; }
<YYINITIAL> "=" { currTokenType = makeToken(FSharpTokenType.EQUALS); return currTokenType; }
<YYINITIAL> "[" { currTokenType = makeToken(FSharpTokenType.LBRACK); return currTokenType; }
<YYINITIAL> "[|" { currTokenType = makeToken(FSharpTokenType.LBRACK_BAR); return currTokenType; }
<YYINITIAL> "[<" { currTokenType = makeToken(FSharpTokenType.LBRACK_LESS); return currTokenType; }
<YYINITIAL> "]" { currTokenType = makeToken(FSharpTokenType.RBRACK); return currTokenType; }
<YYINITIAL> "|]" { currTokenType = makeToken(FSharpTokenType.BAR_RBRACK); return currTokenType; }
<YYINITIAL> ">]" { currTokenType = makeToken(FSharpTokenType.GREATER_RBRACK); return currTokenType; }
<YYINITIAL> "{" { currTokenType = makeToken(FSharpTokenType.LBRACE); return currTokenType; }
<YYINITIAL> "|" { currTokenType = makeToken(FSharpTokenType.BAR); return currTokenType; }
<YYINITIAL> "}" { currTokenType = makeToken(FSharpTokenType.RBRACE); return currTokenType; }
<YYINITIAL> "$" { currTokenType = makeToken(FSharpTokenType.DOLLAR); return currTokenType; }
<YYINITIAL> "%%" { currTokenType = makeToken(FSharpTokenType.DPERCENT_OP); return currTokenType; }
<YYINITIAL> "-" { currTokenType = makeToken(FSharpTokenType.MINUS); return currTokenType; }
<YYINITIAL> "~" { currTokenType = makeToken(FSharpTokenType.TILDE); return currTokenType; }
<YYINITIAL> "`" { currTokenType = makeToken(FSharpTokenType.RESERVED); return currTokenType; }
<YYINITIAL> "<>" { currTokenType = makeToken(FSharpTokenType.LESS_GREATER); return currTokenType; }
<YYINITIAL> "<=" { currTokenType = makeToken(FSharpTokenType.LESS_EQUALS); return currTokenType; }
<YYINITIAL> ">=" { currTokenType = makeToken(FSharpTokenType.GREATER_EQUALS); return currTokenType; }
<YYINITIAL> ">>" { currTokenType = makeToken(FSharpTokenType.GREATER_GREATER); return currTokenType; }
<YYINITIAL> "<<" { currTokenType = makeToken(FSharpTokenType.LESS_LESS); return currTokenType; }


<YYINITIAL> "{" { return makeToken(FSharpTokenType.LBRACE); }
<YYINITIAL> "}" { return makeToken(FSharpTokenType.RBRACE); }
<YYINITIAL> "[" { return makeToken(FSharpTokenType.LBRACKET); }
<YYINITIAL> "]" { return makeToken(FSharpTokenType.RBRACKET); }
<YYINITIAL> "(" { return makeToken(FSharpTokenType.LPARENTH); }
<YYINITIAL> ")" { return makeToken(FSharpTokenType.RPARENTH); }
<YYINITIAL> "." { return makeToken(FSharpTokenType.DOT); }
<YYINITIAL> "," { return makeToken(FSharpTokenType.COMMA); }
<YYINITIAL> ":" { return makeToken(FSharpTokenType.COLON); }
<YYINITIAL> ";" { return makeToken(FSharpTokenType.SEMICOLON); }

<YYINITIAL> "+" { return makeToken(FSharpTokenType.PLUS); }
<YYINITIAL> "-" { return makeToken(FSharpTokenType.MINUS); }
<YYINITIAL> "*" { return makeToken(FSharpTokenType.STAR); }
<YYINITIAL> "/" { return makeToken(FSharpTokenType.DIV); }
<YYINITIAL> "%" { return makeToken(FSharpTokenType.PERCENT); }
<YYINITIAL> "&" { return makeToken(FSharpTokenType.AND); }
<YYINITIAL> "|" { return makeToken(FSharpTokenType.OR); }
<YYINITIAL> "^^^" { return makeToken(FSharpTokenType.BITWISE_XOR); }
<YYINITIAL> "!" { return makeToken(FSharpTokenType.EXCLAMATION_OP); }
<YYINITIAL> "~" { return makeToken(FSharpTokenType.TILDE); }

<YYINITIAL> "=" { return makeToken(FSharpTokenType.EQ); }
<YYINITIAL> "<" { currTokenType = makeToken(FSharpTokenType.LESS); return currTokenType; }
<YYINITIAL> ">" { currTokenType = makeToken(FSharpTokenType.GREATER); return currTokenType; }
<YYINITIAL> "?" { return makeToken(FSharpTokenType.QUEST); }

<YYINITIAL> {REAL_LITERAL}  { return makeToken(FSharpTokenType.FLOAT_LITERAL); }
<YYINITIAL> {CHARACTER_LITERAL}  { return makeToken(FSharpTokenType.CHARACTER_LITERAL); }
<YYINITIAL> {UNFINISHED_CHARACTER_LITERAL} { return makeToken(FSharpTokenType.CHARACTER_LITERAL); }

<YYINITIAL> {STRING_LITERAL}  { return makeToken(FSharpTokenType.STRING_LITERAL); }
<YYINITIAL> {ERROR_STRING_LITERAL}  { return makeToken(FSharpTokenType.STRING_LITERAL); }

<YYINITIAL> . { currTokenType = makeToken(FSharpTokenType.BAD_CHARACTER); return currTokenType; } 