```diff
---lib-full\System.Xml.XmlDocument.dll
+++lib-oss\System.Xml.XmlDocument.dll
 namespace System.Xml {
  public class XmlAttribute : XmlNode {
    protected internal XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc);
    public override string BaseURI { get; }
    public override string InnerText { set; }
    public override string InnerXml { set; }
    public override string LocalName { get; }
    public override string Name { get; }
    public override string NamespaceURI { get; }
    public override XmlNodeType NodeType { get; }
    public override XmlDocument OwnerDocument { get; }
    public virtual XmlElement OwnerElement { get; }
    public override XmlNode ParentNode { get; }
    public override string Prefix { get; set; }
    public virtual bool Specified { get; }
    public override string Value { get; set; }
    public override XmlNode AppendChild(XmlNode newChild);
    public override XmlNode CloneNode(bool deep);
    public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild);
    public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild);
    public override XmlNode PrependChild(XmlNode newChild);
    public override XmlNode RemoveChild(XmlNode oldChild);
    public override XmlNode ReplaceChild(XmlNode newChild, XmlNode oldChild);
    public override void WriteContentTo(XmlWriter w);
    public override void WriteTo(XmlWriter w);
  }
  public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable {
    int System.Collections.ICollection.Count { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    [System.Runtime.CompilerServices.IndexerName("ItemOf")]
    public XmlAttribute this[int i] { get; }
    [System.Runtime.CompilerServices.IndexerName("ItemOf")]
    public XmlAttribute this[string localName, string namespaceURI] { get; }
    [System.Runtime.CompilerServices.IndexerName("ItemOf")]
    public XmlAttribute this[string name] { get; }
    public XmlAttribute Append(XmlAttribute node);
    public void CopyTo(XmlAttribute[] array, int index);
    public XmlAttribute InsertAfter(XmlAttribute newNode, XmlAttribute refNode);
    public XmlAttribute InsertBefore(XmlAttribute newNode, XmlAttribute refNode);
    public XmlAttribute Prepend(XmlAttribute node);
    public XmlAttribute Remove(XmlAttribute node);
    public void RemoveAll();
    public XmlAttribute RemoveAt(int i);
    public override XmlNode SetNamedItem(XmlNode node);
    void System.Collections.ICollection.CopyTo(Array array, int index);
  }
  public class XmlCDataSection : XmlCharacterData {
    protected internal XmlCDataSection(string data, XmlDocument doc);
    public override string LocalName { get; }
    public override string Name { get; }
    public override XmlNodeType NodeType { get; }
    public override XmlNode ParentNode { get; }
    public override XmlNode PreviousText { get; }
    public override XmlNode CloneNode(bool deep);
    public override void WriteContentTo(XmlWriter w);
    public override void WriteTo(XmlWriter w);
  }
  public abstract class XmlCharacterData : XmlLinkedNode {
    protected internal XmlCharacterData(string data, XmlDocument doc);
    public virtual string Data { get; set; }
+   public override string InnerText { get; set; }
    public virtual int Length { get; }
    public override string Value { get; set; }
    public virtual void AppendData(string strData);
    public virtual void DeleteData(int offset, int count);
    public virtual void InsertData(int offset, string strData);
    public virtual void ReplaceData(int offset, int count, string strData);
    public virtual string Substring(int offset, int count);
  }
  public class XmlComment : XmlCharacterData {
    protected internal XmlComment(string comment, XmlDocument doc);
    public override string LocalName { get; }
    public override string Name { get; }
    public override XmlNodeType NodeType { get; }
    public override XmlNode CloneNode(bool deep);
    public override void WriteContentTo(XmlWriter w);
    public override void WriteTo(XmlWriter w);
  }
  public class XmlDeclaration : XmlLinkedNode {
    protected internal XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc);
    public string Encoding { get; set; }
    public override string InnerText { get; set; }
    public override string LocalName { get; }
    public override string Name { get; }
    public override XmlNodeType NodeType { get; }
    public string Standalone { get; set; }
    public override string Value { get; set; }
    public string Version { get; }
    public override XmlNode CloneNode(bool deep);
    public override void WriteContentTo(XmlWriter w);
    public override void WriteTo(XmlWriter w);
  }
  public class XmlDocument : XmlNode {
    public XmlDocument();
    protected internal XmlDocument(XmlImplementation imp);
    public XmlDocument(XmlNameTable nt);
    public override string BaseURI { get; }
    public XmlElement DocumentElement { get; }
    public XmlImplementation Implementation { get; }
    public override string InnerText { set; }
    public override string InnerXml { get; set; }
    public override bool IsReadOnly { get; }
    public override string LocalName { get; }
    public override string Name { get; }
    public XmlNameTable NameTable { get; }
    public override XmlNodeType NodeType { get; }
    public override XmlDocument OwnerDocument { get; }
    public override XmlNode ParentNode { get; }
    public bool PreserveWhitespace { get; set; }
    public event XmlNodeChangedEventHandler NodeChanged;
    public event XmlNodeChangedEventHandler NodeChanging;
    public event XmlNodeChangedEventHandler NodeInserted;
    public event XmlNodeChangedEventHandler NodeInserting;
    public event XmlNodeChangedEventHandler NodeRemoved;
    public event XmlNodeChangedEventHandler NodeRemoving;
    public override XmlNode CloneNode(bool deep);
    public XmlAttribute CreateAttribute(string name);
    public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI);
    public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI);
    public virtual XmlCDataSection CreateCDataSection(string data);
    public virtual XmlComment CreateComment(string data);
    public virtual XmlDocumentFragment CreateDocumentFragment();
    public XmlElement CreateElement(string name);
    public XmlElement CreateElement(string qualifiedName, string namespaceURI);
    public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI);
    public virtual XmlNode CreateNode(string nodeTypeString, string name, string namespaceURI);
    public virtual XmlNode CreateNode(XmlNodeType type, string name, string namespaceURI);
    public virtual XmlNode CreateNode(XmlNodeType type, string prefix, string name, string namespaceURI);
    public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data);
    public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text);
    public virtual XmlText CreateTextNode(string text);
    public virtual XmlWhitespace CreateWhitespace(string text);
    public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone);
    public virtual XmlNodeList GetElementsByTagName(string name);
    public virtual XmlNodeList GetElementsByTagName(string localName, string namespaceURI);
    public virtual XmlNode ImportNode(XmlNode node, bool deep);
    public virtual void Load(Stream inStream);
    public virtual void Load(TextReader txtReader);
    public virtual void Load(XmlReader reader);
    public virtual void LoadXml(string xml);
    public virtual XmlNode ReadNode(XmlReader reader);
    public virtual void Save(Stream outStream);
    public virtual void Save(TextWriter writer);
    public virtual void Save(XmlWriter w);
    public override void WriteContentTo(XmlWriter xw);
    public override void WriteTo(XmlWriter w);
  }
  public class XmlDocumentFragment : XmlNode {
    protected internal XmlDocumentFragment(XmlDocument ownerDocument);
    public override string InnerXml { get; set; }
    public override string LocalName { get; }
    public override string Name { get; }
    public override XmlNodeType NodeType { get; }
    public override XmlDocument OwnerDocument { get; }
    public override XmlNode ParentNode { get; }
    public override XmlNode CloneNode(bool deep);
    public override void WriteContentTo(XmlWriter w);
    public override void WriteTo(XmlWriter w);
  }
  public class XmlElement : XmlLinkedNode {
    protected internal XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc);
    public override XmlAttributeCollection Attributes { get; }
    public virtual bool HasAttributes { get; }
    public override string InnerText { get; set; }
    public override string InnerXml { get; set; }
    public bool IsEmpty { get; set; }
    public override string LocalName { get; }
    public override string Name { get; }
    public override string NamespaceURI { get; }
    public override XmlNode NextSibling { get; }
    public override XmlNodeType NodeType { get; }
    public override XmlDocument OwnerDocument { get; }
    public override XmlNode ParentNode { get; }
    public override string Prefix { get; set; }
    public override XmlNode CloneNode(bool deep);
    public virtual string GetAttribute(string name);
    public virtual string GetAttribute(string localName, string namespaceURI);
    public virtual XmlAttribute GetAttributeNode(string name);
    public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI);
    public virtual XmlNodeList GetElementsByTagName(string name);
    public virtual XmlNodeList GetElementsByTagName(string localName, string namespaceURI);
    public virtual bool HasAttribute(string name);
    public virtual bool HasAttribute(string localName, string namespaceURI);
    public override void RemoveAll();
    public virtual void RemoveAllAttributes();
    public virtual void RemoveAttribute(string name);
    public virtual void RemoveAttribute(string localName, string namespaceURI);
    public virtual XmlNode RemoveAttributeAt(int i);
    public virtual XmlAttribute RemoveAttributeNode(string localName, string namespaceURI);
    public virtual XmlAttribute RemoveAttributeNode(XmlAttribute oldAttr);
    public virtual void SetAttribute(string name, string value);
    public virtual string SetAttribute(string localName, string namespaceURI, string value);
    public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI);
    public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr);
    public override void WriteContentTo(XmlWriter w);
    public override void WriteTo(XmlWriter w);
  }
  public class XmlImplementation {
    public XmlImplementation();
    public XmlImplementation(XmlNameTable nt);
    public virtual XmlDocument CreateDocument();
    public bool HasFeature(string strFeature, string strVersion);
  }
  public abstract class XmlLinkedNode : XmlNode {
    public override XmlNode NextSibling { get; }
    public override XmlNode PreviousSibling { get; }
  }
  public class XmlNamedNodeMap : IEnumerable {
    public virtual int Count { get; }
    public virtual IEnumerator GetEnumerator();
    public virtual XmlNode GetNamedItem(string name);
    public virtual XmlNode GetNamedItem(string localName, string namespaceURI);
    public virtual XmlNode Item(int index);
    public virtual XmlNode RemoveNamedItem(string name);
    public virtual XmlNode RemoveNamedItem(string localName, string namespaceURI);
    public virtual XmlNode SetNamedItem(XmlNode node);
  }
  public abstract class XmlNode : IEnumerable {
    public virtual XmlAttributeCollection Attributes { get; }
    public virtual string BaseURI { get; }
    public virtual XmlNodeList ChildNodes { get; }
    public virtual XmlNode FirstChild { get; }
    public virtual bool HasChildNodes { get; }
    public virtual string InnerText { get; set; }
    public virtual string InnerXml { get; set; }
    public virtual bool IsReadOnly { get; }
    public virtual XmlNode LastChild { get; }
    public abstract string LocalName { get; }
    public abstract string Name { get; }
    public virtual string NamespaceURI { get; }
    public virtual XmlNode NextSibling { get; }
    public abstract XmlNodeType NodeType { get; }
    public virtual string OuterXml { get; }
    public virtual XmlDocument OwnerDocument { get; }
    public virtual XmlNode ParentNode { get; }
    public virtual string Prefix { get; set; }
    public virtual XmlNode PreviousSibling { get; }
    public virtual XmlNode PreviousText { get; }
    public virtual XmlElement this[string localname, string ns] { get; }
    public virtual XmlElement this[string name] { get; }
    public virtual string Value { get; set; }
    public virtual XmlNode AppendChild(XmlNode newChild);
    public abstract XmlNode CloneNode(bool deep);
    public IEnumerator GetEnumerator();
    public virtual string GetNamespaceOfPrefix(string prefix);
    public virtual string GetPrefixOfNamespace(string namespaceURI);
    public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild);
    public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild);
    public virtual void Normalize();
    public virtual XmlNode PrependChild(XmlNode newChild);
    public virtual void RemoveAll();
    public virtual XmlNode RemoveChild(XmlNode oldChild);
    public virtual XmlNode ReplaceChild(XmlNode newChild, XmlNode oldChild);
    public virtual bool Supports(string feature, string version);
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    public abstract void WriteContentTo(XmlWriter w);
    public abstract void WriteTo(XmlWriter w);
  }
  public enum XmlNodeChangedAction {
    Change = 2,
    Insert = 0,
    Remove = 1,
  }
  public class XmlNodeChangedEventArgs : EventArgs {
    public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action);
    public XmlNodeChangedAction Action { get; }
    public XmlNode NewParent { get; }
    public string NewValue { get; }
    public XmlNode Node { get; }
    public XmlNode OldParent { get; }
    public string OldValue { get; }
  }
  public delegate void XmlNodeChangedEventHandler(object sender, XmlNodeChangedEventArgs e);
  public abstract class XmlNodeList : IDisposable, IEnumerable {
    protected XmlNodeList();
    public abstract int Count { get; }
    [System.Runtime.CompilerServices.IndexerName("ItemOf")]
    public virtual XmlNode this[int i] { get; }
    public abstract IEnumerator GetEnumerator();
    public abstract XmlNode Item(int index);
    protected virtual void PrivateDisposeNodeList();
    void System.IDisposable.Dispose();
  }
  public class XmlProcessingInstruction : XmlLinkedNode {
    protected internal XmlProcessingInstruction(string target, string data, XmlDocument doc);
    public string Data { get; set; }
    public override string InnerText { get; set; }
    public override string LocalName { get; }
    public override string Name { get; }
    public override XmlNodeType NodeType { get; }
    public string Target { get; }
    public override string Value { get; set; }
    public override XmlNode CloneNode(bool deep);
    public override void WriteContentTo(XmlWriter w);
    public override void WriteTo(XmlWriter w);
  }
  public class XmlSignificantWhitespace : XmlCharacterData {
    protected internal XmlSignificantWhitespace(string strData, XmlDocument doc);
    public override string LocalName { get; }
    public override string Name { get; }
    public override XmlNodeType NodeType { get; }
    public override XmlNode ParentNode { get; }
    public override XmlNode PreviousText { get; }
    public override string Value { get; set; }
    public override XmlNode CloneNode(bool deep);
    public override void WriteContentTo(XmlWriter w);
    public override void WriteTo(XmlWriter w);
  }
  public class XmlText : XmlCharacterData {
    protected internal XmlText(string strData, XmlDocument doc);
    public override string LocalName { get; }
    public override string Name { get; }
    public override XmlNodeType NodeType { get; }
    public override XmlNode ParentNode { get; }
    public override XmlNode PreviousText { get; }
    public override string Value { get; set; }
    public override XmlNode CloneNode(bool deep);
    public virtual XmlText SplitText(int offset);
    public override void WriteContentTo(XmlWriter w);
    public override void WriteTo(XmlWriter w);
  }
  public class XmlWhitespace : XmlCharacterData {
    protected internal XmlWhitespace(string strData, XmlDocument doc);
    public override string LocalName { get; }
    public override string Name { get; }
    public override XmlNodeType NodeType { get; }
    public override XmlNode ParentNode { get; }
    public override XmlNode PreviousText { get; }
    public override string Value { get; set; }
    public override XmlNode CloneNode(bool deep);
    public override void WriteContentTo(XmlWriter w);
    public override void WriteTo(XmlWriter w);
  }
 }
```
