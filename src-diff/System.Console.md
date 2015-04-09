```diff
---lib-full\System.Console.dll
+++lib-oss\System.Console.dll
 namespace System {
  public static class Console {
    public static ConsoleColor BackgroundColor { get; set; }
    public static TextWriter Error { get; }
    public static ConsoleColor ForegroundColor { get; set; }
    public static TextReader In { get; }
    public static TextWriter Out { get; }
+   public static event ConsoleCancelEventHandler CancelKeyPress;
    public static Stream OpenStandardError();
    public static Stream OpenStandardInput();
    public static Stream OpenStandardOutput();
+   [MethodImpl(NoInlining)]public static int Read();
+   [MethodImpl(NoInlining)]public static string ReadLine();
    public static void ResetColor();
    public static void SetError(TextWriter newError);
    public static void SetIn(TextReader newIn);
    public static void SetOut(TextWriter newOut);
+   [MethodImpl(NoInlining)]public static void Write(bool value);
+   [MethodImpl(NoInlining)]public static void Write(char value);
+   [MethodImpl(NoInlining)]public static void Write(char[] buffer);
+   [MethodImpl(NoInlining)]public static void Write(char[] buffer, int index, int count);
+   [MethodImpl(NoInlining)]public static void Write(decimal value);
+   [MethodImpl(NoInlining)]public static void Write(double value);
+   [MethodImpl(NoInlining)]public static void Write(int value);
+   [MethodImpl(NoInlining)]public static void Write(long value);
+   [MethodImpl(NoInlining)]public static void Write(object value);
+   [MethodImpl(NoInlining)]public static void Write(float value);
+   [MethodImpl(NoInlining)]public static void Write(string value);
+   [MethodImpl(NoInlining)]public static void Write(string format, object arg0);
+   [MethodImpl(NoInlining)]public static void Write(string format, object arg0, object arg1);
+   [MethodImpl(NoInlining)]public static void Write(string format, object arg0, object arg1, object arg2);
+   [MethodImpl(NoInlining)]public static void Write(string format, params object[] arg);
+   [MethodImpl(NoInlining)]public static void Write(uint value);
+   [MethodImpl(NoInlining)]public static void Write(ulong value);
+   [MethodImpl(NoInlining)]public static void WriteLine();
+   [MethodImpl(NoInlining)]public static void WriteLine(bool value);
+   [MethodImpl(NoInlining)]public static void WriteLine(char value);
+   [MethodImpl(NoInlining)]public static void WriteLine(char[] buffer);
+   [MethodImpl(NoInlining)]public static void WriteLine(char[] buffer, int index, int count);
+   [MethodImpl(NoInlining)]public static void WriteLine(decimal value);
+   [MethodImpl(NoInlining)]public static void WriteLine(double value);
+   [MethodImpl(NoInlining)]public static void WriteLine(int value);
+   [MethodImpl(NoInlining)]public static void WriteLine(long value);
+   [MethodImpl(NoInlining)]public static void WriteLine(object value);
+   [MethodImpl(NoInlining)]public static void WriteLine(float value);
+   [MethodImpl(NoInlining)]public static void WriteLine(string value);
+   [MethodImpl(NoInlining)]public static void WriteLine(string format, object arg0);
+   [MethodImpl(NoInlining)]public static void WriteLine(string format, object arg0, object arg1);
+   [MethodImpl(NoInlining)]public static void WriteLine(string format, object arg0, object arg1, object arg2);
+   [MethodImpl(NoInlining)]public static void WriteLine(string format, params object[] arg);
+   [MethodImpl(NoInlining)]public static void WriteLine(uint value);
+   [MethodImpl(NoInlining)]public static void WriteLine(ulong value);
  }
+ public sealed class ConsoleCancelEventArgs : EventArgs {
+   public bool Cancel { get; set; }
+   public ConsoleSpecialKey SpecialKey { get; }
  }
+ public delegate void ConsoleCancelEventHandler(object sender, ConsoleCancelEventArgs e);
  public enum ConsoleColor {
    Black = 0,
    Blue = 9,
    Cyan = 11,
    DarkBlue = 1,
    DarkCyan = 3,
    DarkGray = 8,
    DarkGreen = 2,
    DarkMagenta = 5,
    DarkRed = 4,
    DarkYellow = 6,
    Gray = 7,
    Green = 10,
    Magenta = 13,
    Red = 12,
    White = 15,
    Yellow = 14,
  }
+ public enum ConsoleSpecialKey {
+   ControlBreak = 1,
+   ControlC = 0,
  }
 }
```
