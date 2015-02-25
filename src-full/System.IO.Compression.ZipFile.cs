namespace System.IO.Compression {
  public static class ZipFile {
    public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName);
    public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory);
    public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding);
    public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName);
    public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding);
    public static ZipArchive Open(string archiveFileName, ZipArchiveMode mode);
    public static ZipArchive Open(string archiveFileName, ZipArchiveMode mode, Encoding entryNameEncoding);
    public static ZipArchive OpenRead(string archiveFileName);
  }
  public static class ZipFileExtensions {
    public static ZipArchiveEntry CreateEntryFromFile(this ZipArchive destination, string sourceFileName, string entryName);
    public static ZipArchiveEntry CreateEntryFromFile(this ZipArchive destination, string sourceFileName, string entryName, CompressionLevel compressionLevel);
    public static void ExtractToDirectory(this ZipArchive source, string destinationDirectoryName);
    public static void ExtractToFile(this ZipArchiveEntry source, string destinationFileName);
    public static void ExtractToFile(this ZipArchiveEntry source, string destinationFileName, bool overwrite);
  }
}
