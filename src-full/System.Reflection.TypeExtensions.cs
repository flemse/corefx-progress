namespace System.Reflection {
  public static class AssemblyExtensions {
    public static Type[] GetExportedTypes(this Assembly assembly);
    public static Module[] GetModules(this Assembly assembly);
    public static Type[] GetTypes(this Assembly assembly);
  }
  public enum BindingFlags {
    DeclaredOnly = 2,
    FlattenHierarchy = 64,
    IgnoreCase = 1,
    Instance = 4,
    NonPublic = 32,
    Public = 16,
    Static = 8,
  }
  public static class EventInfoExtensions {
    public static MethodInfo GetAddMethod(this EventInfo eventInfo);
    public static MethodInfo GetAddMethod(this EventInfo eventInfo, bool nonPublic);
    public static MethodInfo GetRaiseMethod(this EventInfo eventInfo);
    public static MethodInfo GetRaiseMethod(this EventInfo eventInfo, bool nonPublic);
    public static MethodInfo GetRemoveMethod(this EventInfo eventInfo);
    public static MethodInfo GetRemoveMethod(this EventInfo eventInfo, bool nonPublic);
  }
  public static class MethodInfoExtensions {
    public static MethodInfo GetBaseDefinition(this MethodInfo method);
  }
  public static class PropertyInfoExtensions {
    public static MethodInfo[] GetAccessors(this PropertyInfo property);
    public static MethodInfo[] GetAccessors(this PropertyInfo property, bool nonPublic);
    public static MethodInfo GetGetMethod(this PropertyInfo property);
    public static MethodInfo GetGetMethod(this PropertyInfo property, bool nonPublic);
    public static MethodInfo GetSetMethod(this PropertyInfo property);
    public static MethodInfo GetSetMethod(this PropertyInfo property, bool nonPublic);
  }
  public static class TypeExtensions {
    public static ConstructorInfo GetConstructor(this Type type, Type[] types);
    public static ConstructorInfo[] GetConstructors(this Type type);
    public static ConstructorInfo[] GetConstructors(this Type type, BindingFlags bindingAttr);
    public static MemberInfo[] GetDefaultMembers(this Type type);
    public static EventInfo GetEvent(this Type type, string name);
    public static EventInfo GetEvent(this Type type, string name, BindingFlags bindingAttr);
    public static EventInfo[] GetEvents(this Type type);
    public static EventInfo[] GetEvents(this Type type, BindingFlags bindingAttr);
    public static FieldInfo GetField(this Type type, string name);
    public static FieldInfo GetField(this Type type, string name, BindingFlags bindingAttr);
    public static FieldInfo[] GetFields(this Type type);
    public static FieldInfo[] GetFields(this Type type, BindingFlags bindingAttr);
    public static Type[] GetGenericArguments(this Type type);
    public static Type[] GetInterfaces(this Type type);
    public static MemberInfo[] GetMember(this Type type, string name);
    public static MemberInfo[] GetMember(this Type type, string name, BindingFlags bindingAttr);
    public static MemberInfo[] GetMembers(this Type type);
    public static MemberInfo[] GetMembers(this Type type, BindingFlags bindingAttr);
    public static MethodInfo GetMethod(this Type type, string name);
    public static MethodInfo GetMethod(this Type type, string name, BindingFlags bindingAttr);
    public static MethodInfo GetMethod(this Type type, string name, Type[] types);
    public static MethodInfo[] GetMethods(this Type type);
    public static MethodInfo[] GetMethods(this Type type, BindingFlags bindingAttr);
    public static Type GetNestedType(this Type type, string name, BindingFlags bindingAttr);
    public static Type[] GetNestedTypes(this Type type, BindingFlags bindingAttr);
    public static PropertyInfo[] GetProperties(this Type type);
    public static PropertyInfo[] GetProperties(this Type type, BindingFlags bindingAttr);
    public static PropertyInfo GetProperty(this Type type, string name);
    public static PropertyInfo GetProperty(this Type type, string name, BindingFlags bindingAttr);
    public static PropertyInfo GetProperty(this Type type, string name, Type returnType);
    public static PropertyInfo GetProperty(this Type type, string name, Type returnType, Type[] types);
    public static bool IsAssignableFrom(this Type type, Type c);
    public static bool IsInstanceOfType(this Type type, object o);
  }
}
