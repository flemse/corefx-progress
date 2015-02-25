namespace Microsoft.Win32.SafeHandles {
  public sealed class SafeFileHandle : SafeHandle {
    public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle);
    public override bool IsInvalid { get; }
    protected override bool ReleaseHandle();
  }
}
namespace System.IO {
  public static class Directory {
    public static DirectoryInfo CreateDirectory(string path);
    public static void Delete(string path);
    public static void Delete(string path, bool recursive);
    public static IEnumerable<string> EnumerateDirectories(string path);
    public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern);
    public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption);
    public static IEnumerable<string> EnumerateFiles(string path);
    public static IEnumerable<string> EnumerateFiles(string path, string searchPattern);
    public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption);
    public static IEnumerable<string> EnumerateFileSystemEntries(string path);
    public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern);
    public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
    public static bool Exists(string path);
    public static DateTime GetCreationTime(string path);
    public static DateTime GetCreationTimeUtc(string path);
    public static string GetCurrentDirectory();
    public static string[] GetDirectories(string path);
    public static string[] GetDirectories(string path, string searchPattern);
    public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);
    public static string GetDirectoryRoot(string path);
    public static string[] GetFiles(string path);
    public static string[] GetFiles(string path, string searchPattern);
    public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption);
    public static string[] GetFileSystemEntries(string path);
    public static string[] GetFileSystemEntries(string path, string searchPattern);
    public static string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
    public static DateTime GetLastAccessTime(string path);
    public static DateTime GetLastAccessTimeUtc(string path);
    public static DateTime GetLastWriteTime(string path);
    public static DateTime GetLastWriteTimeUtc(string path);
    public static DirectoryInfo GetParent(string path);
    public static void Move(string sourceDirName, string destDirName);
    public static void SetCreationTime(string path, DateTime creationTime);
    public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc);
    public static void SetCurrentDirectory(string path);
    public static void SetLastAccessTime(string path, DateTime lastAccessTime);
    public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);
    public static void SetLastWriteTime(string path, DateTime lastWriteTime);
    public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
  }
  public sealed class DirectoryInfo : FileSystemInfo {
    public DirectoryInfo(string path);
    public override bool Exists { get; }
    public override string Name { get; }
    public DirectoryInfo Parent { get; }
    public DirectoryInfo Root { get; }
    public void Create();
    public DirectoryInfo CreateSubdirectory(string path);
    public override void Delete();
    public void Delete(bool recursive);
    public IEnumerable<DirectoryInfo> EnumerateDirectories();
    public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern);
    public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption);
    public IEnumerable<FileInfo> EnumerateFiles();
    public IEnumerable<FileInfo> EnumerateFiles(string searchPattern);
    public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption);
    public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos();
    public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern);
    public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption);
    public DirectoryInfo[] GetDirectories();
    public DirectoryInfo[] GetDirectories(string searchPattern);
    public DirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption);
    public FileInfo[] GetFiles();
    public FileInfo[] GetFiles(string searchPattern);
    public FileInfo[] GetFiles(string searchPattern, SearchOption searchOption);
    public FileSystemInfo[] GetFileSystemInfos();
    public FileSystemInfo[] GetFileSystemInfos(string searchPattern);
    public FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption);
    public void MoveTo(string destDirName);
    public override string ToString();
  }
  public static class File {
    public static void AppendAllLines(string path, IEnumerable<string> contents);
    public static void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding);
    public static void AppendAllText(string path, string contents);
    public static void AppendAllText(string path, string contents, Encoding encoding);
    public static StreamWriter AppendText(string path);
    public static void Copy(string sourceFileName, string destFileName);
    public static void Copy(string sourceFileName, string destFileName, bool overwrite);
    public static FileStream Create(string path);
    public static FileStream Create(string path, int bufferSize);
    public static FileStream Create(string path, int bufferSize, FileOptions options);
    public static StreamWriter CreateText(string path);
    public static void Delete(string path);
    public static bool Exists(string path);
    public static FileAttributes GetAttributes(string path);
    public static DateTime GetCreationTime(string path);
    public static DateTime GetCreationTimeUtc(string path);
    public static DateTime GetLastAccessTime(string path);
    public static DateTime GetLastAccessTimeUtc(string path);
    public static DateTime GetLastWriteTime(string path);
    public static DateTime GetLastWriteTimeUtc(string path);
    public static void Move(string sourceFileName, string destFileName);
    public static FileStream Open(string path, FileMode mode);
    public static FileStream Open(string path, FileMode mode, FileAccess access);
    public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share);
    public static FileStream OpenRead(string path);
    public static StreamReader OpenText(string path);
    public static FileStream OpenWrite(string path);
    public static byte[] ReadAllBytes(string path);
    public static string[] ReadAllLines(string path);
    public static string[] ReadAllLines(string path, Encoding encoding);
    public static string ReadAllText(string path);
    public static string ReadAllText(string path, Encoding encoding);
    public static IEnumerable<string> ReadLines(string path);
    public static IEnumerable<string> ReadLines(string path, Encoding encoding);
    public static void SetAttributes(string path, FileAttributes fileAttributes);
    public static void SetCreationTime(string path, DateTime creationTime);
    public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc);
    public static void SetLastAccessTime(string path, DateTime lastAccessTime);
    public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);
    public static void SetLastWriteTime(string path, DateTime lastWriteTime);
    public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
    public static void WriteAllBytes(string path, byte[] bytes);
    public static void WriteAllLines(string path, IEnumerable<string> contents);
    public static void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding);
    public static void WriteAllText(string path, string contents);
    public static void WriteAllText(string path, string contents, Encoding encoding);
  }
  public sealed class FileInfo : FileSystemInfo {
    public FileInfo(string fileName);
    public DirectoryInfo Directory { get; }
    public string DirectoryName { get; }
    public override bool Exists { get; }
    public bool IsReadOnly { get; set; }
    public long Length { get; }
    public override string Name { get; }
    public StreamWriter AppendText();
    public FileInfo CopyTo(string destFileName);
    public FileInfo CopyTo(string destFileName, bool overwrite);
    public FileStream Create();
    public StreamWriter CreateText();
    public override void Delete();
    public void MoveTo(string destFileName);
    public FileStream Open(FileMode mode);
    public FileStream Open(FileMode mode, FileAccess access);
    public FileStream Open(FileMode mode, FileAccess access, FileShare share);
    public FileStream OpenRead();
    public StreamReader OpenText();
    public FileStream OpenWrite();
    public override string ToString();
  }
  public enum FileOptions {
    Asynchronous = 1073741824,
    DeleteOnClose = 67108864,
    Encrypted = 16384,
    None = 0,
    RandomAccess = 268435456,
    SequentialScan = 134217728,
    WriteThrough = -2147483648,
  }
  public class FileStream : Stream {
    public FileStream(SafeFileHandle handle, FileAccess access);
    public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize);
    public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync);
    public FileStream(string path, FileMode mode);
    public FileStream(string path, FileMode mode, FileAccess access);
    public FileStream(string path, FileMode mode, FileAccess access, FileShare share);
    public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize);
    public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync);
    public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options);
    public override bool CanRead { get; }
    public override bool CanSeek { get; }
    public override bool CanWrite { get; }
    public virtual bool IsAsync { get; }
    public override long Length { get; }
    public string Name { get; }
    public override long Position { get; set; }
    public virtual SafeFileHandle SafeFileHandle { get; }
    protected override void Dispose(bool disposing);
    ~FileStream();
    public override void Flush();
    public virtual void Flush(bool flushToDisk);
    public override Task FlushAsync(CancellationToken cancellationToken);
    public override int Read(byte[] array, int offset, int count);
    public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
    public override int ReadByte();
    public override long Seek(long offset, SeekOrigin origin);
    public override void SetLength(long value);
    public override void Write(byte[] array, int offset, int count);
    public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
    public override void WriteByte(byte value);
  }
  public abstract class FileSystemInfo {
    protected string FullPath;
    protected string OriginalPath;
    protected FileSystemInfo();
    public FileAttributes Attributes { get; set; }
    public DateTime CreationTime { get; set; }
    public DateTime CreationTimeUtc { get; set; }
    public abstract bool Exists { get; }
    public string Extension { get; }
    public virtual string FullName { get; }
    public DateTime LastAccessTime { get; set; }
    public DateTime LastAccessTimeUtc { get; set; }
    public DateTime LastWriteTime { get; set; }
    public DateTime LastWriteTimeUtc { get; set; }
    public abstract string Name { get; }
    public abstract void Delete();
    public void Refresh();
  }
  public enum SearchOption {
    AllDirectories = 1,
    TopDirectoryOnly = 0,
  }
}
