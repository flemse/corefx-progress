```diff
---lib-full\System.Private.DataContractSerialization.dll
+++lib-oss\System.Private.DataContractSerialization.dll
+namespace System.Runtime.Serialization {
+ public abstract class DataContractResolver {
+   protected DataContractResolver();
+   public abstract Type ResolveName(string typeName, string typeNamespace, Type declaredType, DataContractResolver knownTypeResolver);
+   public abstract bool TryResolveType(Type type, Type declaredType, DataContractResolver knownTypeResolver, out XmlDictionaryString typeName, out XmlDictionaryString typeNamespace);
  }
+ public sealed class DataContractSerializer : XmlObjectSerializer {
+   public DataContractSerializer(Type type);
+   public DataContractSerializer(Type type, IEnumerable<Type> knownTypes);
+   public DataContractSerializer(Type type, DataContractSerializerSettings settings);
+   public DataContractSerializer(Type type, string rootName, string rootNamespace);
+   public DataContractSerializer(Type type, string rootName, string rootNamespace, IEnumerable<Type> knownTypes);
+   public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace);
+   public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes);
+   public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, DataContractResolver dataContractResolver);
+   public DataContractResolver DataContractResolver { get; }
+   public bool IgnoreExtensionDataObject { get; }
+   public ReadOnlyCollection<Type> KnownTypes { get; }
+   public int MaxItemsInObjectGraph { get; }
+   public bool PreserveObjectReferences { get; }
+   public bool SerializeReadOnlyTypes { get; }
+   public override bool IsStartObject(XmlDictionaryReader reader);
+   public override bool IsStartObject(XmlReader reader);
+   public override object ReadObject(XmlDictionaryReader reader, bool verifyObjectName);
+   public override object ReadObject(XmlReader reader);
+   public override object ReadObject(XmlReader reader, bool verifyObjectName);
+   public override void WriteEndObject(XmlDictionaryWriter writer);
+   public override void WriteEndObject(XmlWriter writer);
+   public override void WriteObject(XmlWriter writer, object graph);
+   public override void WriteObjectContent(XmlDictionaryWriter writer, object graph);
+   public override void WriteObjectContent(XmlWriter writer, object graph);
+   public override void WriteStartObject(XmlDictionaryWriter writer, object graph);
+   public override void WriteStartObject(XmlWriter writer, object graph);
  }
+ public class DataContractSerializerSettings {
+   public DataContractSerializerSettings();
+   public DataContractResolver DataContractResolver { get; set; }
+   public IEnumerable<Type> KnownTypes { get; set; }
+   public int MaxItemsInObjectGraph { get; set; }
+   public bool PreserveObjectReferences { get; set; }
+   public XmlDictionaryString RootName { get; set; }
+   public XmlDictionaryString RootNamespace { get; set; }
+   public bool SerializeReadOnlyTypes { get; set; }
  }
+ public class DateTimeFormat {
+   public DateTimeFormat(string formatString);
+   public DateTimeFormat(string formatString, IFormatProvider formatProvider);
+   public DateTimeStyles DateTimeStyles { get; set; }
+   public IFormatProvider FormatProvider { get; }
+   public string FormatString { get; }
  }
+ public enum EmitTypeInformation {
+   Always = 1,
+   AsNeeded = 0,
+   Never = 2,
  }
+ public abstract class XmlObjectSerializer {
+   protected XmlObjectSerializer();
+   public abstract bool IsStartObject(XmlDictionaryReader reader);
+   public virtual bool IsStartObject(XmlReader reader);
+   public virtual object ReadObject(Stream stream);
+   public virtual object ReadObject(XmlDictionaryReader reader);
+   public abstract object ReadObject(XmlDictionaryReader reader, bool verifyObjectName);
+   public virtual object ReadObject(XmlReader reader);
+   public virtual object ReadObject(XmlReader reader, bool verifyObjectName);
+   public abstract void WriteEndObject(XmlDictionaryWriter writer);
+   public virtual void WriteEndObject(XmlWriter writer);
+   public virtual void WriteObject(Stream stream, object graph);
+   public virtual void WriteObject(XmlDictionaryWriter writer, object graph);
+   public virtual void WriteObject(XmlWriter writer, object graph);
+   public abstract void WriteObjectContent(XmlDictionaryWriter writer, object graph);
+   public virtual void WriteObjectContent(XmlWriter writer, object graph);
+   public abstract void WriteStartObject(XmlDictionaryWriter writer, object graph);
+   public virtual void WriteStartObject(XmlWriter writer, object graph);
  }
 }
+namespace System.Runtime.Serialization.Json {
+ public sealed class DataContractJsonSerializer {
+   public DataContractJsonSerializer(Type type);
+   public DataContractJsonSerializer(Type type, IEnumerable<Type> knownTypes);
+   public DataContractJsonSerializer(Type type, DataContractJsonSerializerSettings settings);
+   public DateTimeFormat DateTimeFormat { get; }
+   public EmitTypeInformation EmitTypeInformation { get; }
+   public ReadOnlyCollection<Type> KnownTypes { get; }
+   public int MaxItemsInObjectGraph { get; }
+   public bool SerializeReadOnlyTypes { get; }
+   public bool UseSimpleDictionaryFormat { get; }
+   public object ReadObject(Stream stream);
+   public void WriteObject(Stream stream, object graph);
  }
+ public class DataContractJsonSerializerSettings {
+   public DataContractJsonSerializerSettings();
+   public DateTimeFormat DateTimeFormat { get; set; }
+   public EmitTypeInformation EmitTypeInformation { get; set; }
+   public bool IgnoreExtensionDataObject { get; set; }
+   public IEnumerable<Type> KnownTypes { get; set; }
+   public int MaxItemsInObjectGraph { get; set; }
+   public string RootName { get; set; }
+   public bool SerializeReadOnlyTypes { get; set; }
+   public bool UseSimpleDictionaryFormat { get; set; }
  }
 }
+namespace System.Xml {
+ public interface IXmlDictionary {
+   bool TryLookup(int key, out XmlDictionaryString result);
+   bool TryLookup(string value, out XmlDictionaryString result);
+   bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result);
  }
+ public interface IXmlTextReaderInitializer {
+   void SetInput(byte[] buffer, int offset, int count, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose);
+   void SetInput(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose);
  }
+ public delegate void OnXmlDictionaryReaderClose(XmlDictionaryReader reader);
+ public class UniqueId {
+   public UniqueId();
+   public UniqueId(byte[] guid);
+   public UniqueId(byte[] guid, int offset);
+   public UniqueId(char[] chars, int offset, int count);
+   public UniqueId(Guid guid);
+   public UniqueId(string value);
+   public int CharArrayLength { get; }
+   public bool IsGuid { get; }
+   public override bool Equals(object obj);
+   public override int GetHashCode();
+   public static bool operator ==(UniqueId id1, UniqueId id2);
+   public static bool operator !=(UniqueId id1, UniqueId id2);
+   public int ToCharArray(char[] chars, int offset);
+   public override string ToString();
+   public bool TryGetGuid(byte[] buffer, int offset);
+   public bool TryGetGuid(out Guid guid);
  }
+ public class XmlBinaryReaderSession : IXmlDictionary {
+   public XmlBinaryReaderSession();
+   public XmlDictionaryString Add(int id, string value);
+   public void Clear();
+   public bool TryLookup(int key, out XmlDictionaryString result);
+   public bool TryLookup(string value, out XmlDictionaryString result);
+   public bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result);
  }
+ public class XmlBinaryWriterSession {
+   public XmlBinaryWriterSession();
+   public void Reset();
+   public virtual bool TryAdd(XmlDictionaryString value, out int key);
  }
+ public class XmlDictionary : IXmlDictionary {
+   public XmlDictionary();
+   public XmlDictionary(int capacity);
+   public static IXmlDictionary Empty { get; }
+   public virtual XmlDictionaryString Add(string value);
+   public virtual bool TryLookup(int key, out XmlDictionaryString result);
+   public virtual bool TryLookup(string value, out XmlDictionaryString result);
+   public virtual bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result);
  }
+ public abstract class XmlDictionaryReader : XmlReader {
+   protected XmlDictionaryReader();
+   public virtual bool CanCanonicalize { get; }
+   public virtual XmlDictionaryReaderQuotas Quotas { get; }
+   public virtual void Close();
+   public static XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas);
+   public static XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session);
+   public static XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, XmlDictionaryReaderQuotas quotas);
+   public static XmlDictionaryReader CreateBinaryReader(byte[] buffer, XmlDictionaryReaderQuotas quotas);
+   public static XmlDictionaryReader CreateBinaryReader(Stream stream, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas);
+   public static XmlDictionaryReader CreateBinaryReader(Stream stream, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session);
+   public static XmlDictionaryReader CreateBinaryReader(Stream stream, XmlDictionaryReaderQuotas quotas);
+   public static XmlDictionaryReader CreateDictionaryReader(XmlReader reader);
+   public static XmlDictionaryReader CreateTextReader(byte[] buffer, int offset, int count, XmlDictionaryReaderQuotas quotas);
+   public static XmlDictionaryReader CreateTextReader(byte[] buffer, XmlDictionaryReaderQuotas quotas);
+   public static XmlDictionaryReader CreateTextReader(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose);
+   public static XmlDictionaryReader CreateTextReader(Stream stream, XmlDictionaryReaderQuotas quotas);
+   public virtual void EndCanonicalization();
+   public virtual string GetAttribute(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual int IndexOfLocalName(string[] localNames, string namespaceUri);
+   public virtual int IndexOfLocalName(XmlDictionaryString[] localNames, XmlDictionaryString namespaceUri);
+   public virtual bool IsLocalName(string localName);
+   public virtual bool IsLocalName(XmlDictionaryString localName);
+   public virtual bool IsNamespaceUri(string namespaceUri);
+   public virtual bool IsNamespaceUri(XmlDictionaryString namespaceUri);
+   public virtual bool IsStartArray(out Type type);
+   public virtual bool IsStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   protected bool IsTextNode(XmlNodeType nodeType);
+   public virtual void MoveToStartElement();
+   public virtual void MoveToStartElement(string name);
+   public virtual void MoveToStartElement(string localName, string namespaceUri);
+   public virtual void MoveToStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual int ReadArray(string localName, string namespaceUri, bool[] array, int offset, int count);
+   public virtual int ReadArray(string localName, string namespaceUri, DateTime[] array, int offset, int count);
+   public virtual int ReadArray(string localName, string namespaceUri, decimal[] array, int offset, int count);
+   public virtual int ReadArray(string localName, string namespaceUri, double[] array, int offset, int count);
+   public virtual int ReadArray(string localName, string namespaceUri, Guid[] array, int offset, int count);
+   public virtual int ReadArray(string localName, string namespaceUri, short[] array, int offset, int count);
+   public virtual int ReadArray(string localName, string namespaceUri, int[] array, int offset, int count);
+   public virtual int ReadArray(string localName, string namespaceUri, long[] array, int offset, int count);
+   public virtual int ReadArray(string localName, string namespaceUri, float[] array, int offset, int count);
+   public virtual int ReadArray(string localName, string namespaceUri, TimeSpan[] array, int offset, int count);
+   public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
+   public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, DateTime[] array, int offset, int count);
+   public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
+   public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, double[] array, int offset, int count);
+   public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Guid[] array, int offset, int count);
+   public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, short[] array, int offset, int count);
+   public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, int[] array, int offset, int count);
+   public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, long[] array, int offset, int count);
+   public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, float[] array, int offset, int count);
+   public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, TimeSpan[] array, int offset, int count);
+   public virtual bool[] ReadBooleanArray(string localName, string namespaceUri);
+   public virtual bool[] ReadBooleanArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public override object ReadContentAs(Type type, IXmlNamespaceResolver namespaceResolver);
+   public virtual byte[] ReadContentAsBase64();
+   public virtual byte[] ReadContentAsBinHex();
+   protected byte[] ReadContentAsBinHex(int maxByteArrayContentLength);
+   public virtual int ReadContentAsChars(char[] chars, int offset, int count);
+   public override decimal ReadContentAsDecimal();
+   public override float ReadContentAsFloat();
+   public virtual Guid ReadContentAsGuid();
+   public virtual void ReadContentAsQualifiedName(out string localName, out string namespaceUri);
+   public override string ReadContentAsString();
+   protected string ReadContentAsString(int maxStringContentLength);
+   public virtual string ReadContentAsString(string[] strings, out int index);
+   public virtual string ReadContentAsString(XmlDictionaryString[] strings, out int index);
+   public virtual TimeSpan ReadContentAsTimeSpan();
+   public virtual UniqueId ReadContentAsUniqueId();
+   public virtual DateTime[] ReadDateTimeArray(string localName, string namespaceUri);
+   public virtual DateTime[] ReadDateTimeArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual decimal[] ReadDecimalArray(string localName, string namespaceUri);
+   public virtual decimal[] ReadDecimalArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual double[] ReadDoubleArray(string localName, string namespaceUri);
+   public virtual double[] ReadDoubleArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual byte[] ReadElementContentAsBase64();
+   public virtual byte[] ReadElementContentAsBinHex();
+   public override bool ReadElementContentAsBoolean();
+   public virtual DateTime ReadElementContentAsDateTime();
+   public override decimal ReadElementContentAsDecimal();
+   public override double ReadElementContentAsDouble();
+   public override float ReadElementContentAsFloat();
+   public virtual Guid ReadElementContentAsGuid();
+   public override int ReadElementContentAsInt();
+   public override long ReadElementContentAsLong();
+   public override string ReadElementContentAsString();
+   public virtual TimeSpan ReadElementContentAsTimeSpan();
+   public virtual UniqueId ReadElementContentAsUniqueId();
+   public virtual void ReadFullStartElement();
+   public virtual void ReadFullStartElement(string name);
+   public virtual void ReadFullStartElement(string localName, string namespaceUri);
+   public virtual void ReadFullStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual Guid[] ReadGuidArray(string localName, string namespaceUri);
+   public virtual Guid[] ReadGuidArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual short[] ReadInt16Array(string localName, string namespaceUri);
+   public virtual short[] ReadInt16Array(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual int[] ReadInt32Array(string localName, string namespaceUri);
+   public virtual int[] ReadInt32Array(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual long[] ReadInt64Array(string localName, string namespaceUri);
+   public virtual long[] ReadInt64Array(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual float[] ReadSingleArray(string localName, string namespaceUri);
+   public virtual float[] ReadSingleArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual void ReadStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual TimeSpan[] ReadTimeSpanArray(string localName, string namespaceUri);
+   public virtual TimeSpan[] ReadTimeSpanArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual int ReadValueAsBase64(byte[] buffer, int offset, int count);
+   public virtual void StartCanonicalization(Stream stream, bool includeComments, string[] inclusivePrefixes);
+   public virtual bool TryGetArrayLength(out int count);
+   public virtual bool TryGetBase64ContentLength(out int length);
+   public virtual bool TryGetLocalNameAsDictionaryString(out XmlDictionaryString localName);
+   public virtual bool TryGetNamespaceUriAsDictionaryString(out XmlDictionaryString namespaceUri);
+   public virtual bool TryGetValueAsDictionaryString(out XmlDictionaryString value);
  }
+ public sealed class XmlDictionaryReaderQuotas {
+   public XmlDictionaryReaderQuotas();
+   public static XmlDictionaryReaderQuotas Max { get; }
+   public int MaxArrayLength { get; set; }
+   public int MaxBytesPerRead { get; set; }
+   public int MaxDepth { get; set; }
+   public int MaxNameTableCharCount { get; set; }
+   public int MaxStringContentLength { get; set; }
+   public XmlDictionaryReaderQuotaTypes ModifiedQuotas { get; }
+   public void CopyTo(XmlDictionaryReaderQuotas quotas);
  }
+ public enum XmlDictionaryReaderQuotaTypes {
+   MaxArrayLength = 4,
+   MaxBytesPerRead = 8,
+   MaxDepth = 1,
+   MaxNameTableCharCount = 16,
+   MaxStringContentLength = 2,
  }
+ public class XmlDictionaryString {
+   public XmlDictionaryString(IXmlDictionary dictionary, string value, int key);
+   public IXmlDictionary Dictionary { get; }
+   public static XmlDictionaryString Empty { get; }
+   public int Key { get; }
+   public string Value { get; }
+   public override string ToString();
  }
+ public abstract class XmlDictionaryWriter : XmlWriter {
+   protected XmlDictionaryWriter();
+   public virtual bool CanCanonicalize { get; }
+   public virtual void Close();
+   public static XmlDictionaryWriter CreateBinaryWriter(Stream stream);
+   public static XmlDictionaryWriter CreateBinaryWriter(Stream stream, IXmlDictionary dictionary);
+   public static XmlDictionaryWriter CreateBinaryWriter(Stream stream, IXmlDictionary dictionary, XmlBinaryWriterSession session);
+   public static XmlDictionaryWriter CreateBinaryWriter(Stream stream, IXmlDictionary dictionary, XmlBinaryWriterSession session, bool ownsStream);
+   public static XmlDictionaryWriter CreateDictionaryWriter(XmlWriter writer);
+   public static XmlDictionaryWriter CreateTextWriter(Stream stream);
+   public static XmlDictionaryWriter CreateTextWriter(Stream stream, Encoding encoding);
+   public static XmlDictionaryWriter CreateTextWriter(Stream stream, Encoding encoding, bool ownsStream);
+   protected override void Dispose(bool disposing);
+   public virtual void EndCanonicalization();
+   public virtual void StartCanonicalization(Stream stream, bool includeComments, string[] inclusivePrefixes);
+   public virtual void WriteArray(string prefix, string localName, string namespaceUri, bool[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, string localName, string namespaceUri, DateTime[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, string localName, string namespaceUri, decimal[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, string localName, string namespaceUri, double[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, string localName, string namespaceUri, Guid[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, string localName, string namespaceUri, short[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, string localName, string namespaceUri, int[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, string localName, string namespaceUri, long[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, string localName, string namespaceUri, float[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, string localName, string namespaceUri, TimeSpan[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, DateTime[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, double[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Guid[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, short[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, int[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, long[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, float[] array, int offset, int count);
+   public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, TimeSpan[] array, int offset, int count);
+   public void WriteAttributeString(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, string value);
+   public void WriteAttributeString(XmlDictionaryString localName, XmlDictionaryString namespaceUri, string value);
+   public void WriteElementString(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, string value);
+   public void WriteElementString(XmlDictionaryString localName, XmlDictionaryString namespaceUri, string value);
+   public virtual void WriteNode(XmlDictionaryReader reader, bool defattr);
+   public override void WriteNode(XmlReader reader, bool defattr);
+   public virtual void WriteQualifiedName(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual void WriteStartAttribute(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public void WriteStartAttribute(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual void WriteStartElement(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public void WriteStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+   public virtual void WriteString(XmlDictionaryString value);
+   protected virtual void WriteTextNode(XmlDictionaryReader reader, bool isAttribute);
+   public virtual void WriteValue(Guid value);
+   public virtual void WriteValue(TimeSpan value);
+   public virtual void WriteValue(UniqueId value);
+   public virtual void WriteValue(XmlDictionaryString value);
+   public virtual void WriteXmlAttribute(string localName, string value);
+   public virtual void WriteXmlAttribute(XmlDictionaryString localName, XmlDictionaryString value);
+   public virtual void WriteXmlnsAttribute(string prefix, string namespaceUri);
+   public virtual void WriteXmlnsAttribute(string prefix, XmlDictionaryString namespaceUri);
  }
 }
```
