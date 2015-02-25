namespace System.Security.Cryptography {
  public abstract class DeriveBytes : IDisposable {
    protected DeriveBytes();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public abstract byte[] GetBytes(int cb);
    public abstract void Reset();
  }
  public class Rfc2898DeriveBytes : DeriveBytes {
    public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations);
    public Rfc2898DeriveBytes(string password, byte[] salt);
    public Rfc2898DeriveBytes(string password, byte[] salt, int iterations);
    public Rfc2898DeriveBytes(string password, int saltSize);
    public Rfc2898DeriveBytes(string password, int saltSize, int iterations);
    public int IterationCount { get; set; }
    public byte[] Salt { get; set; }
    public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV);
    protected override void Dispose(bool disposing);
    public override byte[] GetBytes(int cb);
    public override void Reset();
  }
}
