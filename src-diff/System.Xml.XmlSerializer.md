```diff
---lib-full\System.Xml.XmlSerializer.dll
+++lib-oss\System.Xml.XmlSerializer.dll
 namespace System.Xml.Serialization {
  public class XmlAnyAttributeAttribute : Attribute {
    public XmlAnyAttributeAttribute();
  }
  public class XmlAnyElementAttribute : Attribute {
    public XmlAnyElementAttribute();
    public XmlAnyElementAttribute(string name);
    public XmlAnyElementAttribute(string name, string ns);
    public string Name { get; set; }
    public string Namespace { get; set; }
    public int Order { get; set; }
  }
  public class XmlAnyElementAttributes : ICollection, IEnumerable, IList {
    public XmlAnyElementAttributes();
    public int Count { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    bool System.Collections.IList.IsFixedSize { get; }
    bool System.Collections.IList.IsReadOnly { get; }
    object System.Collections.IList.this[int index] { get; set; }
    public XmlAnyElementAttribute this[int index] { get; set; }
    public int Add(XmlAnyElementAttribute attribute);
    public void Clear();
    public bool Contains(XmlAnyElementAttribute attribute);
    public void CopyTo(XmlAnyElementAttribute[] array, int index);
    public IEnumerator GetEnumerator();
    public int IndexOf(XmlAnyElementAttribute attribute);
    public void Insert(int index, XmlAnyElementAttribute attribute);
    public void Remove(XmlAnyElementAttribute attribute);
    public void RemoveAt(int index);
    void System.Collections.ICollection.CopyTo(Array array, int index);
    int System.Collections.IList.Add(object value);
    bool System.Collections.IList.Contains(object value);
    int System.Collections.IList.IndexOf(object value);
    void System.Collections.IList.Insert(int index, object value);
    void System.Collections.IList.Remove(object value);
  }
  public class XmlArrayAttribute : Attribute {
    public XmlArrayAttribute();
    public XmlArrayAttribute(string elementName);
    public string ElementName { get; set; }
    public XmlSchemaForm Form { get; set; }
    public bool IsNullable { get; set; }
    public string Namespace { get; set; }
    public int Order { get; set; }
  }
  public class XmlArrayItemAttribute : Attribute {
    public XmlArrayItemAttribute();
    public XmlArrayItemAttribute(string elementName);
    public XmlArrayItemAttribute(string elementName, Type type);
    public XmlArrayItemAttribute(Type type);
    public string DataType { get; set; }
    public string ElementName { get; set; }
    public XmlSchemaForm Form { get; set; }
    public bool IsNullable { get; set; }
    public string Namespace { get; set; }
    public int NestingLevel { get; set; }
    public Type Type { get; set; }
  }
  public class XmlArrayItemAttributes : ICollection, IEnumerable, IList {
    public XmlArrayItemAttributes();
    public int Count { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    bool System.Collections.IList.IsFixedSize { get; }
    bool System.Collections.IList.IsReadOnly { get; }
    object System.Collections.IList.this[int index] { get; set; }
    public XmlArrayItemAttribute this[int index] { get; set; }
    public int Add(XmlArrayItemAttribute attribute);
    public void Clear();
    public bool Contains(XmlArrayItemAttribute attribute);
    public void CopyTo(XmlArrayItemAttribute[] array, int index);
    public IEnumerator GetEnumerator();
    public int IndexOf(XmlArrayItemAttribute attribute);
    public void Insert(int index, XmlArrayItemAttribute attribute);
    public void Remove(XmlArrayItemAttribute attribute);
    public void RemoveAt(int index);
    void System.Collections.ICollection.CopyTo(Array array, int index);
    int System.Collections.IList.Add(object value);
    bool System.Collections.IList.Contains(object value);
    int System.Collections.IList.IndexOf(object value);
    void System.Collections.IList.Insert(int index, object value);
    void System.Collections.IList.Remove(object value);
  }
  public class XmlAttributeAttribute : Attribute {
    public XmlAttributeAttribute();
    public XmlAttributeAttribute(string attributeName);
    public XmlAttributeAttribute(string attributeName, Type type);
    public XmlAttributeAttribute(Type type);
    public string AttributeName { get; set; }
    public string DataType { get; set; }
    public XmlSchemaForm Form { get; set; }
    public string Namespace { get; set; }
    public Type Type { get; set; }
  }
  public class XmlAttributeOverrides {
    public XmlAttributeOverrides();
    public XmlAttributes this[Type type, string member] { get; }
    public XmlAttributes this[Type type] { get; }
    public void Add(Type type, string member, XmlAttributes attributes);
    public void Add(Type type, XmlAttributes attributes);
  }
  public class XmlAttributes {
    public XmlAttributes();
+   public XmlAttributes(MemberInfo memberInfo);
    public XmlAnyAttributeAttribute XmlAnyAttribute { get; set; }
    public XmlAnyElementAttributes XmlAnyElements { get; }
    public XmlArrayAttribute XmlArray { get; set; }
    public XmlArrayItemAttributes XmlArrayItems { get; }
    public XmlAttributeAttribute XmlAttribute { get; set; }
    public XmlChoiceIdentifierAttribute XmlChoiceIdentifier { get; }
    public object XmlDefaultValue { get; set; }
    public XmlElementAttributes XmlElements { get; }
    public XmlEnumAttribute XmlEnum { get; set; }
    public bool XmlIgnore { get; set; }
    public bool Xmlns { get; set; }
    public XmlRootAttribute XmlRoot { get; set; }
    public XmlTextAttribute XmlText { get; set; }
    public XmlTypeAttribute XmlType { get; set; }
  }
  public class XmlChoiceIdentifierAttribute : Attribute {
    public XmlChoiceIdentifierAttribute();
    public XmlChoiceIdentifierAttribute(string name);
    public string MemberName { get; set; }
  }
  public class XmlElementAttribute : Attribute {
    public XmlElementAttribute();
    public XmlElementAttribute(string elementName);
    public XmlElementAttribute(string elementName, Type type);
    public XmlElementAttribute(Type type);
    public string DataType { get; set; }
    public string ElementName { get; set; }
    public XmlSchemaForm Form { get; set; }
    public bool IsNullable { get; set; }
    public string Namespace { get; set; }
    public int Order { get; set; }
    public Type Type { get; set; }
  }
  public class XmlElementAttributes : ICollection, IEnumerable, IList {
    public XmlElementAttributes();
    public int Count { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    bool System.Collections.IList.IsFixedSize { get; }
    bool System.Collections.IList.IsReadOnly { get; }
    object System.Collections.IList.this[int index] { get; set; }
    public XmlElementAttribute this[int index] { get; set; }
    public int Add(XmlElementAttribute attribute);
    public void Clear();
    public bool Contains(XmlElementAttribute attribute);
    public void CopyTo(XmlElementAttribute[] array, int index);
    public IEnumerator GetEnumerator();
    public int IndexOf(XmlElementAttribute attribute);
    public void Insert(int index, XmlElementAttribute attribute);
    public void Remove(XmlElementAttribute attribute);
    public void RemoveAt(int index);
    void System.Collections.ICollection.CopyTo(Array array, int index);
    int System.Collections.IList.Add(object value);
    bool System.Collections.IList.Contains(object value);
    int System.Collections.IList.IndexOf(object value);
    void System.Collections.IList.Insert(int index, object value);
    void System.Collections.IList.Remove(object value);
  }
  public class XmlEnumAttribute : Attribute {
    public XmlEnumAttribute();
    public XmlEnumAttribute(string name);
    public string Name { get; set; }
  }
  public class XmlIgnoreAttribute : Attribute {
    public XmlIgnoreAttribute();
  }
  public class XmlIncludeAttribute : Attribute {
    public XmlIncludeAttribute(Type type);
    public Type Type { get; set; }
  }
+ public abstract class XmlMapping {
+   public string ElementName { get; }
+   public string Namespace { get; }
+   public string XsdElementName { get; }
+   public void SetKey(string key);
  }
+ public enum XmlMappingAccess {
+   None = 0,
+   Read = 1,
+   Write = 2,
  }
+ public class XmlMemberMapping {
+   public bool Any { get; }
+   public bool CheckSpecified { get; }
+   public string ElementName { get; }
+   public string MemberName { get; }
+   public string Namespace { get; }
+   public string TypeFullName { get; }
+   public string TypeName { get; }
+   public string TypeNamespace { get; }
+   public string XsdElementName { get; }
  }
+ public class XmlMembersMapping : XmlMapping {
+   public int Count { get; }
+   public XmlMemberMapping this[int index] { get; }
+   public string TypeName { get; }
+   public string TypeNamespace { get; }
  }
  public class XmlNamespaceDeclarationsAttribute : Attribute {
    public XmlNamespaceDeclarationsAttribute();
  }
+ public class XmlReflectionImporter {
+   public XmlReflectionImporter();
+   public XmlReflectionImporter(string defaultNamespace);
+   public XmlReflectionImporter(XmlAttributeOverrides attributeOverrides);
+   public XmlReflectionImporter(XmlAttributeOverrides attributeOverrides, string defaultNamespace);
+   public XmlMembersMapping ImportMembersMapping(string elementName, string ns, XmlReflectionMember[] members, bool hasWrapperElement);
+   public XmlMembersMapping ImportMembersMapping(string elementName, string ns, XmlReflectionMember[] members, bool hasWrapperElement, bool rpc);
+   public XmlMembersMapping ImportMembersMapping(string elementName, string ns, XmlReflectionMember[] members, bool hasWrapperElement, bool rpc, bool openModel);
+   public XmlMembersMapping ImportMembersMapping(string elementName, string ns, XmlReflectionMember[] members, bool hasWrapperElement, bool rpc, bool openModel, XmlMappingAccess access);
+   public XmlTypeMapping ImportTypeMapping(Type type);
+   public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace);
+   public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root);
+   public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace);
+   public void IncludeType(Type type);
+   public void IncludeTypes(MemberInfo memberInfo);
  }
+ public class XmlReflectionMember {
+   public XmlReflectionMember();
+   public bool IsReturnValue { get; set; }
+   public string MemberName { get; set; }
+   public Type MemberType { get; set; }
+   public bool OverrideIsNullable { get; set; }
+   public XmlAttributes XmlAttributes { get; set; }
  }
  public class XmlRootAttribute : Attribute {
    public XmlRootAttribute();
    public XmlRootAttribute(string elementName);
    public string DataType { get; set; }
    public string ElementName { get; set; }
    public bool IsNullable { get; set; }
    public string Namespace { get; set; }
  }
+ public abstract class XmlSerializationGeneratedCode {
+   protected XmlSerializationGeneratedCode();
  }
+ public abstract class XmlSerializationReader : XmlSerializationGeneratedCode {
+   protected XmlSerializationReader();
+   protected bool DecodeName { get; set; }
+   protected bool IsReturnValue { get; set; }
+   protected XmlReader Reader { get; }
+   protected int ReaderCount { get; }
+   protected void CheckReaderCount(ref int whileIterations, ref int readerCount);
+   protected string CollapseWhitespace(string value);
+   protected Exception CreateAbstractTypeException(string name, string ns);
+   protected Exception CreateBadDerivationException(string xsdDerived, string nsDerived, string xsdBase, string nsBase, string clrDerived, string clrBase);
+   protected Exception CreateCtorHasSecurityException(string typeName);
+   protected Exception CreateInaccessibleConstructorException(string typeName);
+   protected Exception CreateInvalidCastException(Type type, object value);
+   protected Exception CreateInvalidCastException(Type type, object value, string id);
+   protected Exception CreateMissingIXmlSerializableType(string name, string ns, string clrType);
+   protected Exception CreateReadOnlyCollectionException(string name);
+   protected Exception CreateUnknownConstantException(string value, Type enumType);
+   protected Exception CreateUnknownNodeException();
+   protected Exception CreateUnknownTypeException(XmlQualifiedName type);
+   protected Array EnsureArrayIndex(Array a, int index, Type elementType);
+   protected bool GetNullAttr();
+   protected XmlQualifiedName GetXsiType();
+   protected abstract void InitCallbacks();
+   protected abstract void InitIDs();
+   protected bool IsXmlnsAttribute(string name);
+   protected XmlQualifiedName ReadElementQualifiedName();
+   protected void ReadEndElement();
+   protected bool ReadNull();
+   protected XmlQualifiedName ReadNullableQualifiedName();
+   protected string ReadNullableString();
+   protected IXmlSerializable ReadSerializable(IXmlSerializable serializable);
+   protected IXmlSerializable ReadSerializable(IXmlSerializable serializable, bool wrappedAny);
+   protected string ReadString(string value);
+   protected string ReadString(string value, bool trim);
+   protected object ReadTypedNull(XmlQualifiedName type);
+   protected object ReadTypedPrimitive(XmlQualifiedName type);
+   protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable);
+   protected byte[] ToByteArrayBase64(bool isNull);
+   protected static byte[] ToByteArrayBase64(string value);
+   protected byte[] ToByteArrayHex(bool isNull);
+   protected static byte[] ToByteArrayHex(string value);
+   protected static char ToChar(string value);
+   protected static DateTime ToDate(string value);
+   protected static DateTime ToDateTime(string value);
+   protected static long ToEnum(string value, IDictionary h, string typeName);
+   protected static DateTime ToTime(string value);
+   protected static string ToXmlName(string value);
+   protected static string ToXmlNCName(string value);
+   protected static string ToXmlNmToken(string value);
+   protected static string ToXmlNmTokens(string value);
+   protected XmlQualifiedName ToXmlQualifiedName(string value);
+   protected void UnknownNode(object o);
+   protected void UnknownNode(object o, string qnames);
  }
+ public delegate void XmlSerializationWriteCallback(object o);
+ public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode {
+   protected XmlSerializationWriter();
+   protected bool EscapeName { get; set; }
+   protected XmlWriter Writer { get; set; }
+   protected IList XmlNamespaces { get; set; }
+   protected Exception CreateChoiceIdentifierValueException(string value, string identifier, string name, string ns);
+   protected Exception CreateInvalidAnyTypeException(object o);
+   protected Exception CreateInvalidAnyTypeException(Type type);
+   protected Exception CreateInvalidChoiceIdentifierValueException(string type, string identifier);
+   protected Exception CreateInvalidEnumValueException(object value, string typeName);
+   protected Exception CreateMismatchChoiceException(string value, string elementName, string enumValue);
+   protected Exception CreateUnknownAnyElementException(string name, string ns);
+   protected Exception CreateUnknownTypeException(object o);
+   protected Exception CreateUnknownTypeException(Type type);
+   protected static byte[] FromByteArrayBase64(byte[] value);
+   protected static string FromByteArrayHex(byte[] value);
+   protected static string FromChar(char value);
+   protected static string FromDate(DateTime value);
+   protected static string FromDateTime(DateTime value);
+   protected static string FromEnum(long value, string[] values, long[] ids);
+   protected static string FromEnum(long value, string[] values, long[] ids, string typeName);
+   protected static string FromTime(DateTime value);
+   protected static string FromXmlName(string name);
+   protected static string FromXmlNCName(string ncName);
+   protected static string FromXmlNmToken(string nmToken);
+   protected static string FromXmlNmTokens(string nmTokens);
+   protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName);
+   protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName, bool ignoreEmpty);
+   protected abstract void InitCallbacks();
+   protected void TopLevelElement();
+   protected void WriteAttribute(string localName, byte[] value);
+   protected void WriteAttribute(string localName, string value);
+   protected void WriteAttribute(string localName, string ns, byte[] value);
+   protected void WriteAttribute(string localName, string ns, string value);
+   protected void WriteAttribute(string prefix, string localName, string ns, string value);
+   protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value);
+   protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType);
+   protected void WriteElementQualifiedName(string localName, XmlQualifiedName value);
+   protected void WriteElementQualifiedName(string localName, XmlQualifiedName value, XmlQualifiedName xsiType);
+   protected void WriteElementString(string localName, string value);
+   protected void WriteElementString(string localName, string ns, string value);
+   protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType);
+   protected void WriteElementString(string localName, string value, XmlQualifiedName xsiType);
+   protected void WriteElementStringRaw(string localName, byte[] value);
+   protected void WriteElementStringRaw(string localName, byte[] value, XmlQualifiedName xsiType);
+   protected void WriteElementStringRaw(string localName, string value);
+   protected void WriteElementStringRaw(string localName, string ns, byte[] value);
+   protected void WriteElementStringRaw(string localName, string ns, byte[] value, XmlQualifiedName xsiType);
+   protected void WriteElementStringRaw(string localName, string ns, string value);
+   protected void WriteElementStringRaw(string localName, string ns, string value, XmlQualifiedName xsiType);
+   protected void WriteElementStringRaw(string localName, string value, XmlQualifiedName xsiType);
+   protected void WriteEmptyTag(string name);
+   protected void WriteEmptyTag(string name, string ns);
+   protected void WriteEndElement();
+   protected void WriteEndElement(object o);
+   protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns);
+   protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType);
+   protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value);
+   protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType);
+   protected void WriteNullableStringEncodedRaw(string name, string ns, byte[] value, XmlQualifiedName xsiType);
+   protected void WriteNullableStringEncodedRaw(string name, string ns, string value, XmlQualifiedName xsiType);
+   protected void WriteNullableStringLiteral(string name, string ns, string value);
+   protected void WriteNullableStringLiteralRaw(string name, string ns, byte[] value);
+   protected void WriteNullableStringLiteralRaw(string name, string ns, string value);
+   protected void WriteNullTagEncoded(string name);
+   protected void WriteNullTagEncoded(string name, string ns);
+   protected void WriteNullTagLiteral(string name);
+   protected void WriteNullTagLiteral(string name, string ns);
+   protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable);
+   protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped);
+   protected void WriteStartDocument();
+   protected void WriteStartElement(string name);
+   protected void WriteStartElement(string name, string ns);
+   protected void WriteStartElement(string name, string ns, bool writePrefixed);
+   protected void WriteStartElement(string name, string ns, object o);
+   protected void WriteStartElement(string name, string ns, object o, bool writePrefixed);
+   protected void WriteStartElement(string name, string ns, object o, bool writePrefixed, XmlSerializerNamespaces xmlns);
+   protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType);
+   protected void WriteValue(byte[] value);
+   protected void WriteValue(string value);
+   protected void WriteXsiType(string name, string ns);
  }
  public class XmlSerializer {
    protected XmlSerializer();
    public XmlSerializer(Type type);
    public XmlSerializer(Type type, string defaultNamespace);
    public XmlSerializer(Type type, Type[] extraTypes);
    public XmlSerializer(Type type, XmlAttributeOverrides overrides);
    public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace);
    public XmlSerializer(Type type, XmlRootAttribute root);
+   public XmlSerializer(XmlTypeMapping xmlTypeMapping);
    public virtual bool CanDeserialize(XmlReader xmlReader);
+   protected virtual XmlSerializationReader CreateReader();
+   protected virtual XmlSerializationWriter CreateWriter();
    public object Deserialize(Stream stream);
    public object Deserialize(TextReader textReader);
+   protected virtual object Deserialize(XmlSerializationReader reader);
    public object Deserialize(XmlReader xmlReader);
+   public static XmlSerializer[] FromMappings(XmlMapping[] mappings);
+   public static XmlSerializer[] FromMappings(XmlMapping[] mappings, Type type);
    public static XmlSerializer[] FromTypes(Type[] types);
    public void Serialize(Stream stream, object o);
    public void Serialize(Stream stream, object o, XmlSerializerNamespaces namespaces);
    public void Serialize(TextWriter textWriter, object o);
    public void Serialize(TextWriter textWriter, object o, XmlSerializerNamespaces namespaces);
+   protected virtual void Serialize(object o, XmlSerializationWriter writer);
    public void Serialize(XmlWriter xmlWriter, object o);
    public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces);
  }
+ public abstract class XmlSerializerImplementation {
+   protected XmlSerializerImplementation();
+   public virtual XmlSerializationReader Reader { get; }
+   public virtual XmlSerializationWriter Writer { get; }
+   public virtual IDictionary XmlReadMethods { get; }
+   public virtual IDictionary XmlTypedSerializers { get; }
+   public virtual IDictionary XmlWriteMethods { get; }
+   public virtual bool CanSerialize(Type type);
+   public virtual XmlSerializer GetSerializer(Type type);
  }
  public class XmlSerializerNamespaces {
    public XmlSerializerNamespaces();
    public XmlSerializerNamespaces(XmlSerializerNamespaces namespaces);
    public XmlSerializerNamespaces(XmlQualifiedName[] namespaces);
    public int Count { get; }
    public void Add(string prefix, string ns);
    public XmlQualifiedName[] ToArray();
  }
  public class XmlTextAttribute : Attribute {
    public XmlTextAttribute();
    public XmlTextAttribute(Type type);
    public string DataType { get; set; }
    public Type Type { get; set; }
  }
  public class XmlTypeAttribute : Attribute {
    public XmlTypeAttribute();
    public XmlTypeAttribute(string typeName);
    public bool AnonymousType { get; set; }
    public bool IncludeInSchema { get; set; }
    public string Namespace { get; set; }
    public string TypeName { get; set; }
  }
+ public class XmlTypeMapping : XmlMapping {
+   public string TypeFullName { get; }
+   public string TypeName { get; }
+   public string XsdTypeName { get; }
+   public string XsdTypeNamespace { get; }
  }
 }
```
