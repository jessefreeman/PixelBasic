// Generated from /Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Antlr/PixelBasicTokens.g4 by ANTLR 4.9.2
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class PixelBasicTokens extends Lexer {
	static { RuntimeMetaData.checkVersion("4.9.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		MUL=1, DIV=2, ADD=3, SUB=4, EXP=5, MOD=6, NEQ=7, GTE=8, LTE=9, GT=10, 
		LT=11, EQ=12, AND=13, OR=14, NOT=15, COMMA=16, LPAREN=17, RPAREN=18, LEN=19, 
		VAL=20, ISNAN=21, PRINT=22, INPUT=23, LET=24, REM=25, IF=26, THEN=27, 
		ELSE=28, END=29, FOR=30, WHILE=31, REPEAT=32, UNTIL=33, STEP=34, NEXT=35, 
		TO=36, CONTINUE=37, EXIT=38, COMMENT=39, ID=40, NUMBER=41, STRINGLITERAL=42, 
		DOLLAR=43, NEWLINE=44, WS=45;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"MUL", "DIV", "ADD", "SUB", "EXP", "MOD", "NEQ", "GTE", "LTE", "GT", 
			"LT", "EQ", "AND", "OR", "NOT", "COMMA", "LPAREN", "RPAREN", "LEN", "VAL", 
			"ISNAN", "PRINT", "INPUT", "LET", "REM", "IF", "THEN", "ELSE", "END", 
			"FOR", "WHILE", "REPEAT", "UNTIL", "STEP", "NEXT", "TO", "CONTINUE", 
			"EXIT", "COMMENT", "ID", "NUMBER", "STRINGLITERAL", "DOLLAR", "NEWLINE", 
			"WS"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'*'", "'/'", "'+'", "'-'", "'^'", "'MOD'", "'<>'", "'>='", "'<='", 
			"'>'", "'<'", "'='", null, null, null, "','", "'('", "')'", null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, "'$'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "MUL", "DIV", "ADD", "SUB", "EXP", "MOD", "NEQ", "GTE", "LTE", 
			"GT", "LT", "EQ", "AND", "OR", "NOT", "COMMA", "LPAREN", "RPAREN", "LEN", 
			"VAL", "ISNAN", "PRINT", "INPUT", "LET", "REM", "IF", "THEN", "ELSE", 
			"END", "FOR", "WHILE", "REPEAT", "UNTIL", "STEP", "NEXT", "TO", "CONTINUE", 
			"EXIT", "COMMENT", "ID", "NUMBER", "STRINGLITERAL", "DOLLAR", "NEWLINE", 
			"WS"
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


	public PixelBasicTokens(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "PixelBasicTokens.g4"; }

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

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2/\u0190\b\1\4\2\t"+
		"\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!"+
		"\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t+\4"+
		",\t,\4-\t-\4.\t.\3\2\3\2\3\3\3\3\3\4\3\4\3\5\3\5\3\6\3\6\3\7\3\7\3\7\3"+
		"\7\3\b\3\b\3\b\3\t\3\t\3\t\3\n\3\n\3\n\3\13\3\13\3\f\3\f\3\r\3\r\3\16"+
		"\3\16\3\16\3\16\3\16\3\16\5\16\u0081\n\16\3\17\3\17\3\17\3\17\5\17\u0087"+
		"\n\17\3\20\3\20\3\20\3\20\3\20\3\20\5\20\u008f\n\20\3\21\3\21\3\22\3\22"+
		"\3\23\3\23\3\24\3\24\3\24\3\24\3\24\3\24\5\24\u009d\n\24\3\25\3\25\3\25"+
		"\3\25\3\25\3\25\5\25\u00a5\n\25\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\26"+
		"\3\26\3\26\5\26\u00b1\n\26\3\27\3\27\3\27\3\27\3\27\3\27\3\27\3\27\3\27"+
		"\3\27\5\27\u00bd\n\27\3\30\3\30\3\30\3\30\3\30\3\30\3\30\3\30\3\30\3\30"+
		"\5\30\u00c9\n\30\3\31\3\31\3\31\3\31\3\31\3\31\5\31\u00d1\n\31\3\32\3"+
		"\32\3\32\3\32\3\32\3\32\5\32\u00d9\n\32\3\33\3\33\3\33\3\33\5\33\u00df"+
		"\n\33\3\34\3\34\3\34\3\34\3\34\3\34\3\34\3\34\5\34\u00e9\n\34\3\35\3\35"+
		"\3\35\3\35\3\35\3\35\3\35\3\35\5\35\u00f3\n\35\3\36\3\36\3\36\3\36\3\36"+
		"\3\36\5\36\u00fb\n\36\3\37\3\37\3\37\3\37\3\37\3\37\5\37\u0103\n\37\3"+
		" \3 \3 \3 \3 \3 \3 \3 \3 \3 \5 \u010f\n \3!\3!\3!\3!\3!\3!\3!\3!\3!\3"+
		"!\3!\3!\5!\u011d\n!\3\"\3\"\3\"\3\"\3\"\3\"\3\"\3\"\3\"\3\"\5\"\u0129"+
		"\n\"\3#\3#\3#\3#\3#\3#\3#\3#\5#\u0133\n#\3$\3$\3$\3$\3$\3$\3$\3$\5$\u013d"+
		"\n$\3%\3%\3%\3%\5%\u0143\n%\3&\3&\3&\3&\3&\3&\3&\3&\3&\3&\3&\3&\3&\3&"+
		"\3&\3&\5&\u0155\n&\3\'\3\'\3\'\3\'\3\'\3\'\3\'\3\'\5\'\u015f\n\'\3(\3"+
		"(\7(\u0163\n(\f(\16(\u0166\13(\3)\6)\u0169\n)\r)\16)\u016a\3*\6*\u016e"+
		"\n*\r*\16*\u016f\3*\3*\6*\u0174\n*\r*\16*\u0175\5*\u0178\n*\3+\3+\7+\u017c"+
		"\n+\f+\16+\u017f\13+\3+\3+\3,\3,\3-\5-\u0186\n-\3-\3-\3.\6.\u018b\n.\r"+
		".\16.\u018c\3.\3.\2\2/\3\3\5\4\7\5\t\6\13\7\r\b\17\t\21\n\23\13\25\f\27"+
		"\r\31\16\33\17\35\20\37\21!\22#\23%\24\'\25)\26+\27-\30/\31\61\32\63\33"+
		"\65\34\67\359\36;\37= ?!A\"C#E$G%I&K\'M(O)Q*S+U,W-Y.[/\3\2\7\4\2\f\f\17"+
		"\17\4\2C\\c|\3\2\62;\5\2\f\f\17\17$$\4\2\13\13\"\"\2\u01ae\2\3\3\2\2\2"+
		"\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2"+
		"\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2"+
		"\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3\2\2"+
		"\2\2\'\3\2\2\2\2)\3\2\2\2\2+\3\2\2\2\2-\3\2\2\2\2/\3\2\2\2\2\61\3\2\2"+
		"\2\2\63\3\2\2\2\2\65\3\2\2\2\2\67\3\2\2\2\29\3\2\2\2\2;\3\2\2\2\2=\3\2"+
		"\2\2\2?\3\2\2\2\2A\3\2\2\2\2C\3\2\2\2\2E\3\2\2\2\2G\3\2\2\2\2I\3\2\2\2"+
		"\2K\3\2\2\2\2M\3\2\2\2\2O\3\2\2\2\2Q\3\2\2\2\2S\3\2\2\2\2U\3\2\2\2\2W"+
		"\3\2\2\2\2Y\3\2\2\2\2[\3\2\2\2\3]\3\2\2\2\5_\3\2\2\2\7a\3\2\2\2\tc\3\2"+
		"\2\2\13e\3\2\2\2\rg\3\2\2\2\17k\3\2\2\2\21n\3\2\2\2\23q\3\2\2\2\25t\3"+
		"\2\2\2\27v\3\2\2\2\31x\3\2\2\2\33\u0080\3\2\2\2\35\u0086\3\2\2\2\37\u008e"+
		"\3\2\2\2!\u0090\3\2\2\2#\u0092\3\2\2\2%\u0094\3\2\2\2\'\u009c\3\2\2\2"+
		")\u00a4\3\2\2\2+\u00b0\3\2\2\2-\u00bc\3\2\2\2/\u00c8\3\2\2\2\61\u00d0"+
		"\3\2\2\2\63\u00d8\3\2\2\2\65\u00de\3\2\2\2\67\u00e8\3\2\2\29\u00f2\3\2"+
		"\2\2;\u00fa\3\2\2\2=\u0102\3\2\2\2?\u010e\3\2\2\2A\u011c\3\2\2\2C\u0128"+
		"\3\2\2\2E\u0132\3\2\2\2G\u013c\3\2\2\2I\u0142\3\2\2\2K\u0154\3\2\2\2M"+
		"\u015e\3\2\2\2O\u0160\3\2\2\2Q\u0168\3\2\2\2S\u016d\3\2\2\2U\u0179\3\2"+
		"\2\2W\u0182\3\2\2\2Y\u0185\3\2\2\2[\u018a\3\2\2\2]^\7,\2\2^\4\3\2\2\2"+
		"_`\7\61\2\2`\6\3\2\2\2ab\7-\2\2b\b\3\2\2\2cd\7/\2\2d\n\3\2\2\2ef\7`\2"+
		"\2f\f\3\2\2\2gh\7O\2\2hi\7Q\2\2ij\7F\2\2j\16\3\2\2\2kl\7>\2\2lm\7@\2\2"+
		"m\20\3\2\2\2no\7@\2\2op\7?\2\2p\22\3\2\2\2qr\7>\2\2rs\7?\2\2s\24\3\2\2"+
		"\2tu\7@\2\2u\26\3\2\2\2vw\7>\2\2w\30\3\2\2\2xy\7?\2\2y\32\3\2\2\2z{\7"+
		"C\2\2{|\7P\2\2|\u0081\7F\2\2}~\7c\2\2~\177\7p\2\2\177\u0081\7f\2\2\u0080"+
		"z\3\2\2\2\u0080}\3\2\2\2\u0081\34\3\2\2\2\u0082\u0083\7Q\2\2\u0083\u0087"+
		"\7T\2\2\u0084\u0085\7q\2\2\u0085\u0087\7t\2\2\u0086\u0082\3\2\2\2\u0086"+
		"\u0084\3\2\2\2\u0087\36\3\2\2\2\u0088\u0089\7P\2\2\u0089\u008a\7Q\2\2"+
		"\u008a\u008f\7V\2\2\u008b\u008c\7p\2\2\u008c\u008d\7q\2\2\u008d\u008f"+
		"\7v\2\2\u008e\u0088\3\2\2\2\u008e\u008b\3\2\2\2\u008f \3\2\2\2\u0090\u0091"+
		"\7.\2\2\u0091\"\3\2\2\2\u0092\u0093\7*\2\2\u0093$\3\2\2\2\u0094\u0095"+
		"\7+\2\2\u0095&\3\2\2\2\u0096\u0097\7N\2\2\u0097\u0098\7G\2\2\u0098\u009d"+
		"\7P\2\2\u0099\u009a\7n\2\2\u009a\u009b\7g\2\2\u009b\u009d\7p\2\2\u009c"+
		"\u0096\3\2\2\2\u009c\u0099\3\2\2\2\u009d(\3\2\2\2\u009e\u009f\7X\2\2\u009f"+
		"\u00a0\7C\2\2\u00a0\u00a5\7N\2\2\u00a1\u00a2\7x\2\2\u00a2\u00a3\7c\2\2"+
		"\u00a3\u00a5\7n\2\2\u00a4\u009e\3\2\2\2\u00a4\u00a1\3\2\2\2\u00a5*\3\2"+
		"\2\2\u00a6\u00a7\7K\2\2\u00a7\u00a8\7U\2\2\u00a8\u00a9\7P\2\2\u00a9\u00aa"+
		"\7C\2\2\u00aa\u00b1\7P\2\2\u00ab\u00ac\7k\2\2\u00ac\u00ad\7u\2\2\u00ad"+
		"\u00ae\7p\2\2\u00ae\u00af\7c\2\2\u00af\u00b1\7p\2\2\u00b0\u00a6\3\2\2"+
		"\2\u00b0\u00ab\3\2\2\2\u00b1,\3\2\2\2\u00b2\u00b3\7R\2\2\u00b3\u00b4\7"+
		"T\2\2\u00b4\u00b5\7K\2\2\u00b5\u00b6\7P\2\2\u00b6\u00bd\7V\2\2\u00b7\u00b8"+
		"\7r\2\2\u00b8\u00b9\7t\2\2\u00b9\u00ba\7k\2\2\u00ba\u00bb\7p\2\2\u00bb"+
		"\u00bd\7v\2\2\u00bc\u00b2\3\2\2\2\u00bc\u00b7\3\2\2\2\u00bd.\3\2\2\2\u00be"+
		"\u00bf\7K\2\2\u00bf\u00c0\7P\2\2\u00c0\u00c1\7R\2\2\u00c1\u00c2\7W\2\2"+
		"\u00c2\u00c9\7V\2\2\u00c3\u00c4\7k\2\2\u00c4\u00c5\7p\2\2\u00c5\u00c6"+
		"\7r\2\2\u00c6\u00c7\7w\2\2\u00c7\u00c9\7v\2\2\u00c8\u00be\3\2\2\2\u00c8"+
		"\u00c3\3\2\2\2\u00c9\60\3\2\2\2\u00ca\u00cb\7N\2\2\u00cb\u00cc\7G\2\2"+
		"\u00cc\u00d1\7V\2\2\u00cd\u00ce\7n\2\2\u00ce\u00cf\7g\2\2\u00cf\u00d1"+
		"\7v\2\2\u00d0\u00ca\3\2\2\2\u00d0\u00cd\3\2\2\2\u00d1\62\3\2\2\2\u00d2"+
		"\u00d3\7T\2\2\u00d3\u00d4\7G\2\2\u00d4\u00d9\7O\2\2\u00d5\u00d6\7t\2\2"+
		"\u00d6\u00d7\7g\2\2\u00d7\u00d9\7o\2\2\u00d8\u00d2\3\2\2\2\u00d8\u00d5"+
		"\3\2\2\2\u00d9\64\3\2\2\2\u00da\u00db\7K\2\2\u00db\u00df\7H\2\2\u00dc"+
		"\u00dd\7k\2\2\u00dd\u00df\7h\2\2\u00de\u00da\3\2\2\2\u00de\u00dc\3\2\2"+
		"\2\u00df\66\3\2\2\2\u00e0\u00e1\7V\2\2\u00e1\u00e2\7J\2\2\u00e2\u00e3"+
		"\7G\2\2\u00e3\u00e9\7P\2\2\u00e4\u00e5\7v\2\2\u00e5\u00e6\7j\2\2\u00e6"+
		"\u00e7\7g\2\2\u00e7\u00e9\7p\2\2\u00e8\u00e0\3\2\2\2\u00e8\u00e4\3\2\2"+
		"\2\u00e98\3\2\2\2\u00ea\u00eb\7G\2\2\u00eb\u00ec\7N\2\2\u00ec\u00ed\7"+
		"U\2\2\u00ed\u00f3\7G\2\2\u00ee\u00ef\7g\2\2\u00ef\u00f0\7n\2\2\u00f0\u00f1"+
		"\7u\2\2\u00f1\u00f3\7g\2\2\u00f2\u00ea\3\2\2\2\u00f2\u00ee\3\2\2\2\u00f3"+
		":\3\2\2\2\u00f4\u00f5\7G\2\2\u00f5\u00f6\7P\2\2\u00f6\u00fb\7F\2\2\u00f7"+
		"\u00f8\7g\2\2\u00f8\u00f9\7p\2\2\u00f9\u00fb\7f\2\2\u00fa\u00f4\3\2\2"+
		"\2\u00fa\u00f7\3\2\2\2\u00fb<\3\2\2\2\u00fc\u00fd\7H\2\2\u00fd\u00fe\7"+
		"Q\2\2\u00fe\u0103\7T\2\2\u00ff\u0100\7h\2\2\u0100\u0101\7q\2\2\u0101\u0103"+
		"\7t\2\2\u0102\u00fc\3\2\2\2\u0102\u00ff\3\2\2\2\u0103>\3\2\2\2\u0104\u0105"+
		"\7Y\2\2\u0105\u0106\7J\2\2\u0106\u0107\7K\2\2\u0107\u0108\7N\2\2\u0108"+
		"\u010f\7G\2\2\u0109\u010a\7y\2\2\u010a\u010b\7j\2\2\u010b\u010c\7k\2\2"+
		"\u010c\u010d\7n\2\2\u010d\u010f\7g\2\2\u010e\u0104\3\2\2\2\u010e\u0109"+
		"\3\2\2\2\u010f@\3\2\2\2\u0110\u0111\7T\2\2\u0111\u0112\7G\2\2\u0112\u0113"+
		"\7R\2\2\u0113\u0114\7G\2\2\u0114\u0115\7C\2\2\u0115\u011d\7V\2\2\u0116"+
		"\u0117\7t\2\2\u0117\u0118\7g\2\2\u0118\u0119\7r\2\2\u0119\u011a\7g\2\2"+
		"\u011a\u011b\7c\2\2\u011b\u011d\7v\2\2\u011c\u0110\3\2\2\2\u011c\u0116"+
		"\3\2\2\2\u011dB\3\2\2\2\u011e\u011f\7W\2\2\u011f\u0120\7P\2\2\u0120\u0121"+
		"\7V\2\2\u0121\u0122\7K\2\2\u0122\u0129\7N\2\2\u0123\u0124\7w\2\2\u0124"+
		"\u0125\7p\2\2\u0125\u0126\7v\2\2\u0126\u0127\7k\2\2\u0127\u0129\7n\2\2"+
		"\u0128\u011e\3\2\2\2\u0128\u0123\3\2\2\2\u0129D\3\2\2\2\u012a\u012b\7"+
		"U\2\2\u012b\u012c\7V\2\2\u012c\u012d\7G\2\2\u012d\u0133\7R\2\2\u012e\u012f"+
		"\7u\2\2\u012f\u0130\7v\2\2\u0130\u0131\7g\2\2\u0131\u0133\7r\2\2\u0132"+
		"\u012a\3\2\2\2\u0132\u012e\3\2\2\2\u0133F\3\2\2\2\u0134\u0135\7P\2\2\u0135"+
		"\u0136\7G\2\2\u0136\u0137\7Z\2\2\u0137\u013d\7V\2\2\u0138\u0139\7p\2\2"+
		"\u0139\u013a\7g\2\2\u013a\u013b\7z\2\2\u013b\u013d\7v\2\2\u013c\u0134"+
		"\3\2\2\2\u013c\u0138\3\2\2\2\u013dH\3\2\2\2\u013e\u013f\7V\2\2\u013f\u0143"+
		"\7Q\2\2\u0140\u0141\7v\2\2\u0141\u0143\7q\2\2\u0142\u013e\3\2\2\2\u0142"+
		"\u0140\3\2\2\2\u0143J\3\2\2\2\u0144\u0145\7E\2\2\u0145\u0146\7Q\2\2\u0146"+
		"\u0147\7P\2\2\u0147\u0148\7V\2\2\u0148\u0149\7K\2\2\u0149\u014a\7P\2\2"+
		"\u014a\u014b\7W\2\2\u014b\u0155\7G\2\2\u014c\u014d\7e\2\2\u014d\u014e"+
		"\7q\2\2\u014e\u014f\7p\2\2\u014f\u0150\7v\2\2\u0150\u0151\7k\2\2\u0151"+
		"\u0152\7p\2\2\u0152\u0153\7w\2\2\u0153\u0155\7g\2\2\u0154\u0144\3\2\2"+
		"\2\u0154\u014c\3\2\2\2\u0155L\3\2\2\2\u0156\u0157\7G\2\2\u0157\u0158\7"+
		"Z\2\2\u0158\u0159\7K\2\2\u0159\u015f\7V\2\2\u015a\u015b\7G\2\2\u015b\u015c"+
		"\7Z\2\2\u015c\u015d\7K\2\2\u015d\u015f\7V\2\2\u015e\u0156\3\2\2\2\u015e"+
		"\u015a\3\2\2\2\u015fN\3\2\2\2\u0160\u0164\5\63\32\2\u0161\u0163\n\2\2"+
		"\2\u0162\u0161\3\2\2\2\u0163\u0166\3\2\2\2\u0164\u0162\3\2\2\2\u0164\u0165"+
		"\3\2\2\2\u0165P\3\2\2\2\u0166\u0164\3\2\2\2\u0167\u0169\t\3\2\2\u0168"+
		"\u0167\3\2\2\2\u0169\u016a\3\2\2\2\u016a\u0168\3\2\2\2\u016a\u016b\3\2"+
		"\2\2\u016bR\3\2\2\2\u016c\u016e\t\4\2\2\u016d\u016c\3\2\2\2\u016e\u016f"+
		"\3\2\2\2\u016f\u016d\3\2\2\2\u016f\u0170\3\2\2\2\u0170\u0177\3\2\2\2\u0171"+
		"\u0173\7\60\2\2\u0172\u0174\t\4\2\2\u0173\u0172\3\2\2\2\u0174\u0175\3"+
		"\2\2\2\u0175\u0173\3\2\2\2\u0175\u0176\3\2\2\2\u0176\u0178\3\2\2\2\u0177"+
		"\u0171\3\2\2\2\u0177\u0178\3\2\2\2\u0178T\3\2\2\2\u0179\u017d\7$\2\2\u017a"+
		"\u017c\n\5\2\2\u017b\u017a\3\2\2\2\u017c\u017f\3\2\2\2\u017d\u017b\3\2"+
		"\2\2\u017d\u017e\3\2\2\2\u017e\u0180\3\2\2\2\u017f\u017d\3\2\2\2\u0180"+
		"\u0181\7$\2\2\u0181V\3\2\2\2\u0182\u0183\7&\2\2\u0183X\3\2\2\2\u0184\u0186"+
		"\7\17\2\2\u0185\u0184\3\2\2\2\u0185\u0186\3\2\2\2\u0186\u0187\3\2\2\2"+
		"\u0187\u0188\7\f\2\2\u0188Z\3\2\2\2\u0189\u018b\t\6\2\2\u018a\u0189\3"+
		"\2\2\2\u018b\u018c\3\2\2\2\u018c\u018a\3\2\2\2\u018c\u018d\3\2\2\2\u018d"+
		"\u018e\3\2\2\2\u018e\u018f\b.\2\2\u018f\\\3\2\2\2\"\2\u0080\u0086\u008e"+
		"\u009c\u00a4\u00b0\u00bc\u00c8\u00d0\u00d8\u00de\u00e8\u00f2\u00fa\u0102"+
		"\u010e\u011c\u0128\u0132\u013c\u0142\u0154\u015e\u0164\u016a\u016f\u0175"+
		"\u0177\u017d\u0185\u018c\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}