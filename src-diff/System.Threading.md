```diff
---lib-full\System.Threading.dll
+++lib-oss\System.Threading.dll
-namespace System.Threading {
- public class AbandonedMutexException : Exception {
-   public AbandonedMutexException();
-   public AbandonedMutexException(int location, WaitHandle handle);
-   public AbandonedMutexException(string message);
-   public AbandonedMutexException(string message, Exception inner);
-   public AbandonedMutexException(string message, Exception inner, int location, WaitHandle handle);
-   public AbandonedMutexException(string message, int location, WaitHandle handle);
-   public Mutex Mutex { get; }
-   public int MutexIndex { get; }
  }
- public sealed class AsyncLocal<T> {
-   public AsyncLocal();
-   public AsyncLocal(Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler);
-   public T Value { get; set; }
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct AsyncLocalValueChangedArgs<T> {
-   public T CurrentValue { get; }
-   public T PreviousValue { get; }
-   public bool ThreadContextChanged { get; }
  }
- public sealed class AutoResetEvent : EventWaitHandle {
-   public AutoResetEvent(bool initialState);
  }
- public class Barrier : IDisposable {
-   public Barrier(int participantCount);
-   public Barrier(int participantCount, Action<Barrier> postPhaseAction);
-   public long CurrentPhaseNumber { get; }
-   public int ParticipantCount { get; }
-   public int ParticipantsRemaining { get; }
-   public long AddParticipant();
-   public long AddParticipants(int participantCount);
-   public void Dispose();
-   protected virtual void Dispose(bool disposing);
-   public void RemoveParticipant();
-   public void RemoveParticipants(int participantCount);
-   public void SignalAndWait();
-   public bool SignalAndWait(int millisecondsTimeout);
-   public bool SignalAndWait(int millisecondsTimeout, CancellationToken cancellationToken);
-   public void SignalAndWait(CancellationToken cancellationToken);
-   public bool SignalAndWait(TimeSpan timeout);
-   public bool SignalAndWait(TimeSpan timeout, CancellationToken cancellationToken);
  }
- public class BarrierPostPhaseException : Exception {
-   public BarrierPostPhaseException();
-   public BarrierPostPhaseException(Exception innerException);
-   public BarrierPostPhaseException(string message);
-   public BarrierPostPhaseException(string message, Exception innerException);
  }
- public delegate void ContextCallback(object state);
- public class CountdownEvent : IDisposable {
-   public CountdownEvent(int initialCount);
-   public int CurrentCount { get; }
-   public int InitialCount { get; }
-   public bool IsSet { get; }
-   public WaitHandle WaitHandle { get; }
-   public void AddCount();
-   public void AddCount(int signalCount);
-   public void Dispose();
-   protected virtual void Dispose(bool disposing);
-   public void Reset();
-   public void Reset(int count);
-   public bool Signal();
-   public bool Signal(int signalCount);
-   public bool TryAddCount();
-   public bool TryAddCount(int signalCount);
-   public void Wait();
-   public bool Wait(int millisecondsTimeout);
-   public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken);
-   public void Wait(CancellationToken cancellationToken);
-   public bool Wait(TimeSpan timeout);
-   public bool Wait(TimeSpan timeout, CancellationToken cancellationToken);
  }
- public enum EventResetMode {
-   AutoReset = 0,
-   ManualReset = 1,
  }
- public class EventWaitHandle : WaitHandle {
-   public EventWaitHandle(bool initialState, EventResetMode mode);
-   public EventWaitHandle(bool initialState, EventResetMode mode, string name);
-   public EventWaitHandle(bool initialState, EventResetMode mode, string name, out bool createdNew);
-   public static EventWaitHandle OpenExisting(string name);
-   public bool Reset();
-   public bool Set();
-   public static bool TryOpenExisting(string name, out EventWaitHandle result);
  }
- public sealed class ExecutionContext {
-   public static ExecutionContext Capture();
-   public static void Run(ExecutionContext executionContext, ContextCallback callback, object state);
  }
- public static class Interlocked {
-   public static int Add(ref int location1, int value);
-   public static long Add(ref long location1, long value);
-   public static double CompareExchange(ref double location1, double value, double comparand);
-   public static int CompareExchange(ref int location1, int value, int comparand);
-   public static long CompareExchange(ref long location1, long value, long comparand);
-   public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand);
-   public static object CompareExchange(ref object location1, object value, object comparand);
-   public static float CompareExchange(ref float location1, float value, float comparand);
-   public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class;
-   public static int Decrement(ref int location);
-   public static long Decrement(ref long location);
-   public static double Exchange(ref double location1, double value);
-   public static int Exchange(ref int location1, int value);
-   public static long Exchange(ref long location1, long value);
-   public static IntPtr Exchange(ref IntPtr location1, IntPtr value);
-   public static object Exchange(ref object location1, object value);
-   public static float Exchange(ref float location1, float value);
-   public static T Exchange<T>(ref T location1, T value) where T : class;
-   public static int Increment(ref int location);
-   public static long Increment(ref long location);
-   public static void MemoryBarrier();
-   public static long Read(ref long location);
  }
- public static class LazyInitializer {
-   public static T EnsureInitialized<T>(ref T target) where T : class;
-   public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock);
-   public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory);
-   public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) where T : class;
  }
- public class LockRecursionException : Exception {
-   public LockRecursionException();
-   public LockRecursionException(string message);
-   public LockRecursionException(string message, Exception innerException);
  }
- public enum LockRecursionPolicy {
-   NoRecursion = 0,
-   SupportsRecursion = 1,
  }
- public sealed class ManualResetEvent : EventWaitHandle {
-   public ManualResetEvent(bool initialState);
  }
- public class ManualResetEventSlim : IDisposable {
-   public ManualResetEventSlim();
-   public ManualResetEventSlim(bool initialState);
-   public ManualResetEventSlim(bool initialState, int spinCount);
-   public bool IsSet { get; }
-   public int SpinCount { get; }
-   public WaitHandle WaitHandle { get; }
-   public void Dispose();
-   protected virtual void Dispose(bool disposing);
-   public void Reset();
-   public void Set();
-   public void Wait();
-   public bool Wait(int millisecondsTimeout);
-   public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken);
-   public void Wait(CancellationToken cancellationToken);
-   public bool Wait(TimeSpan timeout);
-   public bool Wait(TimeSpan timeout, CancellationToken cancellationToken);
  }
- public static class Monitor {
-   public static void Enter(object obj);
-   public static void Enter(object obj, ref bool lockTaken);
-   public static void Exit(object obj);
-   public static bool IsEntered(object obj);
-   public static void Pulse(object obj);
-   public static void PulseAll(object obj);
-   public static bool TryEnter(object obj);
-   public static void TryEnter(object obj, ref bool lockTaken);
-   public static bool TryEnter(object obj, int millisecondsTimeout);
-   public static void TryEnter(object obj, int millisecondsTimeout, ref bool lockTaken);
-   public static bool TryEnter(object obj, TimeSpan timeout);
-   public static void TryEnter(object obj, TimeSpan timeout, ref bool lockTaken);
-   public static bool Wait(object obj);
-   public static bool Wait(object obj, int millisecondsTimeout);
-   public static bool Wait(object obj, TimeSpan timeout);
  }
- public sealed class Mutex : WaitHandle {
-   public Mutex();
-   public Mutex(bool initiallyOwned);
-   public Mutex(bool initiallyOwned, string name);
-   public Mutex(bool initiallyOwned, string name, out bool createdNew);
-   public static Mutex OpenExisting(string name);
-   public void ReleaseMutex();
-   public static bool TryOpenExisting(string name, out Mutex result);
  }
- public class ReaderWriterLockSlim : IDisposable {
-   public ReaderWriterLockSlim();
-   public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy);
-   public int CurrentReadCount { get; }
-   public bool IsReadLockHeld { get; }
-   public bool IsUpgradeableReadLockHeld { get; }
-   public bool IsWriteLockHeld { get; }
-   public LockRecursionPolicy RecursionPolicy { get; }
-   public int RecursiveReadCount { get; }
-   public int RecursiveUpgradeCount { get; }
-   public int RecursiveWriteCount { get; }
-   public int WaitingReadCount { get; }
-   public int WaitingUpgradeCount { get; }
-   public int WaitingWriteCount { get; }
-   public void Dispose();
-   public void EnterReadLock();
-   public void EnterUpgradeableReadLock();
-   public void EnterWriteLock();
-   public void ExitReadLock();
-   public void ExitUpgradeableReadLock();
-   public void ExitWriteLock();
-   public bool TryEnterReadLock(int millisecondsTimeout);
-   public bool TryEnterReadLock(TimeSpan timeout);
-   public bool TryEnterUpgradeableReadLock(int millisecondsTimeout);
-   public bool TryEnterUpgradeableReadLock(TimeSpan timeout);
-   public bool TryEnterWriteLock(int millisecondsTimeout);
-   public bool TryEnterWriteLock(TimeSpan timeout);
  }
- public sealed class Semaphore : WaitHandle {
-   public Semaphore(int initialCount, int maximumCount);
-   public Semaphore(int initialCount, int maximumCount, string name);
-   public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew);
-   public static Semaphore OpenExisting(string name);
-   public int Release();
-   public int Release(int releaseCount);
-   public static bool TryOpenExisting(string name, out Semaphore result);
  }
- public class SemaphoreFullException : Exception {
-   public SemaphoreFullException();
-   public SemaphoreFullException(string message);
-   public SemaphoreFullException(string message, Exception innerException);
  }
- public class SemaphoreSlim : IDisposable {
-   public SemaphoreSlim(int initialCount);
-   public SemaphoreSlim(int initialCount, int maxCount);
-   public WaitHandle AvailableWaitHandle { get; }
-   public int CurrentCount { get; }
-   public void Dispose();
-   protected virtual void Dispose(bool disposing);
-   public int Release();
-   public int Release(int releaseCount);
-   public void Wait();
-   public bool Wait(int millisecondsTimeout);
-   public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken);
-   public void Wait(CancellationToken cancellationToken);
-   public bool Wait(TimeSpan timeout);
-   public bool Wait(TimeSpan timeout, CancellationToken cancellationToken);
-   public Task WaitAsync();
-   public Task<bool> WaitAsync(int millisecondsTimeout);
-   public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken);
-   public Task WaitAsync(CancellationToken cancellationToken);
-   public Task<bool> WaitAsync(TimeSpan timeout);
-   public Task<bool> WaitAsync(TimeSpan timeout, CancellationToken cancellationToken);
  }
- public delegate void SendOrPostCallback(object state);
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SpinLock {
-   public SpinLock(bool enableThreadOwnerTracking);
-   public bool IsHeld { get; }
-   public bool IsHeldByCurrentThread { get; }
-   public bool IsThreadOwnerTrackingEnabled { get; }
-   public void Enter(ref bool lockTaken);
-   public void Exit();
-   public void Exit(bool useMemoryBarrier);
-   public void TryEnter(ref bool lockTaken);
-   public void TryEnter(int millisecondsTimeout, ref bool lockTaken);
-   public void TryEnter(TimeSpan timeout, ref bool lockTaken);
  }
- [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SpinWait {
-   public int Count { get; }
-   public bool NextSpinWillYield { get; }
-   public void Reset();
-   public void SpinOnce();
-   public static void SpinUntil(Func<bool> condition);
-   public static bool SpinUntil(Func<bool> condition, int millisecondsTimeout);
-   public static bool SpinUntil(Func<bool> condition, TimeSpan timeout);
  }
- public class SynchronizationContext {
-   public SynchronizationContext();
-   public static SynchronizationContext Current { get; }
-   public virtual SynchronizationContext CreateCopy();
-   public virtual void OperationCompleted();
-   public virtual void OperationStarted();
-   public virtual void Post(SendOrPostCallback d, object state);
-   public virtual void Send(SendOrPostCallback d, object state);
-   public static void SetSynchronizationContext(SynchronizationContext syncContext);
  }
- public class SynchronizationLockException : Exception {
-   public SynchronizationLockException();
-   public SynchronizationLockException(string message);
-   public SynchronizationLockException(string message, Exception innerException);
  }
- public class ThreadLocal<T> : IDisposable {
-   public ThreadLocal();
-   public ThreadLocal(bool trackAllValues);
-   public ThreadLocal(Func<T> valueFactory);
-   public ThreadLocal(Func<T> valueFactory, bool trackAllValues);
-   public bool IsValueCreated { get; }
-   public T Value { get; set; }
-   public IList<T> Values { get; }
-   public void Dispose();
-   protected virtual void Dispose(bool disposing);
-   ~ThreadLocal();
-   public override string ToString();
  }
- public static class Volatile {
-   public static bool Read(ref bool location);
-   public static byte Read(ref byte location);
-   public static double Read(ref double location);
-   public static short Read(ref short location);
-   public static int Read(ref int location);
-   public static long Read(ref long location);
-   public static IntPtr Read(ref IntPtr location);
-   public static sbyte Read(ref sbyte location);
-   public static float Read(ref float location);
-   public static ushort Read(ref ushort location);
-   public static uint Read(ref uint location);
-   public static ulong Read(ref ulong location);
-   public static UIntPtr Read(ref UIntPtr location);
-   public static T Read<T>(ref T location) where T : class;
-   public static void Write(ref bool location, bool value);
-   public static void Write(ref byte location, byte value);
-   public static void Write(ref double location, double value);
-   public static void Write(ref short location, short value);
-   public static void Write(ref int location, int value);
-   public static void Write(ref long location, long value);
-   public static void Write(ref IntPtr location, IntPtr value);
-   public static void Write(ref sbyte location, sbyte value);
-   public static void Write(ref float location, float value);
-   public static void Write(ref ushort location, ushort value);
-   public static void Write(ref uint location, uint value);
-   public static void Write(ref ulong location, ulong value);
-   public static void Write(ref UIntPtr location, UIntPtr value);
-   public static void Write<T>(ref T location, T value) where T : class;
  }
- public class WaitHandleCannotBeOpenedException : Exception {
-   public WaitHandleCannotBeOpenedException();
-   public WaitHandleCannotBeOpenedException(string message);
-   public WaitHandleCannotBeOpenedException(string message, Exception innerException);
  }
 }
```
