namespace System.Security.Cryptography {
  public abstract class RandomNumberGenerator : IDisposable {
    protected RandomNumberGenerator();
    public static RandomNumberGenerator Create();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public abstract void GetBytes(byte[] data);
  }
}
