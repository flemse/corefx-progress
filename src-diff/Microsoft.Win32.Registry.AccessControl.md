```diff
---lib-full\Microsoft.Win32.Registry.AccessControl.dll
+++lib-oss\Microsoft.Win32.Registry.AccessControl.dll
-namespace Microsoft.Win32 {
- public static class RegistryAclExtensions {
-   public static RegistrySecurity GetAccessControl(this RegistryKey key);
-   public static RegistrySecurity GetAccessControl(this RegistryKey key, AccessControlSections includeSections);
-   public static void SetAccessControl(this RegistryKey key, RegistrySecurity registrySecurity);
  }
 }
-namespace System.Security.AccessControl {
- public sealed class RegistryAccessRule : AccessRule {
-   public RegistryAccessRule(IdentityReference identity, RegistryRights registryRights, AccessControlType type);
-   public RegistryAccessRule(IdentityReference identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
-   public RegistryAccessRule(string identity, RegistryRights registryRights, AccessControlType type);
-   public RegistryAccessRule(string identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
-   public RegistryRights RegistryRights { get; }
  }
- public sealed class RegistryAuditRule : AuditRule {
-   public RegistryAuditRule(IdentityReference identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
-   public RegistryAuditRule(string identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
-   public RegistryRights RegistryRights { get; }
  }
- public sealed class RegistrySecurity : NativeObjectSecurity {
-   public RegistrySecurity();
-   public override Type AccessRightType { get; }
-   public override Type AccessRuleType { get; }
-   public override Type AuditRuleType { get; }
-   public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
-   public void AddAccessRule(RegistryAccessRule rule);
-   public void AddAuditRule(RegistryAuditRule rule);
-   public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
-   public bool RemoveAccessRule(RegistryAccessRule rule);
-   public void RemoveAccessRuleAll(RegistryAccessRule rule);
-   public void RemoveAccessRuleSpecific(RegistryAccessRule rule);
-   public bool RemoveAuditRule(RegistryAuditRule rule);
-   public void RemoveAuditRuleAll(RegistryAuditRule rule);
-   public void RemoveAuditRuleSpecific(RegistryAuditRule rule);
-   public void ResetAccessRule(RegistryAccessRule rule);
-   public void SetAccessRule(RegistryAccessRule rule);
-   public void SetAuditRule(RegistryAuditRule rule);
  }
 }
```
