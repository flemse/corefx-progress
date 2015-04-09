namespace System.Reflection {
  public abstract class DispatchProxy {
    protected DispatchProxy();
    public static T Create<T, TProxy>() where TProxy : DispatchProxy;
    protected abstract object Invoke(MethodInfo targetMethod, object[] args);
  }
}
