```diff
---lib-full\System.Reflection.Extensions.dll
+++lib-oss\System.Reflection.Extensions.dll
-namespace System.Reflection {
- public static class CustomAttributeExtensions {
-   public static Attribute GetCustomAttribute(this Assembly element, Type attributeType);
-   public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType);
-   public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, bool inherit);
-   public static Attribute GetCustomAttribute(this Module element, Type attributeType);
-   public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType);
-   public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType, bool inherit);
-   public static T GetCustomAttribute<T>(this Assembly element) where T : Attribute;
-   public static T GetCustomAttribute<T>(this MemberInfo element) where T : Attribute;
-   public static T GetCustomAttribute<T>(this MemberInfo element, bool inherit) where T : Attribute;
-   public static T GetCustomAttribute<T>(this Module element) where T : Attribute;
-   public static T GetCustomAttribute<T>(this ParameterInfo element) where T : Attribute;
-   public static T GetCustomAttribute<T>(this ParameterInfo element, bool inherit) where T : Attribute;
-   public static IEnumerable<Attribute> GetCustomAttributes(this Assembly element);
-   public static IEnumerable<Attribute> GetCustomAttributes(this Assembly element, Type attributeType);
-   public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element);
-   public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, bool inherit);
-   public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType);
-   public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType, bool inherit);
-   public static IEnumerable<Attribute> GetCustomAttributes(this Module element);
-   public static IEnumerable<Attribute> GetCustomAttributes(this Module element, Type attributeType);
-   public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element);
-   public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, bool inherit);
-   public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, Type attributeType);
-   public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, Type attributeType, bool inherit);
-   public static IEnumerable<T> GetCustomAttributes<T>(this Assembly element) where T : Attribute;
-   public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element) where T : Attribute;
-   public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element, bool inherit) where T : Attribute;
-   public static IEnumerable<T> GetCustomAttributes<T>(this Module element) where T : Attribute;
-   public static IEnumerable<T> GetCustomAttributes<T>(this ParameterInfo element) where T : Attribute;
-   public static IEnumerable<T> GetCustomAttributes<T>(this ParameterInfo element, bool inherit) where T : Attribute;
-   public static bool IsDefined(this Assembly element, Type attributeType);
-   public static bool IsDefined(this MemberInfo element, Type attributeType);
-   public static bool IsDefined(this MemberInfo element, Type attributeType, bool inherit);
-   public static bool IsDefined(this Module element, Type attributeType);
-   public static bool IsDefined(this ParameterInfo element, Type attributeType);
-   public static bool IsDefined(this ParameterInfo element, Type attributeType, bool inherit);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct InterfaceMapping {
-   public MethodInfo[] InterfaceMethods;
-   public MethodInfo[] TargetMethods;
-   public Type InterfaceType;
-   public Type TargetType;
  }
- public static class RuntimeReflectionExtensions {
-   public static MethodInfo GetMethodInfo(this Delegate del);
-   public static MethodInfo GetRuntimeBaseDefinition(this MethodInfo method);
-   public static EventInfo GetRuntimeEvent(this Type type, string name);
-   public static IEnumerable<EventInfo> GetRuntimeEvents(this Type type);
-   public static FieldInfo GetRuntimeField(this Type type, string name);
-   public static IEnumerable<FieldInfo> GetRuntimeFields(this Type type);
-   public static InterfaceMapping GetRuntimeInterfaceMap(this TypeInfo typeInfo, Type interfaceType);
-   public static MethodInfo GetRuntimeMethod(this Type type, string name, Type[] parameters);
-   public static IEnumerable<MethodInfo> GetRuntimeMethods(this Type type);
-   public static IEnumerable<PropertyInfo> GetRuntimeProperties(this Type type);
-   public static PropertyInfo GetRuntimeProperty(this Type type, string name);
  }
 }
```
