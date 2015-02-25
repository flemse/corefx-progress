```diff
---lib-full\System.Globalization.Extensions.dll
+++lib-oss\System.Globalization.Extensions.dll
 namespace System {
  public static class StringNormalizationExtensions {
    public static bool IsNormalized(this string value);
    public static bool IsNormalized(this string value, NormalizationForm normalizationForm);
    public static string Normalize(this string value);
    public static string Normalize(this string value, NormalizationForm normalizationForm);
  }
 }
 namespace System.Globalization {
  public static class GlobalizationExtensions {
    public static StringComparer GetStringComparer(this CompareInfo compareInfo, CompareOptions options);
  }
  public sealed class IdnMapping {
    public IdnMapping();
    public bool AllowUnassigned { get; set; }
    public bool UseStd3AsciiRules { get; set; }
    public override bool Equals(object obj);
    public string GetAscii(string unicode);
    public string GetAscii(string unicode, int index);
    public string GetAscii(string unicode, int index, int count);
    public override int GetHashCode();
    public string GetUnicode(string ascii);
    public string GetUnicode(string ascii, int index);
    public string GetUnicode(string ascii, int index, int count);
  }
 }
 namespace System.Text {
  public enum NormalizationForm {
    FormC = 1,
    FormD = 2,
    FormKC = 5,
    FormKD = 6,
  }
 }
```
