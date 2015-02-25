namespace System.Text {
  public abstract class Decoder {
    protected Decoder();
    public DecoderFallback Fallback { get; set; }
    public DecoderFallbackBuffer FallbackBuffer { get; }
    public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed);
    public abstract int GetCharCount(byte[] bytes, int index, int count);
    public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush);
    public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
    public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush);
    public virtual void Reset();
  }
  public sealed class DecoderExceptionFallback : DecoderFallback {
    public DecoderExceptionFallback();
    public override int MaxCharCount { get; }
    public override DecoderFallbackBuffer CreateFallbackBuffer();
    public override bool Equals(object value);
    public override int GetHashCode();
  }
  public abstract class DecoderFallback {
    protected DecoderFallback();
    public static DecoderFallback ExceptionFallback { get; }
    public abstract int MaxCharCount { get; }
    public static DecoderFallback ReplacementFallback { get; }
    public abstract DecoderFallbackBuffer CreateFallbackBuffer();
  }
  public abstract class DecoderFallbackBuffer {
    protected DecoderFallbackBuffer();
    public abstract int Remaining { get; }
    public abstract bool Fallback(byte[] bytesUnknown, int index);
    public abstract char GetNextChar();
    public abstract bool MovePrevious();
    public virtual void Reset();
  }
  public sealed class DecoderFallbackException : ArgumentException {
    public DecoderFallbackException();
    public DecoderFallbackException(string message);
    public DecoderFallbackException(string message, byte[] bytesUnknown, int index);
    public DecoderFallbackException(string message, Exception innerException);
    public byte[] BytesUnknown { get; }
    public int Index { get; }
  }
  public sealed class DecoderReplacementFallback : DecoderFallback {
    public DecoderReplacementFallback();
    public DecoderReplacementFallback(string replacement);
    public string DefaultString { get; }
    public override int MaxCharCount { get; }
    public override DecoderFallbackBuffer CreateFallbackBuffer();
    public override bool Equals(object value);
    public override int GetHashCode();
  }
  public abstract class Encoder {
    protected Encoder();
    public EncoderFallback Fallback { get; set; }
    public EncoderFallbackBuffer FallbackBuffer { get; }
    public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed);
    public abstract int GetByteCount(char[] chars, int index, int count, bool flush);
    public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);
    public virtual void Reset();
  }
  public sealed class EncoderExceptionFallback : EncoderFallback {
    public EncoderExceptionFallback();
    public override int MaxCharCount { get; }
    public override EncoderFallbackBuffer CreateFallbackBuffer();
    public override bool Equals(object value);
    public override int GetHashCode();
  }
  public abstract class EncoderFallback {
    protected EncoderFallback();
    public static EncoderFallback ExceptionFallback { get; }
    public abstract int MaxCharCount { get; }
    public static EncoderFallback ReplacementFallback { get; }
    public abstract EncoderFallbackBuffer CreateFallbackBuffer();
  }
  public abstract class EncoderFallbackBuffer {
    protected EncoderFallbackBuffer();
    public abstract int Remaining { get; }
    public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);
    public abstract bool Fallback(char charUnknown, int index);
    public abstract char GetNextChar();
    public abstract bool MovePrevious();
    public virtual void Reset();
  }
  public sealed class EncoderFallbackException : ArgumentException {
    public EncoderFallbackException();
    public EncoderFallbackException(string message);
    public EncoderFallbackException(string message, Exception innerException);
    public char CharUnknown { get; }
    public char CharUnknownHigh { get; }
    public char CharUnknownLow { get; }
    public int Index { get; }
    public bool IsUnknownSurrogate();
  }
  public sealed class EncoderReplacementFallback : EncoderFallback {
    public EncoderReplacementFallback();
    public EncoderReplacementFallback(string replacement);
    public string DefaultString { get; }
    public override int MaxCharCount { get; }
    public override EncoderFallbackBuffer CreateFallbackBuffer();
    public override bool Equals(object value);
    public override int GetHashCode();
  }
  public abstract class Encoding {
    protected Encoding();
    protected Encoding(int codePage);
    protected Encoding(int codePage, EncoderFallback encoderFallback, DecoderFallback decoderFallback);
    public static Encoding ASCII { get; }
    public static Encoding BigEndianUnicode { get; }
    public virtual int CodePage { get; }
    public DecoderFallback DecoderFallback { get; }
    public EncoderFallback EncoderFallback { get; }
    public virtual string EncodingName { get; }
    public virtual bool IsSingleByte { get; }
    public static Encoding Unicode { get; }
    public static Encoding UTF32 { get; }
    public static Encoding UTF7 { get; }
    public static Encoding UTF8 { get; }
    public virtual string WebName { get; }
    public virtual object Clone();
    public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes);
    public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count);
    public override bool Equals(object value);
    public unsafe virtual int GetByteCount(char* chars, int count);
    public virtual int GetByteCount(char[] chars);
    public abstract int GetByteCount(char[] chars, int index, int count);
    public virtual int GetByteCount(string s);
    public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount);
    public virtual byte[] GetBytes(char[] chars);
    public virtual byte[] GetBytes(char[] chars, int index, int count);
    public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
    public virtual byte[] GetBytes(string s);
    public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex);
    public unsafe virtual int GetCharCount(byte* bytes, int count);
    public virtual int GetCharCount(byte[] bytes);
    public abstract int GetCharCount(byte[] bytes, int index, int count);
    public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount);
    public virtual char[] GetChars(byte[] bytes);
    public virtual char[] GetChars(byte[] bytes, int index, int count);
    public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
    public virtual Decoder GetDecoder();
    public virtual Encoder GetEncoder();
    public static Encoding GetEncoding(int codepage);
    public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback);
    public static Encoding GetEncoding(string name);
    public static Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback);
    public override int GetHashCode();
    public abstract int GetMaxByteCount(int charCount);
    public abstract int GetMaxCharCount(int byteCount);
    public virtual byte[] GetPreamble();
    public unsafe string GetString(byte* bytes, int byteCount);
    public virtual string GetString(byte[] bytes);
    public virtual string GetString(byte[] bytes, int index, int count);
    public static void RegisterProvider(EncodingProvider provider);
  }
  public abstract class EncodingProvider {
    public EncodingProvider();
    public abstract Encoding GetEncoding(int codepage);
    public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback);
    public abstract Encoding GetEncoding(string name);
    public virtual Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback);
  }
}
