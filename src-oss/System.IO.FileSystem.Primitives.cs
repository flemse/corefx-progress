﻿namespace System.IO {
  public enum FileAccess {
    Read = 1,
    ReadWrite = 3,
    Write = 2,
  }
  public enum FileAttributes {
    Archive = 32,
    Compressed = 2048,
    Device = 64,
    Directory = 16,
    Encrypted = 16384,
    Hidden = 2,
    IntegrityStream = 32768,
    Normal = 128,
    NoScrubData = 131072,
    NotContentIndexed = 8192,
    Offline = 4096,
    ReadOnly = 1,
    ReparsePoint = 1024,
    SparseFile = 512,
    System = 4,
    Temporary = 256,
  }
  public enum FileMode {
    Append = 6,
    Create = 2,
    CreateNew = 1,
    Open = 3,
    OpenOrCreate = 4,
    Truncate = 5,
  }
  public enum FileShare {
    Delete = 4,
    Inheritable = 16,
    None = 0,
    Read = 1,
    ReadWrite = 3,
    Write = 2,
  }
}
