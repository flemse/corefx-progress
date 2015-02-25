```diff
---lib-full\System.Diagnostics.TraceSource.dll
+++lib-oss\System.Diagnostics.TraceSource.dll
 namespace System.Diagnostics {
  public class BooleanSwitch : Switch {
    public BooleanSwitch(string displayName, string description);
    public BooleanSwitch(string displayName, string description, string defaultSwitchValue);
    public bool Enabled { get; set; }
    protected override void OnValueChanged();
  }
  public class DefaultTraceListener : TraceListener {
    public DefaultTraceListener();
    public override void Fail(string message);
    public override void Fail(string message, string detailMessage);
    public override void Write(string message);
    public override void WriteLine(string message);
  }
  public class EventTypeFilter : TraceFilter {
    public EventTypeFilter(SourceLevels level);
    public SourceLevels EventType { get; set; }
    public override bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);
  }
  public class SourceFilter : TraceFilter {
    public SourceFilter(string source);
    public string Source { get; set; }
    public override bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);
  }
  public enum SourceLevels {
    All = -1,
    Critical = 1,
    Error = 3,
    Information = 15,
    Off = 0,
    Verbose = 31,
    Warning = 7,
  }
  public class SourceSwitch : Switch {
    public SourceSwitch(string name);
    public SourceSwitch(string displayName, string defaultSwitchValue);
    public SourceLevels Level { get; set; }
    protected override void OnValueChanged();
    public bool ShouldTrace(TraceEventType eventType);
  }
  public abstract class Switch {
    protected Switch(string displayName, string description);
    protected Switch(string displayName, string description, string defaultSwitchValue);
    public string Description { get; }
    public string DisplayName { get; }
    protected int SwitchSetting { get; set; }
    protected string Value { get; set; }
    protected virtual void OnSwitchSettingChanged();
    protected virtual void OnValueChanged();
  }
  public sealed class Trace {
    public static bool AutoFlush { get; set; }
    public static int IndentLevel { get; set; }
    public static int IndentSize { get; set; }
    public static TraceListenerCollection Listeners { get; }
    public static bool UseGlobalLock { get; set; }
    public static void Assert(bool condition);
    public static void Assert(bool condition, string message);
    public static void Assert(bool condition, string message, string detailMessage);
    public static void Close();
    public static void Fail(string message);
    public static void Fail(string message, string detailMessage);
    public static void Flush();
    public static void Indent();
    public static void Refresh();
    public static void TraceError(string message);
    public static void TraceError(string format, params object[] args);
    public static void TraceInformation(string message);
    public static void TraceInformation(string format, params object[] args);
    public static void TraceWarning(string message);
    public static void TraceWarning(string format, params object[] args);
    public static void Unindent();
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
    public static void WriteLine(string message, string category);
    public static void WriteLineIf(bool condition, object value);
    public static void WriteLineIf(bool condition, object value, string category);
    public static void WriteLineIf(bool condition, string message);
    public static void WriteLineIf(bool condition, string message, string category);
  }
  public class TraceEventCache {
    public TraceEventCache();
    public DateTime DateTime { get; }
    public int ProcessId { get; }
    public string ThreadId { get; }
    public long Timestamp { get; }
  }
  public enum TraceEventType {
    Critical = 1,
    Error = 2,
    Information = 8,
    Verbose = 16,
    Warning = 4,
  }
  public abstract class TraceFilter {
    protected TraceFilter();
    public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);
  }
  public enum TraceLevel {
    Error = 1,
    Info = 3,
    Off = 0,
    Verbose = 4,
    Warning = 2,
  }
  public abstract class TraceListener : IDisposable {
    protected TraceListener();
    protected TraceListener(string name);
    public TraceFilter Filter { get; set; }
    public int IndentLevel { get; set; }
    public int IndentSize { get; set; }
    public virtual bool IsThreadSafe { get; }
    public virtual string Name { get; set; }
    protected bool NeedIndent { get; set; }
    public TraceOptions TraceOutputOptions { get; set; }
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public virtual void Fail(string message);
    public virtual void Fail(string message, string detailMessage);
    public virtual void Flush();
    public virtual void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data);
    public virtual void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data);
    public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id);
    public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message);
    public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args);
    public virtual void Write(object o);
    public virtual void Write(object o, string category);
    public abstract void Write(string message);
    public virtual void Write(string message, string category);
    protected virtual void WriteIndent();
    public virtual void WriteLine(object o);
    public virtual void WriteLine(object o, string category);
    public abstract void WriteLine(string message);
    public virtual void WriteLine(string message, string category);
  }
  public class TraceListenerCollection : ICollection, IEnumerable, IList {
    public int Count { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    bool System.Collections.IList.IsFixedSize { get; }
    bool System.Collections.IList.IsReadOnly { get; }
    object System.Collections.IList.this[int index] { get; set; }
    public TraceListener this[int i] { get; set; }
    public TraceListener this[string name] { get; }
    public int Add(TraceListener listener);
    public void AddRange(TraceListener[] value);
    public void AddRange(TraceListenerCollection value);
    public void Clear();
    public bool Contains(TraceListener listener);
    public void CopyTo(TraceListener[] listeners, int index);
    public IEnumerator GetEnumerator();
    public int IndexOf(TraceListener listener);
    public void Insert(int index, TraceListener listener);
    public void Remove(TraceListener listener);
    public void Remove(string name);
    public void RemoveAt(int index);
    void System.Collections.ICollection.CopyTo(Array array, int index);
    int System.Collections.IList.Add(object value);
    bool System.Collections.IList.Contains(object value);
    int System.Collections.IList.IndexOf(object value);
    void System.Collections.IList.Insert(int index, object value);
    void System.Collections.IList.Remove(object value);
  }
  public enum TraceOptions {
    DateTime = 2,
    None = 0,
    ProcessId = 8,
    ThreadId = 16,
    Timestamp = 4,
  }
  public class TraceSource {
    public TraceSource(string name);
    public TraceSource(string name, SourceLevels defaultLevel);
    public TraceListenerCollection Listeners { get; }
    public string Name { get; }
    public SourceSwitch Switch { get; set; }
    public void Close();
    public void Flush();
    public void TraceData(TraceEventType eventType, int id, object data);
    public void TraceData(TraceEventType eventType, int id, params object[] data);
    public void TraceEvent(TraceEventType eventType, int id);
    public void TraceEvent(TraceEventType eventType, int id, string message);
    public void TraceEvent(TraceEventType eventType, int id, string format, params object[] args);
    public void TraceInformation(string message);
    public void TraceInformation(string format, params object[] args);
  }
  public class TraceSwitch : Switch {
    public TraceSwitch(string displayName, string description);
    public TraceSwitch(string displayName, string description, string defaultSwitchValue);
    public TraceLevel Level { get; set; }
    public bool TraceError { get; }
    public bool TraceInfo { get; }
    public bool TraceVerbose { get; }
    public bool TraceWarning { get; }
    protected override void OnSwitchSettingChanged();
    protected override void OnValueChanged();
  }
 }
```
