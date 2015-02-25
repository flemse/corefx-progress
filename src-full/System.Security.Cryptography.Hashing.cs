namespace System.Security.Cryptography {
  public abstract class HashAlgorithm : IDisposable {
    protected HashAlgorithm();
    public virtual int HashSize { get; }
    public byte[] ComputeHash(byte[] buffer);
    public byte[] ComputeHash(byte[] buffer, int offset, int count);
    public byte[] ComputeHash(Stream inputStream);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    protected abstract void HashCore(byte[] array, int ibStart, int cbSize);
    protected abstract byte[] HashFinal();
    public abstract void Initialize();
  }
  public abstract class HMAC : KeyedHashAlgorithm {
    protected HMAC();
    public string HashName { get; set; }
    public override byte[] Key { get; set; }
    protected override void Dispose(bool disposing);
    protected override void HashCore(byte[] rgb, int ib, int cb);
    protected override byte[] HashFinal();
    public override void Initialize();
  }
  public abstract class KeyedHashAlgorithm : HashAlgorithm {
    protected KeyedHashAlgorithm();
    public virtual byte[] Key { get; set; }
    protected override void Dispose(bool disposing);
  }
}
