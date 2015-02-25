```diff
---lib-full\System.IO.FileSystem.AccessControl.dll
+++lib-oss\System.IO.FileSystem.AccessControl.dll
-namespace System.IO {
- public static class FileSystemAclExtensions {
-   public static DirectorySecurity GetAccessControl(this DirectoryInfo directoryInfo);
-   public static DirectorySecurity GetAccessControl(this DirectoryInfo directoryInfo, AccessControlSections includeSections);
-   public static FileSecurity GetAccessControl(this FileInfo fileInfo);
-   public static FileSecurity GetAccessControl(this FileInfo fileInfo, AccessControlSections includeSections);
-   public static FileSecurity GetAccessControl(this FileStream fileStream);
-   public static void SetAccessControl(this DirectoryInfo directoryInfo, DirectorySecurity directorySecurity);
-   public static void SetAccessControl(this FileInfo fileInfo, FileSecurity fileSecurity);
-   public static void SetAccessControl(this FileStream fileStream, FileSecurity fileSecurity);
  }
 }
-namespace System.Security.AccessControl {
- public abstract class DirectoryObjectSecurity : ObjectSecurity {
-   protected DirectoryObjectSecurity();
-   protected DirectoryObjectSecurity(CommonSecurityDescriptor securityDescriptor);
-   public virtual AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type, Guid objectType, Guid inheritedObjectType);
-   protected void AddAccessRule(ObjectAccessRule rule);
-   protected void AddAuditRule(ObjectAuditRule rule);
-   public virtual AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags, Guid objectType, Guid inheritedObjectType);
-   public AuthorizationRuleCollection GetAccessRules(bool includeExplicit, bool includeInherited, Type targetType);
-   public AuthorizationRuleCollection GetAuditRules(bool includeExplicit, bool includeInherited, Type targetType);
-   protected override bool ModifyAccess(AccessControlModification modification, AccessRule rule, out bool modified);
-   protected override bool ModifyAudit(AccessControlModification modification, AuditRule rule, out bool modified);
-   protected bool RemoveAccessRule(ObjectAccessRule rule);
-   protected void RemoveAccessRuleAll(ObjectAccessRule rule);
-   protected void RemoveAccessRuleSpecific(ObjectAccessRule rule);
-   protected bool RemoveAuditRule(ObjectAuditRule rule);
-   protected void RemoveAuditRuleAll(ObjectAuditRule rule);
-   protected void RemoveAuditRuleSpecific(ObjectAuditRule rule);
-   protected void ResetAccessRule(ObjectAccessRule rule);
-   protected void SetAccessRule(ObjectAccessRule rule);
-   protected void SetAuditRule(ObjectAuditRule rule);
  }
- public sealed class DirectorySecurity : FileSystemSecurity {
-   public DirectorySecurity();
-   public DirectorySecurity(string name, AccessControlSections includeSections);
  }
- public sealed class FileSecurity : FileSystemSecurity {
-   public FileSecurity();
-   public FileSecurity(string fileName, AccessControlSections includeSections);
  }
- public sealed class FileSystemAccessRule : AccessRule {
-   public FileSystemAccessRule(IdentityReference identity, FileSystemRights fileSystemRights, AccessControlType type);
-   public FileSystemAccessRule(IdentityReference identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
-   public FileSystemAccessRule(string identity, FileSystemRights fileSystemRights, AccessControlType type);
-   public FileSystemAccessRule(string identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
-   public FileSystemRights FileSystemRights { get; }
  }
- public sealed class FileSystemAuditRule : AuditRule {
-   public FileSystemAuditRule(IdentityReference identity, FileSystemRights fileSystemRights, AuditFlags flags);
-   public FileSystemAuditRule(IdentityReference identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
-   public FileSystemAuditRule(string identity, FileSystemRights fileSystemRights, AuditFlags flags);
-   public FileSystemAuditRule(string identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
-   public FileSystemRights FileSystemRights { get; }
  }
- public enum FileSystemRights {
-   AppendData = 4,
-   ChangePermissions = 262144,
-   CreateDirectories = 4,
-   CreateFiles = 2,
-   Delete = 65536,
-   DeleteSubdirectoriesAndFiles = 64,
-   ExecuteFile = 32,
-   FullControl = 2032127,
-   ListDirectory = 1,
-   Modify = 197055,
-   Read = 131209,
-   ReadAndExecute = 131241,
-   ReadAttributes = 128,
-   ReadData = 1,
-   ReadExtendedAttributes = 8,
-   ReadPermissions = 131072,
-   Synchronize = 1048576,
-   TakeOwnership = 524288,
-   Traverse = 32,
-   Write = 278,
-   WriteAttributes = 256,
-   WriteData = 2,
-   WriteExtendedAttributes = 16,
  }
- public abstract class FileSystemSecurity : NativeObjectSecurity {
-   public override Type AccessRightType { get; }
-   public override Type AccessRuleType { get; }
-   public override Type AuditRuleType { get; }
-   public sealed override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
-   public void AddAccessRule(FileSystemAccessRule rule);
-   public void AddAuditRule(FileSystemAuditRule rule);
-   public sealed override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
-   public bool RemoveAccessRule(FileSystemAccessRule rule);
-   public void RemoveAccessRuleAll(FileSystemAccessRule rule);
-   public void RemoveAccessRuleSpecific(FileSystemAccessRule rule);
-   public bool RemoveAuditRule(FileSystemAuditRule rule);
-   public void RemoveAuditRuleAll(FileSystemAuditRule rule);
-   public void RemoveAuditRuleSpecific(FileSystemAuditRule rule);
-   public void ResetAccessRule(FileSystemAccessRule rule);
-   public void SetAccessRule(FileSystemAccessRule rule);
-   public void SetAuditRule(FileSystemAuditRule rule);
  }
 }
```
