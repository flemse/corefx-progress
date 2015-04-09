namespace Microsoft.VisualBasic {
  public enum CallType {
    Get = 2,
    Let = 4,
    Method = 1,
    Set = 8,
  }
  public sealed class Constants {
    public const string vbBack = "\b";
    public const string vbCr = "\r";
    public const string vbCrLf = "\r\n";
    public const string vbFormFeed = "\f";
    public const string vbLf = "\n";
    public const string vbNewLine = "\r\n";
    public const string vbNullChar = "\0";
    public const string vbNullString = null;
    public const string vbTab = "\t";
    public const string vbVerticalTab = "\v";
  }
  public sealed class ControlChars {
    public const char Back = '\b';
    public const char Cr = '\r';
    public const char FormFeed = '\f';
    public const char Lf = '\n';
    public const char NullChar = '\0';
    public const char Quote = '"';
    public const char Tab = '\t';
    public const char VerticalTab = '\v';
    public const string CrLf = "\r\n";
    public const string NewLine = "\r\n";
    public ControlChars();
  }
  public class HideModuleNameAttribute : Attribute {
    public HideModuleNameAttribute();
  }
  public sealed class Interaction {
  }
  public sealed class Strings {
    public static int AscW(char @string);
    public static int AscW(string @string);
    public static char ChrW(int charCode);
    public static string Left(string str, int length);
  }
}
namespace Microsoft.VisualBasic.CompilerServices {
  public class Conversions {
    public static object ChangeType(object expression, Type targetType);
    public static object FallbackUserDefinedConversion(object expression, Type targetType);
    public static CultureInfo GetCultureInfo();
    public static bool IsHexOrOctValue(string value, ref long i64Value);
    public static bool IsHexOrOctValue(string value, ref ulong ui64Value);
    public static bool ToBoolean(object value);
    public static bool ToBoolean(string value);
    public static byte ToByte(object value);
    public static byte ToByte(string value);
    public static char ToChar(object value);
    public static char ToChar(string value);
    public static char[] ToCharArrayRankOne(object value);
    public static char[] ToCharArrayRankOne(string value);
    public static DateTime ToDate(object value);
    public static DateTime ToDate(string value);
    public static decimal ToDecimal(bool value);
    public static decimal ToDecimal(object value);
    public static decimal ToDecimal(string value);
    public static double ToDouble(object value);
    public static double ToDouble(string value);
    public static T ToGenericParameter<T>(object value);
    public static string ToHalfwidthNumbers(string s, CultureInfo culture);
    public static int ToInteger(object value);
    public static int ToInteger(string value);
    public static long ToLong(object value);
    public static long ToLong(string value);
    public static sbyte ToSByte(object value);
    public static sbyte ToSByte(string value);
    public static short ToShort(object value);
    public static short ToShort(string value);
    public static float ToSingle(object value);
    public static float ToSingle(string value);
    public static string ToString(bool value);
    public static string ToString(byte value);
    public static string ToString(char value);
    public static string ToString(DateTime value);
    public static string ToString(decimal value);
    public static string ToString(double value);
    public static string ToString(short value);
    public static string ToString(int value);
    public static string ToString(long value);
    public static string ToString(object value);
    public static string ToString(float value);
    public static string ToString(uint value);
    public static string ToString(ulong value);
    public static uint ToUInteger(object value);
    public static uint ToUInteger(string value);
    public static ulong ToULong(object value);
    public static ulong ToULong(string value);
    public static ushort ToUShort(object value);
    public static ushort ToUShort(string value);
  }
  public class DesignerGeneratedAttribute : Attribute {
    public DesignerGeneratedAttribute();
  }
  public class IncompleteInitialization : Exception {
    public IncompleteInitialization();
  }
  public sealed class InternalErrorException : Exception {
    public InternalErrorException();
    public InternalErrorException(string message);
    public InternalErrorException(string message, Exception innerException);
  }
  public sealed class NewLateBinding {
    public static object FallbackCall(object instance, string memberName, object[] arguments, string[] argumentNames, bool ignoreReturn);
    public static object FallbackGet(object instance, string memberName, object[] arguments, string[] argumentNames);
    public static void FallbackIndexSet(object instance, object[] arguments, string[] argumentNames);
    public static void FallbackIndexSetComplex(object instance, object[] arguments, string[] argumentNames, bool optimisticSet, bool rValueBase);
    public static object FallbackInvokeDefault1(object instance, object[] arguments, string[] argumentNames, bool reportErrors);
    public static object FallbackInvokeDefault2(object instance, object[] arguments, string[] argumentNames, bool reportErrors);
    public static void FallbackSet(object instance, string memberName, object[] arguments);
    public static void FallbackSetComplex(object instance, string memberName, object[] arguments, bool optimisticSet, bool rValueBase);
    public static object LateCall(object instance, Type type, string memberName, object[] arguments, string[] argumentNames, Type[] typeArguments, bool[] copyBack, bool ignoreReturn);
    public static object LateCallInvokeDefault(object instance, object[] arguments, string[] argumentNames, bool reportErrors);
    public static bool LateCanEvaluate(object instance, Type type, string memberName, object[] arguments, bool allowFunctionEvaluation, bool allowPropertyEvaluation);
    public static object LateGet(object instance, Type type, string memberName, object[] arguments, string[] argumentNames, Type[] typeArguments, bool[] copyBack);
    public static object LateGetInvokeDefault(object instance, object[] arguments, string[] argumentNames, bool reportErrors);
    public static object LateIndexGet(object instance, object[] arguments, string[] argumentNames);
    public static void LateIndexSet(object instance, object[] arguments, string[] argumentNames);
    public static void LateIndexSetComplex(object instance, object[] arguments, string[] argumentNames, bool optimisticSet, bool rValueBase);
    public static void LateSet(object instance, Type type, string memberName, object[] arguments, string[] argumentNames, Type[] typeArguments);
    public static void LateSet(object instance, Type type, string memberName, object[] arguments, string[] argumentNames, Type[] typeArguments, bool optimisticSet, bool rValueBase, CallType callType);
    public static void LateSetComplex(object instance, Type type, string memberName, object[] arguments, string[] argumentNames, Type[] typeArguments, bool optimisticSet, bool rValueBase);
  }
  public sealed class ObjectFlowControl {
    public static void CheckForSyncLockOnValueType(object expression);
    public sealed class ForLoopControl {
      public static bool ForLoopInitObj(object counter, object start, object limit, object stepValue, ref object loopForResult, ref object counterResult);
      public static bool ForNextCheckDec(decimal count, decimal limit, decimal stepValue);
      public static bool ForNextCheckObj(object counter, object loopObj, ref object counterResult);
      public static bool ForNextCheckR4(float count, float limit, float stepValue);
      public static bool ForNextCheckR8(double count, double limit, double stepValue);
    }
  }
  public sealed class Operators {
    public static object AddObject(object left, object right);
    public static object AndObject(object left, object right);
    public static int CompareObject(object left, object right, bool textCompare);
    public static object CompareObjectEqual(object left, object right, bool textCompare);
    public static object CompareObjectGreater(object left, object right, bool textCompare);
    public static object CompareObjectGreaterEqual(object left, object right, bool textCompare);
    public static object CompareObjectLess(object left, object right, bool textCompare);
    public static object CompareObjectLessEqual(object left, object right, bool textCompare);
    public static object CompareObjectNotEqual(object left, object right, bool textCompare);
    public static int CompareString(string left, string right, bool textCompare);
    public static object ConcatenateObject(object left, object right);
    public static bool ConditionalCompareObjectEqual(object left, object right, bool textCompare);
    public static bool ConditionalCompareObjectGreater(object left, object right, bool textCompare);
    public static bool ConditionalCompareObjectGreaterEqual(object left, object right, bool textCompare);
    public static bool ConditionalCompareObjectLess(object left, object right, bool textCompare);
    public static bool ConditionalCompareObjectLessEqual(object left, object right, bool textCompare);
    public static bool ConditionalCompareObjectNotEqual(object left, object right, bool textCompare);
    public static object DivideObject(object left, object right);
    public static object ExponentObject(object left, object right);
    public static object FallbackInvokeUserDefinedOperator(object vbOp, object[] arguments);
    public static object IntDivideObject(object left, object right);
    public static object LeftShiftObject(object operand, object amount);
    public static object ModObject(object left, object right);
    public static object MultiplyObject(object left, object right);
    public static object NegateObject(object operand);
    public static object NotObject(object operand);
    public static object OrObject(object left, object right);
    public static object PlusObject(object operand);
    public static object RightShiftObject(object operand, object amount);
    public static object SubtractObject(object left, object right);
    public static object XorObject(object left, object right);
  }
  public class OptionCompareAttribute : Attribute {
    public OptionCompareAttribute();
  }
  public class OptionTextAttribute : Attribute {
    public OptionTextAttribute();
  }
  public class ProjectData {
    public static void ClearProjectError();
    public static void SetProjectError(Exception ex);
    public static void SetProjectError(Exception ex, int lErl);
  }
  public class StandardModuleAttribute : Attribute {
    public StandardModuleAttribute();
  }
  public class StaticLocalInitFlag {
    public short State;
    public StaticLocalInitFlag();
  }
  public sealed class Utils {
    public static Array CopyArray(Array arySrc, Array aryDest);
    public static string GetResourceString(string resourceKey, params string[] args);
    public static string MethodToString(MethodBase method);
  }
}
