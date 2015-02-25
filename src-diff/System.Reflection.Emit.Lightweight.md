```diff
---lib-full\System.Reflection.Emit.Lightweight.dll
+++lib-oss\System.Reflection.Emit.Lightweight.dll
-namespace System.Reflection.Emit {
- public sealed class DynamicMethod : MethodInfo {
-   public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Module m, bool skipVisibility);
-   public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility);
-   public DynamicMethod(string name, Type returnType, Type[] parameterTypes);
-   public DynamicMethod(string name, Type returnType, Type[] parameterTypes, bool restrictedSkipVisibility);
-   public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Module m);
-   public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Module m, bool skipVisibility);
-   public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner);
-   public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility);
-   public override MethodAttributes Attributes { get; }
-   public override CallingConventions CallingConvention { get; }
-   public override Type DeclaringType { get; }
-   public bool InitLocals { get; set; }
-   public override MethodImplAttributes MethodImplementationFlags { get; }
-   public override string Name { get; }
-   public override ParameterInfo ReturnParameter { get; }
-   public override Type ReturnType { get; }
-   public sealed override Delegate CreateDelegate(Type delegateType);
-   public sealed override Delegate CreateDelegate(Type delegateType, object target);
-   public ILGenerator GetILGenerator();
-   public ILGenerator GetILGenerator(int streamSize);
-   public override ParameterInfo[] GetParameters();
-   public override string ToString();
  }
 }
```
