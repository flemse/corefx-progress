namespace System.Runtime.Serialization {
  public class DateTimeFormat {
    public DateTimeFormat(string formatString);
    public DateTimeFormat(string formatString, IFormatProvider formatProvider);
    public DateTimeStyles DateTimeStyles { get; set; }
    public IFormatProvider FormatProvider { get; }
    public string FormatString { get; }
  }
  public enum EmitTypeInformation {
    Always = 1,
    AsNeeded = 0,
    Never = 2,
  }
}
namespace System.Runtime.Serialization.Json {
  public sealed class DataContractJsonSerializer {
    public DataContractJsonSerializer(Type type);
    public DataContractJsonSerializer(Type type, IEnumerable<Type> knownTypes);
    public DataContractJsonSerializer(Type type, DataContractJsonSerializerSettings settings);
    public DateTimeFormat DateTimeFormat { get; }
    public EmitTypeInformation EmitTypeInformation { get; }
    public ReadOnlyCollection<Type> KnownTypes { get; }
    public bool SerializeReadOnlyTypes { get; }
    public bool UseSimpleDictionaryFormat { get; }
    public object ReadObject(Stream stream);
    public void WriteObject(Stream stream, object graph);
  }
  public class DataContractJsonSerializerSettings {
    public DataContractJsonSerializerSettings();
    public DateTimeFormat DateTimeFormat { get; set; }
    public EmitTypeInformation EmitTypeInformation { get; set; }
    public IEnumerable<Type> KnownTypes { get; set; }
    public int MaxItemsInObjectGraph { get; set; }
    public string RootName { get; set; }
    public bool SerializeReadOnlyTypes { get; set; }
    public bool UseSimpleDictionaryFormat { get; set; }
  }
}
