namespace System.Security.Cryptography {
  public class HMACSHA1 : HMAC {
    public HMACSHA1();
    public HMACSHA1(byte[] key);
  }
  public class HMACSHA256 : HMAC {
    public HMACSHA256();
    public HMACSHA256(byte[] key);
  }
  public class HMACSHA384 : HMAC {
    public HMACSHA384();
    public HMACSHA384(byte[] key);
  }
  public class HMACSHA512 : HMAC {
    public HMACSHA512();
    public HMACSHA512(byte[] key);
  }
  public abstract class MD5 : HashAlgorithm {
    protected MD5();
    public static MD5 Create();
  }
  public abstract class SHA1 : HashAlgorithm {
    protected SHA1();
    public static SHA1 Create();
  }
  public abstract class SHA256 : HashAlgorithm {
    protected SHA256();
    public static SHA256 Create();
  }
  public abstract class SHA384 : HashAlgorithm {
    protected SHA384();
    public static SHA384 Create();
  }
  public abstract class SHA512 : HashAlgorithm {
    protected SHA512();
    public static SHA512 Create();
  }
}
