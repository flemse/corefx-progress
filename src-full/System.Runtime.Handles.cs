namespace Microsoft.Win32.SafeHandles {
  public sealed class SafeWaitHandle : SafeHandle {
    public SafeWaitHandle(IntPtr existingHandle, bool ownsHandle);
    public override bool IsInvalid { get; }
    protected override bool ReleaseHandle();
  }
}
namespace System.IO {
  public enum HandleInheritability {
    Inheritable = 1,
    None = 0,
  }
}
namespace System.Runtime.InteropServices {
  public abstract class CriticalHandle : IDisposable {
    protected IntPtr handle;
    protected CriticalHandle(IntPtr invalidHandleValue);
    public bool IsClosed { get; }
    public abstract bool IsInvalid { get; }
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    ~CriticalHandle();
    protected abstract bool ReleaseHandle();
    protected void SetHandle(IntPtr handle);
    public void SetHandleAsInvalid();
  }
  public abstract class SafeHandle : IDisposable {
    protected IntPtr handle;
    protected SafeHandle(IntPtr invalidHandleValue, bool ownsHandle);
    public bool IsClosed { get; }
    public abstract bool IsInvalid { get; }
    public void DangerousAddRef(ref bool success);
    public IntPtr DangerousGetHandle();
    public void DangerousRelease();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    ~SafeHandle();
    protected abstract bool ReleaseHandle();
    protected void SetHandle(IntPtr handle);
    public void SetHandleAsInvalid();
  }
}
namespace System.Threading {
  public static class WaitHandleExtensions {
    public static SafeWaitHandle GetSafeWaitHandle(this WaitHandle waitHandle);
    public static void SetSafeWaitHandle(this WaitHandle waitHandle, SafeWaitHandle value);
  }
}
