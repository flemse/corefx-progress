```diff
---lib-full\System.IO.FileSystem.Watcher.dll
+++lib-oss\System.IO.FileSystem.Watcher.dll
 namespace System.IO {
  public class ErrorEventArgs : EventArgs {
    public ErrorEventArgs(Exception exception);
    public virtual Exception GetException();
  }
  public delegate void ErrorEventHandler(object sender, ErrorEventArgs e);
  public class FileSystemEventArgs : EventArgs {
    public FileSystemEventArgs(WatcherChangeTypes changeType, string directory, string name);
    public WatcherChangeTypes ChangeType { get; }
    public string FullPath { get; }
    public string Name { get; }
  }
  public delegate void FileSystemEventHandler(object sender, FileSystemEventArgs e);
  public class FileSystemWatcher : IDisposable {
    public FileSystemWatcher();
    public FileSystemWatcher(string path);
    public FileSystemWatcher(string path, string filter);
    public bool EnableRaisingEvents { get; set; }
    public string Filter { get; set; }
    public bool IncludeSubdirectories { get; set; }
    public int InternalBufferSize { get; set; }
    public NotifyFilters NotifyFilter { get; set; }
    public string Path { get; set; }
    public event FileSystemEventHandler Changed;
    public event FileSystemEventHandler Created;
    public event FileSystemEventHandler Deleted;
    public event ErrorEventHandler Error;
    public event RenamedEventHandler Renamed;
    public void Dispose();
    protected virtual void Dispose(bool disposing);
+   ~FileSystemWatcher();
    protected void OnChanged(FileSystemEventArgs e);
    protected void OnCreated(FileSystemEventArgs e);
    protected void OnDeleted(FileSystemEventArgs e);
    protected void OnError(ErrorEventArgs e);
    protected void OnRenamed(RenamedEventArgs e);
  }
+ public class InternalBufferOverflowException : Exception {
+   public InternalBufferOverflowException();
+   public InternalBufferOverflowException(string message);
+   public InternalBufferOverflowException(string message, Exception inner);
  }
  public enum NotifyFilters {
    Attributes = 4,
    CreationTime = 64,
    DirectoryName = 2,
    FileName = 1,
    LastAccess = 32,
    LastWrite = 16,
    Security = 256,
    Size = 8,
  }
  public class RenamedEventArgs : FileSystemEventArgs {
    public RenamedEventArgs(WatcherChangeTypes changeType, string directory, string name, string oldName);
    public string OldFullPath { get; }
    public string OldName { get; }
  }
  public delegate void RenamedEventHandler(object sender, RenamedEventArgs e);
  public enum WatcherChangeTypes {
    All = 15,
    Changed = 4,
    Created = 1,
    Deleted = 2,
    Renamed = 8,
  }
 }
```
