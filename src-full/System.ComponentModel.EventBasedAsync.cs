namespace System.ComponentModel {
  public class AsyncCompletedEventArgs : EventArgs {
    public AsyncCompletedEventArgs(Exception error, bool cancelled, object userState);
    public bool Cancelled { get; }
    public Exception Error { get; }
    public object UserState { get; }
    protected void RaiseExceptionIfNecessary();
  }
  public delegate void AsyncCompletedEventHandler(object sender, AsyncCompletedEventArgs e);
  public sealed class AsyncOperation {
    public SynchronizationContext SynchronizationContext { get; }
    public object UserSuppliedState { get; }
    ~AsyncOperation();
    public void OperationCompleted();
    public void Post(SendOrPostCallback d, object arg);
    public void PostOperationCompleted(SendOrPostCallback d, object arg);
  }
  public static class AsyncOperationManager {
    public static SynchronizationContext SynchronizationContext { get; set; }
    public static AsyncOperation CreateOperation(object userSuppliedState);
  }
  public class BackgroundWorker : IDisposable {
    public BackgroundWorker();
    public bool CancellationPending { get; }
    public bool IsBusy { get; }
    public bool WorkerReportsProgress { get; set; }
    public bool WorkerSupportsCancellation { get; set; }
    public event DoWorkEventHandler DoWork;
    public event ProgressChangedEventHandler ProgressChanged;
    public event RunWorkerCompletedEventHandler RunWorkerCompleted;
    public void CancelAsync();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    protected virtual void OnDoWork(DoWorkEventArgs e);
    protected virtual void OnProgressChanged(ProgressChangedEventArgs e);
    protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e);
    public void ReportProgress(int percentProgress);
    public void ReportProgress(int percentProgress, object userState);
    public void RunWorkerAsync();
    public void RunWorkerAsync(object argument);
  }
  public class DoWorkEventArgs : EventArgs {
    public DoWorkEventArgs(object argument);
    public object Argument { get; }
    public bool Cancel { get; set; }
    public object Result { get; set; }
  }
  public delegate void DoWorkEventHandler(object sender, DoWorkEventArgs e);
  public class ProgressChangedEventArgs : EventArgs {
    public ProgressChangedEventArgs(int progressPercentage, object userState);
    public int ProgressPercentage { get; }
    public object UserState { get; }
  }
  public delegate void ProgressChangedEventHandler(object sender, ProgressChangedEventArgs e);
  public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs {
    public RunWorkerCompletedEventArgs(object result, Exception error, bool cancelled);
    public object Result { get; }
    public new object UserState { get; }
  }
  public delegate void RunWorkerCompletedEventHandler(object sender, RunWorkerCompletedEventArgs e);
}
