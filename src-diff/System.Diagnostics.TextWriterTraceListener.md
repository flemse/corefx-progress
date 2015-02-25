```diff
---lib-full\System.Diagnostics.TextWriterTraceListener.dll
+++lib-oss\System.Diagnostics.TextWriterTraceListener.dll
 namespace System.Diagnostics {
  public class DelimitedListTraceListener : TextWriterTraceListener {
    public DelimitedListTraceListener(Stream stream);
    public DelimitedListTraceListener(Stream stream, string name);
    public DelimitedListTraceListener(TextWriter writer);
    public DelimitedListTraceListener(TextWriter writer, string name);
    public string Delimiter { get; set; }
    public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data);
    public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data);
    public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message);
    public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args);
  }
  public class TextWriterTraceListener : TraceListener {
    public TextWriterTraceListener();
    public TextWriterTraceListener(Stream stream);
    public TextWriterTraceListener(Stream stream, string name);
    public TextWriterTraceListener(TextWriter writer);
    public TextWriterTraceListener(TextWriter writer, string name);
    public TextWriter Writer { get; set; }
    protected override void Dispose(bool disposing);
    public override void Flush();
    public override void Write(string message);
    public override void WriteLine(string message);
  }
 }
```
