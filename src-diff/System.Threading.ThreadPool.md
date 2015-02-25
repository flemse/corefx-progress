```diff
---lib-full\System.Threading.ThreadPool.dll
+++lib-oss\System.Threading.ThreadPool.dll
-namespace System.Threading {
- public sealed class RegisteredWaitHandle {
-   public bool Unregister(WaitHandle waitObject);
  }
- public static class ThreadPool {
-   public static bool BindHandle(SafeHandle osHandle);
-   public static bool QueueUserWorkItem(WaitCallback callBack);
-   public static bool QueueUserWorkItem(WaitCallback callBack, object state);
-   public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce);
-   public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce);
-   public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce);
-   public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce);
  }
- public delegate void WaitCallback(object state);
- public delegate void WaitOrTimerCallback(object state, bool timedOut);
 }
```
