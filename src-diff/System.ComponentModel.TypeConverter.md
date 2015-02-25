```diff
---lib-full\System.ComponentModel.TypeConverter.dll
+++lib-oss\System.ComponentModel.TypeConverter.dll
 namespace System.ComponentModel {
  public class ArrayConverter : CollectionConverter {
    public ArrayConverter();
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public abstract class BaseNumberConverter : TypeConverter {
    protected BaseNumberConverter();
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
    public override bool CanConvertTo(ITypeDescriptorContext context, Type tdestinationType);
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public class BooleanConverter : TypeConverter {
    public BooleanConverter();
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
  }
  public class ByteConverter : BaseNumberConverter {
    public ByteConverter();
  }
  public class CharConverter : TypeConverter {
    public CharConverter();
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public class CollectionConverter : TypeConverter {
    public CollectionConverter();
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public class DateTimeConverter : TypeConverter {
    public DateTimeConverter();
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
-   public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public class DateTimeOffsetConverter : TypeConverter {
    public DateTimeOffsetConverter();
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
-   public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public class DecimalConverter : BaseNumberConverter {
    public DecimalConverter();
-   public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
-   public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public class DoubleConverter : BaseNumberConverter {
    public DoubleConverter();
  }
  public class EnumConverter : TypeConverter {
    public EnumConverter(Type type);
    protected Type EnumType { get; }
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public class GuidConverter : TypeConverter {
    public GuidConverter();
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
-   public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
-   public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public class Int16Converter : BaseNumberConverter {
    public Int16Converter();
  }
  public class Int32Converter : BaseNumberConverter {
    public Int32Converter();
  }
  public class Int64Converter : BaseNumberConverter {
    public Int64Converter();
  }
  public interface ITypeDescriptorContext : IServiceProvider {
    IContainer Container { get; }
    object Instance { get; }
    PropertyDescriptor PropertyDescriptor { get; }
    void OnComponentChanged();
    bool OnComponentChanging();
  }
  public class MultilineStringConverter : TypeConverter {
    public MultilineStringConverter();
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public class NullableConverter : TypeConverter {
    public NullableConverter(Type type);
    public Type NullableType { get; }
    public Type UnderlyingType { get; }
    public TypeConverter UnderlyingTypeConverter { get; }
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public abstract class PropertyDescriptor {
  }
  public class SByteConverter : BaseNumberConverter {
    public SByteConverter();
  }
  public class SingleConverter : BaseNumberConverter {
    public SingleConverter();
  }
  public class StringConverter : TypeConverter {
    public StringConverter();
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
  }
  public class TimeSpanConverter : TypeConverter {
    public TimeSpanConverter();
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
-   public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
-   public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public class TypeConverter {
    public TypeConverter();
    public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
    public bool CanConvertFrom(Type sourceType);
    public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
    public bool CanConvertTo(Type destinationType);
    public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
    public object ConvertFrom(object value);
    public object ConvertFromInvariantString(string text);
    public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text);
    public object ConvertFromString(string text);
    public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
    public object ConvertTo(object value, Type destinationType);
    public string ConvertToInvariantString(object value);
    public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value);
    public string ConvertToString(object value);
    protected Exception GetConvertFromException(object value);
    protected Exception GetConvertToException(object value, Type destinationType);
  }
  public sealed class TypeConverterAttribute : Attribute {
    public TypeConverterAttribute(string typeName);
    public TypeConverterAttribute(Type type);
    public string ConverterTypeName { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
  }
  public sealed class TypeDescriptor {
    public static TypeConverter GetConverter(Type type);
  }
  public abstract class TypeListConverter : TypeConverter {
    protected TypeListConverter(Type[] types);
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
-   public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
  }
  public class UInt16Converter : BaseNumberConverter {
    public UInt16Converter();
  }
  public class UInt32Converter : BaseNumberConverter {
    public UInt32Converter();
  }
  public class UInt64Converter : BaseNumberConverter {
    public UInt64Converter();
  }
 }
```
