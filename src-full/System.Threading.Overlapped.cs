namespace System.Threading {
  public unsafe delegate void IOCompletionCallback(uint errorCode, uint numBytes, NativeOverlapped* pOVERLAP);
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct NativeOverlapped {
    public int OffsetHigh;
    public int OffsetLow;
    public IntPtr EventHandle;
    public IntPtr InternalHigh;
    public IntPtr InternalLow;
  }
  public class Overlapped {
    public Overlapped();
    public IAsyncResult AsyncResult { get; set; }
    public int OffsetHigh { get; set; }
    public int OffsetLow { get; set; }
    public unsafe static void Free(NativeOverlapped* nativeOverlappedPtr);
    public unsafe NativeOverlapped* Pack(IOCompletionCallback iocb, object userData);
    public unsafe static Overlapped Unpack(NativeOverlapped* nativeOverlappedPtr);
    public unsafe NativeOverlapped* UnsafePack(IOCompletionCallback iocb, object userData);
  }
}
