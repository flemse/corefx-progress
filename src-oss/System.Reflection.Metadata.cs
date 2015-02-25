namespace System.Reflection {
  public enum AssemblyFlags {
    ContentTypeMask = 3584,
    DisableJitCompileOptimizer = 16384,
    EnableJitCompileTracking = 32768,
    PublicKey = 1,
    Retargetable = 256,
    WindowsRuntime = 512,
  }
  public enum AssemblyHashAlgorithm {
    MD5 = 32771,
    None = 0,
    Sha1 = 32772,
    Sha256 = 32780,
    Sha384 = 32781,
    Sha512 = 32782,
  }
  public enum DeclarativeSecurityAction : short {
    Assert = (short)3,
    Demand = (short)2,
    Deny = (short)4,
    InheritanceDemand = (short)7,
    LinkDemand = (short)6,
    None = (short)0,
    PermitOnly = (short)5,
    RequestMinimum = (short)8,
    RequestOptional = (short)9,
    RequestRefuse = (short)10,
  }
  public enum ManifestResourceAttributes {
    Private = 2,
    Public = 1,
    VisibilityMask = 7,
  }
  public enum MethodImportAttributes : short {
    BestFitMappingDisable = (short)32,
    BestFitMappingEnable = (short)16,
    BestFitMappingMask = (short)48,
    CallingConventionCDecl = (short)512,
    CallingConventionFastCall = (short)1280,
    CallingConventionMask = (short)1792,
    CallingConventionStdCall = (short)768,
    CallingConventionThisCall = (short)1024,
    CallingConventionWinApi = (short)256,
    CharSetAnsi = (short)2,
    CharSetAuto = (short)6,
    CharSetMask = (short)6,
    CharSetUnicode = (short)4,
    ExactSpelling = (short)1,
    None = (short)0,
    SetLastError = (short)64,
    ThrowOnUnmappableCharDisable = (short)8192,
    ThrowOnUnmappableCharEnable = (short)4096,
    ThrowOnUnmappableCharMask = (short)12288,
  }
}
namespace System.Reflection.Metadata {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct AssemblyDefinition {
    public StringHandle Culture { get; }
    public AssemblyFlags Flags { get; }
    public AssemblyHashAlgorithm HashAlgorithm { get; }
    public StringHandle Name { get; }
    public BlobHandle PublicKey { get; }
    public Version Version { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
    public DeclarativeSecurityAttributeHandleCollection GetDeclarativeSecurityAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct AssemblyDefinitionHandle : IEquatable<AssemblyDefinitionHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(AssemblyDefinitionHandle other);
    public override int GetHashCode();
    public static bool operator ==(AssemblyDefinitionHandle left, AssemblyDefinitionHandle right);
    public static explicit operator AssemblyDefinitionHandle (Handle handle);
    public static implicit operator Handle (AssemblyDefinitionHandle handle);
    public static bool operator !=(AssemblyDefinitionHandle left, AssemblyDefinitionHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct AssemblyFile {
    public bool ContainsMetadata { get; }
    public BlobHandle HashValue { get; }
    public StringHandle Name { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct AssemblyFileHandle : IEquatable<AssemblyFileHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(AssemblyFileHandle other);
    public override int GetHashCode();
    public static bool operator ==(AssemblyFileHandle left, AssemblyFileHandle right);
    public static explicit operator AssemblyFileHandle (Handle handle);
    public static implicit operator Handle (AssemblyFileHandle handle);
    public static bool operator !=(AssemblyFileHandle left, AssemblyFileHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct AssemblyFileHandleCollection : IEnumerable, IEnumerable<AssemblyFileHandle>, IReadOnlyCollection<AssemblyFileHandle> {
    public int Count { get; }
    public AssemblyFileHandleCollection.Enumerator GetEnumerator();
    IEnumerator<AssemblyFileHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.AssemblyFileHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<AssemblyFileHandle> {
      public AssemblyFileHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct AssemblyReference {
    public StringHandle Culture { get; }
    public AssemblyFlags Flags { get; }
    public BlobHandle HashValue { get; }
    public StringHandle Name { get; }
    public BlobHandle PublicKeyOrToken { get; }
    public Version Version { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct AssemblyReferenceHandle : IEquatable<AssemblyReferenceHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(AssemblyReferenceHandle other);
    public override int GetHashCode();
    public static bool operator ==(AssemblyReferenceHandle left, AssemblyReferenceHandle right);
    public static explicit operator AssemblyReferenceHandle (Handle handle);
    public static implicit operator Handle (AssemblyReferenceHandle handle);
    public static bool operator !=(AssemblyReferenceHandle left, AssemblyReferenceHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct AssemblyReferenceHandleCollection : IEnumerable, IEnumerable<AssemblyReferenceHandle>, IReadOnlyCollection<AssemblyReferenceHandle> {
    public int Count { get; }
    public AssemblyReferenceHandleCollection.Enumerator GetEnumerator();
    IEnumerator<AssemblyReferenceHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.AssemblyReferenceHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<AssemblyReferenceHandle> {
      public AssemblyReferenceHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct BlobHandle : IEquatable<BlobHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(BlobHandle other);
    public override int GetHashCode();
    public static bool operator ==(BlobHandle left, BlobHandle right);
    public static explicit operator BlobHandle (Handle handle);
    public static implicit operator Handle (BlobHandle handle);
    public static bool operator !=(BlobHandle left, BlobHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct BlobReader {
    public unsafe BlobReader(byte* buffer, int length);
    public int Length { get; }
    public int Offset { get; }
    public int RemainingBytes { get; }
    public bool ReadBoolean();
    public byte ReadByte();
    public byte[] ReadBytes(int byteCount);
    public char ReadChar();
    public int ReadCompressedInteger();
    public int ReadCompressedSignedInteger();
    public double ReadDouble();
    public short ReadInt16();
    public int ReadInt32();
    public long ReadInt64();
    public sbyte ReadSByte();
    public SerializationTypeCode ReadSerializationTypeCode();
    public string ReadSerializedString();
    public SignatureHeader ReadSignatureHeader();
    public SignatureTypeCode ReadSignatureTypeCode();
    public float ReadSingle();
    public Handle ReadTypeHandle();
    public ushort ReadUInt16();
    public uint ReadUInt32();
    public ulong ReadUInt64();
    public string ReadUTF16(int byteCount);
    public string ReadUTF8(int byteCount);
    public void Reset();
    public bool TryReadCompressedInteger(out int value);
    public bool TryReadCompressedSignedInteger(out int value);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Constant {
    public Handle Parent { get; }
    public ConstantTypeCode TypeCode { get; }
    public BlobHandle Value { get; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ConstantHandle : IEquatable<ConstantHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(ConstantHandle other);
    public override int GetHashCode();
    public static bool operator ==(ConstantHandle left, ConstantHandle right);
    public static explicit operator ConstantHandle (Handle handle);
    public static implicit operator Handle (ConstantHandle handle);
    public static bool operator !=(ConstantHandle left, ConstantHandle right);
  }
  public enum ConstantTypeCode : byte {
    Boolean = (byte)2,
    Byte = (byte)5,
    Char = (byte)3,
    Double = (byte)13,
    Int16 = (byte)6,
    Int32 = (byte)8,
    Int64 = (byte)10,
    Invalid = (byte)0,
    NullReference = (byte)18,
    SByte = (byte)4,
    Single = (byte)12,
    String = (byte)14,
    UInt16 = (byte)7,
    UInt32 = (byte)9,
    UInt64 = (byte)11,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct CustomAttribute {
    public Handle Constructor { get; }
    public Handle Parent { get; }
    public BlobHandle Value { get; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct CustomAttributeHandle : IEquatable<CustomAttributeHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(CustomAttributeHandle other);
    public override int GetHashCode();
    public static bool operator ==(CustomAttributeHandle left, CustomAttributeHandle right);
    public static explicit operator CustomAttributeHandle (Handle handle);
    public static implicit operator Handle (CustomAttributeHandle handle);
    public static bool operator !=(CustomAttributeHandle left, CustomAttributeHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct CustomAttributeHandleCollection : IEnumerable, IEnumerable<CustomAttributeHandle>, IReadOnlyCollection<CustomAttributeHandle> {
    public int Count { get; }
    public CustomAttributeHandleCollection.Enumerator GetEnumerator();
    IEnumerator<CustomAttributeHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.CustomAttributeHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<CustomAttributeHandle> {
      public CustomAttributeHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  public enum CustomAttributeNamedArgumentKind : byte {
    Field = (byte)83,
    Property = (byte)84,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct DeclarativeSecurityAttribute {
    public DeclarativeSecurityAction Action { get; }
    public Handle Parent { get; }
    public BlobHandle PermissionSet { get; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct DeclarativeSecurityAttributeHandle : IEquatable<DeclarativeSecurityAttributeHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(DeclarativeSecurityAttributeHandle other);
    public override int GetHashCode();
    public static bool operator ==(DeclarativeSecurityAttributeHandle left, DeclarativeSecurityAttributeHandle right);
    public static explicit operator DeclarativeSecurityAttributeHandle (Handle handle);
    public static implicit operator Handle (DeclarativeSecurityAttributeHandle handle);
    public static bool operator !=(DeclarativeSecurityAttributeHandle left, DeclarativeSecurityAttributeHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct DeclarativeSecurityAttributeHandleCollection : IEnumerable, IEnumerable<DeclarativeSecurityAttributeHandle>, IReadOnlyCollection<DeclarativeSecurityAttributeHandle> {
    public int Count { get; }
    public DeclarativeSecurityAttributeHandleCollection.Enumerator GetEnumerator();
    IEnumerator<DeclarativeSecurityAttributeHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.DeclarativeSecurityAttributeHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<DeclarativeSecurityAttributeHandle> {
      public DeclarativeSecurityAttributeHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct EventAccessors {
    public MethodDefinitionHandle Adder { get; }
    public MethodDefinitionHandle Raiser { get; }
    public MethodDefinitionHandle Remover { get; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct EventDefinition {
    public EventAttributes Attributes { get; }
    public StringHandle Name { get; }
    public Handle Type { get; }
    public EventAccessors GetAccessors();
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct EventDefinitionHandle : IEquatable<EventDefinitionHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(EventDefinitionHandle other);
    public override int GetHashCode();
    public static bool operator ==(EventDefinitionHandle left, EventDefinitionHandle right);
    public static explicit operator EventDefinitionHandle (Handle handle);
    public static implicit operator Handle (EventDefinitionHandle handle);
    public static bool operator !=(EventDefinitionHandle left, EventDefinitionHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct EventDefinitionHandleCollection : IEnumerable, IEnumerable<EventDefinitionHandle>, IReadOnlyCollection<EventDefinitionHandle> {
    public int Count { get; }
    public EventDefinitionHandleCollection.Enumerator GetEnumerator();
    IEnumerator<EventDefinitionHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.EventDefinitionHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<EventDefinitionHandle> {
      public EventDefinitionHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ExceptionRegion {
    public Handle CatchType { get; }
    public int FilterOffset { get; }
    public int HandlerLength { get; }
    public int HandlerOffset { get; }
    public ExceptionRegionKind Kind { get; }
    public int TryLength { get; }
    public int TryOffset { get; }
  }
  public enum ExceptionRegionKind : ushort {
    Catch = (ushort)0,
    Fault = (ushort)4,
    Filter = (ushort)1,
    Finally = (ushort)2,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ExportedType {
    public TypeAttributes Attributes { get; }
    public Handle Implementation { get; }
    public bool IsForwarder { get; }
    public StringHandle Name { get; }
    public NamespaceDefinitionHandle Namespace { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ExportedTypeHandle : IEquatable<ExportedTypeHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(ExportedTypeHandle other);
    public override int GetHashCode();
    public static bool operator ==(ExportedTypeHandle left, ExportedTypeHandle right);
    public static explicit operator ExportedTypeHandle (Handle handle);
    public static implicit operator Handle (ExportedTypeHandle handle);
    public static bool operator !=(ExportedTypeHandle left, ExportedTypeHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ExportedTypeHandleCollection : IEnumerable, IEnumerable<ExportedTypeHandle>, IReadOnlyCollection<ExportedTypeHandle> {
    public int Count { get; }
    public ExportedTypeHandleCollection.Enumerator GetEnumerator();
    IEnumerator<ExportedTypeHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.ExportedTypeHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<ExportedTypeHandle> {
      public ExportedTypeHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct FieldDefinition {
    public FieldAttributes Attributes { get; }
    public StringHandle Name { get; }
    public BlobHandle Signature { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
    public TypeDefinitionHandle GetDeclaringType();
    public ConstantHandle GetDefaultValue();
    public BlobHandle GetMarshallingDescriptor();
    public int GetOffset();
    public int GetRelativeVirtualAddress();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct FieldDefinitionHandle : IEquatable<FieldDefinitionHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(FieldDefinitionHandle other);
    public override int GetHashCode();
    public static bool operator ==(FieldDefinitionHandle left, FieldDefinitionHandle right);
    public static explicit operator FieldDefinitionHandle (Handle handle);
    public static implicit operator Handle (FieldDefinitionHandle handle);
    public static bool operator !=(FieldDefinitionHandle left, FieldDefinitionHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct FieldDefinitionHandleCollection : IEnumerable, IEnumerable<FieldDefinitionHandle>, IReadOnlyCollection<FieldDefinitionHandle> {
    public int Count { get; }
    public FieldDefinitionHandleCollection.Enumerator GetEnumerator();
    IEnumerator<FieldDefinitionHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.FieldDefinitionHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<FieldDefinitionHandle> {
      public FieldDefinitionHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct GenericParameter {
    public GenericParameterAttributes Attributes { get; }
    public int Index { get; }
    public StringHandle Name { get; }
    public Handle Parent { get; }
    public GenericParameterConstraintHandleCollection GetConstraints();
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct GenericParameterConstraint {
    public GenericParameterHandle Parameter { get; }
    public Handle Type { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct GenericParameterConstraintHandle : IEquatable<GenericParameterConstraintHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(GenericParameterConstraintHandle other);
    public override int GetHashCode();
    public static bool operator ==(GenericParameterConstraintHandle left, GenericParameterConstraintHandle right);
    public static explicit operator GenericParameterConstraintHandle (Handle handle);
    public static implicit operator Handle (GenericParameterConstraintHandle handle);
    public static bool operator !=(GenericParameterConstraintHandle left, GenericParameterConstraintHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct GenericParameterConstraintHandleCollection : IEnumerable, IEnumerable<GenericParameterConstraintHandle>, IReadOnlyCollection<GenericParameterConstraintHandle>, IReadOnlyList<GenericParameterConstraintHandle> {
    public int Count { get; }
    public GenericParameterConstraintHandle this[int index] { get; }
    public GenericParameterConstraintHandleCollection.Enumerator GetEnumerator();
    IEnumerator<GenericParameterConstraintHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.GenericParameterConstraintHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<GenericParameterConstraintHandle> {
      public GenericParameterConstraintHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct GenericParameterHandle : IEquatable<GenericParameterHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(GenericParameterHandle other);
    public override int GetHashCode();
    public static bool operator ==(GenericParameterHandle left, GenericParameterHandle right);
    public static explicit operator GenericParameterHandle (Handle handle);
    public static implicit operator Handle (GenericParameterHandle handle);
    public static bool operator !=(GenericParameterHandle left, GenericParameterHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct GenericParameterHandleCollection : IEnumerable, IEnumerable<GenericParameterHandle>, IReadOnlyCollection<GenericParameterHandle>, IReadOnlyList<GenericParameterHandle> {
    public int Count { get; }
    public GenericParameterHandle this[int index] { get; }
    public GenericParameterHandleCollection.Enumerator GetEnumerator();
    IEnumerator<GenericParameterHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.GenericParameterHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<GenericParameterHandle> {
      public GenericParameterHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct GuidHandle : IEquatable<GuidHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(GuidHandle other);
    public override int GetHashCode();
    public static bool operator ==(GuidHandle left, GuidHandle right);
    public static explicit operator GuidHandle (Handle handle);
    public static implicit operator Handle (GuidHandle handle);
    public static bool operator !=(GuidHandle left, GuidHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Handle : IEquatable<Handle> {
    public static readonly AssemblyDefinitionHandle AssemblyDefinition;
    public static readonly ModuleDefinitionHandle ModuleDefinition;
    public bool IsNil { get; }
    public HandleKind Kind { get; }
    public override bool Equals(object obj);
    public bool Equals(Handle other);
    public override int GetHashCode();
    public static bool operator ==(Handle left, Handle right);
    public static bool operator !=(Handle left, Handle right);
  }
  public sealed class HandleComparer : IComparer<Handle>, IEqualityComparer<Handle> {
    public static HandleComparer Default { get; }
    public int Compare(Handle x, Handle y);
    public bool Equals(Handle x, Handle y);
    public int GetHashCode(Handle obj);
  }
  public enum HandleKind : byte {
    AssemblyDefinition = (byte)32,
    AssemblyFile = (byte)38,
    AssemblyReference = (byte)35,
    Blob = (byte)113,
    Constant = (byte)11,
    CustomAttribute = (byte)12,
    DeclarativeSecurityAttribute = (byte)14,
    EventDefinition = (byte)20,
    ExportedType = (byte)39,
    FieldDefinition = (byte)4,
    GenericParameter = (byte)42,
    GenericParameterConstraint = (byte)44,
    Guid = (byte)114,
    InterfaceImplementation = (byte)9,
    ManifestResource = (byte)40,
    MemberReference = (byte)10,
    MethodDefinition = (byte)6,
    MethodImplementation = (byte)25,
    MethodSpecification = (byte)43,
    ModuleDefinition = (byte)0,
    ModuleReference = (byte)26,
    NamespaceDefinition = (byte)124,
    Parameter = (byte)8,
    PropertyDefinition = (byte)23,
    StandaloneSignature = (byte)17,
    String = (byte)120,
    TypeDefinition = (byte)2,
    TypeReference = (byte)1,
    TypeSpecification = (byte)27,
    UserString = (byte)112,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct InterfaceImplementation {
    public Handle Interface { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct InterfaceImplementationHandle : IEquatable<InterfaceImplementationHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(InterfaceImplementationHandle other);
    public override int GetHashCode();
    public static bool operator ==(InterfaceImplementationHandle left, InterfaceImplementationHandle right);
    public static explicit operator InterfaceImplementationHandle (Handle handle);
    public static implicit operator Handle (InterfaceImplementationHandle handle);
    public static bool operator !=(InterfaceImplementationHandle left, InterfaceImplementationHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct InterfaceImplementationHandleCollection : IEnumerable, IEnumerable<InterfaceImplementationHandle>, IReadOnlyCollection<InterfaceImplementationHandle> {
    public int Count { get; }
    public InterfaceImplementationHandleCollection.Enumerator GetEnumerator();
    IEnumerator<InterfaceImplementationHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.InterfaceImplementationHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<InterfaceImplementationHandle> {
      public InterfaceImplementationHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ManifestResource {
    public ManifestResourceAttributes Attributes { get; }
    public Handle Implementation { get; }
    public StringHandle Name { get; }
    public long Offset { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ManifestResourceHandle : IEquatable<ManifestResourceHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(ManifestResourceHandle other);
    public override int GetHashCode();
    public static bool operator ==(ManifestResourceHandle left, ManifestResourceHandle right);
    public static explicit operator ManifestResourceHandle (Handle handle);
    public static implicit operator Handle (ManifestResourceHandle handle);
    public static bool operator !=(ManifestResourceHandle left, ManifestResourceHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ManifestResourceHandleCollection : IEnumerable, IEnumerable<ManifestResourceHandle>, IReadOnlyCollection<ManifestResourceHandle> {
    public int Count { get; }
    public ManifestResourceHandleCollection.Enumerator GetEnumerator();
    IEnumerator<ManifestResourceHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.ManifestResourceHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<ManifestResourceHandle> {
      public ManifestResourceHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MemberReference {
    public StringHandle Name { get; }
    public Handle Parent { get; }
    public BlobHandle Signature { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
    public MemberReferenceKind GetKind();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MemberReferenceHandle : IEquatable<MemberReferenceHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(MemberReferenceHandle other);
    public override int GetHashCode();
    public static bool operator ==(MemberReferenceHandle left, MemberReferenceHandle right);
    public static explicit operator MemberReferenceHandle (Handle handle);
    public static implicit operator Handle (MemberReferenceHandle handle);
    public static bool operator !=(MemberReferenceHandle left, MemberReferenceHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MemberReferenceHandleCollection : IEnumerable, IEnumerable<MemberReferenceHandle>, IReadOnlyCollection<MemberReferenceHandle> {
    public int Count { get; }
    public MemberReferenceHandleCollection.Enumerator GetEnumerator();
    IEnumerator<MemberReferenceHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MemberReferenceHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<MemberReferenceHandle> {
      public MemberReferenceHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  public enum MemberReferenceKind {
    Field = 1,
    Method = 0,
  }
  public enum MetadataKind {
    Ecma335 = 0,
    ManagedWindowsMetadata = 2,
    WindowsMetadata = 1,
  }
  public sealed class MetadataReader {
    public unsafe MetadataReader(byte* metadata, int length);
    public unsafe MetadataReader(byte* metadata, int length, MetadataReaderOptions options);
    public unsafe MetadataReader(byte* metadata, int length, MetadataReaderOptions options, MetadataStringDecoder utf8Decoder);
    public AssemblyFileHandleCollection AssemblyFiles { get; }
    public AssemblyReferenceHandleCollection AssemblyReferences { get; }
    public CustomAttributeHandleCollection CustomAttributes { get; }
    public DeclarativeSecurityAttributeHandleCollection DeclarativeSecurityAttributes { get; }
    public EventDefinitionHandleCollection EventDefinitions { get; }
    public ExportedTypeHandleCollection ExportedTypes { get; }
    public FieldDefinitionHandleCollection FieldDefinitions { get; }
    public bool IsAssembly { get; }
    public ManifestResourceHandleCollection ManifestResources { get; }
    public MemberReferenceHandleCollection MemberReferences { get; }
    public MetadataKind MetadataKind { get; }
    public string MetadataVersion { get; }
    public MethodDefinitionHandleCollection MethodDefinitions { get; }
    public MetadataReaderOptions Options { get; }
    public PropertyDefinitionHandleCollection PropertyDefinitions { get; }
    public MetadataStringComparer StringComparer { get; }
    public TypeDefinitionHandleCollection TypeDefinitions { get; }
    public TypeReferenceHandleCollection TypeReferences { get; }
    public AssemblyDefinition GetAssemblyDefinition();
    public AssemblyFile GetAssemblyFile(AssemblyFileHandle handle);
    public AssemblyReference GetAssemblyReference(AssemblyReferenceHandle handle);
    public byte[] GetBlobBytes(BlobHandle handle);
    public ImmutableArray<byte> GetBlobContent(BlobHandle handle);
    public BlobReader GetBlobReader(BlobHandle handle);
    public Constant GetConstant(ConstantHandle handle);
    public CustomAttribute GetCustomAttribute(CustomAttributeHandle handle);
    public CustomAttributeHandleCollection GetCustomAttributes(Handle handle);
    public DeclarativeSecurityAttribute GetDeclarativeSecurityAttribute(DeclarativeSecurityAttributeHandle handle);
    public EventDefinition GetEventDefinition(EventDefinitionHandle handle);
    public ExportedType GetExportedType(ExportedTypeHandle handle);
    public FieldDefinition GetFieldDefinition(FieldDefinitionHandle handle);
    public GenericParameter GetGenericParameter(GenericParameterHandle handle);
    public GenericParameterConstraint GetGenericParameterConstraint(GenericParameterConstraintHandle handle);
    public Guid GetGuid(GuidHandle handle);
    public InterfaceImplementation GetInterfaceImplementation(InterfaceImplementationHandle handle);
    public ManifestResource GetManifestResource(ManifestResourceHandle handle);
    public MemberReference GetMemberReference(MemberReferenceHandle handle);
    public MethodDefinition GetMethodDefinition(MethodDefinitionHandle handle);
    public MethodImplementation GetMethodImplementation(MethodImplementationHandle handle);
    public MethodSpecification GetMethodSpecification(MethodSpecificationHandle handle);
    public ModuleDefinition GetModuleDefinition();
    public ModuleReference GetModuleReference(ModuleReferenceHandle handle);
    public NamespaceDefinition GetNamespaceDefinition(NamespaceDefinitionHandle handle);
    public NamespaceDefinition GetNamespaceDefinitionRoot();
    public Parameter GetParameter(ParameterHandle handle);
    public PropertyDefinition GetPropertyDefinition(PropertyDefinitionHandle handle);
    public StandaloneSignature GetStandaloneSignature(StandaloneSignatureHandle handle);
    public string GetString(NamespaceDefinitionHandle handle);
    public string GetString(StringHandle handle);
    public TypeDefinition GetTypeDefinition(TypeDefinitionHandle handle);
    public TypeReference GetTypeReference(TypeReferenceHandle handle);
    public TypeSpecification GetTypeSpecification(TypeSpecificationHandle handle);
    public string GetUserString(UserStringHandle handle);
  }
  public enum MetadataReaderOptions {
    ApplyWindowsRuntimeProjections = 1,
    Default = 1,
    None = 0,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MetadataStringComparer {
    public bool Equals(NamespaceDefinitionHandle handle, string value);
    public bool Equals(StringHandle handle, string value);
    public bool StartsWith(StringHandle handle, string value);
  }
  public class MetadataStringDecoder {
    public MetadataStringDecoder(Encoding encoding);
    public static MetadataStringDecoder DefaultUTF8 { get; }
    public Encoding Encoding { get; }
    public unsafe virtual string GetString(byte* bytes, int byteCount);
  }
  public sealed class MethodBodyBlock {
    public ImmutableArray<ExceptionRegion> ExceptionRegions { get; }
    public StandaloneSignatureHandle LocalSignature { get; }
    public bool LocalVariablesInitialized { get; }
    public int MaxStack { get; }
    public int Size { get; }
    public static MethodBodyBlock Create(BlobReader reader);
    public byte[] GetILBytes();
    public ImmutableArray<byte> GetILContent();
    public BlobReader GetILReader();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MethodDefinition {
    public MethodAttributes Attributes { get; }
    public MethodImplAttributes ImplAttributes { get; }
    public StringHandle Name { get; }
    public int RelativeVirtualAddress { get; }
    public BlobHandle Signature { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
    public DeclarativeSecurityAttributeHandleCollection GetDeclarativeSecurityAttributes();
    public TypeDefinitionHandle GetDeclaringType();
    public GenericParameterHandleCollection GetGenericParameters();
    public MethodImport GetImport();
    public ParameterHandleCollection GetParameters();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MethodDefinitionHandle : IEquatable<MethodDefinitionHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(MethodDefinitionHandle other);
    public override int GetHashCode();
    public static bool operator ==(MethodDefinitionHandle left, MethodDefinitionHandle right);
    public static explicit operator MethodDefinitionHandle (Handle handle);
    public static implicit operator Handle (MethodDefinitionHandle handle);
    public static bool operator !=(MethodDefinitionHandle left, MethodDefinitionHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MethodDefinitionHandleCollection : IEnumerable, IEnumerable<MethodDefinitionHandle>, IReadOnlyCollection<MethodDefinitionHandle> {
    public int Count { get; }
    public MethodDefinitionHandleCollection.Enumerator GetEnumerator();
    IEnumerator<MethodDefinitionHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MethodDefinitionHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<MethodDefinitionHandle> {
      public MethodDefinitionHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MethodImplementation {
    public Handle MethodBody { get; }
    public Handle MethodDeclaration { get; }
    public TypeDefinitionHandle Type { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MethodImplementationHandle : IEquatable<MethodImplementationHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(MethodImplementationHandle other);
    public override int GetHashCode();
    public static bool operator ==(MethodImplementationHandle left, MethodImplementationHandle right);
    public static explicit operator MethodImplementationHandle (Handle handle);
    public static implicit operator Handle (MethodImplementationHandle handle);
    public static bool operator !=(MethodImplementationHandle left, MethodImplementationHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MethodImplementationHandleCollection : IEnumerable, IEnumerable<MethodImplementationHandle>, IReadOnlyCollection<MethodImplementationHandle> {
    public int Count { get; }
    public MethodImplementationHandleCollection.Enumerator GetEnumerator();
    IEnumerator<MethodImplementationHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MethodImplementationHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<MethodImplementationHandle> {
      public MethodImplementationHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MethodImport {
    public MethodImportAttributes Attributes { get; }
    public ModuleReferenceHandle Module { get; }
    public StringHandle Name { get; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MethodSpecification {
    public Handle Method { get; }
    public BlobHandle Signature { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct MethodSpecificationHandle : IEquatable<MethodSpecificationHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(MethodSpecificationHandle other);
    public override int GetHashCode();
    public static bool operator ==(MethodSpecificationHandle left, MethodSpecificationHandle right);
    public static explicit operator MethodSpecificationHandle (Handle handle);
    public static implicit operator Handle (MethodSpecificationHandle handle);
    public static bool operator !=(MethodSpecificationHandle left, MethodSpecificationHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ModuleDefinition {
    public GuidHandle BaseGenerationId { get; }
    public int Generation { get; }
    public GuidHandle GenerationId { get; }
    public GuidHandle Mvid { get; }
    public StringHandle Name { get; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ModuleDefinitionHandle : IEquatable<ModuleDefinitionHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(ModuleDefinitionHandle other);
    public override int GetHashCode();
    public static bool operator ==(ModuleDefinitionHandle left, ModuleDefinitionHandle right);
    public static explicit operator ModuleDefinitionHandle (Handle handle);
    public static implicit operator Handle (ModuleDefinitionHandle handle);
    public static bool operator !=(ModuleDefinitionHandle left, ModuleDefinitionHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ModuleReference {
    public StringHandle Name { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ModuleReferenceHandle : IEquatable<ModuleReferenceHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(ModuleReferenceHandle other);
    public override int GetHashCode();
    public static bool operator ==(ModuleReferenceHandle left, ModuleReferenceHandle right);
    public static explicit operator ModuleReferenceHandle (Handle handle);
    public static implicit operator Handle (ModuleReferenceHandle handle);
    public static bool operator !=(ModuleReferenceHandle left, ModuleReferenceHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct NamespaceDefinition {
    public ImmutableArray<ExportedTypeHandle> ExportedTypes { get; }
    public StringHandle Name { get; }
    public ImmutableArray<NamespaceDefinitionHandle> NamespaceDefinitions { get; }
    public NamespaceDefinitionHandle Parent { get; }
    public ImmutableArray<TypeDefinitionHandle> TypeDefinitions { get; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct NamespaceDefinitionHandle : IEquatable<NamespaceDefinitionHandle> {
    public bool IsNil { get; }
    public int CompareTo(NamespaceDefinitionHandle other);
    public override bool Equals(object obj);
    public bool Equals(NamespaceDefinitionHandle other);
    public override int GetHashCode();
    public static bool operator ==(NamespaceDefinitionHandle left, NamespaceDefinitionHandle right);
    public static explicit operator NamespaceDefinitionHandle (Handle handle);
    public static implicit operator Handle (NamespaceDefinitionHandle handle);
    public static bool operator !=(NamespaceDefinitionHandle left, NamespaceDefinitionHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Parameter {
    public ParameterAttributes Attributes { get; }
    public StringHandle Name { get; }
    public int SequenceNumber { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
    public ConstantHandle GetDefaultValue();
    public BlobHandle GetMarshallingDescriptor();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ParameterHandle : IEquatable<ParameterHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(ParameterHandle other);
    public override int GetHashCode();
    public static bool operator ==(ParameterHandle left, ParameterHandle right);
    public static explicit operator ParameterHandle (Handle handle);
    public static implicit operator Handle (ParameterHandle handle);
    public static bool operator !=(ParameterHandle left, ParameterHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ParameterHandleCollection : IEnumerable, IEnumerable<ParameterHandle>, IReadOnlyCollection<ParameterHandle> {
    public int Count { get; }
    public ParameterHandleCollection.Enumerator GetEnumerator();
    IEnumerator<ParameterHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.ParameterHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<ParameterHandle> {
      public ParameterHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  public static class PEReaderExtensions {
    public static MetadataReader GetMetadataReader(this PEReader peReader);
    public static MetadataReader GetMetadataReader(this PEReader peReader, MetadataReaderOptions options);
    public static MetadataReader GetMetadataReader(this PEReader peReader, MetadataReaderOptions options, MetadataStringDecoder utf8Decoder);
    public static MethodBodyBlock GetMethodBody(this PEReader peReader, int relativeVirtualAddress);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct PropertyAccessors {
    public MethodDefinitionHandle Getter { get; }
    public MethodDefinitionHandle Setter { get; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct PropertyDefinition {
    public PropertyAttributes Attributes { get; }
    public StringHandle Name { get; }
    public BlobHandle Signature { get; }
    public PropertyAccessors GetAccessors();
    public CustomAttributeHandleCollection GetCustomAttributes();
    public ConstantHandle GetDefaultValue();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct PropertyDefinitionHandle : IEquatable<PropertyDefinitionHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(PropertyDefinitionHandle other);
    public override int GetHashCode();
    public static bool operator ==(PropertyDefinitionHandle left, PropertyDefinitionHandle right);
    public static explicit operator PropertyDefinitionHandle (Handle handle);
    public static implicit operator Handle (PropertyDefinitionHandle handle);
    public static bool operator !=(PropertyDefinitionHandle left, PropertyDefinitionHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct PropertyDefinitionHandleCollection : IEnumerable, IEnumerable<PropertyDefinitionHandle>, IReadOnlyCollection<PropertyDefinitionHandle> {
    public int Count { get; }
    public PropertyDefinitionHandleCollection.Enumerator GetEnumerator();
    IEnumerator<PropertyDefinitionHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.PropertyDefinitionHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<PropertyDefinitionHandle> {
      public PropertyDefinitionHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  public enum SerializationTypeCode : byte {
    Boolean = (byte)2,
    Byte = (byte)5,
    Char = (byte)3,
    Double = (byte)13,
    Enum = (byte)85,
    Int16 = (byte)6,
    Int32 = (byte)8,
    Int64 = (byte)10,
    Invalid = (byte)0,
    SByte = (byte)4,
    Single = (byte)12,
    String = (byte)14,
    SZArray = (byte)29,
    TaggedObject = (byte)81,
    Type = (byte)80,
    UInt16 = (byte)7,
    UInt32 = (byte)9,
    UInt64 = (byte)11,
  }
  public enum SignatureAttributes : byte {
    ExplicitThis = (byte)64,
    Generic = (byte)16,
    Instance = (byte)32,
    None = (byte)0,
  }
  public enum SignatureCallingConvention : byte {
    CDecl = (byte)1,
    Default = (byte)0,
    FastCall = (byte)4,
    StdCall = (byte)2,
    ThisCall = (byte)3,
    VarArgs = (byte)5,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SignatureHeader : IEquatable<SignatureHeader> {
    public const byte CallingConventionOrKindMask = (byte)15;
    public SignatureHeader(byte rawValue);
    public SignatureAttributes Attributes { get; }
    public SignatureCallingConvention CallingConvention { get; }
    public bool HasExplicitThis { get; }
    public bool IsGeneric { get; }
    public bool IsInstance { get; }
    public SignatureKind Kind { get; }
    public byte RawValue { get; }
    public override bool Equals(object obj);
    public bool Equals(SignatureHeader other);
    public override int GetHashCode();
    public static bool operator ==(SignatureHeader left, SignatureHeader right);
    public static bool operator !=(SignatureHeader left, SignatureHeader right);
    public override string ToString();
  }
  public enum SignatureKind : byte {
    Field = (byte)6,
    LocalVariables = (byte)7,
    Method = (byte)0,
    MethodSpecification = (byte)10,
    Property = (byte)8,
  }
  public enum SignatureTypeCode : byte {
    Array = (byte)20,
    Boolean = (byte)2,
    ByReference = (byte)16,
    Byte = (byte)5,
    Char = (byte)3,
    Double = (byte)13,
    FunctionPointer = (byte)27,
    GenericMethodParameter = (byte)30,
    GenericTypeInstance = (byte)21,
    GenericTypeParameter = (byte)19,
    Int16 = (byte)6,
    Int32 = (byte)8,
    Int64 = (byte)10,
    IntPtr = (byte)24,
    Invalid = (byte)0,
    Object = (byte)28,
    OptionalModifier = (byte)32,
    Pinned = (byte)69,
    Pointer = (byte)15,
    RequiredModifier = (byte)31,
    SByte = (byte)4,
    Sentinel = (byte)65,
    Single = (byte)12,
    String = (byte)14,
    SZArray = (byte)29,
    TypedReference = (byte)22,
    TypeHandle = (byte)64,
    UInt16 = (byte)7,
    UInt32 = (byte)9,
    UInt64 = (byte)11,
    UIntPtr = (byte)25,
    Void = (byte)1,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct StandaloneSignature {
    public BlobHandle Signature { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct StandaloneSignatureHandle : IEquatable<StandaloneSignatureHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(StandaloneSignatureHandle other);
    public override int GetHashCode();
    public static bool operator ==(StandaloneSignatureHandle left, StandaloneSignatureHandle right);
    public static explicit operator StandaloneSignatureHandle (Handle handle);
    public static implicit operator Handle (StandaloneSignatureHandle handle);
    public static bool operator !=(StandaloneSignatureHandle left, StandaloneSignatureHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct StringHandle : IEquatable<StringHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(StringHandle other);
    public override int GetHashCode();
    public static bool operator ==(StringHandle left, StringHandle right);
    public static explicit operator StringHandle (Handle handle);
    public static implicit operator Handle (StringHandle handle);
    public static bool operator !=(StringHandle left, StringHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TypeDefinition {
    public TypeAttributes Attributes { get; }
    public Handle BaseType { get; }
    public StringHandle Name { get; }
    public NamespaceDefinitionHandle Namespace { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
    public DeclarativeSecurityAttributeHandleCollection GetDeclarativeSecurityAttributes();
    public TypeDefinitionHandle GetDeclaringType();
    public EventDefinitionHandleCollection GetEvents();
    public FieldDefinitionHandleCollection GetFields();
    public GenericParameterHandleCollection GetGenericParameters();
    public InterfaceImplementationHandleCollection GetInterfaceImplementations();
    public TypeLayout GetLayout();
    public MethodImplementationHandleCollection GetMethodImplementations();
    public MethodDefinitionHandleCollection GetMethods();
    public ImmutableArray<TypeDefinitionHandle> GetNestedTypes();
    public PropertyDefinitionHandleCollection GetProperties();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TypeDefinitionHandle : IEquatable<TypeDefinitionHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(TypeDefinitionHandle other);
    public override int GetHashCode();
    public static bool operator ==(TypeDefinitionHandle left, TypeDefinitionHandle right);
    public static explicit operator TypeDefinitionHandle (Handle handle);
    public static implicit operator Handle (TypeDefinitionHandle handle);
    public static bool operator !=(TypeDefinitionHandle left, TypeDefinitionHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TypeDefinitionHandleCollection : IEnumerable, IEnumerable<TypeDefinitionHandle>, IReadOnlyCollection<TypeDefinitionHandle> {
    public int Count { get; }
    public TypeDefinitionHandleCollection.Enumerator GetEnumerator();
    IEnumerator<TypeDefinitionHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.TypeDefinitionHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TypeDefinitionHandle> {
      public TypeDefinitionHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TypeLayout {
    public TypeLayout(int size, int packingSize);
    public bool IsDefault { get; }
    public int PackingSize { get; }
    public int Size { get; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TypeReference {
    public StringHandle Name { get; }
    public StringHandle Namespace { get; }
    public Handle ResolutionScope { get; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TypeReferenceHandle : IEquatable<TypeReferenceHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(TypeReferenceHandle other);
    public override int GetHashCode();
    public static bool operator ==(TypeReferenceHandle left, TypeReferenceHandle right);
    public static explicit operator TypeReferenceHandle (Handle handle);
    public static implicit operator Handle (TypeReferenceHandle handle);
    public static bool operator !=(TypeReferenceHandle left, TypeReferenceHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TypeReferenceHandleCollection : IEnumerable, IEnumerable<TypeReferenceHandle>, IReadOnlyCollection<TypeReferenceHandle> {
    public int Count { get; }
    public TypeReferenceHandleCollection.Enumerator GetEnumerator();
    IEnumerator<TypeReferenceHandle> System.Collections.Generic.IEnumerable<System.Reflection.Metadata.TypeReferenceHandle>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TypeReferenceHandle> {
      public TypeReferenceHandle Current { get; }
      object System.Collections.IEnumerator.Current { get; }
      public bool MoveNext();
      void System.Collections.IEnumerator.Reset();
      void System.IDisposable.Dispose();
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TypeSpecification {
    public BlobHandle Signature { get; }
    public CustomAttributeHandleCollection GetCustomAttributes();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TypeSpecificationHandle : IEquatable<TypeSpecificationHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(TypeSpecificationHandle other);
    public override int GetHashCode();
    public static bool operator ==(TypeSpecificationHandle left, TypeSpecificationHandle right);
    public static explicit operator TypeSpecificationHandle (Handle handle);
    public static implicit operator Handle (TypeSpecificationHandle handle);
    public static bool operator !=(TypeSpecificationHandle left, TypeSpecificationHandle right);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct UserStringHandle : IEquatable<UserStringHandle> {
    public bool IsNil { get; }
    public override bool Equals(object obj);
    public bool Equals(UserStringHandle other);
    public override int GetHashCode();
    public static bool operator ==(UserStringHandle left, UserStringHandle right);
    public static explicit operator UserStringHandle (Handle handle);
    public static implicit operator Handle (UserStringHandle handle);
    public static bool operator !=(UserStringHandle left, UserStringHandle right);
  }
}
namespace System.Reflection.Metadata.Ecma335 {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct EditAndContinueLogEntry : IEquatable<EditAndContinueLogEntry> {
    public readonly EditAndContinueOperation Operation;
    public readonly Handle Handle;
    public EditAndContinueLogEntry(Handle handle, EditAndContinueOperation operation);
    public override bool Equals(object obj);
    public bool Equals(EditAndContinueLogEntry other);
    public override int GetHashCode();
  }
  public enum EditAndContinueOperation {
    AddEvent = 5,
    AddField = 2,
    AddMethod = 1,
    AddParameter = 3,
    AddProperty = 4,
    Default = 0,
  }
  public static class ExportedTypeExtensions {
    public static int GetTypeDefinitionId(this ExportedType exportedType);
  }
  public enum HeapIndex {
    Blob = 2,
    Guid = 3,
    String = 1,
    UserString = 0,
  }
  public sealed class MetadataAggregator {
    public MetadataAggregator(IReadOnlyList<int> baseTableRowCounts, IReadOnlyList<int> baseHeapSizes, IReadOnlyList<MetadataReader> deltaReaders);
    public MetadataAggregator(MetadataReader baseReader, IReadOnlyList<MetadataReader> deltaReaders);
    public Handle GetGenerationHandle(Handle handle, out int generation);
  }
  public static class MetadataReaderExtensions {
    public static IEnumerable<EditAndContinueLogEntry> GetEditAndContinueLogEntries(this MetadataReader reader);
    public static IEnumerable<Handle> GetEditAndContinueMapEntries(this MetadataReader reader);
    public static int GetHeapMetadataOffset(this MetadataReader reader, HeapIndex heapIndex);
    public static int GetHeapSize(this MetadataReader reader, HeapIndex heapIndex);
    public static BlobHandle GetNextHandle(this MetadataReader reader, BlobHandle handle);
    public static StringHandle GetNextHandle(this MetadataReader reader, StringHandle handle);
    public static UserStringHandle GetNextHandle(this MetadataReader reader, UserStringHandle handle);
    public static int GetTableMetadataOffset(this MetadataReader reader, TableIndex tableIndex);
    public static int GetTableRowCount(this MetadataReader reader, TableIndex tableIndex);
    public static int GetTableRowSize(this MetadataReader reader, TableIndex tableIndex);
    public static IEnumerable<TypeDefinitionHandle> GetTypesWithEvents(this MetadataReader reader);
    public static IEnumerable<TypeDefinitionHandle> GetTypesWithProperties(this MetadataReader reader);
  }
  public static class MetadataTokens {
    public static readonly int HeapCount;
    public static readonly int TableCount;
    public static AssemblyFileHandle AssemblyFileHandle(int rowNumber);
    public static AssemblyReferenceHandle AssemblyReferenceHandle(int rowNumber);
    public static BlobHandle BlobHandle(int offset);
    public static ConstantHandle ConstantHandle(int rowNumber);
    public static CustomAttributeHandle CustomAttributeHandle(int rowNumber);
    public static DeclarativeSecurityAttributeHandle DeclarativeSecurityAttributeHandle(int rowNumber);
    public static EventDefinitionHandle EventDefinitionHandle(int rowNumber);
    public static ExportedTypeHandle ExportedTypeHandle(int rowNumber);
    public static FieldDefinitionHandle FieldDefinitionHandle(int rowNumber);
    public static GenericParameterConstraintHandle GenericParameterConstraintHandle(int rowNumber);
    public static GenericParameterHandle GenericParameterHandle(int rowNumber);
    public static int GetHeapOffset(Handle handle);
    public static int GetHeapOffset(this MetadataReader reader, Handle handle);
    public static int GetRowNumber(Handle handle);
    public static int GetRowNumber(this MetadataReader reader, Handle handle);
    public static int GetToken(Handle handle);
    public static int GetToken(this MetadataReader reader, Handle handle);
    public static GuidHandle GuidHandle(int offset);
    public static Handle Handle(int token);
    public static Handle Handle(TableIndex tableIndex, int rowNumber);
    public static ManifestResourceHandle ManifestResourceHandle(int rowNumber);
    public static MemberReferenceHandle MemberReferenceHandle(int rowNumber);
    public static MethodDefinitionHandle MethodDefinitionHandle(int rowNumber);
    public static MethodImplementationHandle MethodImplementationHandle(int rowNumber);
    public static MethodSpecificationHandle MethodSpecificationHandle(int rowNumber);
    public static ModuleReferenceHandle ModuleReferenceHandle(int rowNumber);
    public static ParameterHandle ParameterHandle(int rowNumber);
    public static PropertyDefinitionHandle PropertyDefinitionHandle(int rowNumber);
    public static StandaloneSignatureHandle StandaloneSignatureHandle(int rowNumber);
    public static StringHandle StringHandle(int offset);
    public static bool TryGetHeapIndex(HandleKind type, out HeapIndex index);
    public static bool TryGetTableIndex(HandleKind type, out TableIndex index);
    public static TypeDefinitionHandle TypeDefinitionHandle(int rowNumber);
    public static TypeReferenceHandle TypeReferenceHandle(int rowNumber);
    public static TypeSpecificationHandle TypeSpecificationHandle(int rowNumber);
    public static UserStringHandle UserStringHandle(int offset);
  }
  public enum TableIndex : byte {
    Assembly = (byte)32,
    AssemblyOS = (byte)34,
    AssemblyProcessor = (byte)33,
    AssemblyRef = (byte)35,
    AssemblyRefOS = (byte)37,
    AssemblyRefProcessor = (byte)36,
    ClassLayout = (byte)15,
    Constant = (byte)11,
    CustomAttribute = (byte)12,
    DeclSecurity = (byte)14,
    EncLog = (byte)30,
    EncMap = (byte)31,
    Event = (byte)20,
    EventMap = (byte)18,
    EventPtr = (byte)19,
    ExportedType = (byte)39,
    Field = (byte)4,
    FieldLayout = (byte)16,
    FieldMarshal = (byte)13,
    FieldPtr = (byte)3,
    FieldRva = (byte)29,
    File = (byte)38,
    GenericParam = (byte)42,
    GenericParamConstraint = (byte)44,
    ImplMap = (byte)28,
    InterfaceImpl = (byte)9,
    ManifestResource = (byte)40,
    MemberRef = (byte)10,
    MethodDef = (byte)6,
    MethodImpl = (byte)25,
    MethodPtr = (byte)5,
    MethodSemantics = (byte)24,
    MethodSpec = (byte)43,
    Module = (byte)0,
    ModuleRef = (byte)26,
    NestedClass = (byte)41,
    Param = (byte)8,
    ParamPtr = (byte)7,
    Property = (byte)23,
    PropertyMap = (byte)21,
    PropertyPtr = (byte)22,
    StandAloneSig = (byte)17,
    TypeDef = (byte)2,
    TypeRef = (byte)1,
    TypeSpec = (byte)27,
  }
}
namespace System.Reflection.PortableExecutable {
  public enum Characteristics : ushort {
    AggressiveWSTrim = (ushort)16,
    Bit32Machine = (ushort)256,
    BytesReversedHi = (ushort)32768,
    BytesReversedLo = (ushort)128,
    DebugStripped = (ushort)512,
    Dll = (ushort)8192,
    ExecutableImage = (ushort)2,
    LargeAddressAware = (ushort)32,
    LineNumsStripped = (ushort)4,
    LocalSymsStripped = (ushort)8,
    NetRunFromSwap = (ushort)2048,
    RelocsStripped = (ushort)1,
    RemovableRunFromSwap = (ushort)1024,
    System = (ushort)4096,
    UpSystemOnly = (ushort)16384,
  }
  public sealed class CoffHeader {
    public Characteristics Characteristics { get; }
    public Machine Machine { get; }
    public short NumberOfSections { get; }
    public int NumberOfSymbols { get; }
    public int PointerToSymbolTable { get; }
    public short SizeOfOptionalHeader { get; }
    public int TimeDateStamp { get; }
  }
  public enum CorFlags {
    ILLibrary = 4,
    ILOnly = 1,
    NativeEntryPoint = 16,
    Prefers32Bit = 131072,
    Requires32Bit = 2,
    StrongNameSigned = 8,
    TrackDebugData = 65536,
  }
  public sealed class CorHeader {
    public DirectoryEntry CodeManagerTableDirectory { get; }
    public int EntryPointTokenOrRelativeVirtualAddress { get; }
    public DirectoryEntry ExportAddressTableJumpsDirectory { get; }
    public CorFlags Flags { get; }
    public ushort MajorRuntimeVersion { get; }
    public DirectoryEntry ManagedNativeHeaderDirectory { get; }
    public DirectoryEntry MetadataDirectory { get; }
    public ushort MinorRuntimeVersion { get; }
    public DirectoryEntry ResourcesDirectory { get; }
    public DirectoryEntry StrongNameSignatureDirectory { get; }
    public DirectoryEntry VtableFixupsDirectory { get; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct DirectoryEntry {
    public readonly int RelativeVirtualAddress;
    public readonly int Size;
  }
  public enum DllCharacteristics : ushort {
    AppContainer = (ushort)4096,
    DynamicBase = (ushort)64,
    NoBind = (ushort)2048,
    NoIsolation = (ushort)512,
    NoSeh = (ushort)1024,
    NxCompatible = (ushort)256,
    ProcessInit = (ushort)1,
    ProcessTerm = (ushort)2,
    TerminalServerAware = (ushort)32768,
    ThreadInit = (ushort)4,
    ThreadTerm = (ushort)8,
    WdmDriver = (ushort)8192,
  }
  public enum Machine : ushort {
    Alpha = (ushort)388,
    Alpha64 = (ushort)644,
    AM33 = (ushort)467,
    Amd64 = (ushort)34404,
    Arm = (ushort)448,
    ArmThumb2 = (ushort)452,
    Ebc = (ushort)3772,
    I386 = (ushort)332,
    IA64 = (ushort)512,
    M32R = (ushort)36929,
    MIPS16 = (ushort)614,
    MipsFpu = (ushort)870,
    MipsFpu16 = (ushort)1126,
    PowerPC = (ushort)496,
    PowerPCFP = (ushort)497,
    SH3 = (ushort)418,
    SH3Dsp = (ushort)419,
    SH3E = (ushort)420,
    SH4 = (ushort)422,
    SH5 = (ushort)424,
    Thumb = (ushort)450,
    Tricore = (ushort)1312,
    Unknown = (ushort)0,
    WceMipsV2 = (ushort)361,
  }
  public sealed class PEHeader {
    public int AddressOfEntryPoint { get; }
    public int BaseOfCode { get; }
    public int BaseOfData { get; }
    public DirectoryEntry BaseRelocationTableDirectory { get; }
    public DirectoryEntry BoundImportTableDirectory { get; }
    public DirectoryEntry CertificateTableDirectory { get; }
    public uint CheckSum { get; }
    public DirectoryEntry CopyrightTableDirectory { get; }
    public DirectoryEntry CorHeaderTableDirectory { get; }
    public DirectoryEntry DebugTableDirectory { get; }
    public DirectoryEntry DelayImportTableDirectory { get; }
    public DllCharacteristics DllCharacteristics { get; }
    public DirectoryEntry ExceptionTableDirectory { get; }
    public DirectoryEntry ExportTableDirectory { get; }
    public int FileAlignment { get; }
    public DirectoryEntry GlobalPointerTableDirectory { get; }
    public ulong ImageBase { get; }
    public DirectoryEntry ImportAddressTableDirectory { get; }
    public DirectoryEntry ImportTableDirectory { get; }
    public DirectoryEntry LoadConfigTableDirectory { get; }
    public PEMagic Magic { get; }
    public ushort MajorImageVersion { get; }
    public byte MajorLinkerVersion { get; }
    public ushort MajorOperatingSystemVersion { get; }
    public ushort MajorSubsystemVersion { get; }
    public ushort MinorImageVersion { get; }
    public byte MinorLinkerVersion { get; }
    public ushort MinorOperatingSystemVersion { get; }
    public ushort MinorSubsystemVersion { get; }
    public int NumberOfRvaAndSizes { get; }
    public DirectoryEntry ResourceTableDirectory { get; }
    public int SectionAlignment { get; }
    public int SizeOfCode { get; }
    public int SizeOfHeaders { get; }
    public ulong SizeOfHeapCommit { get; }
    public ulong SizeOfHeapReserve { get; }
    public int SizeOfImage { get; }
    public int SizeOfInitializedData { get; }
    public ulong SizeOfStackCommit { get; }
    public ulong SizeOfStackReserve { get; }
    public int SizeOfUninitializedData { get; }
    public Subsystem Subsystem { get; }
    public DirectoryEntry ThreadLocalStorageTableDirectory { get; }
  }
  public sealed class PEHeaders {
    public PEHeaders(Stream peStream);
    public PEHeaders(Stream peStream, int size);
    public CoffHeader CoffHeader { get; }
    public int CoffHeaderStartOffset { get; }
    public CorHeader CorHeader { get; }
    public int CorHeaderStartOffset { get; }
    public bool IsCoffOnly { get; }
    public bool IsConsoleApplication { get; }
    public bool IsDll { get; }
    public bool IsExe { get; }
    public int MetadataSize { get; }
    public int MetadataStartOffset { get; }
    public PEHeader PEHeader { get; }
    public int PEHeaderStartOffset { get; }
    public ImmutableArray<SectionHeader> SectionHeaders { get; }
    public int GetContainingSectionIndex(int relativeVirtualAddress);
    public bool TryGetDirectoryOffset(DirectoryEntry directory, out int offset);
  }
  public enum PEMagic : ushort {
    PE32 = (ushort)267,
    PE32Plus = (ushort)523,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct PEMemoryBlock {
    public int Length { get; }
    public unsafe byte* Pointer { get; }
    public ImmutableArray<byte> GetContent();
  }
  public sealed class PEReader : IDisposable {
    public unsafe PEReader(byte* peImage, int size);
    public PEReader(ImmutableArray<byte> peImage);
    public PEReader(Stream peStream);
    public PEReader(Stream peStream, PEStreamOptions options);
    public PEReader(Stream peStream, PEStreamOptions options, int size);
    public bool HasMetadata { get; }
    public bool IsEntireImageAvailable { get; }
    public PEHeaders PEHeaders { get; }
    public void Dispose();
    public PEMemoryBlock GetEntireImage();
    public PEMemoryBlock GetMetadata();
    public PEMemoryBlock GetSectionData(int relativeVirtualAddress);
  }
  public enum PEStreamOptions {
    Default = 0,
    LeaveOpen = 1,
    PrefetchEntireImage = 4,
    PrefetchMetadata = 2,
  }
  public enum SectionCharacteristics : uint {
    Align1024Bytes = (uint)11534336,
    Align128Bytes = (uint)8388608,
    Align16Bytes = (uint)5242880,
    Align1Bytes = (uint)1048576,
    Align2048Bytes = (uint)12582912,
    Align256Bytes = (uint)9437184,
    Align2Bytes = (uint)2097152,
    Align32Bytes = (uint)6291456,
    Align4096Bytes = (uint)13631488,
    Align4Bytes = (uint)3145728,
    Align512Bytes = (uint)10485760,
    Align64Bytes = (uint)7340032,
    Align8192Bytes = (uint)14680064,
    Align8Bytes = (uint)4194304,
    AlignMask = (uint)15728640,
    ContainsCode = (uint)32,
    ContainsInitializedData = (uint)64,
    ContainsUninitializedData = (uint)128,
    GPRel = (uint)32768,
    LinkerComdat = (uint)4096,
    LinkerInfo = (uint)512,
    LinkerNRelocOvfl = (uint)16777216,
    LinkerOther = (uint)256,
    LinkerRemove = (uint)2048,
    Mem16Bit = (uint)131072,
    MemDiscardable = (uint)33554432,
    MemExecute = (uint)536870912,
    MemFardata = (uint)32768,
    MemLocked = (uint)262144,
    MemNotCached = (uint)67108864,
    MemNotPaged = (uint)134217728,
    MemPreload = (uint)524288,
    MemProtected = (uint)16384,
    MemPurgeable = (uint)131072,
    MemRead = (uint)1073741824,
    MemShared = (uint)268435456,
    MemSysheap = (uint)65536,
    MemWrite = (uint)2147483648,
    NoDeferSpecExc = (uint)16384,
    TypeCopy = (uint)16,
    TypeDSect = (uint)1,
    TypeGroup = (uint)4,
    TypeNoLoad = (uint)2,
    TypeNoPad = (uint)8,
    TypeOver = (uint)1024,
    TypeReg = (uint)0,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SectionHeader {
    public string Name { get; }
    public ushort NumberOfLineNumbers { get; }
    public ushort NumberOfRelocations { get; }
    public int PointerToLineNumbers { get; }
    public int PointerToRawData { get; }
    public int PointerToRelocations { get; }
    public SectionCharacteristics SectionCharacteristics { get; }
    public int SizeOfRawData { get; }
    public int VirtualAddress { get; }
    public int VirtualSize { get; }
  }
  public enum Subsystem : ushort {
    EfiApplication = (ushort)10,
    EfiBootServiceDriver = (ushort)11,
    EfiRom = (ushort)13,
    EfiRuntimeDriver = (ushort)12,
    Native = (ushort)1,
    NativeWindows = (ushort)8,
    OS2Cui = (ushort)5,
    PosixCui = (ushort)7,
    Unknown = (ushort)0,
    WindowsCEGui = (ushort)9,
    WindowsCui = (ushort)3,
    WindowsGui = (ushort)2,
    Xbox = (ushort)14,
  }
}
