```diff
---lib-full\Microsoft.VisualBasic.dll
+++lib-oss\Microsoft.VisualBasic.dll
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
+ public sealed class ControlChars {
+   public const char Back = '\b';
+   public const char Cr = '\r';
+   public const char FormFeed = '\f';
+   public const char Lf = '\n';
+   public const char NullChar = '\0';
+   public const char Quote = '"';
+   public const char Tab = '\t';
+   public const char VerticalTab = '\v';
+   public const string CrLf = "\r\n";
+   public const string NewLine = "\r\n";
+   public ControlChars();
  }
  public sealed class HideModuleNameAttribute : Attribute {
    public HideModuleNameAttribute();
  }
+ public sealed class Interaction {
  }
  public sealed class Strings {
    public static int AscW(char String@string);
    public static int AscW(string String@string);
    public static char ChrW(int CharCodecharCode);
+   public static string Left(string str, int length);
  }
 }
 namespace Microsoft.VisualBasic.CompilerServices {
  public sealed class Conversions {
    public static object ChangeType(object Expressionexpression, Type TargetTypetargetType);
+   public static object FallbackUserDefinedConversion(object expression, Type targetType);
+   public static CultureInfo GetCultureInfo();
+   public static bool IsHexOrOctValue(string value, ref long i64Value);
+   public static bool IsHexOrOctValue(string value, ref ulong ui64Value);
    public static bool ToBoolean(object Valuevalue);
    public static bool ToBoolean(string Valuevalue);
    public static byte ToByte(object Valuevalue);
    public static byte ToByte(string Valuevalue);
    public static char ToChar(object Valuevalue);
    public static char ToChar(string Valuevalue);
    public static char[] ToCharArrayRankOne(object Valuevalue);
    public static char[] ToCharArrayRankOne(string Valuevalue);
    public static DateTime ToDate(object Valuevalue);
    public static DateTime ToDate(string Valuevalue);
    public static decimal ToDecimal(bool Valuevalue);
    public static decimal ToDecimal(object Valuevalue);
    public static decimal ToDecimal(string Valuevalue);
    public static double ToDouble(object Valuevalue);
    public static double ToDouble(string Valuevalue);
    public static T ToGenericParameter<T>(object Valuevalue);
+   public static string ToHalfwidthNumbers(string s, CultureInfo culture);
    public static int ToInteger(object Valuevalue);
    public static int ToInteger(string Valuevalue);
    public static long ToLong(object Valuevalue);
    public static long ToLong(string Valuevalue);
    public static sbyte ToSByte(object Valuevalue);
    public static sbyte ToSByte(string Valuevalue);
    public static short ToShort(object Valuevalue);
    public static short ToShort(string Valuevalue);
    public static float ToSingle(object Valuevalue);
    public static float ToSingle(string Valuevalue);
    public static string ToString(bool Valuevalue);
    public static string ToString(byte Valuevalue);
    public static string ToString(char Valuevalue);
    public static string ToString(DateTime Valuevalue);
    public static string ToString(decimal Valuevalue);
    public static string ToString(double Valuevalue);
    public static string ToString(short Valuevalue);
    public static string ToString(int Valuevalue);
    public static string ToString(long Valuevalue);
    public static string ToString(object Valuevalue);
    public static string ToString(float Valuevalue);
    public static string ToString(uint Valuevalue);
    public static string ToString(ulong Valuevalue);
    public static uint ToUInteger(object Valuevalue);
    public static uint ToUInteger(string Valuevalue);
    public static ulong ToULong(object Valuevalue);
    public static ulong ToULong(string Valuevalue);
    public static ushort ToUShort(object Valuevalue);
    public static ushort ToUShort(string Valuevalue);
  }
  public sealed class DesignerGeneratedAttribute : Attribute {
    public DesignerGeneratedAttribute();
  }
  public sealed class IncompleteInitialization : Exception {
    public IncompleteInitialization();
  }
+ public sealed class InternalErrorException : Exception {
+   public InternalErrorException();
+   public InternalErrorException(string message);
+   public InternalErrorException(string message, Exception innerException);
  }
  public sealed class NewLateBinding {
+   public static object FallbackCall(object instance, string memberName, object[] arguments, string[] argumentNames, bool ignoreReturn);
+   public static object FallbackGet(object instance, string memberName, object[] arguments, string[] argumentNames);
+   public static void FallbackIndexSet(object instance, object[] arguments, string[] argumentNames);
+   public static void FallbackIndexSetComplex(object instance, object[] arguments, string[] argumentNames, bool optimisticSet, bool rValueBase);
+   public static object FallbackInvokeDefault1(object instance, object[] arguments, string[] argumentNames, bool reportErrors);
+   public static object FallbackInvokeDefault2(object instance, object[] arguments, string[] argumentNames, bool reportErrors);
+   public static void FallbackSet(object instance, string memberName, object[] arguments);
+   public static void FallbackSetComplex(object instance, string memberName, object[] arguments, bool optimisticSet, bool rValueBase);
    public static object LateCall(object Instanceinstance, Type Typetype, string MemberNamememberName, object[] Argumentsarguments, string[] ArgumentNamesargumentNames, Type[] TypeArgumentstypeArguments, bool[] CopyBackcopyBack, bool IgnoreReturnignoreReturn);
+   public static object LateCallInvokeDefault(object instance, object[] arguments, string[] argumentNames, bool reportErrors);
+   public static bool LateCanEvaluate(object instance, Type type, string memberName, object[] arguments, bool allowFunctionEvaluation, bool allowPropertyEvaluation);
    public static object LateGet(object Instanceinstance, Type Typetype, string MemberNamememberName, object[] Argumentsarguments, string[] ArgumentNamesargumentNames, Type[] TypeArgumentstypeArguments, bool[] CopyBackcopyBack);
+   public static object LateGetInvokeDefault(object instance, object[] arguments, string[] argumentNames, bool reportErrors);
    public static object LateIndexGet(object Instanceinstance, object[] Argumentsarguments, string[] ArgumentNamesargumentNames);
    public static void LateIndexSet(object Instanceinstance, object[] Argumentsarguments, string[] ArgumentNamesargumentNames);
    public static void LateIndexSetComplex(object Instanceinstance, object[] Argumentsarguments, string[] ArgumentNamesargumentNames, bool OptimisticSetoptimisticSet, bool RValueBaserValueBase);
    public static void LateSet(object Instanceinstance, Type Typetype, string MemberNamememberName, object[] Argumentsarguments, string[] ArgumentNamesargumentNames, Type[] TypeArgumentstypeArguments);
    public static void LateSet(object Instanceinstance, Type Typetype, string MemberNamememberName, object[] Argumentsarguments, string[] ArgumentNamesargumentNames, Type[] TypeArgumentstypeArguments, bool OptimisticSetoptimisticSet, bool RValueBaserValueBase, CallType CallTypecallType);
    public static void LateSetComplex(object Instanceinstance, Type Typetype, string MemberNamememberName, object[] Argumentsarguments, string[] ArgumentNamesargumentNames, Type[] TypeArgumentstypeArguments, bool OptimisticSetoptimisticSet, bool RValueBaserValueBase);
  }
  public sealed class ObjectFlowControl {
    public static void CheckForSyncLockOnValueType(object Expressionexpression);
    public sealed class ForLoopControl {
      public static bool ForLoopInitObj(object Countercounter, object Startstart, object Limitlimit, object StepValuestepValue, ref object LoopForResultloopForResult, ref object CounterResultcounterResult);
      public static bool ForNextCheckDec(decimal count, decimal limit, decimal StepValuestepValue);
      public static bool ForNextCheckObj(object Countercounter, object LoopObjloopObj, ref object CounterResultcounterResult);
      public static bool ForNextCheckR4(float count, float limit, float StepValuestepValue);
      public static bool ForNextCheckR8(double count, double limit, double StepValuestepValue);
    }
  }
  public sealed class Operators {
    public static object AddObject(object Leftleft, object Rightright);
    public static object AndObject(object Leftleft, object Rightright);
+   public static int CompareObject(object left, object right, bool textCompare);
    public static object CompareObjectEqual(object Leftleft, object Rightright, bool TextComparetextCompare);
    public static object CompareObjectGreater(object Leftleft, object Rightright, bool TextComparetextCompare);
    public static object CompareObjectGreaterEqual(object Leftleft, object Rightright, bool TextComparetextCompare);
    public static object CompareObjectLess(object Leftleft, object Rightright, bool TextComparetextCompare);
    public static object CompareObjectLessEqual(object Leftleft, object Rightright, bool TextComparetextCompare);
    public static object CompareObjectNotEqual(object Leftleft, object Rightright, bool TextComparetextCompare);
    public static int CompareString(string Leftleft, string Rightright, bool TextComparetextCompare);
    public static object ConcatenateObject(object Leftleft, object Rightright);
    public static bool ConditionalCompareObjectEqual(object Leftleft, object Rightright, bool TextComparetextCompare);
    public static bool ConditionalCompareObjectGreater(object Leftleft, object Rightright, bool TextComparetextCompare);
    public static bool ConditionalCompareObjectGreaterEqual(object Leftleft, object Rightright, bool TextComparetextCompare);
    public static bool ConditionalCompareObjectLess(object Leftleft, object Rightright, bool TextComparetextCompare);
    public static bool ConditionalCompareObjectLessEqual(object Leftleft, object Rightright, bool TextComparetextCompare);
    public static bool ConditionalCompareObjectNotEqual(object Leftleft, object Rightright, bool TextComparetextCompare);
    public static object DivideObject(object Leftleft, object Rightright);
    public static object ExponentObject(object Leftleft, object Rightright);
+   public static object FallbackInvokeUserDefinedOperator(object vbOp, object[] arguments);
    public static object IntDivideObject(object Leftleft, object Rightright);
    public static object LeftShiftObject(object Operandoperand, object Amountamount);
    public static object ModObject(object Leftleft, object Rightright);
    public static object MultiplyObject(object Leftleft, object Rightright);
    public static object NegateObject(object Operandoperand);
    public static object NotObject(object Operandoperand);
    public static object OrObject(object Leftleft, object Rightright);
    public static object PlusObject(object Operandoperand);
    public static object RightShiftObject(object Operandoperand, object Amountamount);
    public static object SubtractObject(object Leftleft, object Rightright);
    public static object XorObject(object Leftleft, object Rightright);
  }
  public sealed class OptionCompareAttribute : Attribute {
    public OptionCompareAttribute();
  }
  public sealed class OptionTextAttribute : Attribute {
    public OptionTextAttribute();
  }
  public sealed class ProjectData {
    public static void ClearProjectError();
    public static void SetProjectError(Exception ex);
    public static void SetProjectError(Exception ex, int lErl);
  }
  public sealed class StandardModuleAttribute : Attribute {
    public StandardModuleAttribute();
  }
  public sealed class StaticLocalInitFlag {
    public short State;
    public StaticLocalInitFlag();
  }
  public sealed class Utils {
    public static Array CopyArray(Array arySrc, Array aryDest);
+   public static string GetResourceString(string resourceKey, params string[] args);
+   public static string MethodToString(MethodBase method);
  }
 }
```
