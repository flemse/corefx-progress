```diff
---lib-full\System.Threading.Thread.dll
+++lib-oss\System.Threading.Thread.dll
-namespace System.Threading {
- public delegate void ParameterizedThreadStart(object obj);
- public sealed class Thread {
-   public Thread(ParameterizedThreadStart start);
-   public Thread(ThreadStart start);
-   public static Thread CurrentThread { get; }
-   public bool IsAlive { get; }
-   public bool IsBackground { get; set; }
-   public int ManagedThreadId { get; }
-   public string Name { get; set; }
-   public ThreadState ThreadState { get; }
-   public void Join();
-   public bool Join(int millisecondsTimeout);
-   public static void Sleep(int millisecondsTimeout);
-   public static void Sleep(TimeSpan timeout);
-   public void Start();
-   public void Start(object parameter);
  }
- public delegate void ThreadStart();
- public sealed class ThreadStartException : Exception {
  }
- public enum ThreadState {
-   Aborted = 256,
-   AbortRequested = 128,
-   Background = 4,
-   Running = 0,
-   Stopped = 16,
-   StopRequested = 1,
-   Suspended = 64,
-   SuspendRequested = 2,
-   Unstarted = 8,
-   WaitSleepJoin = 32,
  }
- public class ThreadStateException : Exception {
-   public ThreadStateException();
-   public ThreadStateException(string message);
-   public ThreadStateException(string message, Exception innerException);
  }
 }
```
