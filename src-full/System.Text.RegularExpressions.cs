namespace System.Text.RegularExpressions {
  public class Capture {
    public int Index { get; }
    public int Length { get; }
    public string Value { get; }
    public override string ToString();
  }
  public class CaptureCollection : ICollection, IEnumerable {
    public int Count { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    public Capture this[int i] { get; }
    public IEnumerator GetEnumerator();
    void System.Collections.ICollection.CopyTo(Array array, int arrayIndex);
  }
  public class Group : Capture {
    public CaptureCollection Captures { get; }
    public bool Success { get; }
  }
  public class GroupCollection : ICollection, IEnumerable {
    public int Count { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    public Group this[int groupnum] { get; }
    public Group this[string groupname] { get; }
    public IEnumerator GetEnumerator();
    void System.Collections.ICollection.CopyTo(Array array, int arrayIndex);
  }
  public class Match : Group {
    public static Match Empty { get; }
    public virtual GroupCollection Groups { get; }
    public Match NextMatch();
    public virtual string Result(string replacement);
  }
  public class MatchCollection : ICollection, IEnumerable {
    public int Count { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    public virtual Match this[int i] { get; }
    public IEnumerator GetEnumerator();
    void System.Collections.ICollection.CopyTo(Array array, int arrayIndex);
  }
  public delegate string MatchEvaluator(Match match);
  public class Regex {
    public static readonly TimeSpan InfiniteMatchTimeout;
    protected Regex();
    public Regex(string pattern);
    public Regex(string pattern, RegexOptions options);
    public Regex(string pattern, RegexOptions options, TimeSpan matchTimeout);
    public static int CacheSize { get; set; }
    public TimeSpan MatchTimeout { get; }
    public RegexOptions Options { get; }
    public bool RightToLeft { get; }
    public static string Escape(string str);
    public string[] GetGroupNames();
    public int[] GetGroupNumbers();
    public string GroupNameFromNumber(int i);
    public int GroupNumberFromName(string name);
    public bool IsMatch(string input);
    public bool IsMatch(string input, int startat);
    public static bool IsMatch(string input, string pattern);
    public static bool IsMatch(string input, string pattern, RegexOptions options);
    public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout);
    public Match Match(string input);
    public Match Match(string input, int startat);
    public Match Match(string input, int beginning, int length);
    public static Match Match(string input, string pattern);
    public static Match Match(string input, string pattern, RegexOptions options);
    public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout);
    public MatchCollection Matches(string input);
    public MatchCollection Matches(string input, int startat);
    public static MatchCollection Matches(string input, string pattern);
    public static MatchCollection Matches(string input, string pattern, RegexOptions options);
    public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout);
    public string Replace(string input, string replacement);
    public string Replace(string input, string replacement, int count);
    public string Replace(string input, string replacement, int count, int startat);
    public static string Replace(string input, string pattern, string replacement);
    public static string Replace(string input, string pattern, string replacement, RegexOptions options);
    public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout);
    public static string Replace(string input, string pattern, MatchEvaluator evaluator);
    public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options);
    public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout);
    public string Replace(string input, MatchEvaluator evaluator);
    public string Replace(string input, MatchEvaluator evaluator, int count);
    public string Replace(string input, MatchEvaluator evaluator, int count, int startat);
    public string[] Split(string input);
    public string[] Split(string input, int count);
    public string[] Split(string input, int count, int startat);
    public static string[] Split(string input, string pattern);
    public static string[] Split(string input, string pattern, RegexOptions options);
    public static string[] Split(string input, string pattern, RegexOptions options, TimeSpan matchTimeout);
    public override string ToString();
    public static string Unescape(string str);
  }
  public class RegexMatchTimeoutException : TimeoutException {
    public RegexMatchTimeoutException();
    public RegexMatchTimeoutException(string message);
    public RegexMatchTimeoutException(string message, Exception inner);
    public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout);
    public string Input { get; }
    public TimeSpan MatchTimeout { get; }
    public string Pattern { get; }
  }
  public enum RegexOptions {
    Compiled = 8,
    CultureInvariant = 512,
    ECMAScript = 256,
    ExplicitCapture = 4,
    IgnoreCase = 1,
    IgnorePatternWhitespace = 32,
    Multiline = 2,
    None = 0,
    RightToLeft = 64,
    Singleline = 16,
  }
}
