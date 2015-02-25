```diff
---lib-full\System.Runtime.dll
+++lib-oss\System.Runtime.dll
-namespace System {
- public delegate void Action();
- public delegate void Action<in T>(T obj);
- public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
- public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
- public delegate void Action<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
- public delegate void Action<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
- public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
- public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
- public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
- public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
- public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
- public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
- public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
- public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
- public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
- public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
- public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
- public static class Activator {
-   public static object CreateInstance(Type type);
-   public static object CreateInstance(Type type, params object[] args);
-   public static T CreateInstance<T>();
  }
- public class ArgumentException : Exception {
-   public ArgumentException();
-   public ArgumentException(string message);
-   public ArgumentException(string message, Exception innerException);
-   public ArgumentException(string message, string paramName);
-   public ArgumentException(string message, string paramName, Exception innerException);
-   public override string Message { get; }
-   public virtual string ParamName { get; }
  }
- public class ArgumentNullException : ArgumentException {
-   public ArgumentNullException();
-   public ArgumentNullException(string paramName);
-   public ArgumentNullException(string message, Exception innerException);
-   public ArgumentNullException(string paramName, string message);
  }
- public class ArgumentOutOfRangeException : ArgumentException {
-   public ArgumentOutOfRangeException();
-   public ArgumentOutOfRangeException(string paramName);
-   public ArgumentOutOfRangeException(string message, Exception innerException);
-   public ArgumentOutOfRangeException(string paramName, object actualValue, string message);
-   public ArgumentOutOfRangeException(string paramName, string message);
-   public virtual object ActualValue { get; }
-   public override string Message { get; }
  }
- public class ArithmeticException : Exception {
-   public ArithmeticException();
-   public ArithmeticException(string message);
-   public ArithmeticException(string message, Exception innerException);
  }
- public abstract class Array : ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable {
-   public int Length { get; }
-   public int Rank { get; }
-   int System.Collections.ICollection.Count { get; }
-   bool System.Collections.ICollection.IsSynchronized { get; }
-   object System.Collections.ICollection.SyncRoot { get; }
-   bool System.Collections.IList.IsFixedSize { get; }
-   bool System.Collections.IList.IsReadOnly { get; }
-   object System.Collections.IList.this[int index] { get; set; }
-   public static int BinarySearch(Array array, int index, int length, object value);
-   public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer);
-   public static int BinarySearch(Array array, object value);
-   public static int BinarySearch(Array array, object value, IComparer comparer);
-   public static int BinarySearch<T>(T[] array, int index, int length, T value);
-   public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer);
-   public static int BinarySearch<T>(T[] array, T value);
-   public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer);
-   public static void Clear(Array array, int index, int length);
-   public object Clone();
-   public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length);
-   public static void Copy(Array sourceArray, Array destinationArray, int length);
-   public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length);
-   public void CopyTo(Array array, int index);
-   public static Array CreateInstance(Type elementType, int length);
-   public static Array CreateInstance(Type elementType, params int[] lengths);
-   public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds);
-   public static T[] Empty<T>();
-   public static bool Exists<T>(T[] array, Predicate<T> match);
-   public static T Find<T>(T[] array, Predicate<T> match);
-   public static T[] FindAll<T>(T[] array, Predicate<T> match);
-   public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match);
-   public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match);
-   public static int FindIndex<T>(T[] array, Predicate<T> match);
-   public static T FindLast<T>(T[] array, Predicate<T> match);
-   public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match);
-   public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match);
-   public static int FindLastIndex<T>(T[] array, Predicate<T> match);
-   public IEnumerator GetEnumerator();
-   public int GetLength(int dimension);
-   public int GetLowerBound(int dimension);
-   public int GetUpperBound(int dimension);
-   public object GetValue(int index);
-   public object GetValue(params int[] indices);
-   public static int IndexOf(Array array, object value);
-   public static int IndexOf(Array array, object value, int startIndex);
-   public static int IndexOf(Array array, object value, int startIndex, int count);
-   public static int IndexOf<T>(T[] array, T value);
-   public static int IndexOf<T>(T[] array, T value, int startIndex);
-   public static int IndexOf<T>(T[] array, T value, int startIndex, int count);
-   public void Initialize();
-   public static int LastIndexOf(Array array, object value);
-   public static int LastIndexOf(Array array, object value, int startIndex);
-   public static int LastIndexOf(Array array, object value, int startIndex, int count);
-   public static int LastIndexOf<T>(T[] array, T value);
-   public static int LastIndexOf<T>(T[] array, T value, int startIndex);
-   public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count);
-   public static void Resize<T>(ref T[] array, int newSize);
-   public static void Reverse(Array array);
-   public static void Reverse(Array array, int index, int length);
-   public void SetValue(object value, int index);
-   public void SetValue(object value, params int[] indices);
-   public static void Sort(Array array);
-   public static void Sort(Array keys, Array items);
-   public static void Sort(Array keys, Array items, IComparer comparer);
-   public static void Sort(Array keys, Array items, int index, int length);
-   public static void Sort(Array keys, Array items, int index, int length, IComparer comparer);
-   public static void Sort(Array array, IComparer comparer);
-   public static void Sort(Array array, int index, int length);
-   public static void Sort(Array array, int index, int length, IComparer comparer);
-   public static void Sort<T>(T[] array);
-   public static void Sort<T>(T[] array, IComparer<T> comparer);
-   public static void Sort<T>(T[] array, Comparison<T> comparison);
-   public static void Sort<T>(T[] array, int index, int length);
-   public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer);
-   public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items);
-   public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer);
-   public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length);
-   public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer);
-   int System.Collections.IList.Add(object value);
-   void System.Collections.IList.Clear();
-   bool System.Collections.IList.Contains(object value);
-   int System.Collections.IList.IndexOf(object value);
-   void System.Collections.IList.Insert(int index, object value);
-   void System.Collections.IList.Remove(object value);
-   void System.Collections.IList.RemoveAt(int index);
-   int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);
-   bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);
-   int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);
-   public static bool TrueForAll<T>(T[] array, Predicate<T> match);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ArraySegment<T> : ICollection<T>, IEnumerable, IEnumerable<T>, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T> {
-   public ArraySegment(T[] array);
-   public ArraySegment(T[] array, int offset, int count);
-   public T[] Array { get; }
-   public int Count { get; }
-   public int Offset { get; }
-   bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
-   T System.Collections.Generic.IList<T>.this[int index] { get; set; }
-   T System.Collections.Generic.IReadOnlyList<T>.this[int index] { get; }
-   public bool Equals(ArraySegment<T> obj);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public static bool operator ==(ArraySegment<T> a, ArraySegment<T> b);
-   public static bool operator !=(ArraySegment<T> a, ArraySegment<T> b);
-   void System.Collections.Generic.ICollection<T>.Add(T item);
-   void System.Collections.Generic.ICollection<T>.Clear();
-   bool System.Collections.Generic.ICollection<T>.Contains(T item);
-   void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex);
-   bool System.Collections.Generic.ICollection<T>.Remove(T item);
-   IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
-   int System.Collections.Generic.IList<T>.IndexOf(T item);
-   void System.Collections.Generic.IList<T>.Insert(int index, T item);
-   void System.Collections.Generic.IList<T>.RemoveAt(int index);
-   IEnumerator System.Collections.IEnumerable.GetEnumerator();
  }
- public class ArrayTypeMismatchException : Exception {
-   public ArrayTypeMismatchException();
-   public ArrayTypeMismatchException(string message);
-   public ArrayTypeMismatchException(string message, Exception innerException);
  }
- public delegate void AsyncCallback(IAsyncResult ar);
- public abstract class Attribute {
-   protected Attribute();
-   public override bool Equals(object obj);
-   public override int GetHashCode();
  }
- public enum AttributeTargets {
-   All = 32767,
-   Assembly = 1,
-   Class = 4,
-   Constructor = 32,
-   Delegate = 4096,
-   Enum = 16,
-   Event = 512,
-   Field = 256,
-   GenericParameter = 16384,
-   Interface = 1024,
-   Method = 64,
-   Module = 2,
-   Parameter = 2048,
-   Property = 128,
-   ReturnValue = 8192,
-   Struct = 8,
  }
- public sealed class AttributeUsageAttribute : Attribute {
-   public AttributeUsageAttribute(AttributeTargets validOn);
-   public bool AllowMultiple { get; set; }
-   public bool Inherited { get; set; }
-   public AttributeTargets ValidOn { get; }
  }
- public class BadImageFormatException : Exception {
-   public BadImageFormatException();
-   public BadImageFormatException(string message);
-   public BadImageFormatException(string message, Exception inner);
-   public BadImageFormatException(string message, string fileName);
-   public BadImageFormatException(string message, string fileName, Exception inner);
-   public string FileName { get; }
-   public override string Message { get; }
-   public override string ToString();
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Boolean : IComparable, IComparable<bool>, IConvertible, IEquatable<bool> {
-   public static readonly string FalseString;
-   public static readonly string TrueString;
-   public int CompareTo(bool value);
-   public bool Equals(bool obj);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public static bool Parse(string value);
-   int System.IComparable.CompareTo(object obj);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   string System.IConvertible.ToString(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public override string ToString();
-   public static bool TryParse(string value, out bool result);
  }
- public static class Buffer {
-   public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count);
-   public static int ByteLength(Array array);
-   public static byte GetByte(Array array, int index);
-   public unsafe static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy);
-   public unsafe static void MemoryCopy(void* source, void* destination, ulong destinationSizeInBytes, ulong sourceBytesToCopy);
-   public static void SetByte(Array array, int index, byte value);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Byte : IComparable, IComparable<byte>, IConvertible, IEquatable<byte>, IFormattable {
-   public const byte MaxValue = (byte)255;
-   public const byte MinValue = (byte)0;
-   public int CompareTo(byte value);
-   public bool Equals(byte obj);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public static byte Parse(string s);
-   public static byte Parse(string s, NumberStyles style);
-   public static byte Parse(string s, NumberStyles style, IFormatProvider provider);
-   public static byte Parse(string s, IFormatProvider provider);
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public override string ToString();
-   public string ToString(IFormatProvider provider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider provider);
-   public static bool TryParse(string s, out byte result);
-   public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Char : IComparable, IComparable<char>, IConvertible, IEquatable<char> {
-   public const char MaxValue = '\uFFFF';
-   public const char MinValue = '\0';
-   public int CompareTo(char value);
-   public static string ConvertFromUtf32(int utf32);
-   public static int ConvertToUtf32(char highSurrogate, char lowSurrogate);
-   public static int ConvertToUtf32(string s, int index);
-   public bool Equals(char obj);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public static double GetNumericValue(char c);
-   public static double GetNumericValue(string s, int index);
-   public static bool IsControl(char c);
-   public static bool IsControl(string s, int index);
-   public static bool IsDigit(char c);
-   public static bool IsDigit(string s, int index);
-   public static bool IsHighSurrogate(char c);
-   public static bool IsHighSurrogate(string s, int index);
-   public static bool IsLetter(char c);
-   public static bool IsLetter(string s, int index);
-   public static bool IsLetterOrDigit(char c);
-   public static bool IsLetterOrDigit(string s, int index);
-   public static bool IsLower(char c);
-   public static bool IsLower(string s, int index);
-   public static bool IsLowSurrogate(char c);
-   public static bool IsLowSurrogate(string s, int index);
-   public static bool IsNumber(char c);
-   public static bool IsNumber(string s, int index);
-   public static bool IsPunctuation(char c);
-   public static bool IsPunctuation(string s, int index);
-   public static bool IsSeparator(char c);
-   public static bool IsSeparator(string s, int index);
-   public static bool IsSurrogate(char c);
-   public static bool IsSurrogate(string s, int index);
-   public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate);
-   public static bool IsSurrogatePair(string s, int index);
-   public static bool IsSymbol(char c);
-   public static bool IsSymbol(string s, int index);
-   public static bool IsUpper(char c);
-   public static bool IsUpper(string s, int index);
-   public static bool IsWhiteSpace(char c);
-   public static bool IsWhiteSpace(string s, int index);
-   public static char Parse(string s);
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   string System.IConvertible.ToString(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public static char ToLower(char c);
-   public static char ToLowerInvariant(char c);
-   public override string ToString();
-   public static string ToString(char c);
-   public static char ToUpper(char c);
-   public static char ToUpperInvariant(char c);
-   public static bool TryParse(string s, out char result);
  }
- public sealed class CLSCompliantAttribute : Attribute {
-   public CLSCompliantAttribute(bool isCompliant);
-   public bool IsCompliant { get; }
  }
- public delegate int Comparison<in T>(T x, T y);
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
  public struct DateTime : IComparable, IComparable<DateTime>, IConvertible, IEquatable<DateTime>, IFormattable {
-   public static readonly DateTime MaxValue;
-   public static readonly DateTime MinValue;
-   public DateTime(int year, int month, int day);
-   public DateTime(int year, int month, int day, int hour, int minute, int second);
-   public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind);
-   public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond);
-   public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind);
-   public DateTime(long ticks);
-   public DateTime(long ticks, DateTimeKind kind);
-   public DateTime Date { get; }
-   public int Day { get; }
-   public DayOfWeek DayOfWeek { get; }
-   public int DayOfYear { get; }
-   public int Hour { get; }
-   public DateTimeKind Kind { get; }
-   public int Millisecond { get; }
-   public int Minute { get; }
-   public int Month { get; }
-   public static DateTime Now { get; }
-   public int Second { get; }
-   public long Ticks { get; }
-   public TimeSpan TimeOfDay { get; }
-   public static DateTime Today { get; }
-   public static DateTime UtcNow { get; }
-   public int Year { get; }
-   public DateTime Add(TimeSpan value);
-   public DateTime AddDays(double value);
-   public DateTime AddHours(double value);
-   public DateTime AddMilliseconds(double value);
-   public DateTime AddMinutes(double value);
-   public DateTime AddMonths(int months);
-   public DateTime AddSeconds(double value);
-   public DateTime AddTicks(long value);
-   public DateTime AddYears(int value);
-   public static int Compare(DateTime t1, DateTime t2);
-   public int CompareTo(DateTime value);
-   public static int DaysInMonth(int year, int month);
-   public bool Equals(DateTime value);
-   public static bool Equals(DateTime t1, DateTime t2);
-   public override bool Equals(object value);
-   public static DateTime FromBinary(long dateData);
-   public static DateTime FromFileTime(long fileTime);
-   public static DateTime FromFileTimeUtc(long fileTime);
-   public string[] GetDateTimeFormats();
-   public string[] GetDateTimeFormats(char format);
-   public string[] GetDateTimeFormats(char format, IFormatProvider provider);
-   public string[] GetDateTimeFormats(IFormatProvider provider);
-   public override int GetHashCode();
-   public bool IsDaylightSavingTime();
-   public static bool IsLeapYear(int year);
-   public static DateTime operator +(DateTime d, TimeSpan t);
-   public static bool operator ==(DateTime d1, DateTime d2);
-   public static bool operator >(DateTime t1, DateTime t2);
-   public static bool operator >=(DateTime t1, DateTime t2);
-   public static bool operator !=(DateTime d1, DateTime d2);
-   public static bool operator <(DateTime t1, DateTime t2);
-   public static bool operator <=(DateTime t1, DateTime t2);
-   public static TimeSpan operator -(DateTime d1, DateTime d2);
-   public static DateTime operator -(DateTime d, TimeSpan t);
-   public static DateTime Parse(string s);
-   public static DateTime Parse(string s, IFormatProvider provider);
-   public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);
-   public static DateTime ParseExact(string s, string format, IFormatProvider provider);
-   public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style);
-   public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style);
-   public static DateTime SpecifyKind(DateTime value, DateTimeKind kind);
-   public TimeSpan Subtract(DateTime value);
-   public DateTime Subtract(TimeSpan value);
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public long ToBinary();
-   public long ToFileTime();
-   public long ToFileTimeUtc();
-   public DateTime ToLocalTime();
-   public override string ToString();
-   public string ToString(IFormatProvider provider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider provider);
-   public DateTime ToUniversalTime();
-   public static bool TryParse(string s, out DateTime result);
-   public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result);
-   public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result);
-   public static bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result);
  }
- public enum DateTimeKind {
-   Local = 2,
-   Unspecified = 0,
-   Utc = 1,
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
  public struct DateTimeOffset : IComparable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, IFormattable {
-   public static readonly DateTimeOffset MaxValue;
-   public static readonly DateTimeOffset MinValue;
-   public DateTimeOffset(DateTime dateTime);
-   public DateTimeOffset(DateTime dateTime, TimeSpan offset);
-   public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset);
-   public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset);
-   public DateTimeOffset(long ticks, TimeSpan offset);
-   public DateTime Date { get; }
-   public DateTime DateTime { get; }
-   public int Day { get; }
-   public DayOfWeek DayOfWeek { get; }
-   public int DayOfYear { get; }
-   public int Hour { get; }
-   public DateTime LocalDateTime { get; }
-   public int Millisecond { get; }
-   public int Minute { get; }
-   public int Month { get; }
-   public static DateTimeOffset Now { get; }
-   public TimeSpan Offset { get; }
-   public int Second { get; }
-   public long Ticks { get; }
-   public TimeSpan TimeOfDay { get; }
-   public DateTime UtcDateTime { get; }
-   public static DateTimeOffset UtcNow { get; }
-   public long UtcTicks { get; }
-   public int Year { get; }
-   public DateTimeOffset Add(TimeSpan timeSpan);
-   public DateTimeOffset AddDays(double days);
-   public DateTimeOffset AddHours(double hours);
-   public DateTimeOffset AddMilliseconds(double milliseconds);
-   public DateTimeOffset AddMinutes(double minutes);
-   public DateTimeOffset AddMonths(int months);
-   public DateTimeOffset AddSeconds(double seconds);
-   public DateTimeOffset AddTicks(long ticks);
-   public DateTimeOffset AddYears(int years);
-   public static int Compare(DateTimeOffset first, DateTimeOffset second);
-   public int CompareTo(DateTimeOffset other);
-   public bool Equals(DateTimeOffset other);
-   public static bool Equals(DateTimeOffset first, DateTimeOffset second);
-   public override bool Equals(object obj);
-   public bool EqualsExact(DateTimeOffset other);
-   public static DateTimeOffset FromFileTime(long fileTime);
-   public static DateTimeOffset FromUnixTimeMilliseconds(long milliseconds);
-   public static DateTimeOffset FromUnixTimeSeconds(long seconds);
-   public override int GetHashCode();
-   public static DateTimeOffset operator +(DateTimeOffset dateTimeOffset, TimeSpan timeSpan);
-   public static bool operator ==(DateTimeOffset left, DateTimeOffset right);
-   public static bool operator >(DateTimeOffset left, DateTimeOffset right);
-   public static bool operator >=(DateTimeOffset left, DateTimeOffset right);
-   public static implicit operator DateTimeOffset (DateTime dateTime);
-   public static bool operator !=(DateTimeOffset left, DateTimeOffset right);
-   public static bool operator <(DateTimeOffset left, DateTimeOffset right);
-   public static bool operator <=(DateTimeOffset left, DateTimeOffset right);
-   public static TimeSpan operator -(DateTimeOffset left, DateTimeOffset right);
-   public static DateTimeOffset operator -(DateTimeOffset dateTimeOffset, TimeSpan timeSpan);
-   public static DateTimeOffset Parse(string input);
-   public static DateTimeOffset Parse(string input, IFormatProvider formatProvider);
-   public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles);
-   public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider);
-   public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles);
-   public static DateTimeOffset ParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles);
-   public TimeSpan Subtract(DateTimeOffset value);
-   public DateTimeOffset Subtract(TimeSpan value);
-   int System.IComparable.CompareTo(object obj);
-   public long ToFileTime();
-   public DateTimeOffset ToLocalTime();
-   public DateTimeOffset ToOffset(TimeSpan offset);
-   public override string ToString();
-   public string ToString(IFormatProvider formatProvider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider formatProvider);
-   public DateTimeOffset ToUniversalTime();
-   public long ToUnixTimeMilliseconds();
-   public long ToUnixTimeSeconds();
-   public static bool TryParse(string input, out DateTimeOffset result);
-   public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result);
-   public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result);
-   public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result);
  }
- public enum DayOfWeek {
-   Friday = 5,
-   Monday = 1,
-   Saturday = 6,
-   Sunday = 0,
-   Thursday = 4,
-   Tuesday = 2,
-   Wednesday = 3,
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Decimal : IComparable, IComparable<decimal>, IConvertible, IEquatable<decimal>, IFormattable {
-   public static readonly decimal MaxValue;
-   public static readonly decimal MinusOne;
-   public static readonly decimal MinValue;
-   public static readonly decimal One;
-   public static readonly decimal Zero;
-   public Decimal(double value);
-   public Decimal(int value);
-   public Decimal(int lo, int mid, int hi, bool isNegative, byte scale);
-   public Decimal(int[] bits);
-   public Decimal(long value);
-   public Decimal(float value);
-   public Decimal(uint value);
-   public Decimal(ulong value);
-   public static decimal Add(decimal d1, decimal d2);
-   public static decimal Ceiling(decimal d);
-   public static int Compare(decimal d1, decimal d2);
-   public int CompareTo(decimal value);
-   public static decimal Divide(decimal d1, decimal d2);
-   public bool Equals(decimal value);
-   public static bool Equals(decimal d1, decimal d2);
-   public override bool Equals(object value);
-   public static decimal Floor(decimal d);
-   public static int[] GetBits(decimal d);
-   public override int GetHashCode();
-   public static decimal Multiply(decimal d1, decimal d2);
-   public static decimal Negate(decimal d);
-   public static decimal operator +(decimal d1, decimal d2);
-   public static decimal operator --(decimal d);
-   public static decimal operator /(decimal d1, decimal d2);
-   public static bool operator ==(decimal d1, decimal d2);
-   public static explicit operator byte (decimal value);
-   public static explicit operator char (decimal value);
-   public static explicit operator double (decimal value);
-   public static explicit operator short (decimal value);
-   public static explicit operator int (decimal value);
-   public static explicit operator long (decimal value);
-   public static explicit operator sbyte (decimal value);
-   public static explicit operator float (decimal value);
-   public static explicit operator ushort (decimal value);
-   public static explicit operator uint (decimal value);
-   public static explicit operator ulong (decimal value);
-   public static explicit operator decimal (double value);
-   public static explicit operator decimal (float value);
-   public static bool operator >(decimal d1, decimal d2);
-   public static bool operator >=(decimal d1, decimal d2);
-   public static implicit operator decimal (byte value);
-   public static implicit operator decimal (char value);
-   public static implicit operator decimal (short value);
-   public static implicit operator decimal (int value);
-   public static implicit operator decimal (long value);
-   public static implicit operator decimal (sbyte value);
-   public static implicit operator decimal (ushort value);
-   public static implicit operator decimal (uint value);
-   public static implicit operator decimal (ulong value);
-   public static decimal operator ++(decimal d);
-   public static bool operator !=(decimal d1, decimal d2);
-   public static bool operator <(decimal d1, decimal d2);
-   public static bool operator <=(decimal d1, decimal d2);
-   public static decimal operator %(decimal d1, decimal d2);
-   public static decimal operator *(decimal d1, decimal d2);
-   public static decimal operator -(decimal d1, decimal d2);
-   public static decimal operator -(decimal d);
-   public static decimal operator +(decimal d);
-   public static decimal Parse(string s);
-   public static decimal Parse(string s, NumberStyles style);
-   public static decimal Parse(string s, NumberStyles style, IFormatProvider provider);
-   public static decimal Parse(string s, IFormatProvider provider);
-   public static decimal Remainder(decimal d1, decimal d2);
-   public static decimal Subtract(decimal d1, decimal d2);
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public static byte ToByte(decimal value);
-   public static double ToDouble(decimal d);
-   public static short ToInt16(decimal value);
-   public static int ToInt32(decimal d);
-   public static long ToInt64(decimal d);
-   public static sbyte ToSByte(decimal value);
-   public static float ToSingle(decimal d);
-   public override string ToString();
-   public string ToString(IFormatProvider provider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider provider);
-   public static ushort ToUInt16(decimal value);
-   public static uint ToUInt32(decimal d);
-   public static ulong ToUInt64(decimal d);
-   public static decimal Truncate(decimal d);
-   public static bool TryParse(string s, out decimal result);
-   public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result);
  }
- public abstract class Delegate {
-   public object Target { get; }
-   public static Delegate Combine(Delegate a, Delegate b);
-   public static Delegate Combine(params Delegate[] delegates);
-   public object DynamicInvoke(params object[] args);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public virtual Delegate[] GetInvocationList();
-   public static bool operator ==(Delegate d1, Delegate d2);
-   public static bool operator !=(Delegate d1, Delegate d2);
-   public static Delegate Remove(Delegate source, Delegate value);
-   public static Delegate RemoveAll(Delegate source, Delegate value);
  }
- public class DivideByZeroException : ArithmeticException {
-   public DivideByZeroException();
-   public DivideByZeroException(string message);
-   public DivideByZeroException(string message, Exception innerException);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Double : IComparable, IComparable<double>, IConvertible, IEquatable<double>, IFormattable {
-   public const double Epsilon = 4.94065645841247E-324;
-   public const double MaxValue = 1.7976931348623157E+308;
-   public const double MinValue = -1.7976931348623157E+308;
-   public const double NaN = 0.0 / 0.0;
-   public const double NegativeInfinity = -1.0 / 0.0;
-   public const double PositiveInfinity = 1.0 / 0.0;
-   public int CompareTo(double value);
-   public bool Equals(double obj);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public static bool IsInfinity(double d);
-   public static bool IsNaN(double d);
-   public static bool IsNegativeInfinity(double d);
-   public static bool IsPositiveInfinity(double d);
-   public static bool operator ==(double left, double right);
-   public static bool operator >(double left, double right);
-   public static bool operator >=(double left, double right);
-   public static bool operator !=(double left, double right);
-   public static bool operator <(double left, double right);
-   public static bool operator <=(double left, double right);
-   public static double Parse(string s);
-   public static double Parse(string s, NumberStyles style);
-   public static double Parse(string s, NumberStyles style, IFormatProvider provider);
-   public static double Parse(string s, IFormatProvider provider);
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public override string ToString();
-   public string ToString(IFormatProvider provider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider provider);
-   public static bool TryParse(string s, out double result);
-   public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result);
  }
- public abstract class Enum : ValueType, IComparable, IConvertible, IFormattable {
-   protected Enum();
-   public int CompareTo(object target);
-   public override bool Equals(object obj);
-   public static string Format(Type enumType, object value, string format);
-   public override int GetHashCode();
-   public static string GetName(Type enumType, object value);
-   public static string[] GetNames(Type enumType);
-   public static Type GetUnderlyingType(Type enumType);
-   public static Array GetValues(Type enumType);
-   public bool HasFlag(Enum flag);
-   public static bool IsDefined(Type enumType, object value);
-   public static object Parse(Type enumType, string value);
-   public static object Parse(Type enumType, string value, bool ignoreCase);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   string System.IConvertible.ToString(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   string System.IFormattable.ToString(string format, IFormatProvider provider);
-   public static object ToObject(Type enumType, object value);
-   public override string ToString();
-   public string ToString(string format);
-   public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct;
-   public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct;
  }
- public class EventArgs {
-   public static readonly EventArgs Empty;
-   public EventArgs();
  }
- public delegate void EventHandler(object sender, EventArgs e);
- public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);
- public class Exception {
-   public Exception();
-   public Exception(string message);
-   public Exception(string message, Exception innerException);
-   public virtual IDictionary Data { get; }
-   public virtual string HelpLink { get; set; }
-   public int HResult { get; protected set; }
-   public Exception InnerException { get; }
-   public virtual string Message { get; }
-   public virtual string Source { get; set; }
-   public virtual string StackTrace { get; }
-   public virtual Exception GetBaseException();
-   public override string ToString();
  }
- public class FieldAccessException : MemberAccessException {
-   public FieldAccessException();
-   public FieldAccessException(string message);
-   public FieldAccessException(string message, Exception inner);
  }
- public class FlagsAttribute : Attribute {
-   public FlagsAttribute();
  }
- public class FormatException : Exception {
-   public FormatException();
-   public FormatException(string message);
-   public FormatException(string message, Exception innerException);
  }
- public abstract class FormattableString : IFormattable {
-   protected FormattableString();
-   public abstract int ArgumentCount { get; }
-   public abstract string Format { get; }
-   public abstract object GetArgument(int index);
-   public abstract object[] GetArguments();
-   public static string Invariant(FormattableString formattable);
-   string System.IFormattable.ToString(string ignored, IFormatProvider formatProvider);
-   public override string ToString();
-   public abstract string ToString(IFormatProvider formatProvider);
  }
- public delegate TResult Func<out TResult>();
- public delegate TResult Func<in T, out TResult>(T arg);
- public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
- public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);
- public delegate TResult Func<in T1, in T2, in T3, in T4, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
- public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
- public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
- public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
- public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
- public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
- public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
- public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
- public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
- public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
- public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
- public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
- public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
- public static class GC {
-   public static int MaxGeneration { get; }
-   public static void AddMemoryPressure(long bytesAllocated);
-   public static void Collect();
-   public static void Collect(int generation);
-   public static void Collect(int generation, GCCollectionMode mode);
-   public static void Collect(int generation, GCCollectionMode mode, bool blocking);
-   public static int CollectionCount(int generation);
-   public static long GetTotalMemory(bool forceFullCollection);
-   public static void KeepAlive(object obj);
-   public static void RemoveMemoryPressure(long bytesAllocated);
-   public static void ReRegisterForFinalize(object obj);
-   public static void SuppressFinalize(object obj);
-   public static void WaitForPendingFinalizers();
  }
- public enum GCCollectionMode {
-   Default = 0,
-   Forced = 1,
-   Optimized = 2,
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Guid : IComparable, IComparable<Guid>, IEquatable<Guid>, IFormattable {
-   public static readonly Guid Empty;
-   public Guid(byte[] b);
-   public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k);
-   public Guid(int a, short b, short c, byte[] d);
-   public Guid(string g);
-   public Guid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k);
-   public int CompareTo(Guid value);
-   public bool Equals(Guid g);
-   public override bool Equals(object o);
-   public override int GetHashCode();
-   public static Guid NewGuid();
-   public static bool operator ==(Guid a, Guid b);
-   public static bool operator !=(Guid a, Guid b);
-   public static Guid Parse(string input);
-   public static Guid ParseExact(string input, string format);
-   int System.IComparable.CompareTo(object value);
-   string System.IFormattable.ToString(string format, IFormatProvider provider);
-   public byte[] ToByteArray();
-   public override string ToString();
-   public string ToString(string format);
-   public static bool TryParse(string input, out Guid result);
-   public static bool TryParseExact(string input, string format, out Guid result);
  }
- public interface IAsyncResult {
-   object AsyncState { get; }
-   WaitHandle AsyncWaitHandle { get; }
-   bool CompletedSynchronously { get; }
-   bool IsCompleted { get; }
  }
- public interface IComparable {
-   int CompareTo(object obj);
  }
- public interface IComparable<in T> {
-   int CompareTo(T other);
  }
- public interface IConvertible {
-   TypeCode GetTypeCode();
-   bool ToBoolean(IFormatProvider provider);
-   byte ToByte(IFormatProvider provider);
-   char ToChar(IFormatProvider provider);
-   DateTime ToDateTime(IFormatProvider provider);
-   decimal ToDecimal(IFormatProvider provider);
-   double ToDouble(IFormatProvider provider);
-   short ToInt16(IFormatProvider provider);
-   int ToInt32(IFormatProvider provider);
-   long ToInt64(IFormatProvider provider);
-   sbyte ToSByte(IFormatProvider provider);
-   float ToSingle(IFormatProvider provider);
-   string ToString(IFormatProvider provider);
-   object ToType(Type conversionType, IFormatProvider provider);
-   ushort ToUInt16(IFormatProvider provider);
-   uint ToUInt32(IFormatProvider provider);
-   ulong ToUInt64(IFormatProvider provider);
  }
- public interface ICustomFormatter {
-   string Format(string format, object arg, IFormatProvider formatProvider);
  }
- public interface IDisposable {
-   void Dispose();
  }
- public interface IEquatable<T> {
-   bool Equals(T other);
  }
- public interface IFormatProvider {
-   object GetFormat(Type formatType);
  }
- public interface IFormattable {
-   string ToString(string format, IFormatProvider formatProvider);
  }
- public sealed class IndexOutOfRangeException : Exception {
-   public IndexOutOfRangeException();
-   public IndexOutOfRangeException(string message);
-   public IndexOutOfRangeException(string message, Exception innerException);
  }
- public sealed class InsufficientExecutionStackException : Exception {
-   public InsufficientExecutionStackException();
-   public InsufficientExecutionStackException(string message);
-   public InsufficientExecutionStackException(string message, Exception innerException);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Int16 : IComparable, IComparable<short>, IConvertible, IEquatable<short>, IFormattable {
-   public const short MaxValue = (short)32767;
-   public const short MinValue = (short)-32768;
-   public int CompareTo(short value);
-   public bool Equals(short obj);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public static short Parse(string s);
-   public static short Parse(string s, NumberStyles style);
-   public static short Parse(string s, NumberStyles style, IFormatProvider provider);
-   public static short Parse(string s, IFormatProvider provider);
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public override string ToString();
-   public string ToString(IFormatProvider provider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider provider);
-   public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result);
-   public static bool TryParse(string s, out short result);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Int32 : IComparable, IComparable<int>, IConvertible, IEquatable<int>, IFormattable {
-   public const int MaxValue = 2147483647;
-   public const int MinValue = -2147483648;
-   public int CompareTo(int value);
-   public bool Equals(int obj);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public static int Parse(string s);
-   public static int Parse(string s, NumberStyles style);
-   public static int Parse(string s, NumberStyles style, IFormatProvider provider);
-   public static int Parse(string s, IFormatProvider provider);
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public override string ToString();
-   public string ToString(IFormatProvider provider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider provider);
-   public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result);
-   public static bool TryParse(string s, out int result);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Int64 : IComparable, IComparable<long>, IConvertible, IEquatable<long>, IFormattable {
-   public const long MaxValue = (long)9223372036854775807;
-   public const long MinValue = (long)-9223372036854775808;
-   public int CompareTo(long value);
-   public bool Equals(long obj);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public static long Parse(string s);
-   public static long Parse(string s, NumberStyles style);
-   public static long Parse(string s, NumberStyles style, IFormatProvider provider);
-   public static long Parse(string s, IFormatProvider provider);
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public override string ToString();
-   public string ToString(IFormatProvider provider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider provider);
-   public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result);
-   public static bool TryParse(string s, out long result);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct IntPtr {
-   public static readonly IntPtr Zero;
-   public IntPtr(int value);
-   public IntPtr(long value);
-   public unsafe IntPtr(void* value);
-   public static int Size { get; }
-   public static IntPtr Add(IntPtr pointer, int offset);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public static IntPtr operator +(IntPtr pointer, int offset);
-   public static bool operator ==(IntPtr value1, IntPtr value2);
-   public static explicit operator IntPtr (int value);
-   public static explicit operator IntPtr (long value);
-   public static explicit operator int (IntPtr value);
-   public static explicit operator long (IntPtr value);
-   public unsafe static explicit operator void* (IntPtr value);
-   public unsafe static explicit operator IntPtr (void* value);
-   public static bool operator !=(IntPtr value1, IntPtr value2);
-   public static IntPtr operator -(IntPtr pointer, int offset);
-   public static IntPtr Subtract(IntPtr pointer, int offset);
-   public int ToInt32();
-   public long ToInt64();
-   public unsafe void* ToPointer();
-   public override string ToString();
-   public string ToString(string format);
  }
- public class InvalidCastException : Exception {
-   public InvalidCastException();
-   public InvalidCastException(string message);
-   public InvalidCastException(string message, Exception innerException);
-   public InvalidCastException(string message, int errorCode);
  }
- public class InvalidOperationException : Exception {
-   public InvalidOperationException();
-   public InvalidOperationException(string message);
-   public InvalidOperationException(string message, Exception innerException);
  }
- public sealed class InvalidProgramException : Exception {
-   public InvalidProgramException();
-   public InvalidProgramException(string message);
-   public InvalidProgramException(string message, Exception inner);
  }
- public class InvalidTimeZoneException : Exception {
-   public InvalidTimeZoneException();
-   public InvalidTimeZoneException(string message);
-   public InvalidTimeZoneException(string message, Exception innerException);
  }
- public interface IObservable<out T> {
-   IDisposable Subscribe(IObserver<T> observer);
  }
- public interface IObserver<in T> {
-   void OnCompleted();
-   void OnError(Exception error);
-   void OnNext(T value);
  }
- public interface IProgress<in T> {
-   void Report(T value);
  }
- public class Lazy<T> {
-   public Lazy();
-   public Lazy(bool isThreadSafe);
-   public Lazy(Func<T> valueFactory);
-   public Lazy(Func<T> valueFactory, bool isThreadSafe);
-   public Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode);
-   public Lazy(LazyThreadSafetyMode mode);
-   public bool IsValueCreated { get; }
-   public T Value { get; }
-   public override string ToString();
  }
- public class Lazy<T, TMetadata> : Lazy<T> {
-   public Lazy(Func<T> valueFactory, TMetadata metadata);
-   public Lazy(Func<T> valueFactory, TMetadata metadata, bool isThreadSafe);
-   public Lazy(Func<T> valueFactory, TMetadata metadata, LazyThreadSafetyMode mode);
-   public Lazy(TMetadata metadata);
-   public Lazy(TMetadata metadata, bool isThreadSafe);
-   public Lazy(TMetadata metadata, LazyThreadSafetyMode mode);
-   public TMetadata Metadata { get; }
  }
- public class MemberAccessException : Exception {
-   public MemberAccessException();
-   public MemberAccessException(string message);
-   public MemberAccessException(string message, Exception inner);
  }
- public class MethodAccessException : MemberAccessException {
-   public MethodAccessException();
-   public MethodAccessException(string message);
-   public MethodAccessException(string message, Exception inner);
  }
- public class MissingFieldException : MissingMemberException {
-   public MissingFieldException();
-   public MissingFieldException(string message);
-   public MissingFieldException(string message, Exception inner);
-   public override string Message { get; }
  }
- public class MissingMemberException : MemberAccessException {
-   public MissingMemberException();
-   public MissingMemberException(string message);
-   public MissingMemberException(string message, Exception inner);
-   public override string Message { get; }
  }
- public class MissingMethodException : MissingMemberException {
-   public MissingMethodException();
-   public MissingMethodException(string message);
-   public MissingMethodException(string message, Exception inner);
-   public override string Message { get; }
  }
- public sealed class MTAThreadAttribute : Attribute {
-   public MTAThreadAttribute();
  }
- public abstract class MulticastDelegate : Delegate {
-   public sealed override bool Equals(object obj);
-   public sealed override int GetHashCode();
-   public sealed override Delegate[] GetInvocationList();
-   public static bool operator ==(MulticastDelegate d1, MulticastDelegate d2);
-   public static bool operator !=(MulticastDelegate d1, MulticastDelegate d2);
  }
- public class NotImplementedException : Exception {
-   public NotImplementedException();
-   public NotImplementedException(string message);
-   public NotImplementedException(string message, Exception inner);
  }
- public class NotSupportedException : Exception {
-   public NotSupportedException();
-   public NotSupportedException(string message);
-   public NotSupportedException(string message, Exception innerException);
  }
- public static class Nullable {
-   public static int Compare<T>(Nullable<T> n1, Nullable<T> n2) where T : struct;
-   public static bool Equals<T>(Nullable<T> n1, Nullable<T> n2) where T : struct;
-   public static Type GetUnderlyingType(Type nullableType);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Nullable<T> where T : struct {
-   public Nullable(T value);
-   public bool HasValue { get; }
-   public T Value { get; }
-   public override bool Equals(object other);
-   public override int GetHashCode();
-   public T GetValueOrDefault();
-   public T GetValueOrDefault(T defaultValue);
-   public static explicit operator T (Nullable<T> value);
-   public static implicit operator Nullable<T> (T value);
-   public override string ToString();
  }
- public class NullReferenceException : Exception {
-   public NullReferenceException();
-   public NullReferenceException(string message);
-   public NullReferenceException(string message, Exception innerException);
  }
- public class Object {
-   public Object();
-   public virtual bool Equals(object obj);
-   public static bool Equals(object objA, object objB);
-   ~Object();
-   public virtual int GetHashCode();
-   public Type GetType();
-   protected object MemberwiseClone();
-   public static bool ReferenceEquals(object objA, object objB);
-   public virtual string ToString();
  }
- public class ObjectDisposedException : InvalidOperationException {
-   public ObjectDisposedException(string objectName);
-   public ObjectDisposedException(string message, Exception innerException);
-   public ObjectDisposedException(string objectName, string message);
-   public override string Message { get; }
-   public string ObjectName { get; }
  }
- public sealed class ObsoleteAttribute : Attribute {
-   public ObsoleteAttribute();
-   public ObsoleteAttribute(string message);
-   public ObsoleteAttribute(string message, bool error);
-   public bool IsError { get; }
-   public string Message { get; }
  }
- public class OutOfMemoryException : Exception {
-   public OutOfMemoryException();
-   public OutOfMemoryException(string message);
-   public OutOfMemoryException(string message, Exception innerException);
  }
- public class OverflowException : ArithmeticException {
-   public OverflowException();
-   public OverflowException(string message);
-   public OverflowException(string message, Exception innerException);
  }
- public sealed class ParamArrayAttribute : Attribute {
-   public ParamArrayAttribute();
  }
- public class PlatformNotSupportedException : NotSupportedException {
-   public PlatformNotSupportedException();
-   public PlatformNotSupportedException(string message);
-   public PlatformNotSupportedException(string message, Exception inner);
  }
- public delegate bool Predicate<in T>(T obj);
- public class RankException : Exception {
-   public RankException();
-   public RankException(string message);
-   public RankException(string message, Exception innerException);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct RuntimeFieldHandle {
-   public override bool Equals(object obj);
-   public bool Equals(RuntimeFieldHandle handle);
-   public override int GetHashCode();
-   public static bool operator ==(RuntimeFieldHandle left, RuntimeFieldHandle right);
-   public static bool operator !=(RuntimeFieldHandle left, RuntimeFieldHandle right);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct RuntimeMethodHandle {
-   public override bool Equals(object obj);
-   public bool Equals(RuntimeMethodHandle handle);
-   public override int GetHashCode();
-   public static bool operator ==(RuntimeMethodHandle left, RuntimeMethodHandle right);
-   public static bool operator !=(RuntimeMethodHandle left, RuntimeMethodHandle right);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct RuntimeTypeHandle {
-   public override bool Equals(object obj);
-   public bool Equals(RuntimeTypeHandle handle);
-   public override int GetHashCode();
-   public static bool operator ==(object left, RuntimeTypeHandle right);
-   public static bool operator ==(RuntimeTypeHandle left, object right);
-   public static bool operator !=(object left, RuntimeTypeHandle right);
-   public static bool operator !=(RuntimeTypeHandle left, object right);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SByte : IComparable, IComparable<sbyte>, IConvertible, IEquatable<sbyte>, IFormattable {
-   public const sbyte MaxValue = (sbyte)127;
-   public const sbyte MinValue = (sbyte)-128;
-   public int CompareTo(sbyte value);
-   public override bool Equals(object obj);
-   public bool Equals(sbyte obj);
-   public override int GetHashCode();
-   public static sbyte Parse(string s);
-   public static sbyte Parse(string s, NumberStyles style);
-   public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider);
-   public static sbyte Parse(string s, IFormatProvider provider);
-   int System.IComparable.CompareTo(object obj);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public override string ToString();
-   public string ToString(IFormatProvider provider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider provider);
-   public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result);
-   public static bool TryParse(string s, out sbyte result);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Single : IComparable, IComparable<float>, IConvertible, IEquatable<float>, IFormattable {
-   public const float Epsilon = 1.401298E-45f;
-   public const float MaxValue = 3.40282347E+38f;
-   public const float MinValue = -3.40282347E+38f;
-   public const float NaN = 0.0f / 0.0f;
-   public const float NegativeInfinity = -1.0f / 0.0f;
-   public const float PositiveInfinity = 1.0f / 0.0f;
-   public int CompareTo(float value);
-   public override bool Equals(object obj);
-   public bool Equals(float obj);
-   public override int GetHashCode();
-   public static bool IsInfinity(float f);
-   public static bool IsNaN(float f);
-   public static bool IsNegativeInfinity(float f);
-   public static bool IsPositiveInfinity(float f);
-   public static bool operator ==(float left, float right);
-   public static bool operator >(float left, float right);
-   public static bool operator >=(float left, float right);
-   public static bool operator !=(float left, float right);
-   public static bool operator <(float left, float right);
-   public static bool operator <=(float left, float right);
-   public static float Parse(string s);
-   public static float Parse(string s, NumberStyles style);
-   public static float Parse(string s, NumberStyles style, IFormatProvider provider);
-   public static float Parse(string s, IFormatProvider provider);
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public override string ToString();
-   public string ToString(IFormatProvider provider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider provider);
-   public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result);
-   public static bool TryParse(string s, out float result);
  }
- public sealed class STAThreadAttribute : Attribute {
-   public STAThreadAttribute();
  }
- public sealed class String : IComparable, IComparable<string>, IConvertible, IEnumerable, IEnumerable<char>, IEquatable<string> {
-   public static readonly string Empty;
-   public unsafe String(char* value);
-   public unsafe String(char* value, int startIndex, int length);
-   public String(char c, int count);
-   public String(char[] value);
-   public String(char[] value, int startIndex, int length);
-   public int Length { get; }
-   [System.Runtime.CompilerServices.IndexerName("Chars")]
    public char this[int index] { get; }
-   public static int Compare(string strA, int indexA, string strB, int indexB, int length);
-   public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType);
-   public static int Compare(string strA, string strB);
-   public static int Compare(string strA, string strB, bool ignoreCase);
-   public static int Compare(string strA, string strB, StringComparison comparisonType);
-   public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length);
-   public static int CompareOrdinal(string strA, string strB);
-   public int CompareTo(string strB);
-   public static string Concat(IEnumerable<string> values);
-   public static string Concat(object arg0);
-   public static string Concat(object arg0, object arg1);
-   public static string Concat(object arg0, object arg1, object arg2);
-   public static string Concat(params object[] args);
-   public static string Concat(string str0, string str1);
-   public static string Concat(string str0, string str1, string str2);
-   public static string Concat(string str0, string str1, string str2, string str3);
-   public static string Concat(params string[] values);
-   public static string Concat<T>(IEnumerable<T> values);
-   public bool Contains(string value);
-   public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);
-   public bool EndsWith(string value);
-   public bool EndsWith(string value, StringComparison comparisonType);
-   public override bool Equals(object obj);
-   public bool Equals(string value);
-   public static bool Equals(string a, string b);
-   public static bool Equals(string a, string b, StringComparison comparisonType);
-   public bool Equals(string value, StringComparison comparisonType);
-   public static string Format(IFormatProvider provider, string format, object arg0);
-   public static string Format(IFormatProvider provider, string format, object arg0, object arg1);
-   public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2);
-   public static string Format(IFormatProvider provider, string format, params object[] args);
-   public static string Format(string format, object arg0);
-   public static string Format(string format, object arg0, object arg1);
-   public static string Format(string format, object arg0, object arg1, object arg2);
-   public static string Format(string format, params object[] args);
-   public override int GetHashCode();
-   public int IndexOf(char value);
-   public int IndexOf(char value, int startIndex);
-   public int IndexOf(char value, int startIndex, int count);
-   public int IndexOf(string value);
-   public int IndexOf(string value, int startIndex);
-   public int IndexOf(string value, int startIndex, int count);
-   public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType);
-   public int IndexOf(string value, int startIndex, StringComparison comparisonType);
-   public int IndexOf(string value, StringComparison comparisonType);
-   public int IndexOfAny(char[] anyOf);
-   public int IndexOfAny(char[] anyOf, int startIndex);
-   public int IndexOfAny(char[] anyOf, int startIndex, int count);
-   public string Insert(int startIndex, string value);
-   public static bool IsNullOrEmpty(string value);
-   public static bool IsNullOrWhiteSpace(string value);
-   public static string Join(string separator, IEnumerable<string> values);
-   public static string Join(string separator, params object[] values);
-   public static string Join(string separator, params string[] value);
-   public static string Join(string separator, string[] value, int startIndex, int count);
-   public static string Join<T>(string separator, IEnumerable<T> values);
-   public int LastIndexOf(char value);
-   public int LastIndexOf(char value, int startIndex);
-   public int LastIndexOf(char value, int startIndex, int count);
-   public int LastIndexOf(string value);
-   public int LastIndexOf(string value, int startIndex);
-   public int LastIndexOf(string value, int startIndex, int count);
-   public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType);
-   public int LastIndexOf(string value, int startIndex, StringComparison comparisonType);
-   public int LastIndexOf(string value, StringComparison comparisonType);
-   public int LastIndexOfAny(char[] anyOf);
-   public int LastIndexOfAny(char[] anyOf, int startIndex);
-   public int LastIndexOfAny(char[] anyOf, int startIndex, int count);
-   public static bool operator ==(string a, string b);
-   public static bool operator !=(string a, string b);
-   public string PadLeft(int totalWidth);
-   public string PadLeft(int totalWidth, char paddingChar);
-   public string PadRight(int totalWidth);
-   public string PadRight(int totalWidth, char paddingChar);
-   public string Remove(int startIndex);
-   public string Remove(int startIndex, int count);
-   public string Replace(char oldChar, char newChar);
-   public string Replace(string oldValue, string newValue);
-   public string[] Split(params char[] separator);
-   public string[] Split(char[] separator, int count);
-   public string[] Split(char[] separator, int count, StringSplitOptions options);
-   public string[] Split(char[] separator, StringSplitOptions options);
-   public string[] Split(string[] separator, int count, StringSplitOptions options);
-   public string[] Split(string[] separator, StringSplitOptions options);
-   public bool StartsWith(string value);
-   public bool StartsWith(string value, StringComparison comparisonType);
-   public string Substring(int startIndex);
-   public string Substring(int startIndex, int length);
-   IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator();
-   IEnumerator System.Collections.IEnumerable.GetEnumerator();
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   string System.IConvertible.ToString(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public char[] ToCharArray();
-   public char[] ToCharArray(int startIndex, int length);
-   public string ToLower();
-   public string ToLowerInvariant();
-   public override string ToString();
-   public string ToUpper();
-   public string ToUpperInvariant();
-   public string Trim();
-   public string Trim(params char[] trimChars);
-   public string TrimEnd(params char[] trimChars);
-   public string TrimStart(params char[] trimChars);
  }
- public enum StringComparison {
-   CurrentCulture = 0,
-   CurrentCultureIgnoreCase = 1,
-   Ordinal = 4,
-   OrdinalIgnoreCase = 5,
  }
- public enum StringSplitOptions {
-   None = 0,
-   RemoveEmptyEntries = 1,
  }
- public class ThreadStaticAttribute : Attribute {
-   public ThreadStaticAttribute();
  }
- public class TimeoutException : Exception {
-   public TimeoutException();
-   public TimeoutException(string message);
-   public TimeoutException(string message, Exception innerException);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable {
-   public const long TicksPerDay = (long)864000000000;
-   public const long TicksPerHour = (long)36000000000;
-   public const long TicksPerMillisecond = (long)10000;
-   public const long TicksPerMinute = (long)600000000;
-   public const long TicksPerSecond = (long)10000000;
-   public static readonly TimeSpan MaxValue;
-   public static readonly TimeSpan MinValue;
-   public static readonly TimeSpan Zero;
-   public TimeSpan(int hours, int minutes, int seconds);
-   public TimeSpan(int days, int hours, int minutes, int seconds);
-   public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds);
-   public TimeSpan(long ticks);
-   public int Days { get; }
-   public int Hours { get; }
-   public int Milliseconds { get; }
-   public int Minutes { get; }
-   public int Seconds { get; }
-   public long Ticks { get; }
-   public double TotalDays { get; }
-   public double TotalHours { get; }
-   public double TotalMilliseconds { get; }
-   public double TotalMinutes { get; }
-   public double TotalSeconds { get; }
-   public TimeSpan Add(TimeSpan ts);
-   public static int Compare(TimeSpan t1, TimeSpan t2);
-   public int CompareTo(TimeSpan value);
-   public TimeSpan Duration();
-   public override bool Equals(object value);
-   public bool Equals(TimeSpan obj);
-   public static bool Equals(TimeSpan t1, TimeSpan t2);
-   public static TimeSpan FromDays(double value);
-   public static TimeSpan FromHours(double value);
-   public static TimeSpan FromMilliseconds(double value);
-   public static TimeSpan FromMinutes(double value);
-   public static TimeSpan FromSeconds(double value);
-   public static TimeSpan FromTicks(long value);
-   public override int GetHashCode();
-   public TimeSpan Negate();
-   public static TimeSpan operator +(TimeSpan t1, TimeSpan t2);
-   public static bool operator ==(TimeSpan t1, TimeSpan t2);
-   public static bool operator >(TimeSpan t1, TimeSpan t2);
-   public static bool operator >=(TimeSpan t1, TimeSpan t2);
-   public static bool operator !=(TimeSpan t1, TimeSpan t2);
-   public static bool operator <(TimeSpan t1, TimeSpan t2);
-   public static bool operator <=(TimeSpan t1, TimeSpan t2);
-   public static TimeSpan operator -(TimeSpan t1, TimeSpan t2);
-   public static TimeSpan operator -(TimeSpan t);
-   public static TimeSpan operator +(TimeSpan t);
-   public static TimeSpan Parse(string s);
-   public static TimeSpan Parse(string input, IFormatProvider formatProvider);
-   public static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider);
-   public static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles);
-   public static TimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider);
-   public static TimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles);
-   public TimeSpan Subtract(TimeSpan ts);
-   int System.IComparable.CompareTo(object value);
-   public override string ToString();
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider formatProvider);
-   public static bool TryParse(string input, IFormatProvider formatProvider, out TimeSpan result);
-   public static bool TryParse(string s, out TimeSpan result);
-   public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result);
-   public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, out TimeSpan result);
-   public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result);
-   public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, out TimeSpan result);
  }
- public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo> {
-   public TimeSpan BaseUtcOffset { get; }
-   public string DaylightName { get; }
-   public string DisplayName { get; }
-   public string Id { get; }
-   public static TimeZoneInfo Local { get; }
-   public string StandardName { get; }
-   public bool SupportsDaylightSavingTime { get; }
-   public static TimeZoneInfo Utc { get; }
-   public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo destinationTimeZone);
-   public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone);
-   public static DateTimeOffset ConvertTime(DateTimeOffset dateTimeOffset, TimeZoneInfo destinationTimeZone);
-   public bool Equals(TimeZoneInfo other);
-   public static TimeZoneInfo FindSystemTimeZoneById(string id);
-   public TimeSpan[] GetAmbiguousTimeOffsets(DateTime dateTime);
-   public TimeSpan[] GetAmbiguousTimeOffsets(DateTimeOffset dateTimeOffset);
-   public override int GetHashCode();
-   public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones();
-   public TimeSpan GetUtcOffset(DateTime dateTime);
-   public TimeSpan GetUtcOffset(DateTimeOffset dateTimeOffset);
-   public bool IsAmbiguousTime(DateTime dateTime);
-   public bool IsAmbiguousTime(DateTimeOffset dateTimeOffset);
-   public bool IsDaylightSavingTime(DateTime dateTime);
-   public bool IsDaylightSavingTime(DateTimeOffset dateTimeOffset);
-   public bool IsInvalidTime(DateTime dateTime);
-   public override string ToString();
  }
- public static class Tuple {
-   public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8);
-   public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7);
-   public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6);
-   public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);
-   public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4);
-   public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3);
-   public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2);
-   public static Tuple<T1> Create<T1>(T1 item1);
  }
- public class Tuple<T1> : IComparable, IStructuralComparable, IStructuralEquatable {
-   public Tuple(T1 item1);
-   public T1 Item1 { get; }
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);
-   bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);
-   int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);
-   int System.IComparable.CompareTo(object obj);
-   public override string ToString();
  }
- public class Tuple<T1, T2> : IComparable, IStructuralComparable, IStructuralEquatable {
-   public Tuple(T1 item1, T2 item2);
-   public T1 Item1 { get; }
-   public T2 Item2 { get; }
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);
-   bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);
-   int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);
-   int System.IComparable.CompareTo(object obj);
-   public override string ToString();
  }
- public class Tuple<T1, T2, T3> : IComparable, IStructuralComparable, IStructuralEquatable {
-   public Tuple(T1 item1, T2 item2, T3 item3);
-   public T1 Item1 { get; }
-   public T2 Item2 { get; }
-   public T3 Item3 { get; }
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);
-   bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);
-   int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);
-   int System.IComparable.CompareTo(object obj);
-   public override string ToString();
  }
- public class Tuple<T1, T2, T3, T4> : IComparable, IStructuralComparable, IStructuralEquatable {
-   public Tuple(T1 item1, T2 item2, T3 item3, T4 item4);
-   public T1 Item1 { get; }
-   public T2 Item2 { get; }
-   public T3 Item3 { get; }
-   public T4 Item4 { get; }
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);
-   bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);
-   int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);
-   int System.IComparable.CompareTo(object obj);
-   public override string ToString();
  }
- public class Tuple<T1, T2, T3, T4, T5> : IComparable, IStructuralComparable, IStructuralEquatable {
-   public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);
-   public T1 Item1 { get; }
-   public T2 Item2 { get; }
-   public T3 Item3 { get; }
-   public T4 Item4 { get; }
-   public T5 Item5 { get; }
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);
-   bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);
-   int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);
-   int System.IComparable.CompareTo(object obj);
-   public override string ToString();
  }
- public class Tuple<T1, T2, T3, T4, T5, T6> : IComparable, IStructuralComparable, IStructuralEquatable {
-   public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6);
-   public T1 Item1 { get; }
-   public T2 Item2 { get; }
-   public T3 Item3 { get; }
-   public T4 Item4 { get; }
-   public T5 Item5 { get; }
-   public T6 Item6 { get; }
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);
-   bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);
-   int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);
-   int System.IComparable.CompareTo(object obj);
-   public override string ToString();
  }
- public class Tuple<T1, T2, T3, T4, T5, T6, T7> : IComparable, IStructuralComparable, IStructuralEquatable {
-   public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7);
-   public T1 Item1 { get; }
-   public T2 Item2 { get; }
-   public T3 Item3 { get; }
-   public T4 Item4 { get; }
-   public T5 Item5 { get; }
-   public T6 Item6 { get; }
-   public T7 Item7 { get; }
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);
-   bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);
-   int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);
-   int System.IComparable.CompareTo(object obj);
-   public override string ToString();
  }
- public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IComparable, IStructuralComparable, IStructuralEquatable {
-   public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest);
-   public T1 Item1 { get; }
-   public T2 Item2 { get; }
-   public T3 Item3 { get; }
-   public T4 Item4 { get; }
-   public T5 Item5 { get; }
-   public T6 Item6 { get; }
-   public T7 Item7 { get; }
-   public TRest Rest { get; }
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);
-   bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);
-   int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);
-   int System.IComparable.CompareTo(object obj);
-   public override string ToString();
  }
- public abstract class Type {
-   public static readonly object Missing;
-   public static readonly Type[] EmptyTypes;
-   public abstract string AssemblyQualifiedName { get; }
-   public abstract Type DeclaringType { get; }
-   public abstract string FullName { get; }
-   public abstract int GenericParameterPosition { get; }
-   public abstract Type[] GenericTypeArguments { get; }
-   public bool HasElementType { get; }
-   public virtual bool IsArray { get; }
-   public virtual bool IsByRef { get; }
-   public abstract bool IsConstructedGenericType { get; }
-   public abstract bool IsGenericParameter { get; }
-   public bool IsNested { get; }
-   public virtual bool IsPointer { get; }
-   public abstract string Name { get; }
-   public abstract string Namespace { get; }
-   public virtual RuntimeTypeHandle TypeHandle { get; }
-   public override bool Equals(object o);
-   public bool Equals(Type o);
-   public abstract int GetArrayRank();
-   public abstract Type GetElementType();
-   public abstract Type GetGenericTypeDefinition();
-   public override int GetHashCode();
-   public static Type GetType(string typeName);
-   public static Type GetType(string typeName, bool throwOnError);
-   public static Type GetType(string typeName, bool throwOnError, bool ignoreCase);
-   public static Type GetTypeFromHandle(RuntimeTypeHandle handle);
-   public abstract Type MakeArrayType();
-   public abstract Type MakeArrayType(int rank);
-   public abstract Type MakeByRefType();
-   public abstract Type MakeGenericType(params Type[] typeArguments);
-   public abstract Type MakePointerType();
-   public override string ToString();
  }
- public class TypeAccessException : TypeLoadException {
-   public TypeAccessException();
-   public TypeAccessException(string message);
-   public TypeAccessException(string message, Exception inner);
  }
- public enum TypeCode {
-   Boolean = 3,
-   Byte = 6,
-   Char = 4,
-   DateTime = 16,
-   Decimal = 15,
-   Double = 14,
-   Empty = 0,
-   Int16 = 7,
-   Int32 = 9,
-   Int64 = 11,
-   Object = 1,
-   SByte = 5,
-   Single = 13,
-   String = 18,
-   UInt16 = 8,
-   UInt32 = 10,
-   UInt64 = 12,
  }
- public sealed class TypeInitializationException : Exception {
-   public TypeInitializationException(string fullTypeName, Exception innerException);
-   public string TypeName { get; }
  }
- public class TypeLoadException : Exception {
-   public TypeLoadException();
-   public TypeLoadException(string message);
-   public TypeLoadException(string message, Exception inner);
-   public override string Message { get; }
-   public string TypeName { get; }
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct UInt16 : IComparable, IComparable<ushort>, IConvertible, IEquatable<ushort>, IFormattable {
-   public const ushort MaxValue = (ushort)65535;
-   public const ushort MinValue = (ushort)0;
-   public int CompareTo(ushort value);
-   public override bool Equals(object obj);
-   public bool Equals(ushort obj);
-   public override int GetHashCode();
-   public static ushort Parse(string s);
-   public static ushort Parse(string s, NumberStyles style);
-   public static ushort Parse(string s, NumberStyles style, IFormatProvider provider);
-   public static ushort Parse(string s, IFormatProvider provider);
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public override string ToString();
-   public string ToString(IFormatProvider provider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider provider);
-   public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result);
-   public static bool TryParse(string s, out ushort result);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct UInt32 : IComparable, IComparable<uint>, IConvertible, IEquatable<uint>, IFormattable {
-   public const uint MaxValue = (uint)4294967295;
-   public const uint MinValue = (uint)0;
-   public int CompareTo(uint value);
-   public override bool Equals(object obj);
-   public bool Equals(uint obj);
-   public override int GetHashCode();
-   public static uint Parse(string s);
-   public static uint Parse(string s, NumberStyles style);
-   public static uint Parse(string s, NumberStyles style, IFormatProvider provider);
-   public static uint Parse(string s, IFormatProvider provider);
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public override string ToString();
-   public string ToString(IFormatProvider provider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider provider);
-   public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result);
-   public static bool TryParse(string s, out uint result);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct UInt64 : IComparable, IComparable<ulong>, IConvertible, IEquatable<ulong>, IFormattable {
-   public const ulong MaxValue = (ulong)18446744073709551615;
-   public const ulong MinValue = (ulong)0;
-   public int CompareTo(ulong value);
-   public override bool Equals(object obj);
-   public bool Equals(ulong obj);
-   public override int GetHashCode();
-   public static ulong Parse(string s);
-   public static ulong Parse(string s, NumberStyles style);
-   public static ulong Parse(string s, NumberStyles style, IFormatProvider provider);
-   public static ulong Parse(string s, IFormatProvider provider);
-   int System.IComparable.CompareTo(object value);
-   TypeCode System.IConvertible.GetTypeCode();
-   bool System.IConvertible.ToBoolean(IFormatProvider provider);
-   byte System.IConvertible.ToByte(IFormatProvider provider);
-   char System.IConvertible.ToChar(IFormatProvider provider);
-   DateTime System.IConvertible.ToDateTime(IFormatProvider provider);
-   decimal System.IConvertible.ToDecimal(IFormatProvider provider);
-   double System.IConvertible.ToDouble(IFormatProvider provider);
-   short System.IConvertible.ToInt16(IFormatProvider provider);
-   int System.IConvertible.ToInt32(IFormatProvider provider);
-   long System.IConvertible.ToInt64(IFormatProvider provider);
-   sbyte System.IConvertible.ToSByte(IFormatProvider provider);
-   float System.IConvertible.ToSingle(IFormatProvider provider);
-   object System.IConvertible.ToType(Type type, IFormatProvider provider);
-   ushort System.IConvertible.ToUInt16(IFormatProvider provider);
-   uint System.IConvertible.ToUInt32(IFormatProvider provider);
-   ulong System.IConvertible.ToUInt64(IFormatProvider provider);
-   public override string ToString();
-   public string ToString(IFormatProvider provider);
-   public string ToString(string format);
-   public string ToString(string format, IFormatProvider provider);
-   public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result);
-   public static bool TryParse(string s, out ulong result);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct UIntPtr {
-   public static readonly UIntPtr Zero;
-   public UIntPtr(uint value);
-   public UIntPtr(ulong value);
-   public unsafe UIntPtr(void* value);
-   public static int Size { get; }
-   public static UIntPtr Add(UIntPtr pointer, int offset);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public static UIntPtr operator +(UIntPtr pointer, int offset);
-   public static bool operator ==(UIntPtr value1, UIntPtr value2);
-   public static explicit operator UIntPtr (uint value);
-   public static explicit operator UIntPtr (ulong value);
-   public static explicit operator uint (UIntPtr value);
-   public static explicit operator ulong (UIntPtr value);
-   public unsafe static explicit operator void* (UIntPtr value);
-   public unsafe static explicit operator UIntPtr (void* value);
-   public static bool operator !=(UIntPtr value1, UIntPtr value2);
-   public static UIntPtr operator -(UIntPtr pointer, int offset);
-   public static UIntPtr Subtract(UIntPtr pointer, int offset);
-   public unsafe void* ToPointer();
-   public override string ToString();
-   public uint ToUInt32();
-   public ulong ToUInt64();
  }
- public class UnauthorizedAccessException : Exception {
-   public UnauthorizedAccessException();
-   public UnauthorizedAccessException(string message);
-   public UnauthorizedAccessException(string message, Exception inner);
  }
- public class Uri {
-   public Uri(string uriString);
-   public Uri(string uriString, UriKind uriKind);
-   public Uri(Uri baseUri, string relativeUri);
-   public Uri(Uri baseUri, Uri relativeUri);
-   public string AbsolutePath { get; }
-   public string AbsoluteUri { get; }
-   public string Authority { get; }
-   public string DnsSafeHost { get; }
-   public string Fragment { get; }
-   public string Host { get; }
-   public UriHostNameType HostNameType { get; }
-   public string IdnHost { get; }
-   public bool IsAbsoluteUri { get; }
-   public bool IsDefaultPort { get; }
-   public bool IsFile { get; }
-   public bool IsLoopback { get; }
-   public bool IsUnc { get; }
-   public string LocalPath { get; }
-   public string OriginalString { get; }
-   public string PathAndQuery { get; }
-   public int Port { get; }
-   public string Query { get; }
-   public string Scheme { get; }
-   public string[] Segments { get; }
-   public bool UserEscaped { get; }
-   public string UserInfo { get; }
-   public static UriHostNameType CheckHostName(string name);
-   public static bool CheckSchemeName(string schemeName);
-   public static int Compare(Uri uri1, Uri uri2, UriComponents partsToCompare, UriFormat compareFormat, StringComparison comparisonType);
-   public override bool Equals(object comparand);
-   public static string EscapeDataString(string stringToEscape);
-   public static string EscapeUriString(string stringToEscape);
-   public string GetComponents(UriComponents components, UriFormat format);
-   public override int GetHashCode();
-   public bool IsBaseOf(Uri uri);
-   public bool IsWellFormedOriginalString();
-   public static bool IsWellFormedUriString(string uriString, UriKind uriKind);
-   public Uri MakeRelativeUri(Uri uri);
-   public static bool operator ==(Uri uri1, Uri uri2);
-   public static bool operator !=(Uri uri1, Uri uri2);
-   public override string ToString();
-   public static bool TryCreate(string uriString, UriKind uriKind, out Uri result);
-   public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result);
-   public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result);
-   public static string UnescapeDataString(string stringToUnescape);
  }
- public enum UriComponents {
-   AbsoluteUri = 127,
-   Fragment = 64,
-   Host = 4,
-   HostAndPort = 132,
-   HttpRequestUrl = 61,
-   KeepDelimiter = 1073741824,
-   NormalizedHost = 256,
-   Path = 16,
-   PathAndQuery = 48,
-   Port = 8,
-   Query = 32,
-   Scheme = 1,
-   SchemeAndServer = 13,
-   SerializationInfoString = -2147483648,
-   StrongAuthority = 134,
-   StrongPort = 128,
-   UserInfo = 2,
  }
- public enum UriFormat {
-   SafeUnescaped = 3,
-   Unescaped = 2,
-   UriEscaped = 1,
  }
- public class UriFormatException : FormatException {
-   public UriFormatException();
-   public UriFormatException(string textString);
-   public UriFormatException(string textString, Exception e);
  }
- public enum UriHostNameType {
-   Basic = 1,
-   Dns = 2,
-   IPv4 = 3,
-   IPv6 = 4,
-   Unknown = 0,
  }
- public enum UriKind {
-   Absolute = 1,
-   Relative = 2,
-   RelativeOrAbsolute = 0,
  }
- public abstract class ValueType {
-   protected ValueType();
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public override string ToString();
  }
- public sealed class Version : IComparable, IComparable<Version>, IEquatable<Version> {
-   public Version(int major, int minor);
-   public Version(int major, int minor, int build);
-   public Version(int major, int minor, int build, int revision);
-   public Version(string version);
-   public int Build { get; }
-   public int Major { get; }
-   public short MajorRevision { get; }
-   public int Minor { get; }
-   public short MinorRevision { get; }
-   public int Revision { get; }
-   public int CompareTo(Version value);
-   public override bool Equals(object obj);
-   public bool Equals(Version obj);
-   public override int GetHashCode();
-   public static bool operator ==(Version v1, Version v2);
-   public static bool operator >(Version v1, Version v2);
-   public static bool operator >=(Version v1, Version v2);
-   public static bool operator !=(Version v1, Version v2);
-   public static bool operator <(Version v1, Version v2);
-   public static bool operator <=(Version v1, Version v2);
-   public static Version Parse(string input);
-   int System.IComparable.CompareTo(object version);
-   public override string ToString();
-   public string ToString(int fieldCount);
-   public static bool TryParse(string input, out Version result);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
  public struct Void {
  }
- public class WeakReference {
-   public WeakReference(object target);
-   public WeakReference(object target, bool trackResurrection);
-   public virtual bool IsAlive { get; }
-   public virtual object Target { get; set; }
-   public virtual bool TrackResurrection { get; }
-   ~WeakReference();
  }
- public sealed class WeakReference<T> where T : class {
-   public WeakReference(T target);
-   public WeakReference(T target, bool trackResurrection);
-   ~WeakReference();
-   public void SetTarget(T target);
-   public bool TryGetTarget(out T target);
  }
 }
-namespace System.Collections {
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct DictionaryEntry {
-   public DictionaryEntry(object key, object value);
-   public object Key { get; set; }
-   public object Value { get; set; }
  }
- public interface ICollection : IEnumerable {
-   int Count { get; }
-   bool IsSynchronized { get; }
-   object SyncRoot { get; }
-   void CopyTo(Array array, int index);
  }
- public interface IComparer {
-   int Compare(object x, object y);
  }
- public interface IDictionary : ICollection, IEnumerable {
-   bool IsFixedSize { get; }
-   bool IsReadOnly { get; }
-   ICollection Keys { get; }
-   object this[object key] { get; set; }
-   ICollection Values { get; }
-   void Add(object key, object value);
-   void Clear();
-   bool Contains(object key);
-   new IDictionaryEnumerator GetEnumerator();
-   void Remove(object key);
  }
- public interface IDictionaryEnumerator : IEnumerator {
-   DictionaryEntry Entry { get; }
-   object Key { get; }
-   object Value { get; }
  }
- public interface IEnumerable {
-   IEnumerator GetEnumerator();
  }
- public interface IEnumerator {
-   object Current { get; }
-   bool MoveNext();
-   void Reset();
  }
- public interface IEqualityComparer {
-   bool Equals(object x, object y);
-   int GetHashCode(object obj);
  }
- public interface IList : ICollection, IEnumerable {
-   bool IsFixedSize { get; }
-   bool IsReadOnly { get; }
-   object this[int index] { get; set; }
-   int Add(object value);
-   void Clear();
-   bool Contains(object value);
-   int IndexOf(object value);
-   void Insert(int index, object value);
-   void Remove(object value);
-   void RemoveAt(int index);
  }
- public interface IStructuralComparable {
-   int CompareTo(object other, IComparer comparer);
  }
- public interface IStructuralEquatable {
-   bool Equals(object other, IEqualityComparer comparer);
-   int GetHashCode(IEqualityComparer comparer);
  }
 }
-namespace System.Collections.Generic {
- public interface ICollection<T> : IEnumerable, IEnumerable<T> {
-   int Count { get; }
-   bool IsReadOnly { get; }
-   void Add(T item);
-   void Clear();
-   bool Contains(T item);
-   void CopyTo(T[] array, int arrayIndex);
-   bool Remove(T item);
  }
- public interface IComparer<in T> {
-   int Compare(T x, T y);
  }
- public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable, IEnumerable<KeyValuePair<TKey, TValue>> {
-   ICollection<TKey> Keys { get; }
-   TValue this[TKey key] { get; set; }
-   ICollection<TValue> Values { get; }
-   void Add(TKey key, TValue value);
-   bool ContainsKey(TKey key);
-   bool Remove(TKey key);
-   bool TryGetValue(TKey key, out TValue value);
  }
- public interface IEnumerable<out T> : IEnumerable {
-   new IEnumerator<T> GetEnumerator();
  }
- public interface IEnumerator<out T> : IDisposable, IEnumerator {
-   new T Current { get; }
  }
- public interface IEqualityComparer<in T> {
-   bool Equals(T x, T y);
-   int GetHashCode(T obj);
  }
- public interface IList<T> : ICollection<T>, IEnumerable, IEnumerable<T> {
-   T this[int index] { get; set; }
-   int IndexOf(T item);
-   void Insert(int index, T item);
-   void RemoveAt(int index);
  }
- public interface IReadOnlyCollection<out T> : IEnumerable, IEnumerable<T> {
-   int Count { get; }
  }
- public interface IReadOnlyDictionary<TKey, TValue> : IEnumerable, IEnumerable<KeyValuePair<TKey, TValue>>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> {
-   IEnumerable<TKey> Keys { get; }
-   TValue this[TKey key] { get; }
-   IEnumerable<TValue> Values { get; }
-   bool ContainsKey(TKey key);
-   bool TryGetValue(TKey key, out TValue value);
  }
- public interface IReadOnlyList<out T> : IEnumerable, IEnumerable<T>, IReadOnlyCollection<T> {
-   T this[int index] { get; }
  }
- public interface ISet<T> : ICollection<T>, IEnumerable, IEnumerable<T> {
-   new bool Add(T item);
-   void ExceptWith(IEnumerable<T> other);
-   void IntersectWith(IEnumerable<T> other);
-   bool IsProperSubsetOf(IEnumerable<T> other);
-   bool IsProperSupersetOf(IEnumerable<T> other);
-   bool IsSubsetOf(IEnumerable<T> other);
-   bool IsSupersetOf(IEnumerable<T> other);
-   bool Overlaps(IEnumerable<T> other);
-   bool SetEquals(IEnumerable<T> other);
-   void SymmetricExceptWith(IEnumerable<T> other);
-   void UnionWith(IEnumerable<T> other);
  }
- public class KeyNotFoundException : Exception {
-   public KeyNotFoundException();
-   public KeyNotFoundException(string message);
-   public KeyNotFoundException(string message, Exception innerException);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct KeyValuePair<TKey, TValue> {
-   public KeyValuePair(TKey key, TValue value);
-   public TKey Key { get; }
-   public TValue Value { get; }
-   public override string ToString();
  }
 }
-namespace System.Collections.ObjectModel {
- public class Collection<T> : ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, IList, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T> {
-   public Collection();
-   public Collection(IList<T> list);
-   public int Count { get; }
-   protected IList<T> Items { get; }
-   bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
-   bool System.Collections.ICollection.IsSynchronized { get; }
-   object System.Collections.ICollection.SyncRoot { get; }
-   bool System.Collections.IList.IsFixedSize { get; }
-   bool System.Collections.IList.IsReadOnly { get; }
-   object System.Collections.IList.this[int index] { get; set; }
-   public T this[int index] { get; set; }
-   public void Add(T item);
-   public void Clear();
-   protected virtual void ClearItems();
-   public bool Contains(T item);
-   public void CopyTo(T[] array, int index);
-   public IEnumerator<T> GetEnumerator();
-   public int IndexOf(T item);
-   public void Insert(int index, T item);
-   protected virtual void InsertItem(int index, T item);
-   public bool Remove(T item);
-   public void RemoveAt(int index);
-   protected virtual void RemoveItem(int index);
-   protected virtual void SetItem(int index, T item);
-   void System.Collections.ICollection.CopyTo(Array array, int index);
-   IEnumerator System.Collections.IEnumerable.GetEnumerator();
-   int System.Collections.IList.Add(object value);
-   bool System.Collections.IList.Contains(object value);
-   int System.Collections.IList.IndexOf(object value);
-   void System.Collections.IList.Insert(int index, object value);
-   void System.Collections.IList.Remove(object value);
  }
- public class ReadOnlyCollection<T> : ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, IList, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T> {
-   public ReadOnlyCollection(IList<T> list);
-   public int Count { get; }
-   protected IList<T> Items { get; }
-   bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
-   T System.Collections.Generic.IList<T>.this[int index] { get; set; }
-   bool System.Collections.ICollection.IsSynchronized { get; }
-   object System.Collections.ICollection.SyncRoot { get; }
-   bool System.Collections.IList.IsFixedSize { get; }
-   bool System.Collections.IList.IsReadOnly { get; }
-   object System.Collections.IList.this[int index] { get; set; }
-   public T this[int index] { get; }
-   public bool Contains(T value);
-   public void CopyTo(T[] array, int index);
-   public IEnumerator<T> GetEnumerator();
-   public int IndexOf(T value);
-   void System.Collections.Generic.ICollection<T>.Add(T value);
-   void System.Collections.Generic.ICollection<T>.Clear();
-   bool System.Collections.Generic.ICollection<T>.Remove(T value);
-   void System.Collections.Generic.IList<T>.Insert(int index, T value);
-   void System.Collections.Generic.IList<T>.RemoveAt(int index);
-   void System.Collections.ICollection.CopyTo(Array array, int index);
-   IEnumerator System.Collections.IEnumerable.GetEnumerator();
-   int System.Collections.IList.Add(object value);
-   void System.Collections.IList.Clear();
-   bool System.Collections.IList.Contains(object value);
-   int System.Collections.IList.IndexOf(object value);
-   void System.Collections.IList.Insert(int index, object value);
-   void System.Collections.IList.Remove(object value);
-   void System.Collections.IList.RemoveAt(int index);
  }
 }
-namespace System.ComponentModel {
- public class DefaultValueAttribute : Attribute {
-   public DefaultValueAttribute(bool value);
-   public DefaultValueAttribute(byte value);
-   public DefaultValueAttribute(char value);
-   public DefaultValueAttribute(double value);
-   public DefaultValueAttribute(short value);
-   public DefaultValueAttribute(int value);
-   public DefaultValueAttribute(long value);
-   public DefaultValueAttribute(object value);
-   public DefaultValueAttribute(float value);
-   public DefaultValueAttribute(string value);
-   public DefaultValueAttribute(Type type, string value);
-   public virtual object Value { get; }
-   public override bool Equals(object obj);
-   public override int GetHashCode();
  }
- public sealed class EditorBrowsableAttribute : Attribute {
-   public EditorBrowsableAttribute(EditorBrowsableState state);
-   public EditorBrowsableState State { get; }
-   public override bool Equals(object obj);
-   public override int GetHashCode();
  }
- public enum EditorBrowsableState {
-   Advanced = 2,
-   Always = 0,
-   Never = 1,
  }
 }
-namespace System.Diagnostics {
- public sealed class ConditionalAttribute : Attribute {
-   public ConditionalAttribute(string conditionString);
-   public string ConditionString { get; }
  }
- public sealed class DebuggableAttribute : Attribute {
-   public DebuggableAttribute(DebuggableAttribute.DebuggingModes modes);
-   public enum DebuggingModes {
-     Default = 1,
-     DisableOptimizations = 256,
-     EnableEditAndContinue = 4,
-     IgnoreSymbolStoreSequencePoints = 2,
-     None = 0,
    }
  }
 }
-namespace System.Globalization {
- public enum DateTimeStyles {
-   AdjustToUniversal = 16,
-   AllowInnerWhite = 4,
-   AllowLeadingWhite = 1,
-   AllowTrailingWhite = 2,
-   AllowWhiteSpaces = 7,
-   AssumeLocal = 32,
-   AssumeUniversal = 64,
-   NoCurrentDateDefault = 8,
-   None = 0,
-   RoundtripKind = 128,
  }
- public enum NumberStyles {
-   AllowCurrencySymbol = 256,
-   AllowDecimalPoint = 32,
-   AllowExponent = 128,
-   AllowHexSpecifier = 512,
-   AllowLeadingSign = 4,
-   AllowLeadingWhite = 1,
-   AllowParentheses = 16,
-   AllowThousands = 64,
-   AllowTrailingSign = 8,
-   AllowTrailingWhite = 2,
-   Any = 511,
-   Currency = 383,
-   Float = 167,
-   HexNumber = 515,
-   Integer = 7,
-   None = 0,
-   Number = 111,
  }
- public enum TimeSpanStyles {
-   AssumeNegative = 1,
-   None = 0,
  }
 }
-namespace System.IO {
- public class DirectoryNotFoundException : IOException {
-   public DirectoryNotFoundException();
-   public DirectoryNotFoundException(string message);
-   public DirectoryNotFoundException(string message, Exception innerException);
  }
- public class FileLoadException : IOException {
-   public FileLoadException();
-   public FileLoadException(string message);
-   public FileLoadException(string message, Exception inner);
-   public FileLoadException(string message, string fileName);
-   public FileLoadException(string message, string fileName, Exception inner);
-   public string FileName { get; }
-   public override string Message { get; }
-   public override string ToString();
  }
- public class FileNotFoundException : IOException {
-   public FileNotFoundException();
-   public FileNotFoundException(string message);
-   public FileNotFoundException(string message, Exception innerException);
-   public FileNotFoundException(string message, string fileName);
-   public FileNotFoundException(string message, string fileName, Exception innerException);
-   public string FileName { get; }
-   public override string Message { get; }
-   public override string ToString();
  }
- public class IOException : Exception {
-   public IOException();
-   public IOException(string message);
-   public IOException(string message, Exception innerException);
-   public IOException(string message, int hresult);
  }
- public class PathTooLongException : IOException {
-   public PathTooLongException();
-   public PathTooLongException(string message);
-   public PathTooLongException(string message, Exception innerException);
  }
 }
-namespace System.Reflection {
- public sealed class AssemblyCompanyAttribute : Attribute {
-   public AssemblyCompanyAttribute(string company);
-   public string Company { get; }
  }
- public sealed class AssemblyConfigurationAttribute : Attribute {
-   public AssemblyConfigurationAttribute(string configuration);
-   public string Configuration { get; }
  }
- public sealed class AssemblyCopyrightAttribute : Attribute {
-   public AssemblyCopyrightAttribute(string copyright);
-   public string Copyright { get; }
  }
- public sealed class AssemblyCultureAttribute : Attribute {
-   public AssemblyCultureAttribute(string culture);
-   public string Culture { get; }
  }
- public sealed class AssemblyDefaultAliasAttribute : Attribute {
-   public AssemblyDefaultAliasAttribute(string defaultAlias);
-   public string DefaultAlias { get; }
  }
- public sealed class AssemblyDelaySignAttribute : Attribute {
-   public AssemblyDelaySignAttribute(bool delaySign);
-   public bool DelaySign { get; }
  }
- public sealed class AssemblyDescriptionAttribute : Attribute {
-   public AssemblyDescriptionAttribute(string description);
-   public string Description { get; }
  }
- public sealed class AssemblyFileVersionAttribute : Attribute {
-   public AssemblyFileVersionAttribute(string version);
-   public string Version { get; }
  }
- public sealed class AssemblyFlagsAttribute : Attribute {
-   public AssemblyFlagsAttribute(AssemblyNameFlags assemblyFlags);
-   public int AssemblyFlags { get; }
  }
- public sealed class AssemblyInformationalVersionAttribute : Attribute {
-   public AssemblyInformationalVersionAttribute(string informationalVersion);
-   public string InformationalVersion { get; }
  }
- public sealed class AssemblyKeyFileAttribute : Attribute {
-   public AssemblyKeyFileAttribute(string keyFile);
-   public string KeyFile { get; }
  }
- public sealed class AssemblyKeyNameAttribute : Attribute {
-   public AssemblyKeyNameAttribute(string keyName);
-   public string KeyName { get; }
  }
- public sealed class AssemblyMetadataAttribute : Attribute {
-   public AssemblyMetadataAttribute(string key, string value);
-   public string Key { get; }
-   public string Value { get; }
  }
- public enum AssemblyNameFlags {
-   None = 0,
-   PublicKey = 1,
-   Retargetable = 256,
  }
- public sealed class AssemblyProductAttribute : Attribute {
-   public AssemblyProductAttribute(string product);
-   public string Product { get; }
  }
- public sealed class AssemblySignatureKeyAttribute : Attribute {
-   public AssemblySignatureKeyAttribute(string publicKey, string countersignature);
-   public string Countersignature { get; }
-   public string PublicKey { get; }
  }
- public sealed class AssemblyTitleAttribute : Attribute {
-   public AssemblyTitleAttribute(string title);
-   public string Title { get; }
  }
- public sealed class AssemblyTrademarkAttribute : Attribute {
-   public AssemblyTrademarkAttribute(string trademark);
-   public string Trademark { get; }
  }
- public sealed class AssemblyVersionAttribute : Attribute {
-   public AssemblyVersionAttribute(string version);
-   public string Version { get; }
  }
- public sealed class DefaultMemberAttribute : Attribute {
-   public DefaultMemberAttribute(string memberName);
-   public string MemberName { get; }
  }
- public enum ProcessorArchitecture {
-   Amd64 = 4,
-   Arm = 5,
-   IA64 = 3,
-   MSIL = 1,
-   None = 0,
-   X86 = 2,
  }
 }
-namespace System.Runtime {
- public enum GCLargeObjectHeapCompactionMode {
-   CompactOnce = 2,
-   Default = 1,
  }
- public enum GCLatencyMode {
-   Batch = 0,
-   Interactive = 1,
-   LowLatency = 2,
-   SustainedLowLatency = 3,
  }
- public static class GCSettings {
-   public static bool IsServerGC { get; }
-   public static GCLargeObjectHeapCompactionMode LargeObjectHeapCompactionMode { get; set; }
-   public static GCLatencyMode LatencyMode { get; set; }
  }
 }
-namespace System.Runtime.CompilerServices {
- public sealed class AccessedThroughPropertyAttribute : Attribute {
-   public AccessedThroughPropertyAttribute(string propertyName);
-   public string PropertyName { get; }
  }
- public sealed class AsyncStateMachineAttribute : StateMachineAttribute {
-   public AsyncStateMachineAttribute(Type stateMachineType);
  }
- public sealed class CallerFilePathAttribute : Attribute {
-   public CallerFilePathAttribute();
  }
- public sealed class CallerLineNumberAttribute : Attribute {
-   public CallerLineNumberAttribute();
  }
- public sealed class CallerMemberNameAttribute : Attribute {
-   public CallerMemberNameAttribute();
  }
- public class CompilationRelaxationsAttribute : Attribute {
-   public CompilationRelaxationsAttribute(int relaxations);
-   public int CompilationRelaxations { get; }
  }
- public sealed class CompilerGeneratedAttribute : Attribute {
-   public CompilerGeneratedAttribute();
  }
- public sealed class ConditionalWeakTable<TKey, TValue> where TKey : class where TValue : class {
-   public ConditionalWeakTable();
-   public void Add(TKey key, TValue value);
-   ~ConditionalWeakTable();
-   public TValue GetOrCreateValue(TKey key);
-   public TValue GetValue(TKey key, ConditionalWeakTable<TKey, TValue>.CreateValueCallback createValueCallback);
-   public bool Remove(TKey key);
-   public bool TryGetValue(TKey key, out TValue value);
-   public delegate TValue CreateValueCallback(TKey key);
  }
- public abstract class CustomConstantAttribute : Attribute {
-   protected CustomConstantAttribute();
-   public abstract object Value { get; }
  }
- public sealed class DateTimeConstantAttribute : CustomConstantAttribute {
-   public DateTimeConstantAttribute(long ticks);
-   public override object Value { get; }
  }
- public sealed class DecimalConstantAttribute : Attribute {
-   public DecimalConstantAttribute(byte scale, byte sign, int hi, int mid, int low);
-   public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low);
-   public decimal Value { get; }
  }
- public sealed class DisablePrivateReflectionAttribute : Attribute {
-   public DisablePrivateReflectionAttribute();
  }
- public sealed class ExtensionAttribute : Attribute {
-   public ExtensionAttribute();
  }
- public sealed class FixedBufferAttribute : Attribute {
-   public FixedBufferAttribute(Type elementType, int length);
-   public Type ElementType { get; }
-   public int Length { get; }
  }
- public static class FormattableStringFactory {
-   public static FormattableString Create(string format, params object[] arguments);
  }
- public sealed class IndexerNameAttribute : Attribute {
-   public IndexerNameAttribute(string indexerName);
  }
- public sealed class InternalsVisibleToAttribute : Attribute {
-   public InternalsVisibleToAttribute(string assemblyName);
-   public string AssemblyName { get; }
  }
- public static class IsConst {
  }
- public interface IStrongBox {
-   object Value { get; set; }
  }
- public static class IsVolatile {
  }
- public sealed class IteratorStateMachineAttribute : StateMachineAttribute {
-   public IteratorStateMachineAttribute(Type stateMachineType);
  }
- public sealed class MethodImplAttribute : Attribute {
-   public MethodImplAttribute(MethodImplOptions methodImplOptions);
-   public MethodImplOptions Value { get; }
  }
- public enum MethodImplOptions {
-   AggressiveInlining = 256,
-   NoInlining = 8,
-   NoOptimization = 64,
-   PreserveSig = 128,
  }
- public sealed class ReferenceAssemblyAttribute : Attribute {
-   public ReferenceAssemblyAttribute();
-   public ReferenceAssemblyAttribute(string description);
-   public string Description { get; }
  }
- public sealed class RuntimeCompatibilityAttribute : Attribute {
-   public RuntimeCompatibilityAttribute();
-   public bool WrapNonExceptionThrows { get; set; }
  }
- public static class RuntimeHelpers {
-   public static int OffsetToStringData { get; }
-   public static void EnsureSufficientExecutionStack();
-   public static int GetHashCode(object o);
-   public static object GetObjectValue(object obj);
-   public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle);
-   public static void RunClassConstructor(RuntimeTypeHandle type);
  }
- public class StateMachineAttribute : Attribute {
-   public StateMachineAttribute(Type stateMachineType);
-   public Type StateMachineType { get; }
  }
- public class StrongBox<T> : IStrongBox {
-   public T Value;
-   public StrongBox();
-   public StrongBox(T value);
-   object System.Runtime.CompilerServices.IStrongBox.Value { get; set; }
  }
- public sealed class TypeForwardedFromAttribute : Attribute {
-   public TypeForwardedFromAttribute(string assemblyFullName);
-   public string AssemblyFullName { get; }
  }
- public sealed class TypeForwardedToAttribute : Attribute {
-   public TypeForwardedToAttribute(Type destination);
-   public Type Destination { get; }
  }
- public sealed class UnsafeValueTypeAttribute : Attribute {
-   public UnsafeValueTypeAttribute();
  }
 }
-namespace System.Runtime.ExceptionServices {
- public sealed class ExceptionDispatchInfo {
-   public Exception SourceException { get; }
-   public static ExceptionDispatchInfo Capture(Exception source);
-   public void Throw();
  }
 }
-namespace System.Runtime.InteropServices {
- public enum CharSet {
-   Ansi = 2,
-   Unicode = 3,
  }
- public sealed class ComVisibleAttribute : Attribute {
-   public ComVisibleAttribute(bool visibility);
-   public bool Value { get; }
  }
- public sealed class FieldOffsetAttribute : Attribute {
-   public FieldOffsetAttribute(int offset);
-   public int Value { get; }
  }
- public enum LayoutKind {
-   Auto = 3,
-   Explicit = 2,
-   Sequential = 0,
  }
- public sealed class OutAttribute : Attribute {
-   public OutAttribute();
  }
- public sealed class StructLayoutAttribute : Attribute {
-   public int Pack;
-   public int Size;
-   public CharSet CharSet;
-   public StructLayoutAttribute(LayoutKind layoutKind);
-   public LayoutKind Value { get; }
  }
 }
-namespace System.Runtime.Versioning {
- public sealed class TargetFrameworkAttribute : Attribute {
-   public TargetFrameworkAttribute(string frameworkName);
-   public string FrameworkDisplayName { get; set; }
-   public string FrameworkName { get; }
  }
 }
-namespace System.Security {
- public sealed class AllowPartiallyTrustedCallersAttribute : Attribute {
-   public AllowPartiallyTrustedCallersAttribute();
  }
- public sealed class SecurityCriticalAttribute : Attribute {
-   public SecurityCriticalAttribute();
  }
- public class SecurityException : Exception {
-   public SecurityException();
-   public SecurityException(string message);
-   public SecurityException(string message, Exception inner);
-   public override string ToString();
  }
- public sealed class SecuritySafeCriticalAttribute : Attribute {
-   public SecuritySafeCriticalAttribute();
  }
- public sealed class SecurityTransparentAttribute : Attribute {
-   public SecurityTransparentAttribute();
  }
- public class VerificationException : Exception {
-   public VerificationException();
-   public VerificationException(string message);
-   public VerificationException(string message, Exception innerException);
  }
 }
-namespace System.Text {
- public sealed class StringBuilder {
-   public StringBuilder();
-   public StringBuilder(int capacity);
-   public StringBuilder(int capacity, int maxCapacity);
-   public StringBuilder(string value);
-   public StringBuilder(string value, int capacity);
-   public StringBuilder(string value, int startIndex, int length, int capacity);
-   public int Capacity { get; set; }
-   public int Length { get; set; }
-   public int MaxCapacity { get; }
-   [System.Runtime.CompilerServices.IndexerName("Chars")]
    public char this[int index] { get; set; }
-   public StringBuilder Append(bool value);
-   public StringBuilder Append(byte value);
-   public StringBuilder Append(char value);
-   public unsafe StringBuilder Append(char* value, int valueCount);
-   public StringBuilder Append(char value, int repeatCount);
-   public StringBuilder Append(char[] value);
-   public StringBuilder Append(char[] value, int startIndex, int charCount);
-   public StringBuilder Append(decimal value);
-   public StringBuilder Append(double value);
-   public StringBuilder Append(short value);
-   public StringBuilder Append(int value);
-   public StringBuilder Append(long value);
-   public StringBuilder Append(object value);
-   public StringBuilder Append(sbyte value);
-   public StringBuilder Append(float value);
-   public StringBuilder Append(string value);
-   public StringBuilder Append(string value, int startIndex, int count);
-   public StringBuilder Append(ushort value);
-   public StringBuilder Append(uint value);
-   public StringBuilder Append(ulong value);
-   public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0);
-   public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1);
-   public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2);
-   public StringBuilder AppendFormat(IFormatProvider provider, string format, params object[] args);
-   public StringBuilder AppendFormat(string format, object arg0);
-   public StringBuilder AppendFormat(string format, object arg0, object arg1);
-   public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2);
-   public StringBuilder AppendFormat(string format, params object[] args);
-   public StringBuilder AppendLine();
-   public StringBuilder AppendLine(string value);
-   public StringBuilder Clear();
-   public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);
-   public int EnsureCapacity(int capacity);
-   public bool Equals(StringBuilder sb);
-   public StringBuilder Insert(int index, bool value);
-   public StringBuilder Insert(int index, byte value);
-   public StringBuilder Insert(int index, char value);
-   public StringBuilder Insert(int index, char[] value);
-   public StringBuilder Insert(int index, char[] value, int startIndex, int charCount);
-   public StringBuilder Insert(int index, decimal value);
-   public StringBuilder Insert(int index, double value);
-   public StringBuilder Insert(int index, short value);
-   public StringBuilder Insert(int index, int value);
-   public StringBuilder Insert(int index, long value);
-   public StringBuilder Insert(int index, object value);
-   public StringBuilder Insert(int index, sbyte value);
-   public StringBuilder Insert(int index, float value);
-   public StringBuilder Insert(int index, string value);
-   public StringBuilder Insert(int index, string value, int count);
-   public StringBuilder Insert(int index, ushort value);
-   public StringBuilder Insert(int index, uint value);
-   public StringBuilder Insert(int index, ulong value);
-   public StringBuilder Remove(int startIndex, int length);
-   public StringBuilder Replace(char oldChar, char newChar);
-   public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count);
-   public StringBuilder Replace(string oldValue, string newValue);
-   public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count);
-   public override string ToString();
-   public string ToString(int startIndex, int length);
  }
 }
-namespace System.Threading {
- public enum LazyThreadSafetyMode {
-   ExecutionAndPublication = 2,
-   None = 0,
-   PublicationOnly = 1,
  }
- public static class Timeout {
-   public const int Infinite = -1;
-   public static readonly TimeSpan InfiniteTimeSpan;
  }
- public abstract class WaitHandle : IDisposable {
-   public const int WaitTimeout = 258;
-   protected static readonly IntPtr InvalidHandle;
-   protected WaitHandle();
-   public void Dispose();
-   protected virtual void Dispose(bool explicitDisposing);
-   public static bool WaitAll(WaitHandle[] waitHandles);
-   public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout);
-   public static bool WaitAll(WaitHandle[] waitHandles, TimeSpan timeout);
-   public static int WaitAny(WaitHandle[] waitHandles);
-   public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout);
-   public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout);
-   public virtual bool WaitOne();
-   public virtual bool WaitOne(int millisecondsTimeout);
-   public virtual bool WaitOne(TimeSpan timeout);
  }
 }
```
