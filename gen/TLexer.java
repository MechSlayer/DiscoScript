// Generated from C:/Users/Kim/RiderProjects/DiscoScript/DiscoScript.Parser/Lexer\TLexer.g4 by ANTLR 4.8
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class TLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		OpenBracket=1, CloseBracket=2, OpenParen=3, CloseParen=4, OpenBrace=5, 
		CloseBrace=6, SemiColon=7, Comma=8, Assign=9, QuestionMark=10, Colon=11, 
		Ellipsis=12, Dot=13, PlusPlus=14, MinusMinus=15, Plus=16, Minus=17, BitNot=18, 
		Not=19, Multiply=20, Divide=21, Modulus=22, Power=23, NullCoalesce=24, 
		Hashtag=25, RightShiftArithmetic=26, LeftShiftArithmetic=27, RightShiftLogical=28, 
		LessThan=29, MoreThan=30, LessThanEquals=31, GreaterThanEquals=32, Equals_=33, 
		NotEquals=34, IdentityEquals=35, IdentityNotEquals=36, BitAnd=37, BitXOr=38, 
		BitOr=39, And=40, Or=41, MultiplyAssign=42, DivideAssign=43, ModulusAssign=44, 
		PlusAssign=45, MinusAssign=46, LeftShiftArithmeticAssign=47, RightShiftArithmeticAssign=48, 
		RightShiftLogicalAssign=49, BitAndAssign=50, BitXorAssign=51, BitOrAssign=52, 
		PowerAssign=53, ARROW=54, NullLiteral=55, BooleanLiteral=56, DecimalLiteral=57, 
		HexIntegerLiteral=58, OctalIntegerLiteral=59, OctalIntegerLiteral2=60, 
		BinaryIntegerLiteral=61, BigHexIntegerLiteral=62, BigOctalIntegerLiteral=63, 
		BigBinaryIntegerLiteral=64, BigDecimalIntegerLiteral=65, Break=66, New=67, 
		Var=68, Continue=69, While=70, Function=71, Class=72, Import=73, TemplateStringLiteral=74, 
		WhiteSpaces=75, LineTerminator=76, Identifier=77, StringLiteral=78;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"OpenBracket", "CloseBracket", "OpenParen", "CloseParen", "OpenBrace", 
			"CloseBrace", "SemiColon", "Comma", "Assign", "QuestionMark", "Colon", 
			"Ellipsis", "Dot", "PlusPlus", "MinusMinus", "Plus", "Minus", "BitNot", 
			"Not", "Multiply", "Divide", "Modulus", "Power", "NullCoalesce", "Hashtag", 
			"RightShiftArithmetic", "LeftShiftArithmetic", "RightShiftLogical", "LessThan", 
			"MoreThan", "LessThanEquals", "GreaterThanEquals", "Equals_", "NotEquals", 
			"IdentityEquals", "IdentityNotEquals", "BitAnd", "BitXOr", "BitOr", "And", 
			"Or", "MultiplyAssign", "DivideAssign", "ModulusAssign", "PlusAssign", 
			"MinusAssign", "LeftShiftArithmeticAssign", "RightShiftArithmeticAssign", 
			"RightShiftLogicalAssign", "BitAndAssign", "BitXorAssign", "BitOrAssign", 
			"PowerAssign", "ARROW", "NullLiteral", "BooleanLiteral", "DecimalLiteral", 
			"HexIntegerLiteral", "OctalIntegerLiteral", "OctalIntegerLiteral2", "BinaryIntegerLiteral", 
			"BigHexIntegerLiteral", "BigOctalIntegerLiteral", "BigBinaryIntegerLiteral", 
			"BigDecimalIntegerLiteral", "Break", "New", "Var", "Continue", "While", 
			"Function", "Class", "Import", "TemplateStringLiteral", "WhiteSpaces", 
			"LineTerminator", "Identifier", "StringLiteral", "DoubleStringCharacter", 
			"SingleStringCharacter", "EscapeSequence", "CharacterEscapeSequence", 
			"HexEscapeSequence", "UnicodeEscapeSequence", "ExtendedUnicodeEscapeSequence", 
			"SingleEscapeCharacter", "NonEscapeCharacter", "EscapeCharacter", "LineContinuation", 
			"HexDigit", "DecimalIntegerLiteral", "ExponentPart", "IdentifierPart", 
			"IdentifierStart", "UnicodeLetter", "UnicodeCombiningMark", "UnicodeDigit", 
			"UnicodeConnectorPunctuation", "RegularExpressionFirstChar", "RegularExpressionChar", 
			"RegularExpressionClassChar", "RegularExpressionBackslashSequence"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'['", "']'", "'('", "')'", "'{'", "'}'", "';'", "','", "'='", 
			"'?'", "':'", "'...'", "'.'", "'++'", "'--'", "'+'", "'-'", "'~'", "'!'", 
			"'*'", "'/'", "'%'", "'**'", "'??'", "'#'", "'>>'", "'<<'", "'>>>'", 
			"'<'", "'>'", "'<='", "'>='", "'=='", "'!='", "'==='", "'!=='", "'&'", 
			"'^'", "'|'", "'&&'", "'||'", "'*='", "'/='", "'%='", "'+='", "'-='", 
			"'<<='", "'>>='", "'>>>='", "'&='", "'^='", "'|='", "'**='", "'=>'", 
			"'nulo'", null, null, null, null, null, null, null, null, null, null, 
			"'romper'", "'nuevo'", "'var'", "'continuar'", "'mientras'", "'funcion'", 
			"'clase'", "'importar'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "OpenBracket", "CloseBracket", "OpenParen", "CloseParen", "OpenBrace", 
			"CloseBrace", "SemiColon", "Comma", "Assign", "QuestionMark", "Colon", 
			"Ellipsis", "Dot", "PlusPlus", "MinusMinus", "Plus", "Minus", "BitNot", 
			"Not", "Multiply", "Divide", "Modulus", "Power", "NullCoalesce", "Hashtag", 
			"RightShiftArithmetic", "LeftShiftArithmetic", "RightShiftLogical", "LessThan", 
			"MoreThan", "LessThanEquals", "GreaterThanEquals", "Equals_", "NotEquals", 
			"IdentityEquals", "IdentityNotEquals", "BitAnd", "BitXOr", "BitOr", "And", 
			"Or", "MultiplyAssign", "DivideAssign", "ModulusAssign", "PlusAssign", 
			"MinusAssign", "LeftShiftArithmeticAssign", "RightShiftArithmeticAssign", 
			"RightShiftLogicalAssign", "BitAndAssign", "BitXorAssign", "BitOrAssign", 
			"PowerAssign", "ARROW", "NullLiteral", "BooleanLiteral", "DecimalLiteral", 
			"HexIntegerLiteral", "OctalIntegerLiteral", "OctalIntegerLiteral2", "BinaryIntegerLiteral", 
			"BigHexIntegerLiteral", "BigOctalIntegerLiteral", "BigBinaryIntegerLiteral", 
			"BigDecimalIntegerLiteral", "Break", "New", "Var", "Continue", "While", 
			"Function", "Class", "Import", "TemplateStringLiteral", "WhiteSpaces", 
			"LineTerminator", "Identifier", "StringLiteral"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


	public TLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "TLexer.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	@Override
	public void action(RuleContext _localctx, int ruleIndex, int actionIndex) {
		switch (ruleIndex) {
		case 77:
			StringLiteral_action((RuleContext)_localctx, actionIndex);
			break;
		}
	}
	private void StringLiteral_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 0:
			this.ProcessStringLiteral();
			break;
		}
	}
	@Override
	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 58:
			return OctalIntegerLiteral_sempred((RuleContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean OctalIntegerLiteral_sempred(RuleContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return !this.IsStrictMode();
		}
		return true;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2P\u02d6\b\1\4\2\t"+
		"\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!"+
		"\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t+\4"+
		",\t,\4-\t-\4.\t.\4/\t/\4\60\t\60\4\61\t\61\4\62\t\62\4\63\t\63\4\64\t"+
		"\64\4\65\t\65\4\66\t\66\4\67\t\67\48\t8\49\t9\4:\t:\4;\t;\4<\t<\4=\t="+
		"\4>\t>\4?\t?\4@\t@\4A\tA\4B\tB\4C\tC\4D\tD\4E\tE\4F\tF\4G\tG\4H\tH\4I"+
		"\tI\4J\tJ\4K\tK\4L\tL\4M\tM\4N\tN\4O\tO\4P\tP\4Q\tQ\4R\tR\4S\tS\4T\tT"+
		"\4U\tU\4V\tV\4W\tW\4X\tX\4Y\tY\4Z\tZ\4[\t[\4\\\t\\\4]\t]\4^\t^\4_\t_\4"+
		"`\t`\4a\ta\4b\tb\4c\tc\4d\td\4e\te\4f\tf\4g\tg\3\2\3\2\3\3\3\3\3\4\3\4"+
		"\3\5\3\5\3\6\3\6\3\7\3\7\3\b\3\b\3\b\3\b\3\t\3\t\3\n\3\n\3\13\3\13\3\f"+
		"\3\f\3\r\3\r\3\r\3\r\3\16\3\16\3\17\3\17\3\17\3\20\3\20\3\20\3\21\3\21"+
		"\3\22\3\22\3\23\3\23\3\24\3\24\3\25\3\25\3\26\3\26\3\27\3\27\3\30\3\30"+
		"\3\30\3\31\3\31\3\31\3\32\3\32\3\33\3\33\3\33\3\34\3\34\3\34\3\35\3\35"+
		"\3\35\3\35\3\36\3\36\3\37\3\37\3 \3 \3 \3!\3!\3!\3\"\3\"\3\"\3#\3#\3#"+
		"\3$\3$\3$\3$\3%\3%\3%\3%\3&\3&\3\'\3\'\3(\3(\3)\3)\3)\3*\3*\3*\3+\3+\3"+
		"+\3,\3,\3,\3-\3-\3-\3.\3.\3.\3/\3/\3/\3\60\3\60\3\60\3\60\3\61\3\61\3"+
		"\61\3\61\3\62\3\62\3\62\3\62\3\62\3\63\3\63\3\63\3\64\3\64\3\64\3\65\3"+
		"\65\3\65\3\66\3\66\3\66\3\66\3\67\3\67\3\67\38\38\38\38\38\39\39\39\3"+
		"9\39\39\39\39\39\39\39\39\39\39\59\u0177\n9\3:\3:\3:\3:\7:\u017d\n:\f"+
		":\16:\u0180\13:\3:\5:\u0183\n:\3:\3:\3:\7:\u0188\n:\f:\16:\u018b\13:\3"+
		":\5:\u018e\n:\3:\3:\5:\u0192\n:\5:\u0194\n:\3;\3;\3;\3;\7;\u019a\n;\f"+
		";\16;\u019d\13;\3<\3<\6<\u01a1\n<\r<\16<\u01a2\3<\3<\3=\3=\3=\3=\7=\u01ab"+
		"\n=\f=\16=\u01ae\13=\3>\3>\3>\3>\7>\u01b4\n>\f>\16>\u01b7\13>\3?\3?\3"+
		"?\3?\7?\u01bd\n?\f?\16?\u01c0\13?\3?\3?\3@\3@\3@\3@\7@\u01c8\n@\f@\16"+
		"@\u01cb\13@\3@\3@\3A\3A\3A\3A\7A\u01d3\nA\fA\16A\u01d6\13A\3A\3A\3B\3"+
		"B\3B\3C\3C\3C\3C\3C\3C\3C\3D\3D\3D\3D\3D\3D\3E\3E\3E\3E\3F\3F\3F\3F\3"+
		"F\3F\3F\3F\3F\3F\3G\3G\3G\3G\3G\3G\3G\3G\3G\3H\3H\3H\3H\3H\3H\3H\3H\3"+
		"I\3I\3I\3I\3I\3I\3J\3J\3J\3J\3J\3J\3J\3J\3J\3K\3K\3K\3K\7K\u021c\nK\f"+
		"K\16K\u021f\13K\3K\3K\3L\6L\u0224\nL\rL\16L\u0225\3L\3L\3M\3M\3M\3M\3"+
		"N\3N\7N\u0230\nN\fN\16N\u0233\13N\3O\3O\7O\u0237\nO\fO\16O\u023a\13O\3"+
		"O\3O\3O\7O\u023f\nO\fO\16O\u0242\13O\3O\5O\u0245\nO\3O\3O\3P\3P\3P\3P"+
		"\5P\u024d\nP\3Q\3Q\3Q\3Q\5Q\u0253\nQ\3R\3R\3R\3R\3R\5R\u025a\nR\3S\3S"+
		"\5S\u025e\nS\3T\3T\3T\3T\3U\3U\3U\3U\3U\3U\3U\3U\3U\3U\6U\u026e\nU\rU"+
		"\16U\u026f\3U\3U\5U\u0274\nU\3V\3V\3V\6V\u0279\nV\rV\16V\u027a\3V\3V\3"+
		"W\3W\3X\3X\3Y\3Y\5Y\u0285\nY\3Z\3Z\3Z\3[\3[\3\\\3\\\3\\\7\\\u028f\n\\"+
		"\f\\\16\\\u0292\13\\\5\\\u0294\n\\\3]\3]\5]\u0298\n]\3]\6]\u029b\n]\r"+
		"]\16]\u029c\3^\3^\3^\3^\3^\5^\u02a4\n^\3_\3_\3_\3_\5_\u02aa\n_\3`\5`\u02ad"+
		"\n`\3a\5a\u02b0\na\3b\5b\u02b3\nb\3c\5c\u02b6\nc\3d\3d\3d\3d\7d\u02bc"+
		"\nd\fd\16d\u02bf\13d\3d\5d\u02c2\nd\3e\3e\3e\3e\7e\u02c8\ne\fe\16e\u02cb"+
		"\13e\3e\5e\u02ce\ne\3f\3f\5f\u02d2\nf\3g\3g\3g\2\2h\3\3\5\4\7\5\t\6\13"+
		"\7\r\b\17\t\21\n\23\13\25\f\27\r\31\16\33\17\35\20\37\21!\22#\23%\24\'"+
		"\25)\26+\27-\30/\31\61\32\63\33\65\34\67\359\36;\37= ?!A\"C#E$G%I&K\'"+
		"M(O)Q*S+U,W-Y.[/]\60_\61a\62c\63e\64g\65i\66k\67m8o9q:s;u<w=y>{?}@\177"+
		"A\u0081B\u0083C\u0085D\u0087E\u0089F\u008bG\u008dH\u008fI\u0091J\u0093"+
		"K\u0095L\u0097M\u0099N\u009bO\u009dP\u009f\2\u00a1\2\u00a3\2\u00a5\2\u00a7"+
		"\2\u00a9\2\u00ab\2\u00ad\2\u00af\2\u00b1\2\u00b3\2\u00b5\2\u00b7\2\u00b9"+
		"\2\u00bb\2\u00bd\2\u00bf\2\u00c1\2\u00c3\2\u00c5\2\u00c7\2\u00c9\2\u00cb"+
		"\2\u00cd\2\3\2 \3\2\62;\4\2\62;aa\4\2ZZzz\5\2\62;CHch\3\2\629\4\2QQqq"+
		"\4\2\629aa\4\2DDdd\3\2\62\63\4\2\62\63aa\3\2bb\6\2\13\13\r\16\"\"\u00a2"+
		"\u00a2\5\2\f\f\17\17\u202a\u202b\6\2\f\f\17\17$$^^\6\2\f\f\17\17))^^\13"+
		"\2$$))^^ddhhppttvvxx\16\2\f\f\17\17$$))\62;^^ddhhppttvxzz\5\2\62;wwzz"+
		"\6\2\62;CHaach\3\2\63;\4\2GGgg\4\2--//\4\2&&aa\u0101\2C\\c|\u00ac\u00ac"+
		"\u00b7\u00b7\u00bc\u00bc\u00c2\u00d8\u00da\u00f8\u00fa\u0221\u0224\u0235"+
		"\u0252\u02af\u02b2\u02ba\u02bd\u02c3\u02d2\u02d3\u02e2\u02e6\u02f0\u02f0"+
		"\u037c\u037c\u0388\u0388\u038a\u038c\u038e\u038e\u0390\u03a3\u03a5\u03d0"+
		"\u03d2\u03d9\u03dc\u03f5\u0402\u0483\u048e\u04c6\u04c9\u04ca\u04cd\u04ce"+
		"\u04d2\u04f7\u04fa\u04fb\u0533\u0558\u055b\u055b\u0563\u0589\u05d2\u05ec"+
		"\u05f2\u05f4\u0623\u063c\u0642\u064c\u0673\u06d5\u06d7\u06d7\u06e7\u06e8"+
		"\u06fc\u06fe\u0712\u0712\u0714\u072e\u0782\u07a7\u0907\u093b\u093f\u093f"+
		"\u0952\u0952\u095a\u0963\u0987\u098e\u0991\u0992\u0995\u09aa\u09ac\u09b2"+
		"\u09b4\u09b4\u09b8\u09bb\u09de\u09df\u09e1\u09e3\u09f2\u09f3\u0a07\u0a0c"+
		"\u0a11\u0a12\u0a15\u0a2a\u0a2c\u0a32\u0a34\u0a35\u0a37\u0a38\u0a3a\u0a3b"+
		"\u0a5b\u0a5e\u0a60\u0a60\u0a74\u0a76\u0a87\u0a8d\u0a8f\u0a8f\u0a91\u0a93"+
		"\u0a95\u0aaa\u0aac\u0ab2\u0ab4\u0ab5\u0ab7\u0abb\u0abf\u0abf\u0ad2\u0ad2"+
		"\u0ae2\u0ae2\u0b07\u0b0e\u0b11\u0b12\u0b15\u0b2a\u0b2c\u0b32\u0b34\u0b35"+
		"\u0b38\u0b3b\u0b3f\u0b3f\u0b5e\u0b5f\u0b61\u0b63\u0b87\u0b8c\u0b90\u0b92"+
		"\u0b94\u0b97\u0b9b\u0b9c\u0b9e\u0b9e\u0ba0\u0ba1\u0ba5\u0ba6\u0baa\u0bac"+
		"\u0bb0\u0bb7\u0bb9\u0bbb\u0c07\u0c0e\u0c10\u0c12\u0c14\u0c2a\u0c2c\u0c35"+
		"\u0c37\u0c3b\u0c62\u0c63\u0c87\u0c8e\u0c90\u0c92\u0c94\u0caa\u0cac\u0cb5"+
		"\u0cb7\u0cbb\u0ce0\u0ce0\u0ce2\u0ce3\u0d07\u0d0e\u0d10\u0d12\u0d14\u0d2a"+
		"\u0d2c\u0d3b\u0d62\u0d63\u0d87\u0d98\u0d9c\u0db3\u0db5\u0dbd\u0dbf\u0dbf"+
		"\u0dc2\u0dc8\u0e03\u0e32\u0e34\u0e35\u0e42\u0e48\u0e83\u0e84\u0e86\u0e86"+
		"\u0e89\u0e8a\u0e8c\u0e8c\u0e8f\u0e8f\u0e96\u0e99\u0e9b\u0ea1\u0ea3\u0ea5"+
		"\u0ea7\u0ea7\u0ea9\u0ea9\u0eac\u0ead\u0eaf\u0eb2\u0eb4\u0eb5\u0ebf\u0ec6"+
		"\u0ec8\u0ec8\u0ede\u0edf\u0f02\u0f02\u0f42\u0f6c\u0f8a\u0f8d\u1002\u1023"+
		"\u1025\u1029\u102b\u102c\u1052\u1057\u10a2\u10c7\u10d2\u10f8\u1102\u115b"+
		"\u1161\u11a4\u11aa\u11fb\u1202\u1208\u120a\u1248\u124a\u124a\u124c\u124f"+
		"\u1252\u1258\u125a\u125a\u125c\u125f\u1262\u1288\u128a\u128a\u128c\u128f"+
		"\u1292\u12b0\u12b2\u12b2\u12b4\u12b7\u12ba\u12c0\u12c2\u12c2\u12c4\u12c7"+
		"\u12ca\u12d0\u12d2\u12d8\u12da\u12f0\u12f2\u1310\u1312\u1312\u1314\u1317"+
		"\u131a\u1320\u1322\u1348\u134a\u135c\u13a2\u13f6\u1403\u1678\u1683\u169c"+
		"\u16a2\u16ec\u1782\u17b5\u1822\u1879\u1882\u18aa\u1e02\u1e9d\u1ea2\u1efb"+
		"\u1f02\u1f17\u1f1a\u1f1f\u1f22\u1f47\u1f4a\u1f4f\u1f52\u1f59\u1f5b\u1f5b"+
		"\u1f5d\u1f5d\u1f5f\u1f5f\u1f61\u1f7f\u1f82\u1fb6\u1fb8\u1fbe\u1fc0\u1fc0"+
		"\u1fc4\u1fc6\u1fc8\u1fce\u1fd2\u1fd5\u1fd8\u1fdd\u1fe2\u1fee\u1ff4\u1ff6"+
		"\u1ff8\u1ffe\u2081\u2081\u2104\u2104\u2109\u2109\u210c\u2115\u2117\u2117"+
		"\u211b\u211f\u2126\u2126\u2128\u2128\u212a\u212a\u212c\u212f\u2131\u2133"+
		"\u2135\u213b\u2162\u2185\u3007\u3009\u3023\u302b\u3033\u3037\u303a\u303c"+
		"\u3043\u3096\u309f\u30a0\u30a3\u30fc\u30fe\u3100\u3107\u312e\u3133\u3190"+
		"\u31a2\u31b9\u3402\u4dc1\u4e02\ua48e\uac02\uac02\ud7a5\ud7a5\uf902\ufa2f"+
		"\ufb02\ufb08\ufb15\ufb19\ufb1f\ufb1f\ufb21\ufb2a\ufb2c\ufb38\ufb3a\ufb3e"+
		"\ufb40\ufb40\ufb42\ufb43\ufb45\ufb46\ufb48\ufbb3\ufbd5\ufd3f\ufd52\ufd91"+
		"\ufd94\ufdc9\ufdf2\ufdfd\ufe72\ufe74\ufe76\ufe76\ufe78\ufefe\uff23\uff3c"+
		"\uff43\uff5c\uff68\uffc0\uffc4\uffc9\uffcc\uffd1\uffd4\uffd9\uffdc\uffde"+
		"f\2\u0302\u0350\u0362\u0364\u0485\u0488\u0593\u05a3\u05a5\u05bb\u05bd"+
		"\u05bf\u05c1\u05c1\u05c3\u05c4\u05c6\u05c6\u064d\u0657\u0672\u0672\u06d8"+
		"\u06de\u06e1\u06e6\u06e9\u06ea\u06ec\u06ef\u0713\u0713\u0732\u074c\u07a8"+
		"\u07b2\u0903\u0905\u093e\u093e\u0940\u094f\u0953\u0956\u0964\u0965\u0983"+
		"\u0985\u09be\u09c6\u09c9\u09ca\u09cd\u09cf\u09d9\u09d9\u09e4\u09e5\u0a04"+
		"\u0a04\u0a3e\u0a3e\u0a40\u0a44\u0a49\u0a4a\u0a4d\u0a4f\u0a72\u0a73\u0a83"+
		"\u0a85\u0abe\u0abe\u0ac0\u0ac7\u0ac9\u0acb\u0acd\u0acf\u0b03\u0b05\u0b3e"+
		"\u0b3e\u0b40\u0b45\u0b49\u0b4a\u0b4d\u0b4f\u0b58\u0b59\u0b84\u0b85\u0bc0"+
		"\u0bc4\u0bc8\u0bca\u0bcc\u0bcf\u0bd9\u0bd9\u0c03\u0c05\u0c40\u0c46\u0c48"+
		"\u0c4a\u0c4c\u0c4f\u0c57\u0c58\u0c84\u0c85\u0cc0\u0cc6\u0cc8\u0cca\u0ccc"+
		"\u0ccf\u0cd7\u0cd8\u0d04\u0d05\u0d40\u0d45\u0d48\u0d4a\u0d4c\u0d4f\u0d59"+
		"\u0d59\u0d84\u0d85\u0dcc\u0dcc\u0dd1\u0dd6\u0dd8\u0dd8\u0dda\u0de1\u0df4"+
		"\u0df5\u0e33\u0e33\u0e36\u0e3c\u0e49\u0e50\u0eb3\u0eb3\u0eb6\u0ebb\u0ebd"+
		"\u0ebe\u0eca\u0ecf\u0f1a\u0f1b\u0f37\u0f37\u0f39\u0f39\u0f3b\u0f3b\u0f40"+
		"\u0f41\u0f73\u0f86\u0f88\u0f89\u0f92\u0f99\u0f9b\u0fbe\u0fc8\u0fc8\u102e"+
		"\u1034\u1038\u103b\u1058\u105b\u17b6\u17d5\u18ab\u18ab\u20d2\u20de\u20e3"+
		"\u20e3\u302c\u3031\u309b\u309c\ufb20\ufb20\ufe22\ufe25\26\2\62;\u0662"+
		"\u066b\u06f2\u06fb\u0968\u0971\u09e8\u09f1\u0a68\u0a71\u0ae8\u0af1\u0b68"+
		"\u0b71\u0be9\u0bf1\u0c68\u0c71\u0ce8\u0cf1\u0d68\u0d71\u0e52\u0e5b\u0ed2"+
		"\u0edb\u0f22\u0f2b\u1042\u104b\u136b\u1373\u17e2\u17eb\u1812\u181b\uff12"+
		"\uff1b\t\2aa\u2041\u2042\u30fd\u30fd\ufe35\ufe36\ufe4f\ufe51\uff41\uff41"+
		"\uff67\uff67\b\2\f\f\17\17,,\61\61]^\u202a\u202b\7\2\f\f\17\17\61\61]"+
		"^\u202a\u202b\6\2\f\f\17\17^_\u202a\u202b\2\u02f1\2\3\3\2\2\2\2\5\3\2"+
		"\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21"+
		"\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2"+
		"\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3\2\2\2\2\'\3"+
		"\2\2\2\2)\3\2\2\2\2+\3\2\2\2\2-\3\2\2\2\2/\3\2\2\2\2\61\3\2\2\2\2\63\3"+
		"\2\2\2\2\65\3\2\2\2\2\67\3\2\2\2\29\3\2\2\2\2;\3\2\2\2\2=\3\2\2\2\2?\3"+
		"\2\2\2\2A\3\2\2\2\2C\3\2\2\2\2E\3\2\2\2\2G\3\2\2\2\2I\3\2\2\2\2K\3\2\2"+
		"\2\2M\3\2\2\2\2O\3\2\2\2\2Q\3\2\2\2\2S\3\2\2\2\2U\3\2\2\2\2W\3\2\2\2\2"+
		"Y\3\2\2\2\2[\3\2\2\2\2]\3\2\2\2\2_\3\2\2\2\2a\3\2\2\2\2c\3\2\2\2\2e\3"+
		"\2\2\2\2g\3\2\2\2\2i\3\2\2\2\2k\3\2\2\2\2m\3\2\2\2\2o\3\2\2\2\2q\3\2\2"+
		"\2\2s\3\2\2\2\2u\3\2\2\2\2w\3\2\2\2\2y\3\2\2\2\2{\3\2\2\2\2}\3\2\2\2\2"+
		"\177\3\2\2\2\2\u0081\3\2\2\2\2\u0083\3\2\2\2\2\u0085\3\2\2\2\2\u0087\3"+
		"\2\2\2\2\u0089\3\2\2\2\2\u008b\3\2\2\2\2\u008d\3\2\2\2\2\u008f\3\2\2\2"+
		"\2\u0091\3\2\2\2\2\u0093\3\2\2\2\2\u0095\3\2\2\2\2\u0097\3\2\2\2\2\u0099"+
		"\3\2\2\2\2\u009b\3\2\2\2\2\u009d\3\2\2\2\3\u00cf\3\2\2\2\5\u00d1\3\2\2"+
		"\2\7\u00d3\3\2\2\2\t\u00d5\3\2\2\2\13\u00d7\3\2\2\2\r\u00d9\3\2\2\2\17"+
		"\u00db\3\2\2\2\21\u00df\3\2\2\2\23\u00e1\3\2\2\2\25\u00e3\3\2\2\2\27\u00e5"+
		"\3\2\2\2\31\u00e7\3\2\2\2\33\u00eb\3\2\2\2\35\u00ed\3\2\2\2\37\u00f0\3"+
		"\2\2\2!\u00f3\3\2\2\2#\u00f5\3\2\2\2%\u00f7\3\2\2\2\'\u00f9\3\2\2\2)\u00fb"+
		"\3\2\2\2+\u00fd\3\2\2\2-\u00ff\3\2\2\2/\u0101\3\2\2\2\61\u0104\3\2\2\2"+
		"\63\u0107\3\2\2\2\65\u0109\3\2\2\2\67\u010c\3\2\2\29\u010f\3\2\2\2;\u0113"+
		"\3\2\2\2=\u0115\3\2\2\2?\u0117\3\2\2\2A\u011a\3\2\2\2C\u011d\3\2\2\2E"+
		"\u0120\3\2\2\2G\u0123\3\2\2\2I\u0127\3\2\2\2K\u012b\3\2\2\2M\u012d\3\2"+
		"\2\2O\u012f\3\2\2\2Q\u0131\3\2\2\2S\u0134\3\2\2\2U\u0137\3\2\2\2W\u013a"+
		"\3\2\2\2Y\u013d\3\2\2\2[\u0140\3\2\2\2]\u0143\3\2\2\2_\u0146\3\2\2\2a"+
		"\u014a\3\2\2\2c\u014e\3\2\2\2e\u0153\3\2\2\2g\u0156\3\2\2\2i\u0159\3\2"+
		"\2\2k\u015c\3\2\2\2m\u0160\3\2\2\2o\u0163\3\2\2\2q\u0176\3\2\2\2s\u0193"+
		"\3\2\2\2u\u0195\3\2\2\2w\u019e\3\2\2\2y\u01a6\3\2\2\2{\u01af\3\2\2\2}"+
		"\u01b8\3\2\2\2\177\u01c3\3\2\2\2\u0081\u01ce\3\2\2\2\u0083\u01d9\3\2\2"+
		"\2\u0085\u01dc\3\2\2\2\u0087\u01e3\3\2\2\2\u0089\u01e9\3\2\2\2\u008b\u01ed"+
		"\3\2\2\2\u008d\u01f7\3\2\2\2\u008f\u0200\3\2\2\2\u0091\u0208\3\2\2\2\u0093"+
		"\u020e\3\2\2\2\u0095\u0217\3\2\2\2\u0097\u0223\3\2\2\2\u0099\u0229\3\2"+
		"\2\2\u009b\u022d\3\2\2\2\u009d\u0244\3\2\2\2\u009f\u024c\3\2\2\2\u00a1"+
		"\u0252\3\2\2\2\u00a3\u0259\3\2\2\2\u00a5\u025d\3\2\2\2\u00a7\u025f\3\2"+
		"\2\2\u00a9\u0273\3\2\2\2\u00ab\u0275\3\2\2\2\u00ad\u027e\3\2\2\2\u00af"+
		"\u0280\3\2\2\2\u00b1\u0284\3\2\2\2\u00b3\u0286\3\2\2\2\u00b5\u0289\3\2"+
		"\2\2\u00b7\u0293\3\2\2\2\u00b9\u0295\3\2\2\2\u00bb\u02a3\3\2\2\2\u00bd"+
		"\u02a9\3\2\2\2\u00bf\u02ac\3\2\2\2\u00c1\u02af\3\2\2\2\u00c3\u02b2\3\2"+
		"\2\2\u00c5\u02b5\3\2\2\2\u00c7\u02c1\3\2\2\2\u00c9\u02cd\3\2\2\2\u00cb"+
		"\u02d1\3\2\2\2\u00cd\u02d3\3\2\2\2\u00cf\u00d0\7]\2\2\u00d0\4\3\2\2\2"+
		"\u00d1\u00d2\7_\2\2\u00d2\6\3\2\2\2\u00d3\u00d4\7*\2\2\u00d4\b\3\2\2\2"+
		"\u00d5\u00d6\7+\2\2\u00d6\n\3\2\2\2\u00d7\u00d8\7}\2\2\u00d8\f\3\2\2\2"+
		"\u00d9\u00da\7\177\2\2\u00da\16\3\2\2\2\u00db\u00dc\7=\2\2\u00dc\u00dd"+
		"\3\2\2\2\u00dd\u00de\b\b\2\2\u00de\20\3\2\2\2\u00df\u00e0\7.\2\2\u00e0"+
		"\22\3\2\2\2\u00e1\u00e2\7?\2\2\u00e2\24\3\2\2\2\u00e3\u00e4\7A\2\2\u00e4"+
		"\26\3\2\2\2\u00e5\u00e6\7<\2\2\u00e6\30\3\2\2\2\u00e7\u00e8\7\60\2\2\u00e8"+
		"\u00e9\7\60\2\2\u00e9\u00ea\7\60\2\2\u00ea\32\3\2\2\2\u00eb\u00ec\7\60"+
		"\2\2\u00ec\34\3\2\2\2\u00ed\u00ee\7-\2\2\u00ee\u00ef\7-\2\2\u00ef\36\3"+
		"\2\2\2\u00f0\u00f1\7/\2\2\u00f1\u00f2\7/\2\2\u00f2 \3\2\2\2\u00f3\u00f4"+
		"\7-\2\2\u00f4\"\3\2\2\2\u00f5\u00f6\7/\2\2\u00f6$\3\2\2\2\u00f7\u00f8"+
		"\7\u0080\2\2\u00f8&\3\2\2\2\u00f9\u00fa\7#\2\2\u00fa(\3\2\2\2\u00fb\u00fc"+
		"\7,\2\2\u00fc*\3\2\2\2\u00fd\u00fe\7\61\2\2\u00fe,\3\2\2\2\u00ff\u0100"+
		"\7\'\2\2\u0100.\3\2\2\2\u0101\u0102\7,\2\2\u0102\u0103\7,\2\2\u0103\60"+
		"\3\2\2\2\u0104\u0105\7A\2\2\u0105\u0106\7A\2\2\u0106\62\3\2\2\2\u0107"+
		"\u0108\7%\2\2\u0108\64\3\2\2\2\u0109\u010a\7@\2\2\u010a\u010b\7@\2\2\u010b"+
		"\66\3\2\2\2\u010c\u010d\7>\2\2\u010d\u010e\7>\2\2\u010e8\3\2\2\2\u010f"+
		"\u0110\7@\2\2\u0110\u0111\7@\2\2\u0111\u0112\7@\2\2\u0112:\3\2\2\2\u0113"+
		"\u0114\7>\2\2\u0114<\3\2\2\2\u0115\u0116\7@\2\2\u0116>\3\2\2\2\u0117\u0118"+
		"\7>\2\2\u0118\u0119\7?\2\2\u0119@\3\2\2\2\u011a\u011b\7@\2\2\u011b\u011c"+
		"\7?\2\2\u011cB\3\2\2\2\u011d\u011e\7?\2\2\u011e\u011f\7?\2\2\u011fD\3"+
		"\2\2\2\u0120\u0121\7#\2\2\u0121\u0122\7?\2\2\u0122F\3\2\2\2\u0123\u0124"+
		"\7?\2\2\u0124\u0125\7?\2\2\u0125\u0126\7?\2\2\u0126H\3\2\2\2\u0127\u0128"+
		"\7#\2\2\u0128\u0129\7?\2\2\u0129\u012a\7?\2\2\u012aJ\3\2\2\2\u012b\u012c"+
		"\7(\2\2\u012cL\3\2\2\2\u012d\u012e\7`\2\2\u012eN\3\2\2\2\u012f\u0130\7"+
		"~\2\2\u0130P\3\2\2\2\u0131\u0132\7(\2\2\u0132\u0133\7(\2\2\u0133R\3\2"+
		"\2\2\u0134\u0135\7~\2\2\u0135\u0136\7~\2\2\u0136T\3\2\2\2\u0137\u0138"+
		"\7,\2\2\u0138\u0139\7?\2\2\u0139V\3\2\2\2\u013a\u013b\7\61\2\2\u013b\u013c"+
		"\7?\2\2\u013cX\3\2\2\2\u013d\u013e\7\'\2\2\u013e\u013f\7?\2\2\u013fZ\3"+
		"\2\2\2\u0140\u0141\7-\2\2\u0141\u0142\7?\2\2\u0142\\\3\2\2\2\u0143\u0144"+
		"\7/\2\2\u0144\u0145\7?\2\2\u0145^\3\2\2\2\u0146\u0147\7>\2\2\u0147\u0148"+
		"\7>\2\2\u0148\u0149\7?\2\2\u0149`\3\2\2\2\u014a\u014b\7@\2\2\u014b\u014c"+
		"\7@\2\2\u014c\u014d\7?\2\2\u014db\3\2\2\2\u014e\u014f\7@\2\2\u014f\u0150"+
		"\7@\2\2\u0150\u0151\7@\2\2\u0151\u0152\7?\2\2\u0152d\3\2\2\2\u0153\u0154"+
		"\7(\2\2\u0154\u0155\7?\2\2\u0155f\3\2\2\2\u0156\u0157\7`\2\2\u0157\u0158"+
		"\7?\2\2\u0158h\3\2\2\2\u0159\u015a\7~\2\2\u015a\u015b\7?\2\2\u015bj\3"+
		"\2\2\2\u015c\u015d\7,\2\2\u015d\u015e\7,\2\2\u015e\u015f\7?\2\2\u015f"+
		"l\3\2\2\2\u0160\u0161\7?\2\2\u0161\u0162\7@\2\2\u0162n\3\2\2\2\u0163\u0164"+
		"\7p\2\2\u0164\u0165\7w\2\2\u0165\u0166\7n\2\2\u0166\u0167\7q\2\2\u0167"+
		"p\3\2\2\2\u0168\u0169\7x\2\2\u0169\u016a\7g\2\2\u016a\u016b\7t\2\2\u016b"+
		"\u016c\7f\2\2\u016c\u016d\7c\2\2\u016d\u016e\7f\2\2\u016e\u016f\7g\2\2"+
		"\u016f\u0170\7t\2\2\u0170\u0177\7q\2\2\u0171\u0172\7h\2\2\u0172\u0173"+
		"\7c\2\2\u0173\u0174\7n\2\2\u0174\u0175\7u\2\2\u0175\u0177\7q\2\2\u0176"+
		"\u0168\3\2\2\2\u0176\u0171\3\2\2\2\u0177r\3\2\2\2\u0178\u0179\5\u00b7"+
		"\\\2\u0179\u017a\7\60\2\2\u017a\u017e\t\2\2\2\u017b\u017d\t\3\2\2\u017c"+
		"\u017b\3\2\2\2\u017d\u0180\3\2\2\2\u017e\u017c\3\2\2\2\u017e\u017f\3\2"+
		"\2\2\u017f\u0182\3\2\2\2\u0180\u017e\3\2\2\2\u0181\u0183\5\u00b9]\2\u0182"+
		"\u0181\3\2\2\2\u0182\u0183\3\2\2\2\u0183\u0194\3\2\2\2\u0184\u0185\7\60"+
		"\2\2\u0185\u0189\t\2\2\2\u0186\u0188\t\3\2\2\u0187\u0186\3\2\2\2\u0188"+
		"\u018b\3\2\2\2\u0189\u0187\3\2\2\2\u0189\u018a\3\2\2\2\u018a\u018d\3\2"+
		"\2\2\u018b\u0189\3\2\2\2\u018c\u018e\5\u00b9]\2\u018d\u018c\3\2\2\2\u018d"+
		"\u018e\3\2\2\2\u018e\u0194\3\2\2\2\u018f\u0191\5\u00b7\\\2\u0190\u0192"+
		"\5\u00b9]\2\u0191\u0190\3\2\2\2\u0191\u0192\3\2\2\2\u0192\u0194\3\2\2"+
		"\2\u0193\u0178\3\2\2\2\u0193\u0184\3\2\2\2\u0193\u018f\3\2\2\2\u0194t"+
		"\3\2\2\2\u0195\u0196\7\62\2\2\u0196\u0197\t\4\2\2\u0197\u019b\t\5\2\2"+
		"\u0198\u019a\5\u00b5[\2\u0199\u0198\3\2\2\2\u019a\u019d\3\2\2\2\u019b"+
		"\u0199\3\2\2\2\u019b\u019c\3\2\2\2\u019cv\3\2\2\2\u019d\u019b\3\2\2\2"+
		"\u019e\u01a0\7\62\2\2\u019f\u01a1\t\6\2\2\u01a0\u019f\3\2\2\2\u01a1\u01a2"+
		"\3\2\2\2\u01a2\u01a0\3\2\2\2\u01a2\u01a3\3\2\2\2\u01a3\u01a4\3\2\2\2\u01a4"+
		"\u01a5\6<\2\2\u01a5x\3\2\2\2\u01a6\u01a7\7\62\2\2\u01a7\u01a8\t\7\2\2"+
		"\u01a8\u01ac\t\6\2\2\u01a9\u01ab\t\b\2\2\u01aa\u01a9\3\2\2\2\u01ab\u01ae"+
		"\3\2\2\2\u01ac\u01aa\3\2\2\2\u01ac\u01ad\3\2\2\2\u01adz\3\2\2\2\u01ae"+
		"\u01ac\3\2\2\2\u01af\u01b0\7\62\2\2\u01b0\u01b1\t\t\2\2\u01b1\u01b5\t"+
		"\n\2\2\u01b2\u01b4\t\13\2\2\u01b3\u01b2\3\2\2\2\u01b4\u01b7\3\2\2\2\u01b5"+
		"\u01b3\3\2\2\2\u01b5\u01b6\3\2\2\2\u01b6|\3\2\2\2\u01b7\u01b5\3\2\2\2"+
		"\u01b8\u01b9\7\62\2\2\u01b9\u01ba\t\4\2\2\u01ba\u01be\t\5\2\2\u01bb\u01bd"+
		"\5\u00b5[\2\u01bc\u01bb\3\2\2\2\u01bd\u01c0\3\2\2\2\u01be\u01bc\3\2\2"+
		"\2\u01be\u01bf\3\2\2\2\u01bf\u01c1\3\2\2\2\u01c0\u01be\3\2\2\2\u01c1\u01c2"+
		"\7p\2\2\u01c2~\3\2\2\2\u01c3\u01c4\7\62\2\2\u01c4\u01c5\t\7\2\2\u01c5"+
		"\u01c9\t\6\2\2\u01c6\u01c8\t\b\2\2\u01c7\u01c6\3\2\2\2\u01c8\u01cb\3\2"+
		"\2\2\u01c9\u01c7\3\2\2\2\u01c9\u01ca\3\2\2\2\u01ca\u01cc\3\2\2\2\u01cb"+
		"\u01c9\3\2\2\2\u01cc\u01cd\7p\2\2\u01cd\u0080\3\2\2\2\u01ce\u01cf\7\62"+
		"\2\2\u01cf\u01d0\t\t\2\2\u01d0\u01d4\t\n\2\2\u01d1\u01d3\t\13\2\2\u01d2"+
		"\u01d1\3\2\2\2\u01d3\u01d6\3\2\2\2\u01d4\u01d2\3\2\2\2\u01d4\u01d5\3\2"+
		"\2\2\u01d5\u01d7\3\2\2\2\u01d6\u01d4\3\2\2\2\u01d7\u01d8\7p\2\2\u01d8"+
		"\u0082\3\2\2\2\u01d9\u01da\5\u00b7\\\2\u01da\u01db\7p\2\2\u01db\u0084"+
		"\3\2\2\2\u01dc\u01dd\7t\2\2\u01dd\u01de\7q\2\2\u01de\u01df\7o\2\2\u01df"+
		"\u01e0\7r\2\2\u01e0\u01e1\7g\2\2\u01e1\u01e2\7t\2\2\u01e2\u0086\3\2\2"+
		"\2\u01e3\u01e4\7p\2\2\u01e4\u01e5\7w\2\2\u01e5\u01e6\7g\2\2\u01e6\u01e7"+
		"\7x\2\2\u01e7\u01e8\7q\2\2\u01e8\u0088\3\2\2\2\u01e9\u01ea\7x\2\2\u01ea"+
		"\u01eb\7c\2\2\u01eb\u01ec\7t\2\2\u01ec\u008a\3\2\2\2\u01ed\u01ee\7e\2"+
		"\2\u01ee\u01ef\7q\2\2\u01ef\u01f0\7p\2\2\u01f0\u01f1\7v\2\2\u01f1\u01f2"+
		"\7k\2\2\u01f2\u01f3\7p\2\2\u01f3\u01f4\7w\2\2\u01f4\u01f5\7c\2\2\u01f5"+
		"\u01f6\7t\2\2\u01f6\u008c\3\2\2\2\u01f7\u01f8\7o\2\2\u01f8\u01f9\7k\2"+
		"\2\u01f9\u01fa\7g\2\2\u01fa\u01fb\7p\2\2\u01fb\u01fc\7v\2\2\u01fc\u01fd"+
		"\7t\2\2\u01fd\u01fe\7c\2\2\u01fe\u01ff\7u\2\2\u01ff\u008e\3\2\2\2\u0200"+
		"\u0201\7h\2\2\u0201\u0202\7w\2\2\u0202\u0203\7p\2\2\u0203\u0204\7e\2\2"+
		"\u0204\u0205\7k\2\2\u0205\u0206\7q\2\2\u0206\u0207\7p\2\2\u0207\u0090"+
		"\3\2\2\2\u0208\u0209\7e\2\2\u0209\u020a\7n\2\2\u020a\u020b\7c\2\2\u020b"+
		"\u020c\7u\2\2\u020c\u020d\7g\2\2\u020d\u0092\3\2\2\2\u020e\u020f\7k\2"+
		"\2\u020f\u0210\7o\2\2\u0210\u0211\7r\2\2\u0211\u0212\7q\2\2\u0212\u0213"+
		"\7t\2\2\u0213\u0214\7v\2\2\u0214\u0215\7c\2\2\u0215\u0216\7t\2\2\u0216"+
		"\u0094\3\2\2\2\u0217\u021d\7b\2\2\u0218\u0219\7^\2\2\u0219\u021c\7b\2"+
		"\2\u021a\u021c\n\f\2\2\u021b\u0218\3\2\2\2\u021b\u021a\3\2\2\2\u021c\u021f"+
		"\3\2\2\2\u021d\u021b\3\2\2\2\u021d\u021e\3\2\2\2\u021e\u0220\3\2\2\2\u021f"+
		"\u021d\3\2\2\2\u0220\u0221\7b\2\2\u0221\u0096\3\2\2\2\u0222\u0224\t\r"+
		"\2\2\u0223\u0222\3\2\2\2\u0224\u0225\3\2\2\2\u0225\u0223\3\2\2\2\u0225"+
		"\u0226\3\2\2\2\u0226\u0227\3\2\2\2\u0227\u0228\bL\2\2\u0228\u0098\3\2"+
		"\2\2\u0229\u022a\t\16\2\2\u022a\u022b\3\2\2\2\u022b\u022c\bM\2\2\u022c"+
		"\u009a\3\2\2\2\u022d\u0231\5\u00bd_\2\u022e\u0230\5\u00bb^\2\u022f\u022e"+
		"\3\2\2\2\u0230\u0233\3\2\2\2\u0231\u022f\3\2\2\2\u0231\u0232\3\2\2\2\u0232"+
		"\u009c\3\2\2\2\u0233\u0231\3\2\2\2\u0234\u0238\7$\2\2\u0235\u0237\5\u009f"+
		"P\2\u0236\u0235\3\2\2\2\u0237\u023a\3\2\2\2\u0238\u0236\3\2\2\2\u0238"+
		"\u0239\3\2\2\2\u0239\u023b\3\2\2\2\u023a\u0238\3\2\2\2\u023b\u0245\7$"+
		"\2\2\u023c\u0240\7)\2\2\u023d\u023f\5\u00a1Q\2\u023e\u023d\3\2\2\2\u023f"+
		"\u0242\3\2\2\2\u0240\u023e\3\2\2\2\u0240\u0241\3\2\2\2\u0241\u0243\3\2"+
		"\2\2\u0242\u0240\3\2\2\2\u0243\u0245\7)\2\2\u0244\u0234\3\2\2\2\u0244"+
		"\u023c\3\2\2\2\u0245\u0246\3\2\2\2\u0246\u0247\bO\3\2\u0247\u009e\3\2"+
		"\2\2\u0248\u024d\n\17\2\2\u0249\u024a\7^\2\2\u024a\u024d\5\u00a3R\2\u024b"+
		"\u024d\5\u00b3Z\2\u024c\u0248\3\2\2\2\u024c\u0249\3\2\2\2\u024c\u024b"+
		"\3\2\2\2\u024d\u00a0\3\2\2\2\u024e\u0253\n\20\2\2\u024f\u0250\7^\2\2\u0250"+
		"\u0253\5\u00a3R\2\u0251\u0253\5\u00b3Z\2\u0252\u024e\3\2\2\2\u0252\u024f"+
		"\3\2\2\2\u0252\u0251\3\2\2\2\u0253\u00a2\3\2\2\2\u0254\u025a\5\u00a5S"+
		"\2\u0255\u025a\7\62\2\2\u0256\u025a\5\u00a7T\2\u0257\u025a\5\u00a9U\2"+
		"\u0258\u025a\5\u00abV\2\u0259\u0254\3\2\2\2\u0259\u0255\3\2\2\2\u0259"+
		"\u0256\3\2\2\2\u0259\u0257\3\2\2\2\u0259\u0258\3\2\2\2\u025a\u00a4\3\2"+
		"\2\2\u025b\u025e\5\u00adW\2\u025c\u025e\5\u00afX\2\u025d\u025b\3\2\2\2"+
		"\u025d\u025c\3\2\2\2\u025e\u00a6\3\2\2\2\u025f\u0260\7z\2\2\u0260\u0261"+
		"\5\u00b5[\2\u0261\u0262\5\u00b5[\2\u0262\u00a8\3\2\2\2\u0263\u0264\7w"+
		"\2\2\u0264\u0265\5\u00b5[\2\u0265\u0266\5\u00b5[\2\u0266\u0267\5\u00b5"+
		"[\2\u0267\u0268\5\u00b5[\2\u0268\u0274\3\2\2\2\u0269\u026a\7w\2\2\u026a"+
		"\u026b\7}\2\2\u026b\u026d\5\u00b5[\2\u026c\u026e\5\u00b5[\2\u026d\u026c"+
		"\3\2\2\2\u026e\u026f\3\2\2\2\u026f\u026d\3\2\2\2\u026f\u0270\3\2\2\2\u0270"+
		"\u0271\3\2\2\2\u0271\u0272\7\177\2\2\u0272\u0274\3\2\2\2\u0273\u0263\3"+
		"\2\2\2\u0273\u0269\3\2\2\2\u0274\u00aa\3\2\2\2\u0275\u0276\7w\2\2\u0276"+
		"\u0278\7}\2\2\u0277\u0279\5\u00b5[\2\u0278\u0277\3\2\2\2\u0279\u027a\3"+
		"\2\2\2\u027a\u0278\3\2\2\2\u027a\u027b\3\2\2\2\u027b\u027c\3\2\2\2\u027c"+
		"\u027d\7\177\2\2\u027d\u00ac\3\2\2\2\u027e\u027f\t\21\2\2\u027f\u00ae"+
		"\3\2\2\2\u0280\u0281\n\22\2\2\u0281\u00b0\3\2\2\2\u0282\u0285\5\u00ad"+
		"W\2\u0283\u0285\t\23\2\2\u0284\u0282\3\2\2\2\u0284\u0283\3\2\2\2\u0285"+
		"\u00b2\3\2\2\2\u0286\u0287\7^\2\2\u0287\u0288\t\16\2\2\u0288\u00b4\3\2"+
		"\2\2\u0289\u028a\t\24\2\2\u028a\u00b6\3\2\2\2\u028b\u0294\7\62\2\2\u028c"+
		"\u0290\t\25\2\2\u028d\u028f\t\3\2\2\u028e\u028d\3\2\2\2\u028f\u0292\3"+
		"\2\2\2\u0290\u028e\3\2\2\2\u0290\u0291\3\2\2\2\u0291\u0294\3\2\2\2\u0292"+
		"\u0290\3\2\2\2\u0293\u028b\3\2\2\2\u0293\u028c\3\2\2\2\u0294\u00b8\3\2"+
		"\2\2\u0295\u0297\t\26\2\2\u0296\u0298\t\27\2\2\u0297\u0296\3\2\2\2\u0297"+
		"\u0298\3\2\2\2\u0298\u029a\3\2\2\2\u0299\u029b\t\3\2\2\u029a\u0299\3\2"+
		"\2\2\u029b\u029c\3\2\2\2\u029c\u029a\3\2\2\2\u029c\u029d\3\2\2\2\u029d"+
		"\u00ba\3\2\2\2\u029e\u02a4\5\u00bd_\2\u029f\u02a4\5\u00c1a\2\u02a0\u02a4"+
		"\5\u00c3b\2\u02a1\u02a4\5\u00c5c\2\u02a2\u02a4\4\u200e\u200f\2\u02a3\u029e"+
		"\3\2\2\2\u02a3\u029f\3\2\2\2\u02a3\u02a0\3\2\2\2\u02a3\u02a1\3\2\2\2\u02a3"+
		"\u02a2\3\2\2\2\u02a4\u00bc\3\2\2\2\u02a5\u02aa\5\u00bf`\2\u02a6\u02aa"+
		"\t\30\2\2\u02a7\u02a8\7^\2\2\u02a8\u02aa\5\u00a9U\2\u02a9\u02a5\3\2\2"+
		"\2\u02a9\u02a6\3\2\2\2\u02a9\u02a7\3\2\2\2\u02aa\u00be\3\2\2\2\u02ab\u02ad"+
		"\t\31\2\2\u02ac\u02ab\3\2\2\2\u02ad\u00c0\3\2\2\2\u02ae\u02b0\t\32\2\2"+
		"\u02af\u02ae\3\2\2\2\u02b0\u00c2\3\2\2\2\u02b1\u02b3\t\33\2\2\u02b2\u02b1"+
		"\3\2\2\2\u02b3\u00c4\3\2\2\2\u02b4\u02b6\t\34\2\2\u02b5\u02b4\3\2\2\2"+
		"\u02b6\u00c6\3\2\2\2\u02b7\u02c2\n\35\2\2\u02b8\u02c2\5\u00cdg\2\u02b9"+
		"\u02bd\7]\2\2\u02ba\u02bc\5\u00cbf\2\u02bb\u02ba\3\2\2\2\u02bc\u02bf\3"+
		"\2\2\2\u02bd\u02bb\3\2\2\2\u02bd\u02be\3\2\2\2\u02be\u02c0\3\2\2\2\u02bf"+
		"\u02bd\3\2\2\2\u02c0\u02c2\7_\2\2\u02c1\u02b7\3\2\2\2\u02c1\u02b8\3\2"+
		"\2\2\u02c1\u02b9\3\2\2\2\u02c2\u00c8\3\2\2\2\u02c3\u02ce\n\36\2\2\u02c4"+
		"\u02ce\5\u00cdg\2\u02c5\u02c9\7]\2\2\u02c6\u02c8\5\u00cbf\2\u02c7\u02c6"+
		"\3\2\2\2\u02c8\u02cb\3\2\2\2\u02c9\u02c7\3\2\2\2\u02c9\u02ca\3\2\2\2\u02ca"+
		"\u02cc\3\2\2\2\u02cb\u02c9\3\2\2\2\u02cc\u02ce\7_\2\2\u02cd\u02c3\3\2"+
		"\2\2\u02cd\u02c4\3\2\2\2\u02cd\u02c5\3\2\2\2\u02ce\u00ca\3\2\2\2\u02cf"+
		"\u02d2\n\37\2\2\u02d0\u02d2\5\u00cdg\2\u02d1\u02cf\3\2\2\2\u02d1\u02d0"+
		"\3\2\2\2\u02d2\u00cc\3\2\2\2\u02d3\u02d4\7^\2\2\u02d4\u02d5\n\16\2\2\u02d5"+
		"\u00ce\3\2\2\2/\2\u0176\u017e\u0182\u0189\u018d\u0191\u0193\u019b\u01a2"+
		"\u01ac\u01b5\u01be\u01c9\u01d4\u021b\u021d\u0225\u0231\u0238\u0240\u0244"+
		"\u024c\u0252\u0259\u025d\u026f\u0273\u027a\u0284\u0290\u0293\u0297\u029c"+
		"\u02a3\u02a9\u02ac\u02af\u02b2\u02b5\u02bd\u02c1\u02c9\u02cd\u02d1\4\2"+
		"\3\2\3O\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}