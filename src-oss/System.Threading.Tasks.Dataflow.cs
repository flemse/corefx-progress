namespace System.Threading.Tasks.Dataflow {
  public sealed class ActionBlock<TInput> : IDataflowBlock, ITargetBlock<TInput> {
    public ActionBlock(Action<TInput> action);
    public ActionBlock(Action<TInput> action, ExecutionDataflowBlockOptions dataflowBlockOptions);
    public ActionBlock(Func<TInput, Task> action);
    public ActionBlock(Func<TInput, Task> action, ExecutionDataflowBlockOptions dataflowBlockOptions);
    public Task Completion { get; }
    public int InputCount { get; }
    public void Complete();
    [MethodImpl(AggressiveInlining)]public bool Post(TInput item);
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(Exception exception);
    DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<TInput>.OfferMessage(DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<TInput> source, bool consumeToAccept);
    public override string ToString();
  }
  public sealed class BatchBlock<T> : IDataflowBlock, IPropagatorBlock<T, T[]>, IReceivableSourceBlock<T[]>, ISourceBlock<T[]>, ITargetBlock<T> {
    public BatchBlock(int batchSize);
    public BatchBlock(int batchSize, GroupingDataflowBlockOptions dataflowBlockOptions);
    public int BatchSize { get; }
    public Task Completion { get; }
    public int OutputCount { get; }
    public void Complete();
    public IDisposable LinkTo(ITargetBlock<T[]> target, DataflowLinkOptions linkOptions);
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(Exception exception);
    T[] System.Threading.Tasks.Dataflow.ISourceBlock<T[]>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<T[]> target, out bool messageConsumed);
    void System.Threading.Tasks.Dataflow.ISourceBlock<T[]>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<T[]> target);
    bool System.Threading.Tasks.Dataflow.ISourceBlock<T[]>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<T[]> target);
    DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<T>.OfferMessage(DataflowMessageHeader messageHeader, T messageValue, ISourceBlock<T> source, bool consumeToAccept);
    public override string ToString();
    public void TriggerBatch();
    public bool TryReceive(Predicate<T[]> filter, out T[] item);
    public bool TryReceiveAll(out IList<T[]> items);
  }
  public sealed class BatchedJoinBlock<T1, T2> : IDataflowBlock {
    public BatchedJoinBlock(int batchSize);
    public BatchedJoinBlock(int batchSize, GroupingDataflowBlockOptions dataflowBlockOptions);
    public int BatchSize { get; }
    public Task Completion { get; }
    public int OutputCount { get; }
    public ITargetBlock<T1> Target1 { get; }
    public ITargetBlock<T2> Target2 { get; }
    public void Complete();
    public IDisposable LinkTo(ITargetBlock<Tuple<IList<T1>, IList<T2>>> target, DataflowLinkOptions linkOptions);
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(Exception exception);
    public override string ToString();
    public bool TryReceive(Predicate<Tuple<IList<T1>, IList<T2>>> filter, out Tuple<IList<T1>, IList<T2>> item);
    public bool TryReceiveAll(out IList<Tuple<IList<T1>, IList<T2>>> items);
  }
  public sealed class BatchedJoinBlock<T1, T2, T3> : IDataflowBlock {
    public BatchedJoinBlock(int batchSize);
    public BatchedJoinBlock(int batchSize, GroupingDataflowBlockOptions dataflowBlockOptions);
    public int BatchSize { get; }
    public Task Completion { get; }
    public int OutputCount { get; }
    public ITargetBlock<T1> Target1 { get; }
    public ITargetBlock<T2> Target2 { get; }
    public ITargetBlock<T3> Target3 { get; }
    public void Complete();
    public IDisposable LinkTo(ITargetBlock<Tuple<IList<T1>, IList<T2>, IList<T3>>> target, DataflowLinkOptions linkOptions);
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(Exception exception);
    public override string ToString();
    public bool TryReceive(Predicate<Tuple<IList<T1>, IList<T2>, IList<T3>>> filter, out Tuple<IList<T1>, IList<T2>, IList<T3>> item);
    public bool TryReceiveAll(out IList<Tuple<IList<T1>, IList<T2>, IList<T3>>> items);
  }
  public sealed class BroadcastBlock<T> : IDataflowBlock, IPropagatorBlock<T, T>, IReceivableSourceBlock<T>, ISourceBlock<T>, ITargetBlock<T> {
    public BroadcastBlock(Func<T, T> cloningFunction);
    public BroadcastBlock(Func<T, T> cloningFunction, DataflowBlockOptions dataflowBlockOptions);
    public Task Completion { get; }
    public void Complete();
    public IDisposable LinkTo(ITargetBlock<T> target, DataflowLinkOptions linkOptions);
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(Exception exception);
    bool System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T>.TryReceiveAll(out IList<T> items);
    T System.Threading.Tasks.Dataflow.ISourceBlock<T>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target, out bool messageConsumed);
    void System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<T> target);
    bool System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target);
    DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<T>.OfferMessage(DataflowMessageHeader messageHeader, T messageValue, ISourceBlock<T> source, bool consumeToAccept);
    public override string ToString();
    public bool TryReceive(Predicate<T> filter, out T item);
  }
  public sealed class BufferBlock<T> : IDataflowBlock, IPropagatorBlock<T, T>, IReceivableSourceBlock<T>, ISourceBlock<T>, ITargetBlock<T> {
    public BufferBlock();
    public BufferBlock(DataflowBlockOptions dataflowBlockOptions);
    public Task Completion { get; }
    public int Count { get; }
    public void Complete();
    public IDisposable LinkTo(ITargetBlock<T> target, DataflowLinkOptions linkOptions);
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(Exception exception);
    T System.Threading.Tasks.Dataflow.ISourceBlock<T>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target, out bool messageConsumed);
    void System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<T> target);
    bool System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target);
    DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<T>.OfferMessage(DataflowMessageHeader messageHeader, T messageValue, ISourceBlock<T> source, bool consumeToAccept);
    public override string ToString();
    public bool TryReceive(Predicate<T> filter, out T item);
    public bool TryReceiveAll(out IList<T> items);
  }
  public static class DataflowBlock {
    public static IObservable<TOutput> AsObservable<TOutput>(this ISourceBlock<TOutput> source);
    public static IObserver<TInput> AsObserver<TInput>(this ITargetBlock<TInput> target);
    public static Task<int> Choose<T1, T2, T3>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2, ISourceBlock<T3> source3, Action<T3> action3);
    public static Task<int> Choose<T1, T2, T3>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2, ISourceBlock<T3> source3, Action<T3> action3, DataflowBlockOptions dataflowBlockOptions);
    public static Task<int> Choose<T1, T2>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2);
    public static Task<int> Choose<T1, T2>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2, DataflowBlockOptions dataflowBlockOptions);
    public static IPropagatorBlock<TInput, TOutput> Encapsulate<TInput, TOutput>(ITargetBlock<TInput> target, ISourceBlock<TOutput> source);
    public static IDisposable LinkTo<TOutput>(this ISourceBlock<TOutput> source, ITargetBlock<TOutput> target);
    public static IDisposable LinkTo<TOutput>(this ISourceBlock<TOutput> source, ITargetBlock<TOutput> target, Predicate<TOutput> predicate);
    public static IDisposable LinkTo<TOutput>(this ISourceBlock<TOutput> source, ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions, Predicate<TOutput> predicate);
    public static ITargetBlock<TInput> NullTarget<TInput>();
    public static Task<bool> OutputAvailableAsync<TOutput>(this ISourceBlock<TOutput> source);
    public static Task<bool> OutputAvailableAsync<TOutput>(this ISourceBlock<TOutput> source, CancellationToken cancellationToken);
    public static bool Post<TInput>(this ITargetBlock<TInput> target, TInput item);
    public static TOutput Receive<TOutput>(this ISourceBlock<TOutput> source);
    public static TOutput Receive<TOutput>(this ISourceBlock<TOutput> source, CancellationToken cancellationToken);
    public static TOutput Receive<TOutput>(this ISourceBlock<TOutput> source, TimeSpan timeout);
    public static TOutput Receive<TOutput>(this ISourceBlock<TOutput> source, TimeSpan timeout, CancellationToken cancellationToken);
    public static Task<TOutput> ReceiveAsync<TOutput>(this ISourceBlock<TOutput> source);
    public static Task<TOutput> ReceiveAsync<TOutput>(this ISourceBlock<TOutput> source, CancellationToken cancellationToken);
    public static Task<TOutput> ReceiveAsync<TOutput>(this ISourceBlock<TOutput> source, TimeSpan timeout);
    public static Task<TOutput> ReceiveAsync<TOutput>(this ISourceBlock<TOutput> source, TimeSpan timeout, CancellationToken cancellationToken);
    public static Task<bool> SendAsync<TInput>(this ITargetBlock<TInput> target, TInput item);
    public static Task<bool> SendAsync<TInput>(this ITargetBlock<TInput> target, TInput item, CancellationToken cancellationToken);
    public static bool TryReceive<TOutput>(this IReceivableSourceBlock<TOutput> source, out TOutput item);
  }
  public class DataflowBlockOptions {
    public const int Unbounded = -1;
    public DataflowBlockOptions();
    public int BoundedCapacity { get; set; }
    public CancellationToken CancellationToken { get; set; }
    public int MaxMessagesPerTask { get; set; }
    public string NameFormat { get; set; }
    public TaskScheduler TaskScheduler { get; set; }
  }
  public class DataflowLinkOptions {
    public DataflowLinkOptions();
    public bool Append { get; set; }
    public int MaxMessages { get; set; }
    public bool PropagateCompletion { get; set; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct DataflowMessageHeader : IEquatable<DataflowMessageHeader> {
    public DataflowMessageHeader(long id);
    public long Id { get; }
    public bool IsValid { get; }
    public override bool Equals(object obj);
    public bool Equals(DataflowMessageHeader other);
    public override int GetHashCode();
    public static bool operator ==(DataflowMessageHeader left, DataflowMessageHeader right);
    public static bool operator !=(DataflowMessageHeader left, DataflowMessageHeader right);
  }
  public enum DataflowMessageStatus {
    Accepted = 0,
    Declined = 1,
    DecliningPermanently = 4,
    NotAvailable = 3,
    Postponed = 2,
  }
  public class ExecutionDataflowBlockOptions : DataflowBlockOptions {
    public ExecutionDataflowBlockOptions();
    public int MaxDegreeOfParallelism { get; set; }
    public bool SingleProducerConstrained { get; set; }
  }
  public class GroupingDataflowBlockOptions : DataflowBlockOptions {
    public GroupingDataflowBlockOptions();
    public bool Greedy { get; set; }
    public long MaxNumberOfGroups { get; set; }
  }
  public interface IDataflowBlock {
    Task Completion { get; }
    void Complete();
    void Fault(Exception exception);
  }
  public interface IPropagatorBlock<in TInput, out TOutput> : IDataflowBlock, ISourceBlock<TOutput>, ITargetBlock<TInput> {
  }
  public interface IReceivableSourceBlock<TOutput> : IDataflowBlock, ISourceBlock<TOutput> {
    bool TryReceive(Predicate<TOutput> filter, out TOutput item);
    bool TryReceiveAll(out IList<TOutput> items);
  }
  public interface ISourceBlock<out TOutput> : IDataflowBlock {
    TOutput ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target, out bool messageConsumed);
    IDisposable LinkTo(ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions);
    void ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target);
    bool ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target);
  }
  public interface ITargetBlock<in TInput> : IDataflowBlock {
    DataflowMessageStatus OfferMessage(DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<TInput> source, bool consumeToAccept);
  }
  public sealed class JoinBlock<T1, T2> : IDataflowBlock {
    public JoinBlock();
    public JoinBlock(GroupingDataflowBlockOptions dataflowBlockOptions);
    public Task Completion { get; }
    public int OutputCount { get; }
    public ITargetBlock<T1> Target1 { get; }
    public ITargetBlock<T2> Target2 { get; }
    public void Complete();
    public IDisposable LinkTo(ITargetBlock<Tuple<T1, T2>> target, DataflowLinkOptions linkOptions);
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(Exception exception);
    public override string ToString();
    public bool TryReceive(Predicate<Tuple<T1, T2>> filter, out Tuple<T1, T2> item);
    public bool TryReceiveAll(out IList<Tuple<T1, T2>> items);
  }
  public sealed class JoinBlock<T1, T2, T3> : IDataflowBlock {
    public JoinBlock();
    public JoinBlock(GroupingDataflowBlockOptions dataflowBlockOptions);
    public Task Completion { get; }
    public int OutputCount { get; }
    public ITargetBlock<T1> Target1 { get; }
    public ITargetBlock<T2> Target2 { get; }
    public ITargetBlock<T3> Target3 { get; }
    public void Complete();
    public IDisposable LinkTo(ITargetBlock<Tuple<T1, T2, T3>> target, DataflowLinkOptions linkOptions);
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(Exception exception);
    public override string ToString();
    public bool TryReceive(Predicate<Tuple<T1, T2, T3>> filter, out Tuple<T1, T2, T3> item);
    public bool TryReceiveAll(out IList<Tuple<T1, T2, T3>> items);
  }
  public sealed class TransformBlock<TInput, TOutput> : IDataflowBlock, IPropagatorBlock<TInput, TOutput>, IReceivableSourceBlock<TOutput>, ISourceBlock<TOutput>, ITargetBlock<TInput> {
    public TransformBlock(Func<TInput, Task<TOutput>> transform);
    public TransformBlock(Func<TInput, Task<TOutput>> transform, ExecutionDataflowBlockOptions dataflowBlockOptions);
    public TransformBlock(Func<TInput, TOutput> transform);
    public TransformBlock(Func<TInput, TOutput> transform, ExecutionDataflowBlockOptions dataflowBlockOptions);
    public Task Completion { get; }
    public int InputCount { get; }
    public int OutputCount { get; }
    public void Complete();
    public IDisposable LinkTo(ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions);
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(Exception exception);
    TOutput System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target, out bool messageConsumed);
    void System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target);
    bool System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target);
    DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<TInput>.OfferMessage(DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<TInput> source, bool consumeToAccept);
    public override string ToString();
    public bool TryReceive(Predicate<TOutput> filter, out TOutput item);
    public bool TryReceiveAll(out IList<TOutput> items);
  }
  public sealed class TransformManyBlock<TInput, TOutput> : IDataflowBlock, IPropagatorBlock<TInput, TOutput>, IReceivableSourceBlock<TOutput>, ISourceBlock<TOutput>, ITargetBlock<TInput> {
    public TransformManyBlock(Func<TInput, IEnumerable<TOutput>> transform);
    public TransformManyBlock(Func<TInput, IEnumerable<TOutput>> transform, ExecutionDataflowBlockOptions dataflowBlockOptions);
    public TransformManyBlock(Func<TInput, Task<IEnumerable<TOutput>>> transform);
    public TransformManyBlock(Func<TInput, Task<IEnumerable<TOutput>>> transform, ExecutionDataflowBlockOptions dataflowBlockOptions);
    public Task Completion { get; }
    public int InputCount { get; }
    public int OutputCount { get; }
    public void Complete();
    public IDisposable LinkTo(ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions);
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(Exception exception);
    TOutput System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target, out bool messageConsumed);
    void System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target);
    bool System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target);
    DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<TInput>.OfferMessage(DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<TInput> source, bool consumeToAccept);
    public override string ToString();
    public bool TryReceive(Predicate<TOutput> filter, out TOutput item);
    public bool TryReceiveAll(out IList<TOutput> items);
  }
  public sealed class WriteOnceBlock<T> : IDataflowBlock, IPropagatorBlock<T, T>, IReceivableSourceBlock<T>, ISourceBlock<T>, ITargetBlock<T> {
    public WriteOnceBlock(Func<T, T> cloningFunction);
    public WriteOnceBlock(Func<T, T> cloningFunction, DataflowBlockOptions dataflowBlockOptions);
    public Task Completion { get; }
    public void Complete();
    public IDisposable LinkTo(ITargetBlock<T> target, DataflowLinkOptions linkOptions);
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(Exception exception);
    bool System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T>.TryReceiveAll(out IList<T> items);
    T System.Threading.Tasks.Dataflow.ISourceBlock<T>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target, out bool messageConsumed);
    void System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<T> target);
    bool System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target);
    DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<T>.OfferMessage(DataflowMessageHeader messageHeader, T messageValue, ISourceBlock<T> source, bool consumeToAccept);
    public override string ToString();
    public bool TryReceive(Predicate<T> filter, out T item);
  }
}
