namespace System.Security.Cryptography {
  public class AsnEncodedData {
    protected AsnEncodedData();
    public AsnEncodedData(byte[] rawData);
    public AsnEncodedData(AsnEncodedData asnEncodedData);
    public AsnEncodedData(Oid oid, byte[] rawData);
    public AsnEncodedData(string oid, byte[] rawData);
    public Oid Oid { get; set; }
    public byte[] RawData { get; set; }
    public virtual void CopyFrom(AsnEncodedData asnEncodedData);
    public virtual string Format(bool multiLine);
  }
  public sealed class Oid {
    public Oid(Oid oid);
    public Oid(string oid);
    public Oid(string value, string friendlyName);
    public string FriendlyName { get; set; }
    public string Value { get; set; }
    public static Oid FromFriendlyName(string friendlyName, OidGroup group);
    public static Oid FromOidValue(string oidValue, OidGroup group);
  }
  public sealed class OidCollection : ICollection, IEnumerable {
    public OidCollection();
    public int Count { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    public Oid this[int index] { get; }
    public Oid this[string oid] { get; }
    public int Add(Oid oid);
    public void CopyTo(Oid[] array, int index);
    public OidEnumerator GetEnumerator();
    void System.Collections.ICollection.CopyTo(Array array, int index);
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
  }
  public sealed class OidEnumerator : IEnumerator {
    public Oid Current { get; }
    object System.Collections.IEnumerator.Current { get; }
    public bool MoveNext();
    public void Reset();
  }
  public enum OidGroup {
    All = 0,
    Attribute = 5,
    EncryptionAlgorithm = 2,
    EnhancedKeyUsage = 7,
    ExtensionOrAttribute = 6,
    HashAlgorithm = 1,
    KeyDerivationFunction = 10,
    Policy = 8,
    PublicKeyAlgorithm = 3,
    SignatureAlgorithm = 4,
    Template = 9,
  }
}
