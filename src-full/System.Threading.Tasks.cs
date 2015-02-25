namespace System {
  public class AggregateException : Exception {
    public AggregateException();
    public AggregateException(IEnumerable<Exception> innerExceptions);
    public AggregateException(params Exception[] innerExceptions);
    public AggregateException(string message);
    public AggregateException(string message, IEnumerable<Exception> innerExceptions);
    public AggregateException(string message, Exception innerException);
    public AggregateException(string message, params Exception[] innerExceptions);
    public ReadOnlyCollection<Exception> InnerExceptions { get; }
    public AggregateException Flatten();
    public override Exception GetBaseException();
    public void Handle(Func<Exception, bool> predicate);
    public override string ToString();
  }
  public class OperationCanceledException : Exception {
    public OperationCanceledException();
    public OperationCanceledException(string message);
    public OperationCanceledException(string message, Exception innerException);
    public OperationCanceledException(string message, Exception innerException, CancellationToken token);
    public OperationCanceledException(string message, CancellationToken token);
    public OperationCanceledException(CancellationToken token);
    public CancellationToken CancellationToken { get; }
  }
}
namespace System.Runtime.CompilerServices {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct AsyncTaskMethodBuilder {
    public Task Task { get; }
    public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine;
    public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine;
    public static AsyncTaskMethodBuilder Create();
    public void SetException(Exception exception);
    public void SetResult();
    public void SetStateMachine(IAsyncStateMachine stateMachine);
    public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine;
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct AsyncTaskMethodBuilder<TResult> {
    public Task<TResult> Task { get; }
    public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine;
    public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine;
    public static AsyncTaskMethodBuilder<TResult> Create();
    public void SetException(Exception exception);
    public void SetResult(TResult result);
    public void SetStateMachine(IAsyncStateMachine stateMachine);
    public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine;
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct AsyncVoidMethodBuilder {
    public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine;
    public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine;
    public static AsyncVoidMethodBuilder Create();
    public void SetException(Exception exception);
    public void SetResult();
    public void SetStateMachine(IAsyncStateMachine stateMachine);
    public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine;
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ConfiguredTaskAwaitable {
    public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion {
      public bool IsCompleted { get; }
      public void GetResult();
      public void OnCompleted(Action continuation);
      public void UnsafeOnCompleted(Action continuation);
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct ConfiguredTaskAwaitable<TResult> {
    public ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter GetAwaiter();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion {
      public bool IsCompleted { get; }
      public TResult GetResult();
      public void OnCompleted(Action continuation);
      public void UnsafeOnCompleted(Action continuation);
    }
  }
  public interface IAsyncStateMachine {
    void MoveNext();
    void SetStateMachine(IAsyncStateMachine stateMachine);
  }
  public interface ICriticalNotifyCompletion : INotifyCompletion {
    void UnsafeOnCompleted(Action continuation);
  }
  public interface INotifyCompletion {
    void OnCompleted(Action continuation);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion {
    public bool IsCompleted { get; }
    public void GetResult();
    public void OnCompleted(Action continuation);
    public void UnsafeOnCompleted(Action continuation);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion {
    public bool IsCompleted { get; }
    public TResult GetResult();
    public void OnCompleted(Action continuation);
    public void UnsafeOnCompleted(Action continuation);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
  public struct YieldAwaitable {
    public YieldAwaitable.YieldAwaiter GetAwaiter();
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
    public struct YieldAwaiter : ICriticalNotifyCompletion, INotifyCompletion {
      public bool IsCompleted { get; }
      public void GetResult();
      public void OnCompleted(Action continuation);
      public void UnsafeOnCompleted(Action continuation);
    }
  }
}
namespace System.Threading {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct CancellationToken {
    public CancellationToken(bool canceled);
    public bool CanBeCanceled { get; }
    public bool IsCancellationRequested { get; }
    public static CancellationToken None { get; }
    public WaitHandle WaitHandle { get; }
    public override bool Equals(object other);
    public bool Equals(CancellationToken other);
    public override int GetHashCode();
    public static bool operator ==(CancellationToken left, CancellationToken right);
    public static bool operator !=(CancellationToken left, CancellationToken right);
    public CancellationTokenRegistration Register(Action callback);
    public CancellationTokenRegistration Register(Action callback, bool useSynchronizationContext);
    public CancellationTokenRegistration Register(Action<object> callback, object state);
    public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext);
    public void ThrowIfCancellationRequested();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct CancellationTokenRegistration : IDisposable, IEquatable<CancellationTokenRegistration> {
    public void Dispose();
    public override bool Equals(object obj);
    public bool Equals(CancellationTokenRegistration other);
    public override int GetHashCode();
    public static bool operator ==(CancellationTokenRegistration left, CancellationTokenRegistration right);
    public static bool operator !=(CancellationTokenRegistration left, CancellationTokenRegistration right);
  }
  public class CancellationTokenSource : IDisposable {
    public CancellationTokenSource();
    public CancellationTokenSource(int millisecondsDelay);
    public CancellationTokenSource(TimeSpan delay);
    public bool IsCancellationRequested { get; }
    public CancellationToken Token { get; }
    public void Cancel();
    public void Cancel(bool throwOnFirstException);
    public void CancelAfter(int millisecondsDelay);
    public void CancelAfter(TimeSpan delay);
    public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2);
    public static CancellationTokenSource CreateLinkedTokenSource(params CancellationToken[] tokens);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
  }
}
namespace System.Threading.Tasks {
  public class ConcurrentExclusiveSchedulerPair {
    public ConcurrentExclusiveSchedulerPair();
    public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler);
    public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler, int maxConcurrencyLevel);
    public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler, int maxConcurrencyLevel, int maxItemsPerTask);
    public Task Completion { get; }
    public TaskScheduler ConcurrentScheduler { get; }
    public TaskScheduler ExclusiveScheduler { get; }
    public void Complete();
  }
  public class Task : IAsyncResult {
    public Task(Action action);
    public Task(Action action, CancellationToken cancellationToken);
    public Task(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions);
    public Task(Action action, TaskCreationOptions creationOptions);
    public Task(Action<object> action, object state);
    public Task(Action<object> action, object state, CancellationToken cancellationToken);
    public Task(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions);
    public Task(Action<object> action, object state, TaskCreationOptions creationOptions);
    public object AsyncState { get; }
    public static Task CompletedTask { get; }
    public TaskCreationOptions CreationOptions { get; }
    public static Nullable<int> CurrentId { get; }
    public AggregateException Exception { get; }
    public static TaskFactory Factory { get; }
    public int Id { get; }
    public bool IsCanceled { get; }
    public bool IsCompleted { get; }
    public bool IsFaulted { get; }
    public TaskStatus Status { get; }
    WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
    bool System.IAsyncResult.CompletedSynchronously { get; }
    public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext);
    public Task ContinueWith(Action<Task, object> continuationAction, object state);
    public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken);
    public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskContinuationOptions continuationOptions);
    public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler);
    public Task ContinueWith(Action<Task> continuationAction);
    public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken);
    public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions);
    public Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler);
    public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state);
    public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, CancellationToken cancellationToken);
    public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, TaskContinuationOptions continuationOptions);
    public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, TaskScheduler scheduler);
    public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction);
    public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, CancellationToken cancellationToken);
    public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions);
    public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler);
    public static Task Delay(int millisecondsDelay);
    public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken);
    public static Task Delay(TimeSpan delay);
    public static Task Delay(TimeSpan delay, CancellationToken cancellationToken);
    public static Task FromCanceled(CancellationToken cancellationToken);
    public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken);
    public static Task FromException(Exception exception);
    public static Task<TResult> FromException<TResult>(Exception exception);
    public static Task<TResult> FromResult<TResult>(TResult result);
    public TaskAwaiter GetAwaiter();
    public static Task Run(Action action);
    public static Task Run(Action action, CancellationToken cancellationToken);
    public static Task Run(Func<Task> function);
    public static Task Run(Func<Task> function, CancellationToken cancellationToken);
    public static Task<TResult> Run<TResult>(Func<Task<TResult>> function);
    public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken);
    public static Task<TResult> Run<TResult>(Func<TResult> function);
    public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken);
    public void RunSynchronously();
    public void RunSynchronously(TaskScheduler scheduler);
    public void Start();
    public void Start(TaskScheduler scheduler);
    public void Wait();
    public bool Wait(int millisecondsTimeout);
    public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken);
    public void Wait(CancellationToken cancellationToken);
    public bool Wait(TimeSpan timeout);
    public static void WaitAll(params Task[] tasks);
    public static bool WaitAll(Task[] tasks, int millisecondsTimeout);
    public static bool WaitAll(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken);
    public static void WaitAll(Task[] tasks, CancellationToken cancellationToken);
    public static bool WaitAll(Task[] tasks, TimeSpan timeout);
    public static int WaitAny(params Task[] tasks);
    public static int WaitAny(Task[] tasks, int millisecondsTimeout);
    public static int WaitAny(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken);
    public static int WaitAny(Task[] tasks, CancellationToken cancellationToken);
    public static int WaitAny(Task[] tasks, TimeSpan timeout);
    public static Task WhenAll(IEnumerable<Task> tasks);
    public static Task WhenAll(params Task[] tasks);
    public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks);
    public static Task<TResult[]> WhenAll<TResult>(params Task<TResult>[] tasks);
    public static Task<Task> WhenAny(IEnumerable<Task> tasks);
    public static Task<Task> WhenAny(params Task[] tasks);
    public static Task<Task<TResult>> WhenAny<TResult>(IEnumerable<Task<TResult>> tasks);
    public static Task<Task<TResult>> WhenAny<TResult>(params Task<TResult>[] tasks);
    public static YieldAwaitable Yield();
  }
  public class Task<TResult> : Task {
    public Task(Func<object, TResult> function, object state);
    public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken);
    public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions);
    public Task(Func<object, TResult> function, object state, TaskCreationOptions creationOptions);
    public Task(Func<TResult> function);
    public Task(Func<TResult> function, CancellationToken cancellationToken);
    public Task(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions);
    public Task(Func<TResult> function, TaskCreationOptions creationOptions);
    public static new TaskFactory<TResult> Factory { get; }
    public TResult Result { get; }
    public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext);
    public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state);
    public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, CancellationToken cancellationToken);
    public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskContinuationOptions continuationOptions);
    public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskScheduler scheduler);
    public Task ContinueWith(Action<Task<TResult>> continuationAction);
    public Task ContinueWith(Action<Task<TResult>> continuationAction, CancellationToken cancellationToken);
    public Task ContinueWith(Action<Task<TResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskContinuationOptions continuationOptions);
    public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler);
    public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state);
    public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, CancellationToken cancellationToken);
    public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, TaskContinuationOptions continuationOptions);
    public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, TaskScheduler scheduler);
    public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction);
    public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken);
    public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions);
    public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler);
    public new TaskAwaiter<TResult> GetAwaiter();
  }
  public class TaskCanceledException : OperationCanceledException {
    public TaskCanceledException();
    public TaskCanceledException(string message);
    public TaskCanceledException(string message, Exception innerException);
    public TaskCanceledException(Task task);
    public Task Task { get; }
  }
  public class TaskCompletionSource<TResult> {
    public TaskCompletionSource();
    public TaskCompletionSource(object state);
    public TaskCompletionSource(object state, TaskCreationOptions creationOptions);
    public TaskCompletionSource(TaskCreationOptions creationOptions);
    public Task<TResult> Task { get; }
    public void SetCanceled();
    public void SetException(IEnumerable<Exception> exceptions);
    public void SetException(Exception exception);
    public void SetResult(TResult result);
    public bool TrySetCanceled();
    public bool TrySetCanceled(CancellationToken cancellationToken);
    public bool TrySetException(IEnumerable<Exception> exceptions);
    public bool TrySetException(Exception exception);
    public bool TrySetResult(TResult result);
  }
  public enum TaskContinuationOptions {
    AttachedToParent = 4,
    DenyChildAttach = 8,
    ExecuteSynchronously = 524288,
    HideScheduler = 16,
    LazyCancellation = 32,
    LongRunning = 2,
    None = 0,
    NotOnCanceled = 262144,
    NotOnFaulted = 131072,
    NotOnRanToCompletion = 65536,
    OnlyOnCanceled = 196608,
    OnlyOnFaulted = 327680,
    OnlyOnRanToCompletion = 393216,
    PreferFairness = 1,
    RunContinuationsAsynchronously = 64,
  }
  public enum TaskCreationOptions {
    AttachedToParent = 4,
    DenyChildAttach = 8,
    HideScheduler = 16,
    LongRunning = 2,
    None = 0,
    PreferFairness = 1,
    RunContinuationsAsynchronously = 64,
  }
  public static class TaskExtensions {
    public static Task Unwrap(this Task<Task> task);
    public static Task<TResult> Unwrap<TResult>(this Task<Task<TResult>> task);
  }
  public class TaskFactory {
    public TaskFactory();
    public TaskFactory(CancellationToken cancellationToken);
    public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions);
    public TaskFactory(TaskScheduler scheduler);
    public CancellationToken CancellationToken { get; }
    public TaskContinuationOptions ContinuationOptions { get; }
    public TaskCreationOptions CreationOptions { get; }
    public TaskScheduler Scheduler { get; }
    public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction);
    public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, CancellationToken cancellationToken);
    public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, TaskContinuationOptions continuationOptions);
    public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction);
    public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken);
    public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions);
    public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction);
    public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken);
    public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, TaskContinuationOptions continuationOptions);
    public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction);
    public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken);
    public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, TaskContinuationOptions continuationOptions);
    public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction);
    public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, CancellationToken cancellationToken);
    public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, TaskContinuationOptions continuationOptions);
    public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction);
    public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken);
    public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions);
    public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction);
    public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, CancellationToken cancellationToken);
    public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, TaskContinuationOptions continuationOptions);
    public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction);
    public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken);
    public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions);
    public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state);
    public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state, TaskCreationOptions creationOptions);
    public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod);
    public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions);
    public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler);
    public Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state);
    public Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions);
    public Task FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state);
    public Task FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions);
    public Task<TResult> FromAsync<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state);
    public Task<TResult> FromAsync<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions);
    public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state);
    public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions);
    public Task<TResult> FromAsync<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state);
    public Task<TResult> FromAsync<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions);
    public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state);
    public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions);
    public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state);
    public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state, TaskCreationOptions creationOptions);
    public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod);
    public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions);
    public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler);
    public Task StartNew(Action action);
    public Task StartNew(Action action, CancellationToken cancellationToken);
    public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler);
    public Task StartNew(Action action, TaskCreationOptions creationOptions);
    public Task StartNew(Action<object> action, object state);
    public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken);
    public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler);
    public Task StartNew(Action<object> action, object state, TaskCreationOptions creationOptions);
    public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state);
    public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken);
    public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler);
    public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, TaskCreationOptions creationOptions);
    public Task<TResult> StartNew<TResult>(Func<TResult> function);
    public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken);
    public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler);
    public Task<TResult> StartNew<TResult>(Func<TResult> function, TaskCreationOptions creationOptions);
  }
  public class TaskFactory<TResult> {
    public TaskFactory();
    public TaskFactory(CancellationToken cancellationToken);
    public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions);
    public TaskFactory(TaskScheduler scheduler);
    public CancellationToken CancellationToken { get; }
    public TaskContinuationOptions ContinuationOptions { get; }
    public TaskCreationOptions CreationOptions { get; }
    public TaskScheduler Scheduler { get; }
    public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction);
    public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken);
    public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, TaskContinuationOptions continuationOptions);
    public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction);
    public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken);
    public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions);
    public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction);
    public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken);
    public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions);
    public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction);
    public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken);
    public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
    public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions);
    public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state);
    public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state, TaskCreationOptions creationOptions);
    public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod);
    public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions);
    public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler);
    public Task<TResult> FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state);
    public Task<TResult> FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions);
    public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state);
    public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions);
    public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state);
    public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions);
    public Task<TResult> StartNew(Func<object, TResult> function, object state);
    public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken);
    public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler);
    public Task<TResult> StartNew(Func<object, TResult> function, object state, TaskCreationOptions creationOptions);
    public Task<TResult> StartNew(Func<TResult> function);
    public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken);
    public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler);
    public Task<TResult> StartNew(Func<TResult> function, TaskCreationOptions creationOptions);
  }
  public abstract class TaskScheduler {
    protected TaskScheduler();
    public static TaskScheduler Current { get; }
    public static TaskScheduler Default { get; }
    public int Id { get; }
    public virtual int MaximumConcurrencyLevel { get; }
    public static event EventHandler<UnobservedTaskExceptionEventArgs> UnobservedTaskException;
    public static TaskScheduler FromCurrentSynchronizationContext();
    protected abstract IEnumerable<Task> GetScheduledTasks();
    protected internal abstract void QueueTask(Task task);
    protected internal virtual bool TryDequeue(Task task);
    protected bool TryExecuteTask(Task task);
    protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);
  }
  public class TaskSchedulerException : Exception {
    public TaskSchedulerException();
    public TaskSchedulerException(Exception innerException);
    public TaskSchedulerException(string message);
    public TaskSchedulerException(string message, Exception innerException);
  }
  public enum TaskStatus {
    Canceled = 6,
    Created = 0,
    Faulted = 7,
    RanToCompletion = 5,
    Running = 3,
    WaitingForActivation = 1,
    WaitingForChildrenToComplete = 4,
    WaitingToRun = 2,
  }
  public class UnobservedTaskExceptionEventArgs : EventArgs {
    public UnobservedTaskExceptionEventArgs(AggregateException exception);
    public AggregateException Exception { get; }
    public bool Observed { get; }
    public void SetObserved();
  }
}
