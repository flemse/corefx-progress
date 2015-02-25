```diff
---lib-full\System.IO.UnmanagedMemoryStream.dll
+++lib-oss\System.IO.UnmanagedMemoryStream.dll
 namespace System.IO {
  public class UnmanagedMemoryAccessor : IDisposable {
    protected UnmanagedMemoryAccessor();
    public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity);
    public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity, FileAccess access);
    public bool CanRead { get; }
    public bool CanWrite { get; }
    public long Capacity { get; }
    protected bool IsOpen { get; }
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    protected void Initialize(SafeBuffer buffer, long offset, long capacity, FileAccess access);
    public bool ReadBoolean(long position);
    public byte ReadByte(long position);
    public char ReadChar(long position);
    public decimal ReadDecimal(long position);
    public double ReadDouble(long position);
    public short ReadInt16(long position);
    public int ReadInt32(long position);
    public long ReadInt64(long position);
    public sbyte ReadSByte(long position);
    public float ReadSingle(long position);
    public ushort ReadUInt16(long position);
    public uint ReadUInt32(long position);
    public ulong ReadUInt64(long position);
    public void Write(long position, bool value);
    public void Write(long position, byte value);
    public void Write(long position, char value);
    public void Write(long position, decimal value);
    public void Write(long position, double value);
    public void Write(long position, short value);
    public void Write(long position, int value);
    public void Write(long position, long value);
    public void Write(long position, sbyte value);
    public void Write(long position, float value);
    public void Write(long position, ushort value);
    public void Write(long position, uint value);
    public void Write(long position, ulong value);
  }
  public class UnmanagedMemoryStream : Stream {
    protected UnmanagedMemoryStream();
    public unsafe UnmanagedMemoryStream(byte* pointer, long length);
    public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access);
    public UnmanagedMemoryStream(SafeBuffer buffer, long offset, long length);
    public UnmanagedMemoryStream(SafeBuffer buffer, long offset, long length, FileAccess access);
    public override bool CanRead { get; }
    public override bool CanSeek { get; }
    public override bool CanWrite { get; }
    public long Capacity { get; }
    public override long Length { get; }
    public override long Position { get; set; }
    public unsafe byte* PositionPointer { get; set; }
    protected override void Dispose(bool disposing);
    public override void Flush();
    public override Task FlushAsync(CancellationToken cancellationToken);
    protected unsafe void Initialize(byte* pointer, long length, long capacity, FileAccess access);
    protected void Initialize(SafeBuffer buffer, long offset, long length, FileAccess access);
    public override int Read(byte[] buffer, int offset, int count);
    public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
    public override int ReadByte();
    public override long Seek(long offset, SeekOrigin loc);
    public override void SetLength(long value);
    public override void Write(byte[] buffer, int offset, int count);
    public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
    public override void WriteByte(byte value);
  }
 }
```
