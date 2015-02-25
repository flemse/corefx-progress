```diff
---lib-full\System.Runtime.InteropServices.dll
+++lib-oss\System.Runtime.InteropServices.dll
-namespace System {
- public sealed class DataMisalignedException : Exception {
-   public DataMisalignedException();
-   public DataMisalignedException(string message);
-   public DataMisalignedException(string message, Exception innerException);
  }
- public class DllNotFoundException : TypeLoadException {
-   public DllNotFoundException();
-   public DllNotFoundException(string message);
-   public DllNotFoundException(string message, Exception inner);
  }
 }
-namespace System.Reflection {
- public sealed class Missing {
-   public static readonly Missing Value;
  }
 }
-namespace System.Runtime.InteropServices {
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ArrayWithOffset {
-   public ArrayWithOffset(object array, int offset);
-   public override bool Equals(object obj);
-   public bool Equals(ArrayWithOffset obj);
-   public object GetArray();
-   public override int GetHashCode();
-   public int GetOffset();
-   public static bool operator ==(ArrayWithOffset a, ArrayWithOffset b);
-   public static bool operator !=(ArrayWithOffset a, ArrayWithOffset b);
  }
- public sealed class BestFitMappingAttribute : Attribute {
-   public bool ThrowOnUnmappableChar;
-   public BestFitMappingAttribute(bool BestFitMapping);
-   public bool BestFitMapping { get; }
  }
- public sealed class BStrWrapper {
-   public BStrWrapper(object value);
-   public BStrWrapper(string value);
-   public string WrappedObject { get; }
  }
- public enum CallingConvention {
-   Cdecl = 2,
-   StdCall = 3,
-   ThisCall = 4,
-   Winapi = 1,
  }
- public sealed class ClassInterfaceAttribute : Attribute {
-   public ClassInterfaceAttribute(short classInterfaceType);
-   public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType);
-   public ClassInterfaceType Value { get; }
  }
- public enum ClassInterfaceType {
-   AutoDispatch = 1,
-   AutoDual = 2,
-   None = 0,
  }
- public sealed class CoClassAttribute : Attribute {
-   public CoClassAttribute(Type coClass);
-   public Type CoClass { get; }
  }
- public class ComAwareEventInfo : EventInfo {
-   public ComAwareEventInfo(Type type, string eventName);
-   public override EventAttributes Attributes { get; }
-   public override Type DeclaringType { get; }
-   public override string Name { get; }
-   public override void AddEventHandler(object target, Delegate handler);
-   public override void RemoveEventHandler(object target, Delegate handler);
  }
- public sealed class ComDefaultInterfaceAttribute : Attribute {
-   public ComDefaultInterfaceAttribute(Type defaultInterface);
-   public Type Value { get; }
  }
- public sealed class ComEventInterfaceAttribute : Attribute {
-   public ComEventInterfaceAttribute(Type SourceInterface, Type EventProvider);
-   public Type EventProvider { get; }
-   public Type SourceInterface { get; }
  }
- public static class ComEventsHelper {
-   public static void Combine(object rcw, Guid iid, int dispid, Delegate d);
-   public static Delegate Remove(object rcw, Guid iid, int dispid, Delegate d);
  }
- public class COMException : Exception {
-   public COMException();
-   public COMException(string message);
-   public COMException(string message, Exception inner);
-   public COMException(string message, int errorCode);
  }
- public sealed class ComImportAttribute : Attribute {
-   public ComImportAttribute();
  }
- public enum ComInterfaceType {
-   InterfaceIsDual = 0,
-   InterfaceIsIDispatch = 2,
-   InterfaceIsIInspectable = 3,
-   InterfaceIsIUnknown = 1,
  }
- public enum ComMemberType {
-   Method = 0,
-   PropGet = 1,
-   PropSet = 2,
  }
- public sealed class ComSourceInterfacesAttribute : Attribute {
-   public ComSourceInterfacesAttribute(string sourceInterfaces);
-   public ComSourceInterfacesAttribute(Type sourceInterface);
-   public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2);
-   public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2, Type sourceInterface3);
-   public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2, Type sourceInterface3, Type sourceInterface4);
-   public string Value { get; }
  }
- public sealed class CurrencyWrapper {
-   public CurrencyWrapper(decimal obj);
-   public CurrencyWrapper(object obj);
-   public decimal WrappedObject { get; }
  }
- public enum CustomQueryInterfaceMode {
-   Allow = 1,
-   Ignore = 0,
  }
- public enum CustomQueryInterfaceResult {
-   Failed = 2,
-   Handled = 0,
-   NotHandled = 1,
  }
- public sealed class DefaultCharSetAttribute : Attribute {
-   public DefaultCharSetAttribute(CharSet charSet);
-   public CharSet CharSet { get; }
  }
- public sealed class DefaultDllImportSearchPathsAttribute : Attribute {
-   public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths);
-   public DllImportSearchPath Paths { get; }
  }
- public sealed class DefaultParameterValueAttribute : Attribute {
-   public DefaultParameterValueAttribute(object value);
-   public object Value { get; }
  }
- public sealed class DispatchWrapper {
-   public DispatchWrapper(object obj);
-   public object WrappedObject { get; }
  }
- public sealed class DispIdAttribute : Attribute {
-   public DispIdAttribute(int dispId);
-   public int Value { get; }
  }
- public sealed class DllImportAttribute : Attribute {
-   public bool BestFitMapping;
-   public bool ExactSpelling;
-   public bool PreserveSig;
-   public bool SetLastError;
-   public bool ThrowOnUnmappableChar;
-   public CallingConvention CallingConvention;
-   public CharSet CharSet;
-   public string EntryPoint;
-   public DllImportAttribute(string dllName);
-   public string Value { get; }
  }
- public enum DllImportSearchPath {
-   ApplicationDirectory = 512,
-   AssemblyDirectory = 2,
-   LegacyBehavior = 0,
-   SafeDirectories = 4096,
-   System32 = 2048,
-   UseDllDirectoryForDependencies = 256,
-   UserDirectories = 1024,
  }
- public sealed class ErrorWrapper {
-   public ErrorWrapper(Exception e);
-   public ErrorWrapper(int errorCode);
-   public ErrorWrapper(object errorCode);
-   public int ErrorCode { get; }
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct GCHandle {
-   public bool IsAllocated { get; }
-   public object Target { get; set; }
-   public IntPtr AddrOfPinnedObject();
-   public static GCHandle Alloc(object value);
-   public static GCHandle Alloc(object value, GCHandleType type);
-   public override bool Equals(object o);
-   public void Free();
-   public static GCHandle FromIntPtr(IntPtr value);
-   public override int GetHashCode();
-   public static bool operator ==(GCHandle a, GCHandle b);
-   public static explicit operator GCHandle (IntPtr value);
-   public static explicit operator IntPtr (GCHandle value);
-   public static bool operator !=(GCHandle a, GCHandle b);
-   public static IntPtr ToIntPtr(GCHandle value);
  }
- public enum GCHandleType {
-   Normal = 2,
-   Pinned = 3,
-   Weak = 0,
-   WeakTrackResurrection = 1,
  }
- public sealed class GuidAttribute : Attribute {
-   public GuidAttribute(string guid);
-   public string Value { get; }
  }
- public sealed class HandleCollector {
-   public HandleCollector(string name, int initialThreshold);
-   public HandleCollector(string name, int initialThreshold, int maximumThreshold);
-   public int Count { get; }
-   public int InitialThreshold { get; }
-   public int MaximumThreshold { get; }
-   public string Name { get; }
-   public void Add();
-   public void Remove();
  }
- public interface ICustomAdapter {
-   object GetUnderlyingObject();
  }
- public interface ICustomQueryInterface {
-   CustomQueryInterfaceResult GetInterface(ref Guid iid, out IntPtr ppv);
  }
- public sealed class InAttribute : Attribute {
-   public InAttribute();
  }
- public sealed class InterfaceTypeAttribute : Attribute {
-   public InterfaceTypeAttribute(short interfaceType);
-   public InterfaceTypeAttribute(ComInterfaceType interfaceType);
-   public ComInterfaceType Value { get; }
  }
- public class InvalidComObjectException : Exception {
-   public InvalidComObjectException();
-   public InvalidComObjectException(string message);
-   public InvalidComObjectException(string message, Exception inner);
  }
- public class InvalidOleVariantTypeException : Exception {
-   public InvalidOleVariantTypeException();
-   public InvalidOleVariantTypeException(string message);
-   public InvalidOleVariantTypeException(string message, Exception inner);
  }
- public static class Marshal {
-   public static readonly int SystemDefaultCharSize;
-   public static readonly int SystemMaxDBCSCharSize;
-   public static int AddRef(IntPtr pUnk);
-   public static IntPtr AllocCoTaskMem(int cb);
-   public static IntPtr AllocHGlobal(int cb);
-   public static IntPtr AllocHGlobal(IntPtr cb);
-   public static bool AreComObjectsAvailableForCleanup();
-   public static void Copy(byte[] source, int startIndex, IntPtr destination, int length);
-   public static void Copy(char[] source, int startIndex, IntPtr destination, int length);
-   public static void Copy(double[] source, int startIndex, IntPtr destination, int length);
-   public static void Copy(short[] source, int startIndex, IntPtr destination, int length);
-   public static void Copy(int[] source, int startIndex, IntPtr destination, int length);
-   public static void Copy(long[] source, int startIndex, IntPtr destination, int length);
-   public static void Copy(IntPtr source, byte[] destination, int startIndex, int length);
-   public static void Copy(IntPtr source, char[] destination, int startIndex, int length);
-   public static void Copy(IntPtr source, double[] destination, int startIndex, int length);
-   public static void Copy(IntPtr source, short[] destination, int startIndex, int length);
-   public static void Copy(IntPtr source, int[] destination, int startIndex, int length);
-   public static void Copy(IntPtr source, long[] destination, int startIndex, int length);
-   public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length);
-   public static void Copy(IntPtr source, float[] destination, int startIndex, int length);
-   public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length);
-   public static void Copy(float[] source, int startIndex, IntPtr destination, int length);
-   public static IntPtr CreateAggregatedObject(IntPtr pOuter, object o);
-   public static IntPtr CreateAggregatedObject<T>(IntPtr pOuter, T o);
-   public static object CreateWrapperOfType(object o, Type t);
-   public static TWrapper CreateWrapperOfType<T, TWrapper>(T o);
-   public static void DestroyStructure(IntPtr ptr, Type structuretype);
-   public static void DestroyStructure<T>(IntPtr ptr);
-   public static int FinalReleaseComObject(object o);
-   public static void FreeBSTR(IntPtr ptr);
-   public static void FreeCoTaskMem(IntPtr ptr);
-   public static void FreeHGlobal(IntPtr hglobal);
-   public static IntPtr GetComInterfaceForObject(object o, Type T);
-   public static IntPtr GetComInterfaceForObject(object o, Type T, CustomQueryInterfaceMode mode);
-   public static IntPtr GetComInterfaceForObject<T, TInterface>(T o);
-   public static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t);
-   public static TDelegate GetDelegateForFunctionPointer<TDelegate>(IntPtr ptr);
-   public static int GetExceptionCode();
-   public static Exception GetExceptionForHR(int errorCode);
-   public static Exception GetExceptionForHR(int errorCode, IntPtr errorInfo);
-   public static IntPtr GetFunctionPointerForDelegate(Delegate d);
-   public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d);
-   public static int GetHRForException(Exception e);
-   public static int GetHRForLastWin32Error();
-   public static IntPtr GetIUnknownForObject(object o);
-   public static int GetLastWin32Error();
-   public static void GetNativeVariantForObject(object obj, IntPtr pDstNativeVariant);
-   public static void GetNativeVariantForObject<T>(T obj, IntPtr pDstNativeVariant);
-   public static object GetObjectForIUnknown(IntPtr pUnk);
-   public static object GetObjectForNativeVariant(IntPtr pSrcNativeVariant);
-   public static T GetObjectForNativeVariant<T>(IntPtr pSrcNativeVariant);
-   public static object[] GetObjectsForNativeVariants(IntPtr aSrcNativeVariant, int cVars);
-   public static T[] GetObjectsForNativeVariants<T>(IntPtr aSrcNativeVariant, int cVars);
-   public static int GetStartComSlot(Type t);
-   public static Type GetTypeFromCLSID(Guid clsid);
-   public static string GetTypeInfoName(ITypeInfo typeInfo);
-   public static object GetUniqueObjectForIUnknown(IntPtr unknown);
-   public static bool IsComObject(object o);
-   public static IntPtr OffsetOf(Type t, string fieldName);
-   public static IntPtr OffsetOf<T>(string fieldName);
-   public static string PtrToStringAnsi(IntPtr ptr);
-   public static string PtrToStringAnsi(IntPtr ptr, int len);
-   public static string PtrToStringBSTR(IntPtr ptr);
-   public static string PtrToStringUni(IntPtr ptr);
-   public static string PtrToStringUni(IntPtr ptr, int len);
-   public static void PtrToStructure(IntPtr ptr, object structure);
-   public static object PtrToStructure(IntPtr ptr, Type structureType);
-   public static T PtrToStructure<T>(IntPtr ptr);
-   public static void PtrToStructure<T>(IntPtr ptr, T structure);
-   public static int QueryInterface(IntPtr pUnk, ref Guid iid, out IntPtr ppv);
-   public static byte ReadByte(IntPtr ptr);
-   public static byte ReadByte(IntPtr ptr, int ofs);
-   public static byte ReadByte(object ptr, int ofs);
-   public static short ReadInt16(IntPtr ptr);
-   public static short ReadInt16(IntPtr ptr, int ofs);
-   public static short ReadInt16(object ptr, int ofs);
-   public static int ReadInt32(IntPtr ptr);
-   public static int ReadInt32(IntPtr ptr, int ofs);
-   public static int ReadInt32(object ptr, int ofs);
-   public static long ReadInt64(IntPtr ptr);
-   public static long ReadInt64(IntPtr ptr, int ofs);
-   public static long ReadInt64(object ptr, int ofs);
-   public static IntPtr ReadIntPtr(IntPtr ptr);
-   public static IntPtr ReadIntPtr(IntPtr ptr, int ofs);
-   public static IntPtr ReadIntPtr(object ptr, int ofs);
-   public static IntPtr ReAllocCoTaskMem(IntPtr pv, int cb);
-   public static IntPtr ReAllocHGlobal(IntPtr pv, IntPtr cb);
-   public static int Release(IntPtr pUnk);
-   public static int ReleaseComObject(object o);
-   public static int SizeOf(object structure);
-   public static int SizeOf(Type t);
-   public static int SizeOf<T>();
-   public static int SizeOf<T>(T structure);
-   public static IntPtr StringToBSTR(string s);
-   public static IntPtr StringToCoTaskMemAnsi(string s);
-   public static IntPtr StringToCoTaskMemUni(string s);
-   public static IntPtr StringToHGlobalAnsi(string s);
-   public static IntPtr StringToHGlobalUni(string s);
-   public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld);
-   public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld);
-   public static void ThrowExceptionForHR(int errorCode);
-   public static void ThrowExceptionForHR(int errorCode, IntPtr errorInfo);
-   public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index);
-   public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index);
-   public static void WriteByte(IntPtr ptr, byte val);
-   public static void WriteByte(IntPtr ptr, int ofs, byte val);
-   public static void WriteByte(object ptr, int ofs, byte val);
-   public static void WriteInt16(IntPtr ptr, char val);
-   public static void WriteInt16(IntPtr ptr, short val);
-   public static void WriteInt16(IntPtr ptr, int ofs, char val);
-   public static void WriteInt16(IntPtr ptr, int ofs, short val);
-   public static void WriteInt16(object ptr, int ofs, char val);
-   public static void WriteInt16(object ptr, int ofs, short val);
-   public static void WriteInt32(IntPtr ptr, int val);
-   public static void WriteInt32(IntPtr ptr, int ofs, int val);
-   public static void WriteInt32(object ptr, int ofs, int val);
-   public static void WriteInt64(IntPtr ptr, int ofs, long val);
-   public static void WriteInt64(IntPtr ptr, long val);
-   public static void WriteInt64(object ptr, int ofs, long val);
-   public static void WriteIntPtr(IntPtr ptr, int ofs, IntPtr val);
-   public static void WriteIntPtr(IntPtr ptr, IntPtr val);
-   public static void WriteIntPtr(object ptr, int ofs, IntPtr val);
-   public static void ZeroFreeBSTR(IntPtr s);
-   public static void ZeroFreeCoTaskMemAnsi(IntPtr s);
-   public static void ZeroFreeCoTaskMemUnicode(IntPtr s);
-   public static void ZeroFreeGlobalAllocAnsi(IntPtr s);
-   public static void ZeroFreeGlobalAllocUnicode(IntPtr s);
  }
- public sealed class MarshalAsAttribute : Attribute {
-   public short SizeParamIndex;
-   public int IidParameterIndex;
-   public int SizeConst;
-   public UnmanagedType ArraySubType;
-   public VarEnum SafeArraySubType;
-   public string MarshalCookie;
-   public string MarshalType;
-   public Type MarshalTypeRef;
-   public Type SafeArrayUserDefinedSubType;
-   public MarshalAsAttribute(short unmanagedType);
-   public MarshalAsAttribute(UnmanagedType unmanagedType);
-   public UnmanagedType Value { get; }
  }
- public class MarshalDirectiveException : Exception {
-   public MarshalDirectiveException();
-   public MarshalDirectiveException(string message);
-   public MarshalDirectiveException(string message, Exception inner);
  }
- public sealed class OptionalAttribute : Attribute {
-   public OptionalAttribute();
  }
- public sealed class PreserveSigAttribute : Attribute {
-   public PreserveSigAttribute();
  }
- public class SafeArrayRankMismatchException : Exception {
-   public SafeArrayRankMismatchException();
-   public SafeArrayRankMismatchException(string message);
-   public SafeArrayRankMismatchException(string message, Exception inner);
  }
- public class SafeArrayTypeMismatchException : Exception {
-   public SafeArrayTypeMismatchException();
-   public SafeArrayTypeMismatchException(string message);
-   public SafeArrayTypeMismatchException(string message, Exception inner);
  }
- public abstract class SafeBuffer : SafeHandle {
-   protected SafeBuffer(bool ownsHandle);
-   public ulong ByteLength { get; }
-   public override bool IsInvalid { get; }
-   public unsafe void AcquirePointer(ref byte* pointer);
-   public void Initialize(uint numElements, uint sizeOfEachElement);
-   public void Initialize(ulong numBytes);
-   public void Initialize<T>(uint numElements) where T : struct;
-   public T Read<T>(ulong byteOffset) where T : struct;
-   public void ReadArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct;
-   public void ReleasePointer();
-   public void Write<T>(ulong byteOffset, T value) where T : struct;
-   public void WriteArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct;
  }
- public class SEHException : Exception {
-   public SEHException();
-   public SEHException(string message);
-   public SEHException(string message, Exception inner);
-   public virtual bool CanResume();
  }
- public sealed class TypeIdentifierAttribute : Attribute {
-   public TypeIdentifierAttribute();
-   public TypeIdentifierAttribute(string scope, string identifier);
-   public string Identifier { get; }
-   public string Scope { get; }
  }
- public sealed class UnknownWrapper {
-   public UnknownWrapper(object obj);
-   public object WrappedObject { get; }
  }
- public sealed class UnmanagedFunctionPointerAttribute : Attribute {
-   public bool BestFitMapping;
-   public bool SetLastError;
-   public bool ThrowOnUnmappableChar;
-   public CharSet CharSet;
-   public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention);
-   public CallingConvention CallingConvention { get; }
  }
- public enum UnmanagedType {
-   AnsiBStr = 35,
-   AsAny = 40,
-   Bool = 2,
-   BStr = 19,
-   ByValArray = 30,
-   ByValTStr = 23,
-   Currency = 15,
-   Error = 45,
-   FunctionPtr = 38,
-   HString = 47,
-   I1 = 3,
-   I2 = 5,
-   I4 = 7,
-   I8 = 9,
-   IDispatch = 26,
-   IInspectable = 46,
-   Interface = 28,
-   IUnknown = 25,
-   LPArray = 42,
-   LPStr = 20,
-   LPStruct = 43,
-   LPTStr = 22,
-   LPWStr = 21,
-   R4 = 11,
-   R8 = 12,
-   SafeArray = 29,
-   Struct = 27,
-   SysInt = 31,
-   SysUInt = 32,
-   TBStr = 36,
-   U1 = 4,
-   U2 = 6,
-   U4 = 8,
-   U8 = 10,
-   VariantBool = 37,
-   VBByRefStr = 34,
  }
- public enum VarEnum {
-   VT_ARRAY = 8192,
-   VT_BLOB = 65,
-   VT_BLOB_OBJECT = 70,
-   VT_BOOL = 11,
-   VT_BSTR = 8,
-   VT_BYREF = 16384,
-   VT_CARRAY = 28,
-   VT_CF = 71,
-   VT_CLSID = 72,
-   VT_CY = 6,
-   VT_DATE = 7,
-   VT_DECIMAL = 14,
-   VT_DISPATCH = 9,
-   VT_EMPTY = 0,
-   VT_ERROR = 10,
-   VT_FILETIME = 64,
-   VT_HRESULT = 25,
-   VT_I1 = 16,
-   VT_I2 = 2,
-   VT_I4 = 3,
-   VT_I8 = 20,
-   VT_INT = 22,
-   VT_LPSTR = 30,
-   VT_LPWSTR = 31,
-   VT_NULL = 1,
-   VT_PTR = 26,
-   VT_R4 = 4,
-   VT_R8 = 5,
-   VT_RECORD = 36,
-   VT_SAFEARRAY = 27,
-   VT_STORAGE = 67,
-   VT_STORED_OBJECT = 69,
-   VT_STREAM = 66,
-   VT_STREAMED_OBJECT = 68,
-   VT_UI1 = 17,
-   VT_UI2 = 18,
-   VT_UI4 = 19,
-   VT_UI8 = 21,
-   VT_UINT = 23,
-   VT_UNKNOWN = 13,
-   VT_USERDEFINED = 29,
-   VT_VARIANT = 12,
-   VT_VECTOR = 4096,
-   VT_VOID = 24,
  }
- public sealed class VariantWrapper {
-   public VariantWrapper(object obj);
-   public object WrappedObject { get; }
  }
 }
-namespace System.Runtime.InteropServices.ComTypes {
- public enum ADVF {
-   ADVF_DATAONSTOP = 64,
-   ADVF_NODATA = 1,
-   ADVF_ONLYONCE = 4,
-   ADVF_PRIMEFIRST = 2,
-   ADVFCACHE_FORCEBUILTIN = 16,
-   ADVFCACHE_NOHANDLER = 8,
-   ADVFCACHE_ONSAVE = 32,
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct BIND_OPTS {
-   public int cbStruct;
-   public int dwTickCountDeadline;
-   public int grfFlags;
-   public int grfMode;
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
  public struct BINDPTR {
-   [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
    public IntPtr lpfuncdesc;
-   [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
    public IntPtr lptcomp;
-   [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
    public IntPtr lpvardesc;
  }
- public enum CALLCONV {
-   CC_CDECL = 1,
-   CC_MACPASCAL = 3,
-   CC_MAX = 9,
-   CC_MPWCDECL = 7,
-   CC_MPWPASCAL = 8,
-   CC_MSCPASCAL = 2,
-   CC_PASCAL = 2,
-   CC_RESERVED = 5,
-   CC_STDCALL = 4,
-   CC_SYSCALL = 6,
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct CONNECTDATA {
-   public int dwCookie;
-   public object pUnk;
  }
- public enum DATADIR {
-   DATADIR_GET = 1,
-   DATADIR_SET = 2,
  }
- public enum DESCKIND {
-   DESCKIND_FUNCDESC = 1,
-   DESCKIND_IMPLICITAPPOBJ = 4,
-   DESCKIND_MAX = 5,
-   DESCKIND_NONE = 0,
-   DESCKIND_TYPECOMP = 3,
-   DESCKIND_VARDESC = 2,
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct DISPPARAMS {
-   public int cArgs;
-   public int cNamedArgs;
-   public IntPtr rgdispidNamedArgs;
-   public IntPtr rgvarg;
  }
- public enum DVASPECT {
-   DVASPECT_CONTENT = 1,
-   DVASPECT_DOCPRINT = 8,
-   DVASPECT_ICON = 4,
-   DVASPECT_THUMBNAIL = 2,
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ELEMDESC {
-   public ELEMDESC.DESCUNION desc;
-   public TYPEDESC tdesc;
-   [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct DESCUNION {
-     [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
      public IDLDESC idldesc;
-     [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
      public PARAMDESC paramdesc;
    }
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct EXCEPINFO {
-   public short wCode;
-   public short wReserved;
-   public int dwHelpContext;
-   public int scode;
-   public IntPtr pfnDeferredFillIn;
-   public IntPtr pvReserved;
-   public string bstrDescription;
-   public string bstrHelpFile;
-   public string bstrSource;
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct FILETIME {
-   public int dwHighDateTime;
-   public int dwLowDateTime;
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct FORMATETC {
-   public short cfFormat;
-   public int lindex;
-   public IntPtr ptd;
-   public DVASPECT dwAspect;
-   public TYMED tymed;
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct FUNCDESC {
-   public short cParams;
-   public short cParamsOpt;
-   public short cScodes;
-   public short oVft;
-   public short wFuncFlags;
-   public int memid;
-   public IntPtr lprgelemdescParam;
-   public IntPtr lprgscode;
-   public CALLCONV callconv;
-   public ELEMDESC elemdescFunc;
-   public FUNCKIND funckind;
-   public INVOKEKIND invkind;
  }
- public enum FUNCFLAGS : short {
-   FUNCFLAG_FBINDABLE = (short)4,
-   FUNCFLAG_FDEFAULTBIND = (short)32,
-   FUNCFLAG_FDEFAULTCOLLELEM = (short)256,
-   FUNCFLAG_FDISPLAYBIND = (short)16,
-   FUNCFLAG_FHIDDEN = (short)64,
-   FUNCFLAG_FIMMEDIATEBIND = (short)4096,
-   FUNCFLAG_FNONBROWSABLE = (short)1024,
-   FUNCFLAG_FREPLACEABLE = (short)2048,
-   FUNCFLAG_FREQUESTEDIT = (short)8,
-   FUNCFLAG_FRESTRICTED = (short)1,
-   FUNCFLAG_FSOURCE = (short)2,
-   FUNCFLAG_FUIDEFAULT = (short)512,
-   FUNCFLAG_FUSESGETLASTERROR = (short)128,
  }
- public enum FUNCKIND {
-   FUNC_DISPATCH = 4,
-   FUNC_NONVIRTUAL = 2,
-   FUNC_PUREVIRTUAL = 1,
-   FUNC_STATIC = 3,
-   FUNC_VIRTUAL = 0,
  }
- public interface IAdviseSink {
-   void OnClose();
-   void OnDataChange(ref FORMATETC format, ref STGMEDIUM stgmedium);
-   void OnRename(IMoniker moniker);
-   void OnSave();
-   void OnViewChange(int aspect, int index);
  }
- public interface IBindCtx {
-   void EnumObjectParam(out IEnumString ppenum);
-   void GetBindOptions(ref BIND_OPTS pbindopts);
-   void GetObjectParam(string pszKey, out object ppunk);
-   void GetRunningObjectTable(out IRunningObjectTable pprot);
-   void RegisterObjectBound(object punk);
-   void RegisterObjectParam(string pszKey, object punk);
-   void ReleaseBoundObjects();
-   void RevokeObjectBound(object punk);
-   int RevokeObjectParam(string pszKey);
-   void SetBindOptions(ref BIND_OPTS pbindopts);
  }
- public interface IConnectionPoint {
-   void Advise(object pUnkSink, out int pdwCookie);
-   void EnumConnections(out IEnumConnections ppEnum);
-   void GetConnectionInterface(out Guid pIID);
-   void GetConnectionPointContainer(out IConnectionPointContainer ppCPC);
-   void Unadvise(int dwCookie);
  }
- public interface IConnectionPointContainer {
-   void EnumConnectionPoints(out IEnumConnectionPoints ppEnum);
-   void FindConnectionPoint(ref Guid riid, out IConnectionPoint ppCP);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct IDLDESC {
-   public IntPtr dwReserved;
-   public IDLFLAG wIDLFlags;
  }
- public enum IDLFLAG : short {
-   IDLFLAG_FIN = (short)1,
-   IDLFLAG_FLCID = (short)4,
-   IDLFLAG_FOUT = (short)2,
-   IDLFLAG_FRETVAL = (short)8,
-   IDLFLAG_NONE = (short)0,
  }
- public interface IEnumConnectionPoints {
-   void Clone(out IEnumConnectionPoints ppenum);
-   int Next(int celt, IConnectionPoint[] rgelt, IntPtr pceltFetched);
-   void Reset();
-   int Skip(int celt);
  }
- public interface IEnumConnections {
-   void Clone(out IEnumConnections ppenum);
-   int Next(int celt, CONNECTDATA[] rgelt, IntPtr pceltFetched);
-   void Reset();
-   int Skip(int celt);
  }
- public interface IEnumFORMATETC {
-   void Clone(out IEnumFORMATETC newEnum);
-   int Next(int celt, FORMATETC[] rgelt, int[] pceltFetched);
-   int Reset();
-   int Skip(int celt);
  }
- public interface IEnumMoniker {
-   void Clone(out IEnumMoniker ppenum);
-   int Next(int celt, IMoniker[] rgelt, IntPtr pceltFetched);
-   void Reset();
-   int Skip(int celt);
  }
- public interface IEnumString {
-   void Clone(out IEnumString ppenum);
-   int Next(int celt, string[] rgelt, IntPtr pceltFetched);
-   void Reset();
-   int Skip(int celt);
  }
- public interface IEnumVARIANT {
-   IEnumVARIANT Clone();
-   int Next(int celt, object[] rgVar, IntPtr pceltFetched);
-   int Reset();
-   int Skip(int celt);
  }
- public interface IMoniker {
-   void BindToObject(IBindCtx pbc, IMoniker pmkToLeft, ref Guid riidResult, out object ppvResult);
-   void BindToStorage(IBindCtx pbc, IMoniker pmkToLeft, ref Guid riid, out object ppvObj);
-   void CommonPrefixWith(IMoniker pmkOther, out IMoniker ppmkPrefix);
-   void ComposeWith(IMoniker pmkRight, bool fOnlyIfNotGeneric, out IMoniker ppmkComposite);
-   void Enum(bool fForward, out IEnumMoniker ppenumMoniker);
-   void GetClassID(out Guid pClassID);
-   void GetDisplayName(IBindCtx pbc, IMoniker pmkToLeft, out string ppszDisplayName);
-   void GetSizeMax(out long pcbSize);
-   void GetTimeOfLastChange(IBindCtx pbc, IMoniker pmkToLeft, out FILETIME pFileTime);
-   void Hash(out int pdwHash);
-   void Inverse(out IMoniker ppmk);
-   int IsDirty();
-   int IsEqual(IMoniker pmkOtherMoniker);
-   int IsRunning(IBindCtx pbc, IMoniker pmkToLeft, IMoniker pmkNewlyRunning);
-   int IsSystemMoniker(out int pdwMksys);
-   void Load(IStream pStm);
-   void ParseDisplayName(IBindCtx pbc, IMoniker pmkToLeft, string pszDisplayName, out int pchEaten, out IMoniker ppmkOut);
-   void Reduce(IBindCtx pbc, int dwReduceHowFar, ref IMoniker ppmkToLeft, out IMoniker ppmkReduced);
-   void RelativePathTo(IMoniker pmkOther, out IMoniker ppmkRelPath);
-   void Save(IStream pStm, bool fClearDirty);
  }
- public enum IMPLTYPEFLAGS {
-   IMPLTYPEFLAG_FDEFAULT = 1,
-   IMPLTYPEFLAG_FDEFAULTVTABLE = 8,
-   IMPLTYPEFLAG_FRESTRICTED = 4,
-   IMPLTYPEFLAG_FSOURCE = 2,
  }
- public enum INVOKEKIND {
-   INVOKE_FUNC = 1,
-   INVOKE_PROPERTYGET = 2,
-   INVOKE_PROPERTYPUT = 4,
-   INVOKE_PROPERTYPUTREF = 8,
  }
- public interface IPersistFile {
-   void GetClassID(out Guid pClassID);
-   void GetCurFile(out string ppszFileName);
-   int IsDirty();
-   void Load(string pszFileName, int dwMode);
-   void Save(string pszFileName, bool fRemember);
-   void SaveCompleted(string pszFileName);
  }
- public interface IRunningObjectTable {
-   void EnumRunning(out IEnumMoniker ppenumMoniker);
-   int GetObject(IMoniker pmkObjectName, out object ppunkObject);
-   int GetTimeOfLastChange(IMoniker pmkObjectName, out FILETIME pfiletime);
-   int IsRunning(IMoniker pmkObjectName);
-   void NoteChangeTime(int dwRegister, ref FILETIME pfiletime);
-   int Register(int grfFlags, object punkObject, IMoniker pmkObjectName);
-   void Revoke(int dwRegister);
  }
- public interface IStream {
-   void Clone(out IStream ppstm);
-   void Commit(int grfCommitFlags);
-   void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten);
-   void LockRegion(long libOffset, long cb, int dwLockType);
-   void Read(byte[] pv, int cb, IntPtr pcbRead);
-   void Revert();
-   void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition);
-   void SetSize(long libNewSize);
-   void Stat(out STATSTG pstatstg, int grfStatFlag);
-   void UnlockRegion(long libOffset, long cb, int dwLockType);
-   void Write(byte[] pv, int cb, IntPtr pcbWritten);
  }
- public interface ITypeComp {
-   void Bind(string szName, int lHashVal, short wFlags, out ITypeInfo ppTInfo, out DESCKIND pDescKind, out BINDPTR pBindPtr);
-   void BindType(string szName, int lHashVal, out ITypeInfo ppTInfo, out ITypeComp ppTComp);
  }
- public interface ITypeInfo {
-   void AddressOfMember(int memid, INVOKEKIND invKind, out IntPtr ppv);
-   void CreateInstance(object pUnkOuter, ref Guid riid, out object ppvObj);
-   void GetContainingTypeLib(out ITypeLib ppTLB, out int pIndex);
-   void GetDllEntry(int memid, INVOKEKIND invKind, IntPtr pBstrDllName, IntPtr pBstrName, IntPtr pwOrdinal);
-   void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
-   void GetFuncDesc(int index, out IntPtr ppFuncDesc);
-   void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
-   void GetImplTypeFlags(int index, out IMPLTYPEFLAGS pImplTypeFlags);
-   void GetMops(int memid, out string pBstrMops);
-   void GetNames(int memid, string[] rgBstrNames, int cMaxNames, out int pcNames);
-   void GetRefTypeInfo(int hRef, out ITypeInfo ppTI);
-   void GetRefTypeOfImplType(int index, out int href);
-   void GetTypeAttr(out IntPtr ppTypeAttr);
-   void GetTypeComp(out ITypeComp ppTComp);
-   void GetVarDesc(int index, out IntPtr ppVarDesc);
-   void Invoke(object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, out int puArgErr);
-   void ReleaseFuncDesc(IntPtr pFuncDesc);
-   void ReleaseTypeAttr(IntPtr pTypeAttr);
-   void ReleaseVarDesc(IntPtr pVarDesc);
  }
- public interface ITypeInfo2 : ITypeInfo {
-   new void AddressOfMember(int memid, INVOKEKIND invKind, out IntPtr ppv);
-   new void CreateInstance(object pUnkOuter, ref Guid riid, out object ppvObj);
-   void GetAllCustData(IntPtr pCustData);
-   void GetAllFuncCustData(int index, IntPtr pCustData);
-   void GetAllImplTypeCustData(int index, IntPtr pCustData);
-   void GetAllParamCustData(int indexFunc, int indexParam, IntPtr pCustData);
-   void GetAllVarCustData(int index, IntPtr pCustData);
-   new void GetContainingTypeLib(out ITypeLib ppTLB, out int pIndex);
-   void GetCustData(ref Guid guid, out object pVarVal);
-   new void GetDllEntry(int memid, INVOKEKIND invKind, IntPtr pBstrDllName, IntPtr pBstrName, IntPtr pwOrdinal);
-   new void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
-   void GetDocumentation2(int memid, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);
-   void GetFuncCustData(int index, ref Guid guid, out object pVarVal);
-   new void GetFuncDesc(int index, out IntPtr ppFuncDesc);
-   void GetFuncIndexOfMemId(int memid, INVOKEKIND invKind, out int pFuncIndex);
-   new void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
-   void GetImplTypeCustData(int index, ref Guid guid, out object pVarVal);
-   new void GetImplTypeFlags(int index, out IMPLTYPEFLAGS pImplTypeFlags);
-   new void GetMops(int memid, out string pBstrMops);
-   new void GetNames(int memid, string[] rgBstrNames, int cMaxNames, out int pcNames);
-   void GetParamCustData(int indexFunc, int indexParam, ref Guid guid, out object pVarVal);
-   new void GetRefTypeInfo(int hRef, out ITypeInfo ppTI);
-   new void GetRefTypeOfImplType(int index, out int href);
-   new void GetTypeAttr(out IntPtr ppTypeAttr);
-   new void GetTypeComp(out ITypeComp ppTComp);
-   void GetTypeFlags(out int pTypeFlags);
-   void GetTypeKind(out TYPEKIND pTypeKind);
-   void GetVarCustData(int index, ref Guid guid, out object pVarVal);
-   new void GetVarDesc(int index, out IntPtr ppVarDesc);
-   void GetVarIndexOfMemId(int memid, out int pVarIndex);
-   new void Invoke(object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, out int puArgErr);
-   new void ReleaseFuncDesc(IntPtr pFuncDesc);
-   new void ReleaseTypeAttr(IntPtr pTypeAttr);
-   new void ReleaseVarDesc(IntPtr pVarDesc);
  }
- public interface ITypeLib {
-   void FindName(string szNameBuf, int lHashVal, ITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
-   void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
-   void GetLibAttr(out IntPtr ppTLibAttr);
-   void GetTypeComp(out ITypeComp ppTComp);
-   void GetTypeInfo(int index, out ITypeInfo ppTI);
-   int GetTypeInfoCount();
-   void GetTypeInfoOfGuid(ref Guid guid, out ITypeInfo ppTInfo);
-   void GetTypeInfoType(int index, out TYPEKIND pTKind);
-   bool IsName(string szNameBuf, int lHashVal);
-   void ReleaseTLibAttr(IntPtr pTLibAttr);
  }
- public interface ITypeLib2 : ITypeLib {
-   new void FindName(string szNameBuf, int lHashVal, ITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
-   void GetAllCustData(IntPtr pCustData);
-   void GetCustData(ref Guid guid, out object pVarVal);
-   new void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
-   void GetDocumentation2(int index, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);
-   new void GetLibAttr(out IntPtr ppTLibAttr);
-   void GetLibStatistics(IntPtr pcUniqueNames, out int pcchUniqueNames);
-   new void GetTypeComp(out ITypeComp ppTComp);
-   new void GetTypeInfo(int index, out ITypeInfo ppTI);
-   new int GetTypeInfoCount();
-   new void GetTypeInfoOfGuid(ref Guid guid, out ITypeInfo ppTInfo);
-   new void GetTypeInfoType(int index, out TYPEKIND pTKind);
-   new bool IsName(string szNameBuf, int lHashVal);
-   new void ReleaseTLibAttr(IntPtr pTLibAttr);
  }
- public enum LIBFLAGS : short {
-   LIBFLAG_FCONTROL = (short)2,
-   LIBFLAG_FHASDISKIMAGE = (short)8,
-   LIBFLAG_FHIDDEN = (short)4,
-   LIBFLAG_FRESTRICTED = (short)1,
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct PARAMDESC {
-   public IntPtr lpVarValue;
-   public PARAMFLAG wParamFlags;
  }
- public enum PARAMFLAG : short {
-   PARAMFLAG_FHASCUSTDATA = (short)64,
-   PARAMFLAG_FHASDEFAULT = (short)32,
-   PARAMFLAG_FIN = (short)1,
-   PARAMFLAG_FLCID = (short)4,
-   PARAMFLAG_FOPT = (short)16,
-   PARAMFLAG_FOUT = (short)2,
-   PARAMFLAG_FRETVAL = (short)8,
-   PARAMFLAG_NONE = (short)0,
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct STATDATA {
-   public int connection;
-   public ADVF advf;
-   public FORMATETC formatetc;
-   public IAdviseSink advSink;
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct STATSTG {
-   public Guid clsid;
-   public int grfLocksSupported;
-   public int grfMode;
-   public int grfStateBits;
-   public int reserved;
-   public int type;
-   public long cbSize;
-   public FILETIME atime;
-   public FILETIME ctime;
-   public FILETIME mtime;
-   public string pwcsName;
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct STGMEDIUM {
-   public IntPtr unionmember;
-   public object pUnkForRelease;
-   public TYMED tymed;
  }
- public enum SYSKIND {
-   SYS_MAC = 2,
-   SYS_WIN16 = 0,
-   SYS_WIN32 = 1,
-   SYS_WIN64 = 3,
  }
- public enum TYMED {
-   TYMED_ENHMF = 64,
-   TYMED_FILE = 2,
-   TYMED_GDI = 16,
-   TYMED_HGLOBAL = 1,
-   TYMED_ISTORAGE = 8,
-   TYMED_ISTREAM = 4,
-   TYMED_MFPICT = 32,
-   TYMED_NULL = 0,
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TYPEATTR {
-   public Guid guid;
-   public short cbAlignment;
-   public short cbSizeVft;
-   public short cFuncs;
-   public short cImplTypes;
-   public short cVars;
-   public short wMajorVerNum;
-   public short wMinorVerNum;
-   public int cbSizeInstance;
-   public int dwReserved;
-   public int lcid;
-   public const int MEMBER_ID_NIL = -1;
-   public int memidConstructor;
-   public int memidDestructor;
-   public IntPtr lpstrSchema;
-   public IDLDESC idldescType;
-   public TYPEDESC tdescAlias;
-   public TYPEFLAGS wTypeFlags;
-   public TYPEKIND typekind;
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TYPEDESC {
-   public short vt;
-   public IntPtr lpValue;
  }
- public enum TYPEFLAGS : short {
-   TYPEFLAG_FAGGREGATABLE = (short)1024,
-   TYPEFLAG_FAPPOBJECT = (short)1,
-   TYPEFLAG_FCANCREATE = (short)2,
-   TYPEFLAG_FCONTROL = (short)32,
-   TYPEFLAG_FDISPATCHABLE = (short)4096,
-   TYPEFLAG_FDUAL = (short)64,
-   TYPEFLAG_FHIDDEN = (short)16,
-   TYPEFLAG_FLICENSED = (short)4,
-   TYPEFLAG_FNONEXTENSIBLE = (short)128,
-   TYPEFLAG_FOLEAUTOMATION = (short)256,
-   TYPEFLAG_FPREDECLID = (short)8,
-   TYPEFLAG_FPROXY = (short)16384,
-   TYPEFLAG_FREPLACEABLE = (short)2048,
-   TYPEFLAG_FRESTRICTED = (short)512,
-   TYPEFLAG_FREVERSEBIND = (short)8192,
  }
- public enum TYPEKIND {
-   TKIND_ALIAS = 6,
-   TKIND_COCLASS = 5,
-   TKIND_DISPATCH = 4,
-   TKIND_ENUM = 0,
-   TKIND_INTERFACE = 3,
-   TKIND_MAX = 8,
-   TKIND_MODULE = 2,
-   TKIND_RECORD = 1,
-   TKIND_UNION = 7,
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TYPELIBATTR {
-   public Guid guid;
-   public short wMajorVerNum;
-   public short wMinorVerNum;
-   public int lcid;
-   public LIBFLAGS wLibFlags;
-   public SYSKIND syskind;
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct VARDESC {
-   public VARDESC.DESCUNION desc;
-   public short wVarFlags;
-   public int memid;
-   public ELEMDESC elemdescVar;
-   public VARKIND varkind;
-   public string lpstrSchema;
-   [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct DESCUNION {
-     [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
      public int oInst;
-     [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
      public IntPtr lpvarValue;
    }
  }
- public enum VARFLAGS : short {
-   VARFLAG_FBINDABLE = (short)4,
-   VARFLAG_FDEFAULTBIND = (short)32,
-   VARFLAG_FDEFAULTCOLLELEM = (short)256,
-   VARFLAG_FDISPLAYBIND = (short)16,
-   VARFLAG_FHIDDEN = (short)64,
-   VARFLAG_FIMMEDIATEBIND = (short)4096,
-   VARFLAG_FNONBROWSABLE = (short)1024,
-   VARFLAG_FREADONLY = (short)1,
-   VARFLAG_FREPLACEABLE = (short)2048,
-   VARFLAG_FREQUESTEDIT = (short)8,
-   VARFLAG_FRESTRICTED = (short)128,
-   VARFLAG_FSOURCE = (short)2,
-   VARFLAG_FUIDEFAULT = (short)512,
  }
- public enum VARKIND {
-   VAR_CONST = 2,
-   VAR_DISPATCH = 3,
-   VAR_PERINSTANCE = 0,
-   VAR_STATIC = 1,
  }
 }
```
