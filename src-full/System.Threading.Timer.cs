namespace System.Threading {
  public sealed class Timer : IDisposable {
    public Timer(TimerCallback callback, object state, int dueTime, int period);
    public Timer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period);
    public bool Change(int dueTime, int period);
    public bool Change(TimeSpan dueTime, TimeSpan period);
    public void Dispose();
  }
  public delegate void TimerCallback(object state);
}
