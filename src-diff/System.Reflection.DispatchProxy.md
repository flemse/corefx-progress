```diff
---lib-full\System.Reflection.DispatchProxy.dll
+++lib-oss\System.Reflection.DispatchProxy.dll
 namespace System.Reflection {
  public abstract class DispatchProxy {
    protected DispatchProxy();
    public static T Create<T, TProxy>() where TProxy : DispatchProxy;
    protected abstract object Invoke(MethodInfo targetMethod, object[] args);
  }
 }
```
