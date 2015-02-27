namespace Microsoft.Win32.SafeHandles {
  public sealed class SafeProcessHandle : SafeHandle {
    public SafeProcessHandle(IntPtr handle, bool ownsHandle);
    public override bool IsInvalid { get; }
    protected override bool ReleaseHandle();
  }
}
namespace System.Diagnostics {
  public class DataReceivedEventArgs : EventArgs {
    public string Data { get; }
  }
  public delegate void DataReceivedEventHandler(object sender, DataReceivedEventArgs e);
  public class Process : IDisposable {
    public Process();
    public int BasePriority { get; }
    public bool EnableRaisingEvents { get; set; }
    public int ExitCode { get; }
    public DateTime ExitTime { get; }
    public int HandleCount { get; }
    public bool HasExited { get; }
    public int Id { get; }
    public string MachineName { get; }
    public ProcessModule MainModule { get; }
    public IntPtr MaxWorkingSet { get; set; }
    public IntPtr MinWorkingSet { get; set; }
    public ProcessModuleCollection Modules { get; }
    public long NonpagedSystemMemorySize64 { get; }
    public long PagedMemorySize64 { get; }
    public long PagedSystemMemorySize64 { get; }
    public long PeakPagedMemorySize64 { get; }
    public long PeakVirtualMemorySize64 { get; }
    public long PeakWorkingSet64 { get; }
    public bool PriorityBoostEnabled { get; set; }
    public ProcessPriorityClass PriorityClass { get; set; }
    public long PrivateMemorySize64 { get; }
    public TimeSpan PrivilegedProcessorTime { get; }
    public string ProcessName { get; }
    public IntPtr ProcessorAffinity { get; set; }
    public SafeProcessHandle SafeHandle { get; }
    public int SessionId { get; }
    public StreamReader StandardError { get; }
    public StreamWriter StandardInput { get; }
    public StreamReader StandardOutput { get; }
    public ProcessStartInfo StartInfo { get; set; }
    public DateTime StartTime { get; }
    public ProcessThreadCollection Threads { get; }
    public TimeSpan TotalProcessorTime { get; }
    public TimeSpan UserProcessorTime { get; }
    public long VirtualMemorySize64 { get; }
    public long WorkingSet64 { get; }
    public event DataReceivedEventHandler ErrorDataReceived;
    public event EventHandler Exited;
    public event DataReceivedEventHandler OutputDataReceived;
    public void BeginErrorReadLine();
    public void BeginOutputReadLine();
    public void CancelErrorRead();
    public void CancelOutputRead();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public static void EnterDebugMode();
    public static Process GetCurrentProcess();
    public static Process GetProcessById(int processId);
    public static Process GetProcessById(int processId, string machineName);
    public static Process[] GetProcesses();
    public static Process[] GetProcesses(string machineName);
    public static Process[] GetProcessesByName(string processName);
    public static Process[] GetProcessesByName(string processName, string machineName);
    public void Kill();
    public static void LeaveDebugMode();
    protected void OnExited();
    public void Refresh();
    public bool Start();
    public static Process Start(ProcessStartInfo startInfo);
    public static Process Start(string fileName);
    public static Process Start(string fileName, string arguments);
    public static Process Start(string fileName, string userName, SecureString password, string domain);
    public static Process Start(string fileName, string arguments, string userName, SecureString password, string domain);
    public override string ToString();
    public void WaitForExit();
    public bool WaitForExit(int milliseconds);
  }
  public class ProcessModule {
    public IntPtr BaseAddress { get; }
    public IntPtr EntryPointAddress { get; }
    public string FileName { get; }
    public int ModuleMemorySize { get; }
    public string ModuleName { get; }
    public override string ToString();
  }
  public class ProcessModuleCollection : ICollection, IEnumerable {
    protected ProcessModuleCollection();
    public ProcessModuleCollection(ProcessModule[] processModules);
    public virtual int Count { get; }
    protected List<ProcessModule> InnerList { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    public ProcessModule this[int index] { get; }
    public bool Contains(ProcessModule module);
    public void CopyTo(ProcessModule[] array, int index);
    public virtual IEnumerator GetEnumerator();
    public int IndexOf(ProcessModule module);
    void System.Collections.ICollection.CopyTo(Array array, int index);
  }
  public enum ProcessPriorityClass {
    AboveNormal = 32768,
    BelowNormal = 16384,
    High = 128,
    Idle = 64,
    Normal = 32,
    RealTime = 256,
  }
  public sealed class ProcessStartInfo {
    public ProcessStartInfo();
    public ProcessStartInfo(string fileName);
    public ProcessStartInfo(string fileName, string arguments);
    public string Arguments { get; set; }
    public bool CreateNoWindow { get; set; }
    public string Domain { get; set; }
    public IDictionary<string, string> Environment { get; }
    public string FileName { get; set; }
    public bool LoadUserProfile { get; set; }
    public SecureString Password { get; set; }
    public bool RedirectStandardError { get; set; }
    public bool RedirectStandardInput { get; set; }
    public bool RedirectStandardOutput { get; set; }
    public Encoding StandardErrorEncoding { get; set; }
    public Encoding StandardOutputEncoding { get; set; }
    public string UserName { get; set; }
    public bool UseShellExecute { get; set; }
    public string WorkingDirectory { get; set; }
  }
  public class ProcessThread {
    public int BasePriority { get; }
    public int CurrentPriority { get; }
    public int Id { get; }
    public int IdealProcessor { set; }
    public bool PriorityBoostEnabled { get; set; }
    public ThreadPriorityLevel PriorityLevel { get; set; }
    public TimeSpan PrivilegedProcessorTime { get; }
    public IntPtr ProcessorAffinity { set; }
    public IntPtr StartAddress { get; }
    public DateTime StartTime { get; }
    public ThreadState ThreadState { get; }
    public TimeSpan TotalProcessorTime { get; }
    public TimeSpan UserProcessorTime { get; }
    public ThreadWaitReason WaitReason { get; }
    public void ResetIdealProcessor();
  }
  public class ProcessThreadCollection : ICollection, IEnumerable {
    protected ProcessThreadCollection();
    public ProcessThreadCollection(ProcessThread[] processThreads);
    public virtual int Count { get; }
    protected List<ProcessThread> InnerList { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    public ProcessThread this[int index] { get; }
    public int Add(ProcessThread thread);
    public bool Contains(ProcessThread thread);
    public void CopyTo(ProcessThread[] array, int index);
    public virtual IEnumerator GetEnumerator();
    public int IndexOf(ProcessThread thread);
    public void Insert(int index, ProcessThread thread);
    public void Remove(ProcessThread thread);
    void System.Collections.ICollection.CopyTo(Array array, int index);
  }
  public enum ProcessWindowStyle {
    Hidden = 1,
    Maximized = 3,
    Minimized = 2,
    Normal = 0,
  }
  public enum ThreadPriorityLevel {
    AboveNormal = 1,
    BelowNormal = -1,
    Highest = 2,
    Idle = -15,
    Lowest = -2,
    Normal = 0,
    TimeCritical = 15,
  }
  public enum ThreadState {
    Initialized = 0,
    Ready = 1,
    Running = 2,
    Standby = 3,
    Terminated = 4,
    Transition = 6,
    Unknown = 7,
    Wait = 5,
  }
  public enum ThreadWaitReason {
    EventPairHigh = 7,
    EventPairLow = 8,
    ExecutionDelay = 4,
    Executive = 0,
    FreePage = 1,
    LpcReceive = 9,
    LpcReply = 10,
    PageIn = 2,
    PageOut = 12,
    Suspended = 5,
    SystemAllocation = 3,
    Unknown = 13,
    UserRequest = 6,
    VirtualMemory = 11,
  }
}
