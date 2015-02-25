```diff
---lib-full\System.IO.FileSystem.DriveInfo.dll
+++lib-oss\System.IO.FileSystem.DriveInfo.dll
 namespace System.IO {
  public sealed class DriveInfo {
    public DriveInfo(string driveName);
    public long AvailableFreeSpace { get; }
    public string DriveFormat { get; }
    public DriveType DriveType { get; }
    public bool IsReady { get; }
    public string Name { get; }
    public DirectoryInfo RootDirectory { get; }
    public long TotalFreeSpace { get; }
    public long TotalSize { get; }
    public string VolumeLabel { get; set; }
    public static DriveInfo[] GetDrives();
    public override string ToString();
  }
  public class DriveNotFoundException : IOException {
    public DriveNotFoundException();
    public DriveNotFoundException(string message);
    public DriveNotFoundException(string message, Exception innerException);
  }
  public enum DriveType {
    CDRom = 5,
    Fixed = 3,
    Network = 4,
    NoRootDirectory = 1,
    Ram = 6,
    Removable = 2,
    Unknown = 0,
  }
 }
```
