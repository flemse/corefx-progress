namespace System.Diagnostics {
  public static class Debug {
    public static void Assert(bool condition);
    public static void Assert(bool condition, string message);
    public static void Assert(bool condition, string message, string detailMessage);
    public static void Assert(bool condition, string message, string detailMessageFormat, params object[] args);
    public static void Fail(string message);
    public static void Fail(string message, string detailMessage);
    public static void Write(object value);
    public static void Write(object value, string category);
    public static void Write(string message);
    public static void Write(string message, string category);
    public static void WriteIf(bool condition, object value);
    public static void WriteIf(bool condition, object value, string category);
    public static void WriteIf(bool condition, string message);
    public static void WriteIf(bool condition, string message, string category);
    public static void WriteLine(object value);
    public static void WriteLine(object value, string category);
    public static void WriteLine(string message);
    public static void WriteLine(string format, params object[] args);
    public static void WriteLine(string message, string category);
    public static void WriteLineIf(bool condition, object value);
    public static void WriteLineIf(bool condition, object value, string category);
    public static void WriteLineIf(bool condition, string value);
    public static void WriteLineIf(bool condition, string value, string category);
  }
  public static class Debugger {
    public static bool IsAttached { get; }
    public static void Break();
    public static bool Launch();
  }
  public sealed class DebuggerBrowsableAttribute : Attribute {
    public DebuggerBrowsableAttribute(DebuggerBrowsableState state);
    public DebuggerBrowsableState State { get; }
  }
  public enum DebuggerBrowsableState {
    Collapsed = 2,
    Never = 0,
    RootHidden = 3,
  }
  public sealed class DebuggerDisplayAttribute : Attribute {
    public DebuggerDisplayAttribute(string value);
    public string Name { get; set; }
    public Type Target { get; set; }
    public string TargetTypeName { get; set; }
    public string Type { get; set; }
    public string Value { get; }
  }
  public sealed class DebuggerHiddenAttribute : Attribute {
    public DebuggerHiddenAttribute();
  }
  public sealed class DebuggerNonUserCodeAttribute : Attribute {
    public DebuggerNonUserCodeAttribute();
  }
  public sealed class DebuggerStepThroughAttribute : Attribute {
    public DebuggerStepThroughAttribute();
  }
  public sealed class DebuggerTypeProxyAttribute : Attribute {
    public DebuggerTypeProxyAttribute(string typeName);
    public DebuggerTypeProxyAttribute(Type type);
    public string ProxyTypeName { get; }
    public Type Target { get; set; }
    public string TargetTypeName { get; set; }
  }
}
