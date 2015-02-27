```diff
---lib-full\System.Xml.ReaderWriter.dll
+++lib-oss\System.Xml.ReaderWriter.dll
 namespace System.Xml {
  public enum ConformanceLevel {
    Auto = 0,
    Document = 2,
    Fragment = 1,
  }
  public enum DtdProcessing {
    Ignore = 1,
+   Parse = 2,
    Prohibit = 0,
  }
  public interface IXmlLineInfo {
    int LineNumber { get; }
    int LinePosition { get; }
    bool HasLineInfo();
  }
  public interface IXmlNamespaceResolver {
    IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope);
    string LookupNamespace(string prefix);
    string LookupPrefix(string namespaceName);
  }
  public enum NamespaceHandling {
    Default = 0,
    OmitDuplicates = 1,
  }
  public class NameTable : XmlNameTable {
    public NameTable();
    public override string Add(char[] key, int start, int len);
    public override string Add(string key);
    public override string Get(char[] key, int start, int len);
    public override string Get(string value);
  }
  public enum NewLineHandling {
    Entitize = 1,
    None = 2,
    Replace = 0,
  }
  public enum ReadState {
    Closed = 4,
    EndOfFile = 3,
    Error = 2,
    Initial = 0,
    Interactive = 1,
  }
  public enum WriteState {
    Attribute = 3,
    Closed = 5,
    Content = 4,
    Element = 2,
    Error = 6,
    Prolog = 1,
    Start = 0,
  }
  public static class XmlConvert {
    public static string DecodeName(string name);
    public static string EncodeLocalName(string name);
    public static string EncodeName(string name);
    public static string EncodeNmToken(string name);
    public static bool ToBoolean(string s);
    public static byte ToByte(string s);
    public static char ToChar(string s);
    public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption);
    public static DateTimeOffset ToDateTimeOffset(string s);
    public static DateTimeOffset ToDateTimeOffset(string s, string format);
    public static DateTimeOffset ToDateTimeOffset(string s, string[] formats);
    public static decimal ToDecimal(string s);
    public static double ToDouble(string s);
    public static Guid ToGuid(string s);
    public static short ToInt16(string s);
    public static int ToInt32(string s);
    public static long ToInt64(string s);
    public static sbyte ToSByte(string s);
    public static float ToSingle(string s);
    public static string ToString(bool value);
    public static string ToString(byte value);
    public static string ToString(char value);
    public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption);
    public static string ToString(DateTimeOffset value);
    public static string ToString(DateTimeOffset value, string format);
    public static string ToString(decimal value);
    public static string ToString(double value);
    public static string ToString(Guid value);
    public static string ToString(short value);
    public static string ToString(int value);
    public static string ToString(long value);
    public static string ToString(sbyte value);
    public static string ToString(float value);
    public static string ToString(TimeSpan value);
    public static string ToString(ushort value);
    public static string ToString(uint value);
    public static string ToString(ulong value);
    public static TimeSpan ToTimeSpan(string s);
    public static ushort ToUInt16(string s);
    public static uint ToUInt32(string s);
    public static ulong ToUInt64(string s);
    public static string VerifyName(string name);
    public static string VerifyNCName(string name);
    public static string VerifyNMTOKEN(string name);
    public static string VerifyPublicId(string publicId);
    public static string VerifyWhitespace(string content);
    public static string VerifyXmlChars(string content);
  }
  public enum XmlDateTimeSerializationMode {
    Local = 0,
    RoundtripKind = 3,
    Unspecified = 2,
    Utc = 1,
  }
  public class XmlException : Exception {
    public XmlException();
    public XmlException(string message);
    public XmlException(string message, Exception innerException);
    public XmlException(string message, Exception innerException, int lineNumber, int linePosition);
    public int LineNumber { get; }
    public int LinePosition { get; }
-   public override string Message { get; }
  }
  public class XmlNamespaceManager : IEnumerable, IXmlNamespaceResolver {
    public XmlNamespaceManager(XmlNameTable nameTable);
    public virtual string DefaultNamespace { get; }
    public virtual XmlNameTable NameTable { get; }
    public virtual void AddNamespace(string prefix, string uri);
    public virtual IEnumerator GetEnumerator();
    public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope);
    public virtual bool HasNamespace(string prefix);
    public virtual string LookupNamespace(string prefix);
    public virtual string LookupPrefix(string uri);
    public virtual bool PopScope();
    public virtual void PushScope();
    public virtual void RemoveNamespace(string prefix, string uri);
  }
  public enum XmlNamespaceScope {
    All = 0,
    ExcludeXml = 1,
    Local = 2,
  }
  public abstract class XmlNameTable {
    protected XmlNameTable();
    public abstract string Add(char[] array, int offset, int length);
    public abstract string Add(string array);
    public abstract string Get(char[] array, int offset, int length);
    public abstract string Get(string array);
  }
  public enum XmlNodeType {
    Attribute = 2,
    CDATA = 4,
    Comment = 8,
    Document = 9,
    DocumentFragment = 11,
    DocumentType = 10,
    Element = 1,
    EndElement = 15,
    EndEntity = 16,
    Entity = 6,
    EntityReference = 5,
    None = 0,
    Notation = 12,
    ProcessingInstruction = 7,
    SignificantWhitespace = 14,
    Text = 3,
    Whitespace = 13,
    XmlDeclaration = 17,
  }
  public class XmlParserContext {
    public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace);
    public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc);
    public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace);
    public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace, Encoding enc);
    public string BaseURI { get; set; }
    public string DocTypeName { get; set; }
    public Encoding Encoding { get; set; }
    public string InternalSubset { get; set; }
    public XmlNamespaceManager NamespaceManager { get; set; }
    public XmlNameTable NameTable { get; set; }
    public string PublicId { get; set; }
    public string SystemId { get; set; }
    public string XmlLang { get; set; }
    public XmlSpace XmlSpace { get; set; }
  }
  public class XmlQualifiedName {
    public static readonly XmlQualifiedName Empty;
    public XmlQualifiedName();
    public XmlQualifiedName(string name);
    public XmlQualifiedName(string name, string ns);
    public bool IsEmpty { get; }
    public string Name { get; }
    public string Namespace { get; }
    public override bool Equals(object other);
    public override int GetHashCode();
    public static bool operator ==(XmlQualifiedName a, XmlQualifiedName b);
    public static bool operator !=(XmlQualifiedName a, XmlQualifiedName b);
    public override string ToString();
    public static string ToString(string name, string ns);
  }
  public abstract class XmlReader : IDisposable {
    protected XmlReader();
    public abstract int AttributeCount { get; }
    public abstract string BaseURI { get; }
    public virtual bool CanReadBinaryContent { get; }
    public virtual bool CanReadValueChunk { get; }
    public virtual bool CanResolveEntity { get; }
    public abstract int Depth { get; }
    public abstract bool EOF { get; }
    public virtual bool HasAttributes { get; }
    public virtual bool HasValue { get; }
    public virtual bool IsDefault { get; }
    public abstract bool IsEmptyElement { get; }
    public abstract string LocalName { get; }
    public virtual string Name { get; }
    public abstract string NamespaceURI { get; }
    public abstract XmlNameTable NameTable { get; }
    public abstract XmlNodeType NodeType { get; }
    public abstract string Prefix { get; }
    public abstract ReadState ReadState { get; }
    public virtual XmlReaderSettings Settings { get; }
    public virtual string this[int i] { get; }
    public virtual string this[string name, string namespaceURI] { get; }
    public virtual string this[string name] { get; }
    public abstract string Value { get; }
    public virtual Type ValueType { get; }
    public virtual string XmlLang { get; }
    public virtual XmlSpace XmlSpace { get; }
    public static XmlReader Create(Stream input);
    public static XmlReader Create(Stream input, XmlReaderSettings settings);
    public static XmlReader Create(Stream input, XmlReaderSettings settings, XmlParserContext inputContext);
    public static XmlReader Create(TextReader input);
    public static XmlReader Create(TextReader input, XmlReaderSettings settings);
    public static XmlReader Create(TextReader input, XmlReaderSettings settings, XmlParserContext inputContext);
    public static XmlReader Create(string inputUri);
    public static XmlReader Create(string inputUri, XmlReaderSettings settings);
    public static XmlReader Create(XmlReader reader, XmlReaderSettings settings);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public abstract string GetAttribute(int i);
    public abstract string GetAttribute(string name);
    public abstract string GetAttribute(string name, string namespaceURI);
    public virtual Task<string> GetValueAsync();
    public static bool IsName(string str);
    public static bool IsNameToken(string str);
    public virtual bool IsStartElement();
    public virtual bool IsStartElement(string name);
    public virtual bool IsStartElement(string localname, string ns);
    public abstract string LookupNamespace(string prefix);
    public virtual void MoveToAttribute(int i);
    public abstract bool MoveToAttribute(string name);
    public abstract bool MoveToAttribute(string name, string ns);
    public virtual XmlNodeType MoveToContent();
    public virtual Task<XmlNodeType> MoveToContentAsync();
    public abstract bool MoveToElement();
    public abstract bool MoveToFirstAttribute();
    public abstract bool MoveToNextAttribute();
    public abstract bool Read();
    public virtual Task<bool> ReadAsync();
    public abstract bool ReadAttributeValue();
    public virtual object ReadContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver);
    public virtual Task<object> ReadContentAsAsync(Type returnType, IXmlNamespaceResolver namespaceResolver);
    public virtual int ReadContentAsBase64(byte[] buffer, int index, int count);
    public virtual Task<int> ReadContentAsBase64Async(byte[] buffer, int index, int count);
    public virtual int ReadContentAsBinHex(byte[] buffer, int index, int count);
    public virtual Task<int> ReadContentAsBinHexAsync(byte[] buffer, int index, int count);
    public virtual bool ReadContentAsBoolean();
    public virtual DateTimeOffset ReadContentAsDateTimeOffset();
    public virtual decimal ReadContentAsDecimal();
    public virtual double ReadContentAsDouble();
    public virtual float ReadContentAsFloat();
    public virtual int ReadContentAsInt();
    public virtual long ReadContentAsLong();
    public virtual object ReadContentAsObject();
    public virtual Task<object> ReadContentAsObjectAsync();
    public virtual string ReadContentAsString();
    public virtual Task<string> ReadContentAsStringAsync();
    public virtual object ReadElementContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver);
    public virtual object ReadElementContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver, string localName, string namespaceURI);
    public virtual Task<object> ReadElementContentAsAsync(Type returnType, IXmlNamespaceResolver namespaceResolver);
    public virtual int ReadElementContentAsBase64(byte[] buffer, int index, int count);
    public virtual Task<int> ReadElementContentAsBase64Async(byte[] buffer, int index, int count);
    public virtual int ReadElementContentAsBinHex(byte[] buffer, int index, int count);
    public virtual Task<int> ReadElementContentAsBinHexAsync(byte[] buffer, int index, int count);
    public virtual bool ReadElementContentAsBoolean();
    public virtual bool ReadElementContentAsBoolean(string localName, string namespaceURI);
    public virtual decimal ReadElementContentAsDecimal();
    public virtual decimal ReadElementContentAsDecimal(string localName, string namespaceURI);
    public virtual double ReadElementContentAsDouble();
    public virtual double ReadElementContentAsDouble(string localName, string namespaceURI);
    public virtual float ReadElementContentAsFloat();
    public virtual float ReadElementContentAsFloat(string localName, string namespaceURI);
    public virtual int ReadElementContentAsInt();
    public virtual int ReadElementContentAsInt(string localName, string namespaceURI);
    public virtual long ReadElementContentAsLong();
    public virtual long ReadElementContentAsLong(string localName, string namespaceURI);
    public virtual object ReadElementContentAsObject();
    public virtual object ReadElementContentAsObject(string localName, string namespaceURI);
    public virtual Task<object> ReadElementContentAsObjectAsync();
    public virtual string ReadElementContentAsString();
    public virtual string ReadElementContentAsString(string localName, string namespaceURI);
    public virtual Task<string> ReadElementContentAsStringAsync();
    public virtual void ReadEndElement();
    public virtual string ReadInnerXml();
    public virtual Task<string> ReadInnerXmlAsync();
    public virtual string ReadOuterXml();
    public virtual Task<string> ReadOuterXmlAsync();
    public virtual void ReadStartElement();
    public virtual void ReadStartElement(string name);
    public virtual void ReadStartElement(string localname, string ns);
    public virtual XmlReader ReadSubtree();
    public virtual bool ReadToDescendant(string name);
    public virtual bool ReadToDescendant(string localName, string namespaceURI);
    public virtual bool ReadToFollowing(string name);
    public virtual bool ReadToFollowing(string localName, string namespaceURI);
    public virtual bool ReadToNextSibling(string name);
    public virtual bool ReadToNextSibling(string localName, string namespaceURI);
    public virtual int ReadValueChunk(char[] buffer, int index, int count);
    public virtual Task<int> ReadValueChunkAsync(char[] buffer, int index, int count);
    public abstract void ResolveEntity();
    public virtual void Skip();
    public virtual Task SkipAsync();
  }
  public sealed class XmlReaderSettings {
    public XmlReaderSettings();
    public bool Async { get; set; }
    public bool CheckCharacters { get; set; }
    public bool CloseInput { get; set; }
    public ConformanceLevel ConformanceLevel { get; set; }
    public DtdProcessing DtdProcessing { get; set; }
    public bool IgnoreComments { get; set; }
    public bool IgnoreProcessingInstructions { get; set; }
    public bool IgnoreWhitespace { get; set; }
    public int LineNumberOffset { get; set; }
    public int LinePositionOffset { get; set; }
    public long MaxCharactersFromEntities { get; set; }
    public long MaxCharactersInDocument { get; set; }
    public XmlNameTable NameTable { get; set; }
    public XmlReaderSettings Clone();
    public void Reset();
  }
  public enum XmlSpace {
    Default = 1,
    None = 0,
    Preserve = 2,
  }
  public abstract class XmlWriter : IDisposable {
    protected XmlWriter();
    public virtual XmlWriterSettings Settings { get; }
    public abstract WriteState WriteState { get; }
    public virtual string XmlLang { get; }
    public virtual XmlSpace XmlSpace { get; }
    public static XmlWriter Create(Stream output);
    public static XmlWriter Create(Stream output, XmlWriterSettings settings);
    public static XmlWriter Create(TextWriter output);
    public static XmlWriter Create(TextWriter output, XmlWriterSettings settings);
    public static XmlWriter Create(StringBuilder output);
    public static XmlWriter Create(StringBuilder output, XmlWriterSettings settings);
    public static XmlWriter Create(XmlWriter output);
    public static XmlWriter Create(XmlWriter output, XmlWriterSettings settings);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public abstract void Flush();
    public virtual Task FlushAsync();
    public abstract string LookupPrefix(string ns);
    public virtual void WriteAttributes(XmlReader reader, bool defattr);
    public virtual Task WriteAttributesAsync(XmlReader reader, bool defattr);
    public void WriteAttributeString(string localName, string value);
    public void WriteAttributeString(string localName, string ns, string value);
    public void WriteAttributeString(string prefix, string localName, string ns, string value);
    public Task WriteAttributeStringAsync(string prefix, string localName, string ns, string value);
    public abstract void WriteBase64(byte[] buffer, int index, int count);
    public virtual Task WriteBase64Async(byte[] buffer, int index, int count);
    public virtual void WriteBinHex(byte[] buffer, int index, int count);
    public virtual Task WriteBinHexAsync(byte[] buffer, int index, int count);
    public abstract void WriteCData(string text);
    public virtual Task WriteCDataAsync(string text);
    public abstract void WriteCharEntity(char ch);
    public virtual Task WriteCharEntityAsync(char ch);
    public abstract void WriteChars(char[] buffer, int index, int count);
    public virtual Task WriteCharsAsync(char[] buffer, int index, int count);
    public abstract void WriteComment(string text);
    public virtual Task WriteCommentAsync(string text);
    public abstract void WriteDocType(string name, string pubid, string sysid, string subset);
    public virtual Task WriteDocTypeAsync(string name, string pubid, string sysid, string subset);
    public void WriteElementString(string localName, string value);
    public void WriteElementString(string localName, string ns, string value);
    public void WriteElementString(string prefix, string localName, string ns, string value);
    public Task WriteElementStringAsync(string prefix, string localName, string ns, string value);
    public abstract void WriteEndAttribute();
    protected internal virtual Task WriteEndAttributeAsync();
    public abstract void WriteEndDocument();
    public virtual Task WriteEndDocumentAsync();
    public abstract void WriteEndElement();
    public virtual Task WriteEndElementAsync();
    public abstract void WriteEntityRef(string name);
    public virtual Task WriteEntityRefAsync(string name);
    public abstract void WriteFullEndElement();
    public virtual Task WriteFullEndElementAsync();
    public virtual void WriteName(string name);
    public virtual Task WriteNameAsync(string name);
    public virtual void WriteNmToken(string name);
    public virtual Task WriteNmTokenAsync(string name);
    public virtual void WriteNode(XmlReader reader, bool defattr);
    public virtual Task WriteNodeAsync(XmlReader reader, bool defattr);
    public abstract void WriteProcessingInstruction(string name, string text);
    public virtual Task WriteProcessingInstructionAsync(string name, string text);
    public virtual void WriteQualifiedName(string localName, string ns);
    public virtual Task WriteQualifiedNameAsync(string localName, string ns);
    public abstract void WriteRaw(char[] buffer, int index, int count);
    public abstract void WriteRaw(string data);
    public virtual Task WriteRawAsync(char[] buffer, int index, int count);
    public virtual Task WriteRawAsync(string data);
    public void WriteStartAttribute(string localName);
    public void WriteStartAttribute(string localName, string ns);
    public abstract void WriteStartAttribute(string prefix, string localName, string ns);
    protected internal virtual Task WriteStartAttributeAsync(string prefix, string localName, string ns);
    public abstract void WriteStartDocument();
    public abstract void WriteStartDocument(bool standalone);
    public virtual Task WriteStartDocumentAsync();
    public virtual Task WriteStartDocumentAsync(bool standalone);
    public void WriteStartElement(string localName);
    public void WriteStartElement(string localName, string ns);
    public abstract void WriteStartElement(string prefix, string localName, string ns);
    public virtual Task WriteStartElementAsync(string prefix, string localName, string ns);
    public abstract void WriteString(string text);
    public virtual Task WriteStringAsync(string text);
    public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);
    public virtual Task WriteSurrogateCharEntityAsync(char lowChar, char highChar);
    public virtual void WriteValue(bool value);
    public virtual void WriteValue(DateTimeOffset value);
    public virtual void WriteValue(decimal value);
    public virtual void WriteValue(double value);
    public virtual void WriteValue(int value);
    public virtual void WriteValue(long value);
    public virtual void WriteValue(object value);
    public virtual void WriteValue(float value);
    public virtual void WriteValue(string value);
    public abstract void WriteWhitespace(string ws);
    public virtual Task WriteWhitespaceAsync(string ws);
  }
  public sealed class XmlWriterSettings {
    public XmlWriterSettings();
    public bool Async { get; set; }
    public bool CheckCharacters { get; set; }
    public bool CloseOutput { get; set; }
    public ConformanceLevel ConformanceLevel { get; set; }
    public Encoding Encoding { get; set; }
    public bool Indent { get; set; }
    public string IndentChars { get; set; }
    public NamespaceHandling NamespaceHandling { get; set; }
    public string NewLineChars { get; set; }
    public NewLineHandling NewLineHandling { get; set; }
    public bool NewLineOnAttributes { get; set; }
    public bool OmitXmlDeclaration { get; set; }
    public bool WriteEndDocumentOnClose { get; set; }
    public XmlWriterSettings Clone();
    public void Reset();
  }
 }
 namespace System.Xml.Schema {
  public class XmlSchema {
  }
  public enum XmlSchemaForm {
    None = 0,
    Qualified = 1,
    Unqualified = 2,
  }
 }
 namespace System.Xml.Serialization {
  public interface IXmlSerializable {
    XmlSchema GetSchema();
    void ReadXml(XmlReader reader);
    void WriteXml(XmlWriter writer);
  }
  public sealed class XmlSchemaProviderAttribute : Attribute {
    public XmlSchemaProviderAttribute(string methodName);
    public bool IsAny { get; set; }
    public string MethodName { get; }
  }
 }
```
