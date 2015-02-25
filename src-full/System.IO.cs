namespace System.IO {
  public class BinaryReader : IDisposable {
    public BinaryReader(Stream input);
    public BinaryReader(Stream input, Encoding encoding);
    public BinaryReader(Stream input, Encoding encoding, bool leaveOpen);
    public virtual Stream BaseStream { get; }
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    protected virtual void FillBuffer(int numBytes);
    public virtual int PeekChar();
    public virtual int Read();
    public virtual int Read(byte[] buffer, int index, int count);
    public virtual int Read(char[] buffer, int index, int count);
    protected internal int Read7BitEncodedInt();
    public virtual bool ReadBoolean();
    public virtual byte ReadByte();
    public virtual byte[] ReadBytes(int count);
    public virtual char ReadChar();
    public virtual char[] ReadChars(int count);
    public virtual decimal ReadDecimal();
    public virtual double ReadDouble();
    public virtual short ReadInt16();
    public virtual int ReadInt32();
    public virtual long ReadInt64();
    public virtual sbyte ReadSByte();
    public virtual float ReadSingle();
    public virtual string ReadString();
    public virtual ushort ReadUInt16();
    public virtual uint ReadUInt32();
    public virtual ulong ReadUInt64();
  }
  public class BinaryWriter : IDisposable {
    public static readonly BinaryWriter Null;
    protected Stream OutStream;
    protected BinaryWriter();
    public BinaryWriter(Stream output);
    public BinaryWriter(Stream output, Encoding encoding);
    public BinaryWriter(Stream output, Encoding encoding, bool leaveOpen);
    public virtual Stream BaseStream { get; }
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public virtual void Flush();
    public virtual long Seek(int offset, SeekOrigin origin);
    public virtual void Write(bool value);
    public virtual void Write(byte value);
    public virtual void Write(byte[] buffer);
    public virtual void Write(byte[] buffer, int index, int count);
    public virtual void Write(char ch);
    public virtual void Write(char[] chars);
    public virtual void Write(char[] chars, int index, int count);
    public virtual void Write(decimal value);
    public virtual void Write(double value);
    public virtual void Write(short value);
    public virtual void Write(int value);
    public virtual void Write(long value);
    public virtual void Write(sbyte value);
    public virtual void Write(float value);
    public virtual void Write(string value);
    public virtual void Write(ushort value);
    public virtual void Write(uint value);
    public virtual void Write(ulong value);
    protected void Write7BitEncodedInt(int value);
  }
  public class EndOfStreamException : IOException {
    public EndOfStreamException();
    public EndOfStreamException(string message);
    public EndOfStreamException(string message, Exception innerException);
  }
  public sealed class InvalidDataException : Exception {
    public InvalidDataException();
    public InvalidDataException(string message);
    public InvalidDataException(string message, Exception innerException);
  }
  public class MemoryStream : Stream {
    public MemoryStream();
    public MemoryStream(byte[] buffer);
    public MemoryStream(byte[] buffer, bool writable);
    public MemoryStream(byte[] buffer, int index, int count);
    public MemoryStream(byte[] buffer, int index, int count, bool writable);
    public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible);
    public MemoryStream(int capacity);
    public override bool CanRead { get; }
    public override bool CanSeek { get; }
    public override bool CanWrite { get; }
    public virtual int Capacity { get; set; }
    public override long Length { get; }
    public override long Position { get; set; }
    public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken);
    protected override void Dispose(bool disposing);
    public override void Flush();
    public override Task FlushAsync(CancellationToken cancellationToken);
    public override int Read(byte[] buffer, int offset, int count);
    public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
    public override int ReadByte();
    public override long Seek(long offset, SeekOrigin loc);
    public override void SetLength(long value);
    public virtual byte[] ToArray();
    public virtual bool TryGetBuffer(out ArraySegment<byte> buffer);
    public override void Write(byte[] buffer, int offset, int count);
    public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
    public override void WriteByte(byte value);
    public virtual void WriteTo(Stream stream);
  }
  public enum SeekOrigin {
    Begin = 0,
    Current = 1,
    End = 2,
  }
  public abstract class Stream : IDisposable {
    public static readonly Stream Null;
    protected Stream();
    public abstract bool CanRead { get; }
    public abstract bool CanSeek { get; }
    public virtual bool CanTimeout { get; }
    public abstract bool CanWrite { get; }
    public abstract long Length { get; }
    public abstract long Position { get; set; }
    public virtual int ReadTimeout { get; set; }
    public virtual int WriteTimeout { get; set; }
    public void CopyTo(Stream destination);
    public void CopyTo(Stream destination, int bufferSize);
    public Task CopyToAsync(Stream destination);
    public Task CopyToAsync(Stream destination, int bufferSize);
    public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public abstract void Flush();
    public Task FlushAsync();
    public virtual Task FlushAsync(CancellationToken cancellationToken);
    public abstract int Read(byte[] buffer, int offset, int count);
    public Task<int> ReadAsync(byte[] buffer, int offset, int count);
    public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
    public virtual int ReadByte();
    public abstract long Seek(long offset, SeekOrigin origin);
    public abstract void SetLength(long value);
    public abstract void Write(byte[] buffer, int offset, int count);
    public Task WriteAsync(byte[] buffer, int offset, int count);
    public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
    public virtual void WriteByte(byte value);
  }
  public class StreamReader : TextReader {
    public static readonly new StreamReader Null;
    public StreamReader(Stream stream);
    public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks);
    public StreamReader(Stream stream, Encoding encoding);
    public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks);
    public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize);
    public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen);
    public virtual Stream BaseStream { get; }
    public virtual Encoding CurrentEncoding { get; }
    public bool EndOfStream { get; }
    public void DiscardBufferedData();
    protected override void Dispose(bool disposing);
    public override int Peek();
    public override int Read();
    public override int Read(char[] buffer, int index, int count);
    public override Task<int> ReadAsync(char[] buffer, int index, int count);
    public override int ReadBlock(char[] buffer, int index, int count);
    public override Task<int> ReadBlockAsync(char[] buffer, int index, int count);
    public override string ReadLine();
    public override Task<string> ReadLineAsync();
    public override string ReadToEnd();
    public override Task<string> ReadToEndAsync();
  }
  public class StreamWriter : TextWriter {
    public static readonly new StreamWriter Null;
    public StreamWriter(Stream stream);
    public StreamWriter(Stream stream, Encoding encoding);
    public StreamWriter(Stream stream, Encoding encoding, int bufferSize);
    public StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen);
    public virtual bool AutoFlush { get; set; }
    public virtual Stream BaseStream { get; }
    public override Encoding Encoding { get; }
    protected override void Dispose(bool disposing);
    public override void Flush();
    public override Task FlushAsync();
    public override void Write(char value);
    public override void Write(char[] buffer);
    public override void Write(char[] buffer, int index, int count);
    public override void Write(string value);
    public override Task WriteAsync(char value);
    public override Task WriteAsync(char[] buffer, int index, int count);
    public override Task WriteAsync(string value);
    public override Task WriteLineAsync();
    public override Task WriteLineAsync(char value);
    public override Task WriteLineAsync(char[] buffer, int index, int count);
    public override Task WriteLineAsync(string value);
  }
  public class StringReader : TextReader {
    public StringReader(string s);
    protected override void Dispose(bool disposing);
    public override int Peek();
    public override int Read();
    public override int Read(char[] buffer, int index, int count);
    public override Task<int> ReadAsync(char[] buffer, int index, int count);
    public override Task<int> ReadBlockAsync(char[] buffer, int index, int count);
    public override string ReadLine();
    public override Task<string> ReadLineAsync();
    public override string ReadToEnd();
    public override Task<string> ReadToEndAsync();
  }
  public class StringWriter : TextWriter {
    public StringWriter();
    public StringWriter(IFormatProvider formatProvider);
    public StringWriter(StringBuilder sb);
    public StringWriter(StringBuilder sb, IFormatProvider formatProvider);
    public override Encoding Encoding { get; }
    protected override void Dispose(bool disposing);
    public override Task FlushAsync();
    public virtual StringBuilder GetStringBuilder();
    public override string ToString();
    public override void Write(char value);
    public override void Write(char[] buffer, int index, int count);
    public override void Write(string value);
    public override Task WriteAsync(char value);
    public override Task WriteAsync(char[] buffer, int index, int count);
    public override Task WriteAsync(string value);
    public override Task WriteLineAsync(char value);
    public override Task WriteLineAsync(char[] buffer, int index, int count);
    public override Task WriteLineAsync(string value);
  }
  public abstract class TextReader : IDisposable {
    public static readonly TextReader Null;
    protected TextReader();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public virtual int Peek();
    public virtual int Read();
    public virtual int Read(char[] buffer, int index, int count);
    public virtual Task<int> ReadAsync(char[] buffer, int index, int count);
    public virtual int ReadBlock(char[] buffer, int index, int count);
    public virtual Task<int> ReadBlockAsync(char[] buffer, int index, int count);
    public virtual string ReadLine();
    public virtual Task<string> ReadLineAsync();
    public virtual string ReadToEnd();
    public virtual Task<string> ReadToEndAsync();
  }
  public abstract class TextWriter : IDisposable {
    protected char[] CoreNewLine;
    public static readonly TextWriter Null;
    protected TextWriter();
    protected TextWriter(IFormatProvider formatProvider);
    public abstract Encoding Encoding { get; }
    public virtual IFormatProvider FormatProvider { get; }
    public virtual string NewLine { get; set; }
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public virtual void Flush();
    public virtual Task FlushAsync();
    public virtual void Write(bool value);
    public abstract void Write(char value);
    public virtual void Write(char[] buffer);
    public virtual void Write(char[] buffer, int index, int count);
    public virtual void Write(decimal value);
    public virtual void Write(double value);
    public virtual void Write(int value);
    public virtual void Write(long value);
    public virtual void Write(object value);
    public virtual void Write(float value);
    public virtual void Write(string value);
    public virtual void Write(string format, object arg0);
    public virtual void Write(string format, object arg0, object arg1);
    public virtual void Write(string format, object arg0, object arg1, object arg2);
    public virtual void Write(string format, params object[] arg);
    public virtual void Write(uint value);
    public virtual void Write(ulong value);
    public virtual Task WriteAsync(char value);
    public Task WriteAsync(char[] buffer);
    public virtual Task WriteAsync(char[] buffer, int index, int count);
    public virtual Task WriteAsync(string value);
    public virtual void WriteLine();
    public virtual void WriteLine(bool value);
    public virtual void WriteLine(char value);
    public virtual void WriteLine(char[] buffer);
    public virtual void WriteLine(char[] buffer, int index, int count);
    public virtual void WriteLine(decimal value);
    public virtual void WriteLine(double value);
    public virtual void WriteLine(int value);
    public virtual void WriteLine(long value);
    public virtual void WriteLine(object value);
    public virtual void WriteLine(float value);
    public virtual void WriteLine(string value);
    public virtual void WriteLine(string format, object arg0);
    public virtual void WriteLine(string format, object arg0, object arg1);
    public virtual void WriteLine(string format, object arg0, object arg1, object arg2);
    public virtual void WriteLine(string format, params object[] arg);
    public virtual void WriteLine(uint value);
    public virtual void WriteLine(ulong value);
    public virtual Task WriteLineAsync();
    public virtual Task WriteLineAsync(char value);
    public Task WriteLineAsync(char[] buffer);
    public virtual Task WriteLineAsync(char[] buffer, int index, int count);
    public virtual Task WriteLineAsync(string value);
  }
}
