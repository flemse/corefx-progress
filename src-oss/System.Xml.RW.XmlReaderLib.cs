namespace XmlReaderTest.Common {
  public class CDataReader {
    public const int STATUS_FAILED = 0;
    public const int STATUS_PASSED = 1;
    public CDataReader(object objInternal, EREADER_TYPE eReaderType, string strSource);
    public virtual int AttributeCount { get; }
    public virtual string BaseURI { get; }
    public bool CanReadBinaryContent { get; }
    public bool CanReadValueChunk { get; }
    public virtual bool CanResolveEntity { get; }
    public virtual int Depth { get; }
    public virtual bool EOF { get; }
    public virtual bool HasAttributes { get; }
    public virtual bool HasValue { get; }
    public virtual XmlReader Internal { get; set; }
    public virtual bool IsDefault { get; }
    public virtual bool IsEmptyElement { get; }
    public virtual int LineNumber { get; }
    public virtual int LinePosition { get; }
    public virtual string LocalName { get; }
    public virtual string Name { get; }
    public virtual bool Namespaces { get; set; }
    public virtual string NamespaceURI { get; }
    public virtual XmlNameTable NameTable { get; }
    public virtual XmlNodeType NodeType { get; }
    public virtual string Prefix { get; }
    public virtual EREADER_TYPE ReaderType { get; }
    public virtual ReadState ReadState { get; }
    public XmlReaderSettings Settings { get; }
    public string this[int i] { get; }
    public string this[string name, string namespaceURI] { get; }
    public string this[string name] { get; }
    public virtual string Value { get; }
    public virtual Type ValueType { get; }
    public virtual string XmlLang { get; }
    public virtual XmlSpace XmlSpace { get; }
    public void CheckWrappingReader();
    public virtual void Close();
    public void CompareNode(XmlNodeType eExpNodeType, string strExpName, string strExpValue);
    public virtual void Dispose();
    public void DumpAll();
    public void DumpOneNode();
    public int FindNodeType(XmlNodeType _nodetype);
    public string GetAttribute(int i);
    public string GetAttribute(string name);
    public string GetAttribute(string name, string namespaceURI);
    public bool IsStartElement();
    public bool IsStartElement(string name);
    public bool IsStartElement(string name, string ns);
    public string LookupNamespace(string prefix);
    public void MoveToAttribute(int i);
    public bool MoveToAttribute(string name);
    public bool MoveToAttribute(string name, string namespaceURI);
    public XmlNodeType MoveToContent();
    public bool MoveToElement();
    public bool MoveToFirstAttribute();
    public bool MoveToNextAttribute();
    public void PositionOnElement(string strElementName);
    public void PositionOnNodeType(XmlNodeType nodeType);
    public virtual bool Read();
    public bool ReadAttributeValue();
    public virtual object ReadContentAs(Type type, IXmlNamespaceResolver resolver);
    public int ReadContentAsBase64(byte[] array, int offset, int len);
    public int ReadContentAsBinHex(byte[] array, int offset, int len);
    public virtual bool ReadContentAsBoolean();
    public virtual DateTimeOffset ReadContentAsDateTimeOffset();
    public virtual decimal ReadContentAsDecimal();
    public virtual double ReadContentAsDouble();
    public virtual float ReadContentAsFloat();
    public virtual int ReadContentAsInt();
    public virtual long ReadContentAsLong();
    public virtual object ReadContentAsObject();
    public virtual string ReadContentAsString();
    public virtual object ReadElementContentAs(Type type, IXmlNamespaceResolver resolver);
    public virtual object ReadElementContentAs(Type type, IXmlNamespaceResolver resolver, string localName, string namespaceUri);
    public int ReadElementContentAsBase64(byte[] array, int offset, int len);
    public int ReadElementContentAsBinHex(byte[] array, int offset, int len);
    public virtual bool ReadElementContentAsBoolean();
    public virtual bool ReadElementContentAsBoolean(string localName, string namespaceUri);
    public virtual decimal ReadElementContentAsDecimal();
    public virtual decimal ReadElementContentAsDecimal(string localName, string namespaceUri);
    public virtual double ReadElementContentAsDouble();
    public virtual double ReadElementContentAsDouble(string localName, string namespaceUri);
    public virtual float ReadElementContentAsFloat();
    public virtual float ReadElementContentAsFloat(string localName, string namespaceUri);
    public virtual int ReadElementContentAsInt();
    public virtual int ReadElementContentAsInt(string localName, string namespaceUri);
    public virtual long ReadElementContentAsLong();
    public virtual long ReadElementContentAsLong(string localName, string namespaceUri);
    public virtual object ReadElementContentAsObject();
    public virtual object ReadElementContentAsObject(string localName, string namespaceUri);
    public virtual string ReadElementContentAsString();
    public virtual string ReadElementContentAsString(string localName, string namespaceUri);
    public void ReadEndElement();
    public string ReadInnerXml();
    public string ReadOuterXml();
    public void ReadStartElement();
    public void ReadStartElement(string name);
    public void ReadStartElement(string name, string ns);
    public XmlReader ReadSubtree();
    public bool ReadToDescendant(string name);
    public bool ReadToDescendant(string localName, string ns);
    public bool ReadToFollowing(string name);
    public bool ReadToFollowing(string localName, string ns);
    public bool ReadToNextSibling(string name);
    public bool ReadToNextSibling(string localName, string ns);
    public int ReadValueChunk(char[] buffer, int offset, int count);
    public void ResetState();
    public void ResetWrappingReader();
    public void ResolveEntity();
    public virtual void Skip();
    public bool VerifyNode(XmlNodeType eExpNodeType, string strExpName, string strExpValue);
  }
  public class CDataReaderTestCase : CGenericTestCase {
    public CDataReaderTestCase();
    public CDataReader DataReader { get; }
    public string WRONG_EXCEPTION { get; }
    protected int BoolToLTMResult(bool bResult);
    protected void CheckException(string expectedCode, Exception e);
    protected void CheckXmlException(string expectedCode, XmlException e, int expectedLine, int expectedPosition);
    public void CreateTestFile(EREADER_TYPE eReaderType);
    public void DeleteTestFile(EREADER_TYPE eReaderType);
    public override int ExecuteVariation(int index, object param);
    public string GetTestFileName(EREADER_TYPE eReaderType);
    public virtual void PostExecuteVariation(int index, object param);
    public virtual void PreExecuteVariation(int index, object param);
    public override int Terminate(object objParam);
  }
  public class CGenericTestCase : CTestCase {
    public CGenericTestCase();
    public string StandardPath { get; }
    public string TestData { get; }
    public virtual CGenericTestModule TestModule { get; set; }
  }
  public class CGenericTestModule : CTestModule {
    public CGenericTestModule();
    public ReaderFactory ReaderFactory { get; set; }
    public string StandardPath { get; }
    public string TestData { get; }
    public override int Init(object objParam);
    public override int Terminate(object objParam);
  }
  public class CustomReader : XmlReader, IXmlLineInfo {
    public CustomReader(Stream stream);
    public CustomReader(TextReader txtReader, bool isFragment);
    public CustomReader(string filename);
    public CustomReader(string url, bool isFragment);
    public override int AttributeCount { get; }
    public override string BaseURI { get; }
    public override bool CanResolveEntity { get; }
    public override int Depth { get; }
    public override bool EOF { get; }
    public override bool HasValue { get; }
    public override bool IsEmptyElement { get; }
    public int LineNumber { get; }
    public int LinePosition { get; }
    public override string LocalName { get; }
    public override string NamespaceURI { get; }
    public override XmlNameTable NameTable { get; }
    public override XmlNodeType NodeType { get; }
    public override string Prefix { get; }
    public override ReadState ReadState { get; }
    public override string Value { get; }
    protected override void Dispose(bool disposing);
    public override string GetAttribute(int i);
    public override string GetAttribute(string name);
    public override string GetAttribute(string name, string namespaceURI);
    public bool HasLineInfo();
    public override string LookupNamespace(string prefix);
    public override bool MoveToAttribute(string name);
    public override bool MoveToAttribute(string name, string ns);
    public override bool MoveToElement();
    public override bool MoveToFirstAttribute();
    public override bool MoveToNextAttribute();
    public override bool Read();
    public override bool ReadAttributeValue();
    public override void ResolveEntity();
  }
  public enum EINTEGRITY {
    AFTER_CLEAR = 5,
    AFTER_CLOSE = 7,
    AFTER_FLUSH = 6,
    AFTER_READ_FALSE = 1,
    AFTER_RESETSTATE = 2,
    AFTER_WRITE_FALSE = 4,
    BEFORE_READ = 0,
    BEFORE_WRITE = 3,
    CLOSE_IN_THE_MIDDLE = 8,
  }
  public enum EREADER_TYPE {
    BASE64_TEST = 21,
    BIG_ELEMENT_SIZE = 6,
    BIGENDIAN = 2,
    BINARY = 27,
    BINHEX_TEST = 22,
    BYTE = 3,
    CONSTRUCTOR = 23,
    GENERIC = 4,
    INVALID_DTD = 16,
    INVALID_NAMESPACE = 8,
    INVALID_SCHEMA = 17,
    INVWELLFORMED_DTD = 14,
    JUNK = 7,
    LBNORMALIZATION = 25,
    LINENUMBER = 24,
    NONWELLFORMED_DTD = 13,
    SCHEMATYPE = 26,
    STRING_ONLY = 5,
    UNICODE = 0,
    UTF8 = 1,
    VALID_DTD = 15,
    WELLFORMED_DTD = 12,
    WHITESPACE_TEST = 20,
    XMLLANG_TEST = 10,
    XMLNAMESPACE_TEST = 9,
    XMLSCHEMA = 18,
    XMLSPACE_TEST = 11,
    XSLT_COPY = 19,
  }
  public class InheritRequired : Attribute {
    public InheritRequired();
  }
  public abstract class ReaderFactory {
    public static string HT_CURDESC;
    public static string HT_CURVAR;
    public static string HT_FILENAME;
    public static string HT_FRAGMENT;
    public static string HT_READERSETTINGS;
    public static string HT_READERTYPE;
    public static string HT_SCHEMACOLLECTION;
    public static string HT_SCHEMASET;
    public static string HT_STREAM;
    public static string HT_STRINGREADER;
    public static string HT_VALIDATIONHANDLER;
    public static string HT_VALIDATIONTYPE;
    protected ReaderFactory();
    public int ValidationCallbackCount { get; set; }
    public int ValidationErrorCount { get; set; }
    public int ValidationWarningCount { get; set; }
    public abstract XmlReader Create(MyDict<string, object> options);
    public virtual void Initialize();
    public virtual void Terminate();
  }
  public abstract class TCAttributeAccess : TCXMLReaderBaseGeneral {
    protected TCAttributeAccess();
    public override void AddChildren();
    public int TestAttributeAccess1();
    public int TestAttributeAccess2();
    public int TestAttributeAccess3();
    public int TestAttributeAccess4();
    public int TestAttributeAccess5();
  }
  public abstract class TCAttributeTest : TCXMLReaderBaseGeneral {
    protected TCAttributeTest();
    public override void AddChildren();
    public int TestAttributeTestNodeType_CDATA();
    public int TestAttributeTestNodeType_Comment();
    public int TestAttributeTestNodeType_DocumentType();
    public int TestAttributeTestNodeType_Element();
    public int TestAttributeTestNodeType_EndElement();
    public int TestAttributeTestNodeType_EndEntity();
    public int TestAttributeTestNodeType_EntityReference();
    public int TestAttributeTestNodeType_None();
    public int TestAttributeTestNodeType_ProcessingInstruction();
    public int TestAttributeTestNodeType_Text();
    public int TestAttributeTestNodeType_Whitespace();
    public int TestAttributeTestNodeType_XmlDeclaration();
  }
  public abstract class TCAttributeXmlDeclaration : TCXMLReaderBaseGeneral {
    protected TCAttributeXmlDeclaration();
    public override void AddChildren();
    public override int Init(object objParam);
    public int TAXmlDecl_1();
    public int TAXmlDecl_10();
    public int TAXmlDecl_11();
    public int TAXmlDecl_12();
    public int TAXmlDecl_13();
    public int TAXmlDecl_2();
    public int TAXmlDecl_3();
    public int TAXmlDecl_4();
    public int TAXmlDecl_5();
    public int TAXmlDecl_6();
    public int TAXmlDecl_7();
    public int TAXmlDecl_8();
    public int TAXmlDecl_9();
  }
  public abstract class TCBaseURI : TCXMLReaderBaseGeneral {
    public const string ST_GEN_ENT_NAME = "ext3";
    public const string ST_GEN_ENT_VALUE = "blah";
    public const string ST_TEST_ENT = "AllNodeTypes.ent";
    protected TCBaseURI();
    public int TestBaseURI1();
    public int TestBaseURI10();
    public int TestBaseURI2();
    public int TestBaseURI3();
    public int TestBaseURI4();
    public int TestBaseURI6();
    public int TestBaseURI7();
    public int TestBaseURI8();
    public int TestBaseURI9();
    public int TestTextBaseURI1();
    public int TestTextReaderBaseURI107315();
    public int TestTextReaderBaseURI2();
    public int TestTextReaderBaseURI4();
    public int TestTextReaderBaseURI5();
    public int TestTextReaderBaseURI6();
    public int TestTextReaderBaseURI7();
    public int TestTextReaderBaseURI8();
  }
  public abstract class TCBufferBoundaries : TCXMLReaderBaseGeneral {
    protected TCBufferBoundaries();
    public override void AddChildren();
    public MemoryStream GetStream(string sTag, string eTag, string content, int val);
    public int v1();
  }
  public abstract class TCDepth : TCXMLReaderBaseGeneral {
    protected TCDepth();
    public override void AddChildren();
    public int TestDepth1();
    public int TestDepth2();
    public int TestDepth3();
    public int TestDepth4();
    public int TestDepth5();
    public int TestDepth6();
  }
  public abstract class TCDispose : TCXMLReaderBaseGeneral {
    protected TCDispose();
    public override void AddChildren();
    public int Variation1();
    public int Variation2();
    public int Variation3();
  }
  public abstract class TCErrorCondition : TCXMLReaderBaseGeneral {
    public static string xmlStr;
    protected TCErrorCondition();
    public override void AddChildren();
    public int Dev10_67883();
    public int v1();
    public int v10();
    public int v11();
    public int v14();
    public int V16();
    public int v1a();
    public int v1b();
    public int v2();
    public int v3();
    public int v4();
    public int v5();
    public int v6();
    public int v7();
    public int V8();
    public int V9a();
    public int var12();
    public int var13();
    public int var15();
  }
  public abstract class TCGetAttributeName : TCXMLReaderBaseGeneral {
    protected TCGetAttributeName();
    public override void AddChildren();
    public int GetAttributeWithName1();
    public int GetAttributeWithName10();
    public int GetAttributeWithName11();
    public int GetAttributeWithName12();
    public int GetAttributeWithName13();
    public int GetAttributeWithName14();
    public int GetAttributeWithName2();
    public int GetAttributeWithName3();
    public int GetAttributeWithName4();
    public int GetAttributeWithName5();
    public int GetAttributeWithName6();
    public int GetAttributeWithName7();
    public int GetAttributeWithName8();
    public int GetAttributeWithName9();
  }
  public abstract class TCGetAttributeOrdinal : TCXMLReaderBaseGeneral {
    protected TCGetAttributeOrdinal();
    public override void AddChildren();
    public int FieldCountOrdinal();
    public int GetAttributeWithGetAttrDoubleQ();
    public int GetAttributeWithMoveAttrDoubleQ();
    public int GetAttributeWithMoveAttrSingleQ();
    public int NegativeOneOrdinal();
    public int OrdinalMinusOne();
    public int OrdinalPlusOne();
    public int OrdinalWithGetAttrSingleQ();
  }
  public abstract class TCHasValue : TCXMLReaderBaseGeneral {
    protected TCHasValue();
    public override void AddChildren();
    public int TestHasValue1();
    public int TestHasValueNodeType_Attribute();
    public int TestHasValueNodeType_CDATA();
    public int TestHasValueNodeType_Comment();
    public int TestHasValueNodeType_Element();
    public int TestHasValueNodeType_EndElement();
    public int TestHasValueNodeType_EndEntity();
    public int TestHasValueNodeType_EntityReference();
    public int TestHasValueNodeType_None();
    public int TestHasValueNodeType_ProcessingInstruction();
    public int TestHasValueNodeType_Text();
    public int TestHasValueNodeType_Whitespace();
    public int TestHasValueNodeType_XmlDeclaration();
    public int v13();
  }
  public abstract class TCInvalidXML : TCXMLReaderBaseGeneral {
    protected TCInvalidXML();
    public override void AddChildren();
    public int FactoryReaderInvalidCharacter();
    public int InvalidCommentCharacters();
    public int Read1();
    public int Read10a();
    public int Read11();
    public int Read12();
    public int Read13();
    public int Read14();
    public int Read15();
    public int Read16();
    public int Read17();
    public int Read18();
    public int Read19();
    public int Read2();
    public int Read20();
    public int Read21();
    public int Read22();
    public int Read22a();
    public int Read23();
    public int Read24a();
    public int Read25b();
    public int Read26b();
    public int Read28();
    public int Read29a();
    public int Read29b();
    public int Read29c();
    public int Read3();
    public int Read30();
    public int Read30a();
    public int Read30b();
    public int Read30c();
    public int Read31();
    public int Read31a();
    public int Read31b();
    public int Read31c();
    public int Read32();
    public int Read32a();
    public int Read32b();
    public int Read32c();
    public int Read33();
    public int Read33a();
    public int Read33b();
    public int Read33c();
    public int Read34();
    public int Read34a();
    public int Read34b();
    public int Read34c();
    public int Read35();
    public int Read35a();
    public int Read35b();
    public int Read35c();
    public int Read36();
    public int Read36a();
    public int Read36b();
    public int Read36c();
    public int Read37();
    public int Read37a();
    public int Read37b();
    public int Read37c();
    public int Read4();
    public int Read5();
    public int Read6();
    public int Read8();
  }
  public abstract class TCIsEmptyElement : TCXMLReaderBaseGeneral {
    protected TCIsEmptyElement();
    public override void AddChildren();
    public int TestEmpty1();
    public int TestEmpty2();
    public int TestEmpty3();
    public int TestEmpty4();
    public int TestEmptyNodeType_CDATA();
    public int TestEmptyNodeType_Comment();
    public int TestEmptyNodeType_DocumentType();
    public int TestEmptyNodeType_Element();
    public int TestEmptyNodeType_EndElement();
    public int TestEmptyNodeType_EndEntity();
    public int TestEmptyNodeType_EntityReference();
    public int TestEmptyNodeType_None();
    public int TestEmptyNodeType_ProcessingInstruction();
    public int TestEmptyNodeType_Text();
    public int TestEmptyNodeType_Whitespace();
    public int TestEmptyNodeType_XmlDeclaration();
  }
  public abstract class TCIsStartElement : TCXMLReaderBaseGeneral {
    protected TCIsStartElement();
    public override void AddChildren();
    public int TestIsStartElement1();
    public int TestIsStartElement10();
    public int TestIsStartElement11();
    public int TestIsStartElement12();
    public int TestIsStartElement13();
    public int TestIsStartElement15();
    public int TestIsStartElement2();
    public int TestIsStartElement3();
    public int TestIsStartElement4();
    public int TestIsStartElement5();
    public int TestIsStartElement6();
    public int TestIsStartElement7();
    public int TestIsStartElement8();
    public int TestIsStartElement9();
    public int TestTextIsStartElement1();
    public int TestTextIsStartElement2();
  }
  public abstract class TCLinePos : TCXMLReaderBaseGeneral {
    public const string ST_A0 = "a0";
    public const string ST_A1 = "a1";
    public const string ST_A2 = "a2";
    public const string ST_BASE64 = "BASE64";
    public const string ST_BINHEX = "BINHEX";
    public const string ST_BOOLXSD = "BOOLXSD";
    public const string ST_CHARENTITY = "CHARENTITY";
    public const string ST_DATE = "DATE";
    public const string ST_DATETIME = "DATETIME";
    public const string ST_DECIMAL2 = "DECIMAL";
    public const string ST_ELEMENT = "ELEMENT";
    public const string ST_ENTITYREF = "ENTITYREF";
    public const string ST_INT = "INT";
    public const string ST_SKIP = "SKIP";
    public const string ST_TIME = "TIME";
    public const string ST_TIMESPAN = "TIMESPAN";
    protected TCLinePos();
    public override void AddChildren();
    public int LineNumberAndLinePositionAreCorrect();
    public void PositionOnNodeType2(XmlNodeType nodeType);
    public int ReadingNonWellFormedXmlThrows();
    public int TestLinePos1();
    public int TestLinePos10();
    public int TestLinePos11();
    public int TestLinePos12();
    public int TestLinePos13();
    public int TestLinePos14();
    public int TestLinePos15();
    public int TestLinePos16();
    public int TestLinePos18();
    public int TestLinePos19();
    public int TestLinePos2();
    public int TestLinePos20();
    public int TestLinePos21();
    public int TestLinePos22();
    public int TestLinePos26();
    public int TestLinePos27();
    public int TestLinePos39();
    public int TestLinePos4();
    public int TestLinePos40();
    public int TestLinePos41();
    public int TestLinePos42();
    public int TestLinePos43();
    public int TestLinePos44();
    public int TestLinePos45();
    public int TestLinePos6();
    public int TestLinePos7();
    public int TestLinePos9();
    public int TestLinePos99();
    public int XmlExceptionAndXmlTextReaderLineNumberShouldBeSameAfterExceptionIsThrown();
    public int XmlReaderShouldIncreaseLineNumberAfterNewLineInElementTag();
  }
  public abstract class TCLookupNamespace : TCXMLReaderBaseGeneral {
    protected TCLookupNamespace();
    public int LookupNamespace1();
    public int LookupNamespace10();
    public int LookupNamespace2();
    public int LookupNamespace3();
    public int LookupNamespace4();
    public int LookupNamespace5();
    public int LookupNamespace6();
    public int LookupNamespace7();
    public int LookupNamespace8();
    public int LookupNamespace9();
  }
  public abstract class TCMoveToAttribute : TCXMLReaderBaseGeneral {
    protected TCMoveToAttribute();
    public override void AddChildren();
    public int MoveToAttributeWithName1();
    public int MoveToAttributeWithName2();
  }
  public abstract class TCMoveToAttributeOrdinal : TCXMLReaderBaseGeneral {
    protected TCMoveToAttributeOrdinal();
    public override void AddChildren();
    public int FieldCountOrdinal();
    public int MoveToAttributeWithGetAttrDoubleQ();
    public int MoveToAttributeWithGetAttrSingleQ();
    public int MoveToAttributeWithMoveAttrDoubleQ();
    public int MoveToAttributeWithMoveAttrSingleQ();
    public int NegativeOneOrdinal();
    public int OrdinalMinusOne();
    public int OrdinalPlusOne();
  }
  public abstract class TCMoveToContent : TCXMLReaderBaseGeneral {
    public const string ST_ATT1_NAME = "att1";
    public const string ST_ENT1_ELEM_ALL_ENTITIES_TYPE = "xxxBxxxDxxxe1fooxxx";
    public const string ST_GEN_ENT_NAME = "e1";
    public const string ST_GEN_ENT_VALUE = "e1foo";
    public const string ST_TEST_CDATA = "cdata info";
    public const string ST_TEST_NAME1 = "GOTOCONTENT";
    public const string ST_TEST_NAME2 = "SKIPCONTENT";
    public const string ST_TEST_NAME3 = "MIXCONTENT";
    public const string ST_TEST_TEXT = "some text";
    protected TCMoveToContent();
    public override void AddChildren();
    public int TestMoveToContent1();
    public int TestMoveToContent3();
    public int TestMoveToContent5();
  }
  public abstract class TCMoveToElement : TCXMLReaderBaseGeneral {
    protected TCMoveToElement();
    public override void AddChildren();
    public int v1();
    public int v2();
    public int v3();
    public int v5();
  }
  public abstract class TCMoveToFirstAttribute : TCXMLReaderBaseGeneral {
    protected TCMoveToFirstAttribute();
    public override void AddChildren();
    public int MoveToFirstAttribute1();
    public int MoveToFirstAttribute2();
    public int MoveToFirstAttribute3();
    public int MoveToFirstAttribute4();
    public int MoveToFirstAttribute5();
    public int MoveToFirstAttribute6();
    public int MoveToFirstAttribute7();
    public int MoveToFirstAttribute8();
  }
  public abstract class TCMoveToNextAttribute : TCXMLReaderBaseGeneral {
    protected TCMoveToNextAttribute();
    public override void AddChildren();
    public int MoveToFirstAttribute5();
    public int MoveToFirstAttribute6();
    public int MoveToFirstAttribute7();
    public int MoveToFirstAttribute8();
    public int MoveToNextAttribute1();
    public int MoveToNextAttribute2();
    public int MoveToNextAttribute3();
    public int MoveToNextAttribute4();
    public int MoveToNextAttribute9();
  }
  public abstract class TCNamespace : TCXMLReaderBaseGeneral {
    protected TCNamespace();
    public override void AddChildren();
    public int sqlbu435761();
    public int TestNamespace1();
    public int TestNamespace2();
    public int TestNamespace3();
    public int TestNamespace4();
    public int TestNamespace5();
    public int TestNamespace6();
    public int TestNamespace7();
  }
  public abstract class TCRead2 : TCXMLReaderBaseGeneral {
    protected TCRead2();
    public override void AddChildren();
    public int Read31();
    public int Read33();
    public int Read33a();
    public int Read34();
    public int Read35();
    public int Read36();
    public int Read37();
    public int Read38();
    public int Read39();
    public int Read41();
    public int Read42();
    public int Read43();
    public int Read44();
    public int Read45();
    public int Read46();
    public int Read47();
    public int Read48();
    public int Read49();
    public int Read50();
    public int Read51();
    public int Read53();
    public int Read54();
    public int Read55();
    public int Read56();
    public int Read57();
    public int Read58();
    public int Read59();
    public int Read61();
    public int Read63();
    public int Read64();
    public int Read65();
    public int Read66();
    public int Read68();
    public int Read68a();
    public int Read70();
    public int ReadEmpty();
    public int v1();
    public int v10();
    public int v12();
    public int v13();
    public int v14();
    public int v2();
    public int v3();
    public int v4();
    public int v6();
    public int v7();
    public int v8();
    public int v9();
    public int XmlExceptionCtorWithNoParamsDoesNotThrow();
  }
  public abstract class TCReadAttributeValue : TCXMLReaderBaseGeneral {
    protected TCReadAttributeValue();
    public override void AddChildren();
    public int TestReadAttributeValue1();
    public int TestReadAttributeValue2();
    public int TestReadAttributeValue3();
    public int TestReadAttributeValue4();
    public int TestReadAttributeValue5();
  }
  public abstract class TCReadContentAsBase64 : TCXMLReaderBaseGeneral {
    public const string Base64Xml = "Base64.xml";
    public const string ST_ELEM_NAME1 = "ElemAll";
    public const string ST_ELEM_NAME2 = "ElemEmpty";
    public const string ST_ELEM_NAME3 = "ElemNum";
    public const string ST_ELEM_NAME4 = "ElemText";
    public const string ST_ELEM_NAME5 = "ElemNumText";
    public const string ST_ELEM_NAME6 = "ElemLong";
    public const string strNumBase64 = "0123456789+/";
    public const string strTextBase64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    protected TCReadContentAsBase64();
    public override void AddChildren();
    public override int Init(object objParam);
    public int ReadBase64_10();
    public int ReadBase64_11();
    public int ReadBase64_12();
    public int ReadBase64_7();
    public int ReadBase64_8();
    public int ReadBase64_9();
    public int ReadBase64BufferOverflowWorksProperly();
    public override int Terminate(object objParam);
    protected void TestOnInvalidNodeType(XmlNodeType nt);
    protected void TestOnNopNodeType(XmlNodeType nt);
    public int TestReadBase64_1();
    public int TestReadBase64_13();
    public int TestReadBase64_14();
    public int TestReadBase64_15();
    public int TestReadBase64_16();
    public int TestReadBase64_17();
    public int TestReadBase64_2();
    public int TestReadBase64_3();
    public int TestReadBase64_5();
    public int TestReadBase64_6();
    public int TestTextReadBase64_23();
    public int TestTextReadBase64_24();
    public int TestTextReadBase64_26();
    public int TestTextReadBase64_27();
  }
  public abstract class TCReadContentAsBinHex : TCXMLReaderBaseGeneral {
    public static string BinHexXml;
    public const string ST_ELEM_NAME1 = "ElemAll";
    public const string ST_ELEM_NAME2 = "ElemEmpty";
    public const string ST_ELEM_NAME3 = "ElemNum";
    public const string ST_ELEM_NAME4 = "ElemText";
    public const string ST_ELEM_NAME5 = "ElemNumText";
    public const string ST_ELEM_NAME6 = "ElemLong";
    public const string strNumBinHex = "0123456789";
    public const string strTextBinHex = "ABCDEF";
    protected TCReadContentAsBinHex();
    public override void AddChildren();
    public void Dump(byte[] bytes);
    public override int Init(object objParam);
    public override int Terminate(object objParam);
    protected void TestInvalidNodeType(XmlNodeType nt);
    public int TestReadBinHex_1();
    public int TestReadBinHex_10();
    public int TestReadBinHex_11();
    public int TestReadBinHex_12();
    public int TestReadBinHex_13();
    public int TestReadBinHex_14();
    public int TestReadBinHex_16();
    public int TestReadBinHex_17();
    public int TestReadBinHex_2();
    public int TestReadBinHex_3();
    public int TestReadBinHex_4();
    public int TestReadBinHex_5();
    public int TestReadBinHex_6();
    public int TestReadBinHex_7();
    public int TestReadBinHex_8();
    public int TestTextReadBinHex_21();
    public int TestTextReadBinHex_22();
    public int TestTextReadBinHex_23();
    public int TestTextReadBinHex_24();
    public int vReadBinHex_9();
  }
  public abstract class TCReadElementContentAsBase64 : TCXMLReaderBaseGeneral {
    public const string ST_ELEM_NAME1 = "ElemAll";
    public const string ST_ELEM_NAME2 = "ElemEmpty";
    public const string ST_ELEM_NAME3 = "ElemNum";
    public const string ST_ELEM_NAME4 = "ElemText";
    public const string ST_ELEM_NAME5 = "ElemNumText";
    public const string ST_ELEM_NAME6 = "ElemLong";
    public const string strNumBase64 = "0123456789+/";
    public const string strTextBase64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    protected TCReadElementContentAsBase64();
    public override void AddChildren();
    public override int Init(object objParam);
    public int ReadBase64_10();
    public int ReadBase64_11();
    public int ReadBase64_12();
    public int ReadBase64_7();
    public int ReadBase64_8();
    public int ReadBase64_9();
    public int ReadBase64RunsIntoOverflow();
    public int SubtreeReaderInsertedAttributesWorkWithReadContentAsBase64();
    public override int Terminate(object objParam);
    protected void TestOnInvalidNodeType(XmlNodeType nt);
    public int TestReadBase64_1();
    public int TestReadBase64_13();
    public int TestReadBase64_14();
    public int TestReadBase64_15();
    public int TestReadBase64_16();
    public int TestReadBase64_17();
    public int TestReadBase64_2();
    public int TestReadBase64_28();
    public int TestReadBase64_29();
    public int TestReadBase64_3();
    public int TestReadBase64_30();
    public int TestReadBase64_31();
    public int TestReadBase64_32();
    public int TestReadBase64_33();
    public int TestReadBase64_34();
    public int TestReadBase64_5();
    public int TestReadBase64_6();
    public int TestReadBase64ReadsTheContent();
    public int TestReadReadBase64_35();
    public int TestReadReadBase64_36();
    public int TestTextReadBase64_23();
    public int TestTextReadBase64_24();
    public int TestTextReadBase64_26();
    public int TestTextReadBase64_27();
  }
  public abstract class TCReadElementContentAsBinHex : TCXMLReaderBaseGeneral {
    public static string BinHexXml;
    public const string ST_ELEM_NAME1 = "ElemAll";
    public const string ST_ELEM_NAME2 = "ElemEmpty";
    public const string ST_ELEM_NAME3 = "ElemNum";
    public const string ST_ELEM_NAME4 = "ElemText";
    public const string ST_ELEM_NAME5 = "ElemNumText";
    public const string ST_ELEM_NAME6 = "ElemLong";
    public const string strNumBinHex = "0123456789";
    public const string strTextBinHex = "ABCDEF";
    protected TCReadElementContentAsBinHex();
    public override void AddChildren();
    public override int Init(object objParam);
    public override int Terminate(object objParam);
    public int TestBinHex_34();
    protected void TestInvalidNodeType(XmlNodeType nt);
    public int TestReadBinHex_1();
    public int TestReadBinHex_10();
    public int TestReadBinHex_105376();
    public int TestReadBinHex_11();
    public int TestReadBinHex_12();
    public int TestReadBinHex_13();
    public int TestReadBinHex_14();
    public int TestReadBinHex_16();
    public int TestReadBinHex_18();
    public int TestReadBinHex_2();
    public int TestReadBinHex_27();
    public int TestReadBinHex_28();
    public int TestReadBinHex_29();
    public int TestReadBinHex_3();
    public int TestReadBinHex_30();
    public int TestReadBinHex_31();
    public int TestReadBinHex_32();
    public int TestReadBinHex_33();
    public int TestReadBinHex_35();
    public int TestReadBinHex_36();
    public int TestReadBinHex_4();
    public int TestReadBinHex_430329();
    public int TestReadBinHex_5();
    public int TestReadBinHex_6();
    public int TestReadBinHex_7();
    public int TestReadBinHex_8();
    public int TestTextReadBinHex_21();
    public int TestTextReadBinHex_22();
    public int TestTextReadBinHex_23();
    public int TestTextReadBinHex_24();
    public int vReadBinHex_9();
  }
  public abstract class TCReadEndElement : TCXMLReaderBaseGeneral {
    protected TCReadEndElement();
    public override void AddChildren();
    public int TestReadEndElement1();
    public int TestReadEndElement10();
    public int TestReadEndElement11();
    public int TestReadEndElement13();
    public int TestReadEndElement2();
    public int TestReadEndElement3();
    public int TestReadEndElement4();
    public int TestReadEndElement5();
    public int TestReadEndElement6();
    public int TestReadEndElement7();
    public int TestReadEndElement9();
    public int TestTextReadEndElement1();
    public int TestTextReadEndElement2();
  }
  public abstract class TCReadInnerXml : TCXMLReaderBaseGeneral {
    public const string ST_ENT_TEXT = "xxx&gt;xxx&#66;xxx&#x44;xxx&e1;xxx";
    protected TCReadInnerXml();
    public int TestReadInnerXml1();
    public int TestReadInnerXml10();
    public int TestReadInnerXml11();
    public int TestReadInnerXml12();
    public int TestReadInnerXml13();
    public int TestReadInnerXml14();
    public int TestReadInnerXml16();
    public int TestReadInnerXml17();
    public int TestReadInnerXml18();
    public int TestReadInnerXml19();
    public int TestReadInnerXml2();
    public int TestReadInnerXml3();
    public int TestReadInnerXml4();
    public int TestReadInnerXml5();
    public int TestReadInnerXml6();
    public int TestReadInnerXml7();
    public int TestReadInnerXml8();
    public int TestReadInnerXml9();
    public int TestTextReadInnerXml16();
    public int TestTextReadInnerXml18();
    public int TestTextReadInnerXml2();
    public int TestTextReadInnerXml4();
    public int TestTextReadInnerXml5();
  }
  public abstract class TCReadOuterXml : TCXMLReaderBaseGeneral {
    protected TCReadOuterXml();
    public override void AddChildren();
    public int ReadOuterXml1();
    public int ReadOuterXml10();
    public int ReadOuterXml11();
    public int ReadOuterXml12();
    public int ReadOuterXml13();
    public int ReadOuterXml14();
    public int ReadOuterXml15();
    public int ReadOuterXml16();
    public int ReadOuterXml17();
    public int ReadOuterXml18();
    public int ReadOuterXml19();
    public int ReadOuterXml2();
    public int ReadOuterXml20();
    public int ReadOuterXml21();
    public int ReadOuterXml22();
    public int ReadOuterXml23();
    public int ReadOuterXml24();
    public int ReadOuterXml25();
    public int ReadOuterXml26();
    public int ReadOuterXml3();
    public int ReadOuterXml4();
    public int ReadOuterXml5();
    public int ReadOuterXml6();
    public int ReadOuterXml7();
    public int ReadOuterXml8();
    public int ReadOuterXml9();
    public int ReadOuterXmlWhenNamespacesIgnoredWorksWithXmlns();
    public int SubtreeXmlReaderOutputsSingleNamespaceDeclaration();
    public int TestTextReadOuterXml29();
    public int TRReadOuterXml27();
    public int TRReadOuterXml28();
  }
  public abstract class TCReadStartElement : TCXMLReaderBaseGeneral {
    protected TCReadStartElement();
    public override void AddChildren();
    public int TestReadStartElement1();
    public int TestReadStartElement10();
    public int TestReadStartElement11();
    public int TestReadStartElement12();
    public int TestReadStartElement13();
    public int TestReadStartElement14();
    public int TestReadStartElement15();
    public int TestReadStartElement16();
    public int TestReadStartElement2();
    public int TestReadStartElement3();
    public int TestReadStartElement4();
    public int TestReadStartElement5();
    public int TestReadStartElement6();
    public int TestReadStartElement7();
    public int TestReadStartElement8();
    public int TestReadStartElement9();
  }
  public abstract class TCReadState : TCXMLReaderBaseGeneral {
    protected TCReadState();
    public override int Init(object objParam);
    public int ReadState1();
    public override int Terminate(object objParam);
  }
  public abstract class TCReadSubtree : TCXMLReaderBaseGeneral {
    protected TCReadSubtree();
    public override void AddChildren();
    public int DisposingSubtreeReaderThatIsInErrorStateWorksProperly();
    public int IndexingMethodsWorksProperly();
    public int ReadSubtreeWorksOnlyOnElementNode();
    public int SubtreeReaderCanDealWithMultipleNamespaces();
    public int SubtreeReaderReadsProperlyNodeTypeOfAttributes();
    public int v100();
    public int v101();
    public int v102();
    public int v2();
    public int v3();
    public int v4();
    public int v5();
    public int v7();
    public int v8();
    public int XmlReaderDisposeDoesntDisposeMainReader();
    public int XmlReaderNameIsConsistentWhenReadingNamespaceNodeAttribute();
    public int XmlSubtreeReaderDoesntAddMultipleNamespaceDeclarations();
    public int XmlSubtreeReaderDoesntDuplicateLocalNames();
  }
  public abstract class TCReadToDescendant : TCXMLReaderBaseGeneral {
    protected TCReadToDescendant();
    public override void AddChildren();
    public int v();
    public int v10();
    public int v11();
    public int v12();
    public int v13();
    public int v14();
    public int v15();
    public int v17();
    public int v18();
    public int v19();
    public int v2();
    public int v2_1();
    public int v3();
    public int v4();
    public int v5();
    public int v6();
    public int v7();
    public int v8();
    public int v9();
  }
  public abstract class TCReadToFollowing : TCXMLReaderBaseGeneral {
    protected TCReadToFollowing();
    public override void AddChildren();
    public int v1();
    public int v10();
    public int v11();
    public int v14();
    public int v15();
    public int v17();
    public int v2();
    public int v4();
    public int v5_1();
    public int v5_2();
    public int v6();
    public int v7();
    public int v8();
    public int v9();
  }
  public abstract class TCReadToNextSibling : TCXMLReaderBaseGeneral {
    protected TCReadToNextSibling();
    public override void AddChildren();
    public int v();
    public int v12();
    public int v16();
    public int v17();
    public int v2();
    public int v2_1();
    public int v3();
    public int v4();
    public int v5();
    public int v6();
  }
  public abstract class TCReadValue : TCXMLReaderBaseGeneral {
    public const string ST_GEN_ENT_NAME = "e1";
    public const string ST_GEN_ENT_VALUE = "e1foo";
    public const string ST_TEST_NAME = "CHARS1";
    protected TCReadValue();
    public override void AddChildren();
    public int ReadValueChunkDoesWorkProperlyOnAttributes();
    public int ReadValueChunkDoesWorkProperlyOnSpecialAttributes();
    public int ReadValueChunkWorksProperlyWithSubtreeReaderInsertedAttributes();
    public int SkipAfterReadAttributeValueAndReadValueChunkDoesNotThrow();
    public int TestCharEntities0();
    public int TestCharEntities1();
    public int TestCharEntities2();
    public int TestReadChar11();
    public int TestReadChar12();
    public int TestReadChar13();
    public int TestReadChar14();
    public int TestReadChar15();
    public int TestReadChar16();
    public int TestReadChar19();
    public int TestReadChar21();
    public int TestReadValue_1();
    public int TestReadValue_2();
    public int TestReadValue_3();
    public int TestReadValue_4();
    public int TestReadValue_5();
    public int TestReadValue_6();
    public int TestReadValue_7();
    public int TestReadValue_8();
    public int TestReadValue1();
    public int TestReadValue10();
    public int TestReadValue2();
    public int TestReadValue2Pri0();
    public int TestReadValue3();
    public int TestReadValue3Pri0();
    public int TestReadValue4();
    public int TestReadValue4Pri0();
    public int TestReadValue5();
    public int TestReadValue7();
    public int TestReadValue8();
    public int TestReadValueOnAttribute0();
    public int TestReadValueOnAttribute1();
    public int TestReadValueOnBig();
    public int TestReadValueOnComments0();
    public int TestReadValueOnPIs0();
    public int TestReadValuePri0();
    public int TestReadValuePri0onElement();
    public int TestTextReadValue25();
    public int TestTextReadValue26();
  }
  public abstract class TCResolveEntity : TCXMLReaderBaseGeneral {
    protected TCResolveEntity();
    public override void AddChildren();
    public int TestResolveEntityNodeType_Attribute();
    public int TestResolveEntityNodeType_CDATA();
    public int TestResolveEntityNodeType_Comment();
    public int TestResolveEntityNodeType_Element();
    public int TestResolveEntityNodeType_EndElement();
    public int TestResolveEntityNodeType_EndEntity();
    public int TestResolveEntityNodeType_None();
    public int TestResolveEntityNodeType_ProcessingInstruction();
    public int TestResolveEntityNodeType_Text();
    public int TestResolveEntityNodeType_Whitespace();
    public int TestResolveEntityNodeType_XmlDeclaration();
  }
  public abstract class TCSkip : TCXMLReaderBaseGeneral {
    protected TCSkip();
    public override void AddChildren();
    public int skip307543();
    public int TestSkip1();
    public int TestSkip10();
    public int TestSkip11();
    public int TestSkip12();
    public int TestSkip13();
    public int TestSkip14();
    public int TestSkip15();
    public int TestSkip2();
    public int TestSkip3();
    public int TestSkip4();
    public int TestSkip5();
    public int TestSkip6();
    public int TestSkip7();
    public int TestSkip8();
    public int TestSkip9();
    public int TestTextSkip1();
    public bool VerifySkipOnNodeType(XmlNodeType testNodeType);
    public int XmlTextReaderDoesHandleAmpersands();
  }
  public abstract class TCThisName : TCXMLReaderBaseGeneral {
    protected TCThisName();
    public override void AddChildren();
    public int ThisWithName1();
    public int ThisWithName10();
    public int ThisWithName11();
    public int ThisWithName12();
    public int ThisWithName13();
    public int ThisWithName14();
    public int ThisWithName15();
    public int ThisWithName16();
    public int ThisWithName2();
    public int ThisWithName3();
    public int ThisWithName4();
    public int ThisWithName5();
    public int ThisWithName6();
    public int ThisWithName7();
    public int ThisWithName8();
    public int ThisWithName9();
  }
  public abstract class TCThisOrdinal : TCXMLReaderBaseGeneral {
    protected TCThisOrdinal();
    public override void AddChildren();
    public int FieldCountOrdinal();
    public int NegativeOneOrdinal();
    public int OrdinalMinusOne();
    public int OrdinalPlusOne();
    public int OrdinalWithGetAttrDoubleQ();
    public int OrdinalWithGetAttrSingleQ();
    public int OrdinalWithMoveAttrDoubleQ();
    public int OrdinalWithMoveAttrSingleQ();
  }
  public abstract class TCXMLException : TCXMLReaderBaseGeneral {
    protected TCXMLException();
    public override void AddChildren();
    public int InvalidEncodingCharacterThrowsExceptionWithCorrectLineNumberAndPosition();
    public int ReadingElementWithDuplicateAttributesThrowsException();
    public int ReadingForbiddenXmlNamespaceAliasThrows();
    public int ReadingNonSupportedEncodingDoesntThrow();
    public int ReadingXmlElementWithNameStartingWithNumberThrows();
    public int SourceUri1();
    public int UnexpectedTokenThrowsErrorWithCorrectPositions();
    public int v0();
    public int v1();
    public int v2();
    public int v3();
  }
  public class TCXMLIntegrityBase : CDataReaderTestCase {
    public TCXMLIntegrityBase();
    public EINTEGRITY IntegrityVer { get; set; }
    public override void AddChildren();
    public int AttributeCount();
    public int CloseTest();
    public int GetAttributeEmptyName();
    public int GetAttributeEmptyNameNamespace();
    public int GetAttributeName();
    public int GetAttributeNameNamespace();
    public int GetAttributeOrdinal();
    public virtual int GetBaseURI();
    public int GetDepth();
    public int GetEOF();
    public int GetReadState();
    public int GetXmlLang();
    public int GetXmlReaderLocalName();
    public int GetXmlReaderName();
    public int GetXmlReaderNodeType();
    public int GetXmlReaderValue();
    public int GetXmlSpace();
    public int HasAttribute();
    public int HasValue();
    public int HelperThisName();
    public int HelperThisNameNamespace();
    public int HelperThisOrdinal();
    public int InitReaderPointer();
    public int IsDefault();
    public int IsEmptyElement();
    public int LookupNamespace();
    public int MoveToAttributeName();
    public int MoveToAttributeNameNamespace();
    public int MoveToAttributeOrdinal();
    public int MoveToElement();
    public int MoveToFirstAttribute();
    public int MoveToNextAttribute();
    public int Namespace();
    public int Prefix();
    public int ReadAttributeValue();
    public int ReadInnerXmlTestAfterClose();
    public int ReadTestAfterClose();
    public virtual void ReloadSource();
    public int ResolveEntity();
    public int TestIsStartElement();
    public int TestIsStartElementName();
    public int TestIsStartElementName2();
    public int TestIsStartElementNameNs();
    public int TestIsStartElementNameNs2();
    public int TestMoveToContent();
    public int TestNameTable();
    public int TestReadEndElement();
    public int TestReadOuterXml();
    public int TestReadStartElement();
    public int TestReadStartElementName();
    public int TestReadStartElementName2();
    public int TestReadStartElementNameNs();
    public int TestReadStartElementNameNs2();
    public int XMLSkip();
  }
  public abstract class TCXmlLang : TCXMLReaderBaseGeneral {
    protected TCXmlLang();
    public override void AddChildren();
    public int TestXmlLang1();
    public int TestXmlLang2();
    public int TestXmlLang3();
    public int TestXmlLang4();
    public int TestXmlLang5();
    public int TestXmlLang6();
    public int TestXmlTextReaderLang1();
  }
  public abstract class TCXmlns : TCXMLReaderBaseGeneral {
    protected TCXmlns();
    public override void AddChildren();
    public int TXmlns1();
    public int TXmlns2();
    public int TXmlns3();
    public int TXmlns4();
    public int TXmlns5();
    public int TXmlns6();
  }
  public abstract class TCXmlnsPrefix : TCXMLReaderBaseGeneral {
    protected TCXmlnsPrefix();
    public override void AddChildren();
    public int TXmlnsPrefix1();
    public int TXmlnsPrefix2();
    public int TXmlnsPrefix3();
    public int TXmlnsPrefix4();
    public int TXmlnsPrefix5();
    public int TXmlnsPrefix6();
    public void WriteAttribute(XmlWriter w, bool param, string name, string value);
  }
  public abstract class TCXMLReaderBaseGeneral : CDataReaderTestCase {
    public const int ASCII_ZERO = 48;
    public const string ST_DECIMAL = "#decimal";
    public const string ST_ENT1_ATT_EXPAND_CHAR_ENTITIES = "xxx<xxxAxxxCxxx&e1;xxx";
    public const string ST_ENT1_ATT_EXPAND_CHAR_ENTITIES2 = "xxx&lt;xxxAxxxCxxx&e1;xxx";
    public const string ST_ENT1_ATT_EXPAND_CHAR_ENTITIES3 = "xxx<xxxAxxxCxxx";
    public const string ST_ENT1_ATT_EXPAND_CHAR_ENTITIES4 = "xxx&lt;xxxAxxxCxxxe1fooxxx";
    public const string ST_ENT1_ATT_EXPAND_ENTITIES = "xxx<xxxAxxxCxxxNO_REFERENCEe1;xxx";
    public const string ST_ENT1_ATT_IGNORE_ENTITIES = "xxx&lt;xxx&#65;xxx&#x43;xxx&e1;xxx";
    public const string ST_ENTTEST_NAME = "ENTITY1";
    public const string ST_EXPAND_CHAR_ENTITIES = "xxx>xxxBxxxDxxx";
    public const string ST_EXPAND_ENTITIES = "xxx>xxxBxxxDxxxe1fooxxx";
    public const string ST_EXPAND_ENTITIES2 = "xxx&gt;xxxBxxxDxxxe1fooxxx";
    public const string ST_EXPAND_ENTITIES3 = "xxx&gt;xxxBxxxDxxx&e1;xxx";
    public const string ST_GT = "gt";
    public const string ST_HEXIDECIMAL = "#hexidecimal";
    public const string ST_IGNORE_ENTITIES = "xxx&gt;xxx&#66;xxx&#x44;xxx&e1;xxx";
    public const string ST_LT = "lt";
    public const string ST_TEXT_VALUE = "xxx";
    public static string strAttr;
    public static string strNamespace;
    protected XmlReader MainReader;
    protected TCXMLReaderBaseGeneral();
    public string StrValidation { get; set; }
    public bool CheckCanReadBinaryContent();
    public virtual void CloseReader();
    public void DumpStat();
    protected int FindNodeType(XmlNodeType nodeType);
    protected bool IsBinaryReader();
    protected bool IsCharCheckingReader();
    protected bool IsCoreReader();
    protected bool IsCustomReader();
    protected bool IsFactoryReader();
    protected bool IsFactoryTextReader();
    protected bool IsFactoryValidatingReader();
    protected bool IsRoundTrippedReader();
    protected bool IsSubtreeReader();
    protected bool IsWrappedReader();
    protected bool IsXmlNodeReader();
    protected bool IsXmlNodeReaderDataDoc();
    protected bool IsXmlTextReader();
    protected bool IsXmlValidatingReader();
    protected bool IsXPathNavigatorReader();
    protected bool IsXsltReader();
    protected void PositionOnNodeType(XmlNodeType nodeType);
    public override void PostExecuteVariation(int index, object param);
    public virtual void PostReloadSource();
    public virtual void ReloadSource();
    public virtual void ReloadSource(MyDict<string, object> options);
    public virtual void ReloadSource(Stream stream, string filename);
    public virtual void ReloadSource(StringReader strRdr);
    public virtual void ReloadSource(string filename);
    public virtual void ReloadSource(EREADER_TYPE eReaderType);
    public virtual void ReloadSourceStr(string strxml);
  }
  public abstract class TCXmlSpace : TCXMLReaderBaseGeneral {
    protected TCXmlSpace();
    public override void AddChildren();
    public int TestXmlSpace1();
    public int TestXmlSpace2();
    public int TestXmlSpace3();
    public int TestXmlSpace4();
    public int TestXmlSpace5();
  }
  public class TestFiles {
    public TestFiles();
    public static void CreateBase64TestFile(string strFileName);
    public static void CreateBigElementTestFile(string strFileName);
    public static void CreateBinaryTestFile(string strFileName);
    public static void CreateBinHexTestFile(string strFileName);
    public static void CreateByteTestFile(string strFileName);
    public static void CreateConstructorTestFile(string strFileName);
    public static void CreateEncodedTestFile(string strFileName, Encoding encode);
    public static void CreateGenericTestFile(string strFileName);
    public static void CreateGenericXsltTestFile(string strFileName);
    public static void CreateInvalidDTDTestFile(string strFileName);
    public static void CreateInvalidNamespaceTestFile(string strFileName);
    public static void CreateInvalidXMLXDRTestFile(string strFileName);
    public static void CreateInvWellFormedDTDTestFile(string strFileName);
    public static void CreateJunkTestFile(string strFileName);
    public static void CreateLbNormalizationTestFile(string strFileName);
    public static void CreateLineNumberTestFile(string strFileName);
    public static void CreateNamespaceTestFile(string strFileName);
    public static void CreateNonWellFormedDTDTestFile(string strFileName);
    public static void CreateTestFile(ref string strFileName, EREADER_TYPE eReaderType);
    public static void CreateUTF8EncodedTestFile(string strFileName, Encoding encode);
    public static void CreateValidDTDTestFile(string strFileName);
    public static void CreateWellFormedDTDTestFile(string strFileName);
    public static void CreateWhitespaceHandlingTestFile(string strFileName);
    public static void CreateXDRTestFile(string strFileName);
    public static void CreateXDRXMLTestFile(string strFileName);
    public static void CreateXmlLangTestFile(string strFileName);
    public static void CreateXmlSpaceTestFile(string strFileName);
    public static void CreateXSLTStyleSheetWCopyTestFile(string strFileName);
    protected static void DeleteTestFile(string strFileName);
    public static void ensureSpace(ref byte[] buffer, int len);
    public static string GetTestFileName(EREADER_TYPE eReaderType);
    public static void RemoveDataReader(EREADER_TYPE eReaderType);
    public static void WriteToBuffer(ref byte[] destBuff, ref int len, byte srcByte);
    public static void WriteToBuffer(ref byte[] destBuff, ref int len, byte[] srcBuff);
    public static void WriteToBuffer(ref byte[] destBuff, ref int destStart, byte[] srcBuff, int srcStart, int count);
    public static void WriteToBuffer(ref byte[] destBuffer, ref int destBuffLen, string strValue);
  }
  public class XmlCustomReader : XmlReader {
    public XmlCustomReader(Stream stream, XmlReaderSettings settings, string baseUri);
    public XmlCustomReader(TextReader textReader, XmlReaderSettings settings, string baseUri);
    public XmlCustomReader(string filename, XmlReaderSettings settings);
    public XmlCustomReader(XmlReader reader, XmlReaderSettings settings);
    public override int AttributeCount { get; }
    public override string BaseURI { get; }
    public override bool CanReadBinaryContent { get; }
    public override bool CanReadValueChunk { get; }
    public override bool CanResolveEntity { get; }
    public override int Depth { get; }
    public override bool EOF { get; }
    public override bool HasAttributes { get; }
    public override bool HasValue { get; }
    public bool IsCalled { get; set; }
    public override bool IsDefault { get; }
    public override bool IsEmptyElement { get; }
    public override string LocalName { get; }
    public override string Name { get; }
    public override string NamespaceURI { get; }
    public override XmlNameTable NameTable { get; }
    public override XmlNodeType NodeType { get; }
    public override string Prefix { get; }
    public override ReadState ReadState { get; }
    public override XmlReaderSettings Settings { get; }
    public override string Value { get; }
    public override Type ValueType { get; }
    public override string XmlLang { get; }
    public override XmlSpace XmlSpace { get; }
    public override string GetAttribute(int i);
    public override string GetAttribute(string name);
    public override string GetAttribute(string name, string namespaceURI);
    public override bool IsStartElement();
    public override bool IsStartElement(string localname);
    public override bool IsStartElement(string name, string ns);
    public override string LookupNamespace(string prefix);
    public override void MoveToAttribute(int i);
    public override bool MoveToAttribute(string name);
    public override bool MoveToAttribute(string name, string ns);
    public override XmlNodeType MoveToContent();
    public override bool MoveToElement();
    public override bool MoveToFirstAttribute();
    public override bool MoveToNextAttribute();
    public override bool Read();
    public override bool ReadAttributeValue();
    public override object ReadContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver);
    public override int ReadContentAsBase64(byte[] buffer, int startIndex, int count);
    public override int ReadContentAsBinHex(byte[] buffer, int startIndex, int count);
    public override bool ReadContentAsBoolean();
    public override DateTimeOffset ReadContentAsDateTimeOffset();
    public override decimal ReadContentAsDecimal();
    public override double ReadContentAsDouble();
    public override float ReadContentAsFloat();
    public override int ReadContentAsInt();
    public override long ReadContentAsLong();
    public override object ReadContentAsObject();
    public override string ReadContentAsString();
    public override object ReadElementContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver);
    public override object ReadElementContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver, string localName, string namespaceURI);
    public override int ReadElementContentAsBase64(byte[] buffer, int startIndex, int count);
    public override int ReadElementContentAsBinHex(byte[] buffer, int startIndex, int count);
    public override bool ReadElementContentAsBoolean();
    public override bool ReadElementContentAsBoolean(string localName, string namespaceURI);
    public override decimal ReadElementContentAsDecimal();
    public override decimal ReadElementContentAsDecimal(string localname, string namespaceURI);
    public override double ReadElementContentAsDouble();
    public override double ReadElementContentAsDouble(string localname, string namespaceURI);
    public override float ReadElementContentAsFloat();
    public override float ReadElementContentAsFloat(string localname, string namespaceURI);
    public override int ReadElementContentAsInt();
    public override int ReadElementContentAsInt(string localname, string namespaceURI);
    public override long ReadElementContentAsLong();
    public override long ReadElementContentAsLong(string localname, string namespaceURI);
    public override object ReadElementContentAsObject();
    public override object ReadElementContentAsObject(string localName, string namespaceURI);
    public override string ReadElementContentAsString();
    public override string ReadElementContentAsString(string localname, string namespaceURI);
    public override void ReadEndElement();
    public override string ReadInnerXml();
    public override string ReadOuterXml();
    public override void ReadStartElement();
    public override void ReadStartElement(string name);
    public override void ReadStartElement(string localname, string ns);
    public override XmlReader ReadSubtree();
    public override bool ReadToDescendant(string name);
    public override bool ReadToDescendant(string localName, string namespaceURI);
    public override bool ReadToFollowing(string name);
    public override bool ReadToFollowing(string localName, string namespaceURI);
    public override bool ReadToNextSibling(string name);
    public override bool ReadToNextSibling(string localName, string namespaceURI);
    public override int ReadValueChunk(char[] buffer, int startIndex, int count);
    public override void ResolveEntity();
    public override void Skip();
  }
}
