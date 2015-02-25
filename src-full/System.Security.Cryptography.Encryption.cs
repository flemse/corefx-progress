namespace System.Security.Cryptography {
  public abstract class AsymmetricAlgorithm : IDisposable {
    protected AsymmetricAlgorithm();
    public virtual int KeySize { get; set; }
    public virtual KeySizes[] LegalKeySizes { get; }
    public void Dispose();
    protected virtual void Dispose(bool disposing);
  }
  public enum CipherMode {
    CBC = 1,
    CTS = 5,
    ECB = 2,
  }
  public class CryptographicException : Exception {
    public CryptographicException();
    public CryptographicException(int hr);
    public CryptographicException(string message);
    public CryptographicException(string message, Exception inner);
    public CryptographicException(string format, string insert);
  }
  public class CryptoStream : Stream, IDisposable {
    public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode);
    public override bool CanRead { get; }
    public override bool CanSeek { get; }
    public override bool CanWrite { get; }
    public bool HasFlushedFinalBlock { get; }
    public override long Length { get; }
    public override long Position { get; set; }
    protected override void Dispose(bool disposing);
    public override void Flush();
    public override Task FlushAsync(CancellationToken cancellationToken);
    public void FlushFinalBlock();
    public override int Read(byte[] buffer, int offset, int count);
    public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
    public override long Seek(long offset, SeekOrigin origin);
    public override void SetLength(long value);
    public override void Write(byte[] buffer, int offset, int count);
    public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
  }
  public enum CryptoStreamMode {
    Read = 0,
    Write = 1,
  }
  public interface ICryptoTransform : IDisposable {
    bool CanReuseTransform { get; }
    bool CanTransformMultipleBlocks { get; }
    int InputBlockSize { get; }
    int OutputBlockSize { get; }
    int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);
    byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
  }
  public sealed class KeySizes {
    public KeySizes(int minSize, int maxSize, int skipSize);
    public int MaxSize { get; }
    public int MinSize { get; }
    public int SkipSize { get; }
  }
  public enum PaddingMode {
    None = 1,
    PKCS7 = 2,
    Zeros = 3,
  }
  public abstract class SymmetricAlgorithm : IDisposable {
    protected SymmetricAlgorithm();
    public virtual int BlockSize { get; set; }
    public virtual byte[] IV { get; set; }
    public virtual byte[] Key { get; set; }
    public virtual int KeySize { get; set; }
    public virtual KeySizes[] LegalBlockSizes { get; }
    public virtual KeySizes[] LegalKeySizes { get; }
    public virtual CipherMode Mode { get; set; }
    public virtual PaddingMode Padding { get; set; }
    public virtual ICryptoTransform CreateDecryptor();
    public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);
    public virtual ICryptoTransform CreateEncryptor();
    public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public abstract void GenerateIV();
    public abstract void GenerateKey();
  }
}
