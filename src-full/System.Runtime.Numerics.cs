namespace System.Numerics {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct BigInteger : IComparable, IComparable<BigInteger>, IEquatable<BigInteger>, IFormattable {
    public BigInteger(byte[] value);
    public BigInteger(decimal value);
    public BigInteger(double value);
    public BigInteger(int value);
    public BigInteger(long value);
    public BigInteger(float value);
    public BigInteger(uint value);
    public BigInteger(ulong value);
    public bool IsEven { get; }
    public bool IsOne { get; }
    public bool IsPowerOfTwo { get; }
    public bool IsZero { get; }
    public static BigInteger MinusOne { get; }
    public static BigInteger One { get; }
    public int Sign { get; }
    public static BigInteger Zero { get; }
    public static BigInteger Abs(BigInteger value);
    public static BigInteger Add(BigInteger left, BigInteger right);
    public static int Compare(BigInteger left, BigInteger right);
    public int CompareTo(long other);
    public int CompareTo(BigInteger other);
    public int CompareTo(ulong other);
    public static BigInteger Divide(BigInteger dividend, BigInteger divisor);
    public static BigInteger DivRem(BigInteger dividend, BigInteger divisor, out BigInteger remainder);
    public bool Equals(long other);
    public bool Equals(BigInteger other);
    public override bool Equals(object obj);
    public bool Equals(ulong other);
    public override int GetHashCode();
    public static BigInteger GreatestCommonDivisor(BigInteger left, BigInteger right);
    public static double Log(BigInteger value);
    public static double Log(BigInteger value, double baseValue);
    public static double Log10(BigInteger value);
    public static BigInteger Max(BigInteger left, BigInteger right);
    public static BigInteger Min(BigInteger left, BigInteger right);
    public static BigInteger ModPow(BigInteger value, BigInteger exponent, BigInteger modulus);
    public static BigInteger Multiply(BigInteger left, BigInteger right);
    public static BigInteger Negate(BigInteger value);
    public static BigInteger operator +(BigInteger left, BigInteger right);
    public static BigInteger operator &(BigInteger left, BigInteger right);
    public static BigInteger operator |(BigInteger left, BigInteger right);
    public static BigInteger operator --(BigInteger value);
    public static BigInteger operator /(BigInteger dividend, BigInteger divisor);
    public static bool operator ==(long left, BigInteger right);
    public static bool operator ==(BigInteger left, long right);
    public static bool operator ==(BigInteger left, BigInteger right);
    public static bool operator ==(BigInteger left, ulong right);
    public static bool operator ==(ulong left, BigInteger right);
    public static BigInteger operator ^(BigInteger left, BigInteger right);
    public static explicit operator BigInteger (decimal value);
    public static explicit operator BigInteger (double value);
    public static explicit operator byte (BigInteger value);
    public static explicit operator decimal (BigInteger value);
    public static explicit operator double (BigInteger value);
    public static explicit operator short (BigInteger value);
    public static explicit operator int (BigInteger value);
    public static explicit operator long (BigInteger value);
    public static explicit operator sbyte (BigInteger value);
    public static explicit operator float (BigInteger value);
    public static explicit operator ushort (BigInteger value);
    public static explicit operator uint (BigInteger value);
    public static explicit operator ulong (BigInteger value);
    public static explicit operator BigInteger (float value);
    public static bool operator >(long left, BigInteger right);
    public static bool operator >(BigInteger left, long right);
    public static bool operator >(BigInteger left, BigInteger right);
    public static bool operator >(BigInteger left, ulong right);
    public static bool operator >(ulong left, BigInteger right);
    public static bool operator >=(long left, BigInteger right);
    public static bool operator >=(BigInteger left, long right);
    public static bool operator >=(BigInteger left, BigInteger right);
    public static bool operator >=(BigInteger left, ulong right);
    public static bool operator >=(ulong left, BigInteger right);
    public static implicit operator BigInteger (byte value);
    public static implicit operator BigInteger (short value);
    public static implicit operator BigInteger (int value);
    public static implicit operator BigInteger (long value);
    public static implicit operator BigInteger (sbyte value);
    public static implicit operator BigInteger (ushort value);
    public static implicit operator BigInteger (uint value);
    public static implicit operator BigInteger (ulong value);
    public static BigInteger operator ++(BigInteger value);
    public static bool operator !=(long left, BigInteger right);
    public static bool operator !=(BigInteger left, long right);
    public static bool operator !=(BigInteger left, BigInteger right);
    public static bool operator !=(BigInteger left, ulong right);
    public static bool operator !=(ulong left, BigInteger right);
    public static BigInteger operator <<(BigInteger value, int shift);
    public static bool operator <(long left, BigInteger right);
    public static bool operator <(BigInteger left, long right);
    public static bool operator <(BigInteger left, BigInteger right);
    public static bool operator <(BigInteger left, ulong right);
    public static bool operator <(ulong left, BigInteger right);
    public static bool operator <=(long left, BigInteger right);
    public static bool operator <=(BigInteger left, long right);
    public static bool operator <=(BigInteger left, BigInteger right);
    public static bool operator <=(BigInteger left, ulong right);
    public static bool operator <=(ulong left, BigInteger right);
    public static BigInteger operator %(BigInteger dividend, BigInteger divisor);
    public static BigInteger operator *(BigInteger left, BigInteger right);
    public static BigInteger operator ~(BigInteger value);
    public static BigInteger operator >>(BigInteger value, int shift);
    public static BigInteger operator -(BigInteger left, BigInteger right);
    public static BigInteger operator -(BigInteger value);
    public static BigInteger operator +(BigInteger value);
    public static BigInteger Parse(string value);
    public static BigInteger Parse(string value, NumberStyles style);
    public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider);
    public static BigInteger Parse(string value, IFormatProvider provider);
    public static BigInteger Pow(BigInteger value, int exponent);
    public static BigInteger Remainder(BigInteger dividend, BigInteger divisor);
    public static BigInteger Subtract(BigInteger left, BigInteger right);
    int System.IComparable.CompareTo(object obj);
    public byte[] ToByteArray();
    public override string ToString();
    public string ToString(IFormatProvider provider);
    public string ToString(string format);
    public string ToString(string format, IFormatProvider provider);
    public static bool TryParse(string value, NumberStyles style, IFormatProvider provider, out BigInteger result);
    public static bool TryParse(string value, out BigInteger result);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct Complex : IEquatable<Complex>, IFormattable {
    public static readonly Complex ImaginaryOne;
    public static readonly Complex One;
    public static readonly Complex Zero;
    public Complex(double real, double imaginary);
    public double Imaginary { get; }
    public double Magnitude { get; }
    public double Phase { get; }
    public double Real { get; }
    public static double Abs(Complex value);
    public static Complex Acos(Complex value);
    public static Complex Add(Complex left, Complex right);
    public static Complex Asin(Complex value);
    public static Complex Atan(Complex value);
    public static Complex Conjugate(Complex value);
    public static Complex Cos(Complex value);
    public static Complex Cosh(Complex value);
    public static Complex Divide(Complex dividend, Complex divisor);
    public bool Equals(Complex value);
    public override bool Equals(object obj);
    public static Complex Exp(Complex value);
    public static Complex FromPolarCoordinates(double magnitude, double phase);
    public override int GetHashCode();
    public static Complex Log(Complex value);
    public static Complex Log(Complex value, double baseValue);
    public static Complex Log10(Complex value);
    public static Complex Multiply(Complex left, Complex right);
    public static Complex Negate(Complex value);
    public static Complex operator +(Complex left, Complex right);
    public static Complex operator /(Complex left, Complex right);
    public static bool operator ==(Complex left, Complex right);
    public static explicit operator Complex (decimal value);
    public static explicit operator Complex (BigInteger value);
    public static implicit operator Complex (byte value);
    public static implicit operator Complex (double value);
    public static implicit operator Complex (short value);
    public static implicit operator Complex (int value);
    public static implicit operator Complex (long value);
    public static implicit operator Complex (sbyte value);
    public static implicit operator Complex (float value);
    public static implicit operator Complex (ushort value);
    public static implicit operator Complex (uint value);
    public static implicit operator Complex (ulong value);
    public static bool operator !=(Complex left, Complex right);
    public static Complex operator *(Complex left, Complex right);
    public static Complex operator -(Complex left, Complex right);
    public static Complex operator -(Complex value);
    public static Complex Pow(Complex value, double power);
    public static Complex Pow(Complex value, Complex power);
    public static Complex Reciprocal(Complex value);
    public static Complex Sin(Complex value);
    public static Complex Sinh(Complex value);
    public static Complex Sqrt(Complex value);
    public static Complex Subtract(Complex left, Complex right);
    public static Complex Tan(Complex value);
    public static Complex Tanh(Complex value);
    public override string ToString();
    public string ToString(IFormatProvider provider);
    public string ToString(string format);
    public string ToString(string format, IFormatProvider provider);
  }
}
