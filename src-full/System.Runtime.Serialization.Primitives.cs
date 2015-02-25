namespace System.Runtime.Serialization {
  public sealed class CollectionDataContractAttribute : Attribute {
    public CollectionDataContractAttribute();
    public bool IsReference { get; set; }
    public string ItemName { get; set; }
    public string KeyName { get; set; }
    public string Name { get; set; }
    public string Namespace { get; set; }
    public string ValueName { get; set; }
  }
  public sealed class ContractNamespaceAttribute : Attribute {
    public ContractNamespaceAttribute(string contractNamespace);
    public string ClrNamespace { get; set; }
    public string ContractNamespace { get; }
  }
  public sealed class DataContractAttribute : Attribute {
    public DataContractAttribute();
    public bool IsReference { get; set; }
    public string Name { get; set; }
    public string Namespace { get; set; }
  }
  public sealed class DataMemberAttribute : Attribute {
    public DataMemberAttribute();
    public bool EmitDefaultValue { get; set; }
    public bool IsRequired { get; set; }
    public string Name { get; set; }
    public int Order { get; set; }
  }
  public sealed class EnumMemberAttribute : Attribute {
    public EnumMemberAttribute();
    public string Value { get; set; }
  }
  public sealed class IgnoreDataMemberAttribute : Attribute {
    public IgnoreDataMemberAttribute();
  }
  public sealed class KnownTypeAttribute : Attribute {
    public KnownTypeAttribute(string methodName);
    public KnownTypeAttribute(Type type);
    public string MethodName { get; }
    public Type Type { get; }
  }
  public sealed class OnDeserializedAttribute : Attribute {
    public OnDeserializedAttribute();
  }
  public sealed class OnDeserializingAttribute : Attribute {
    public OnDeserializingAttribute();
  }
  public sealed class OnSerializedAttribute : Attribute {
    public OnSerializedAttribute();
  }
  public sealed class OnSerializingAttribute : Attribute {
    public OnSerializingAttribute();
  }
  public class SerializationException : Exception {
    public SerializationException();
    public SerializationException(string message);
    public SerializationException(string message, Exception innerException);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct StreamingContext {
    public override bool Equals(object obj);
    public override int GetHashCode();
  }
}
