namespace System {
  public static class Console {
    public static ConsoleColor BackgroundColor { get; set; }
    public static TextWriter Error { get; }
    public static ConsoleColor ForegroundColor { get; set; }
    public static TextReader In { get; }
    public static TextWriter Out { get; }
    public static Stream OpenStandardError();
    public static Stream OpenStandardInput();
    public static Stream OpenStandardOutput();
    public static int Read();
    public static string ReadLine();
    public static void ResetColor();
    public static void SetError(TextWriter newError);
    public static void SetIn(TextReader newIn);
    public static void SetOut(TextWriter newOut);
    public static void Write(bool value);
    public static void Write(char value);
    public static void Write(char[] buffer);
    public static void Write(char[] buffer, int index, int count);
    public static void Write(decimal value);
    public static void Write(double value);
    public static void Write(int value);
    public static void Write(long value);
    public static void Write(object value);
    public static void Write(float value);
    public static void Write(string value);
    public static void Write(string format, object arg0);
    public static void Write(string format, object arg0, object arg1);
    public static void Write(string format, object arg0, object arg1, object arg2);
    public static void Write(string format, params object[] arg);
    public static void Write(uint value);
    public static void Write(ulong value);
    public static void WriteLine();
    public static void WriteLine(bool value);
    public static void WriteLine(char value);
    public static void WriteLine(char[] buffer);
    public static void WriteLine(char[] buffer, int index, int count);
    public static void WriteLine(decimal value);
    public static void WriteLine(double value);
    public static void WriteLine(int value);
    public static void WriteLine(long value);
    public static void WriteLine(object value);
    public static void WriteLine(float value);
    public static void WriteLine(string value);
    public static void WriteLine(string format, object arg0);
    public static void WriteLine(string format, object arg0, object arg1);
    public static void WriteLine(string format, object arg0, object arg1, object arg2);
    public static void WriteLine(string format, params object[] arg);
    public static void WriteLine(uint value);
    public static void WriteLine(ulong value);
  }
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
}
