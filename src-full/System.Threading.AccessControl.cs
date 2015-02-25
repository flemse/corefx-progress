namespace System.Security.AccessControl {
  public sealed class EventWaitHandleAccessRule : AccessRule {
    public EventWaitHandleAccessRule(IdentityReference identity, EventWaitHandleRights eventRights, AccessControlType type);
    public EventWaitHandleAccessRule(string identity, EventWaitHandleRights eventRights, AccessControlType type);
    public EventWaitHandleRights EventWaitHandleRights { get; }
  }
  public sealed class EventWaitHandleAuditRule : AuditRule {
    public EventWaitHandleAuditRule(IdentityReference identity, EventWaitHandleRights eventRights, AuditFlags flags);
    public EventWaitHandleRights EventWaitHandleRights { get; }
  }
  public enum EventWaitHandleRights {
    ChangePermissions = 262144,
    Delete = 65536,
    FullControl = 2031619,
    Modify = 2,
    ReadPermissions = 131072,
    Synchronize = 1048576,
    TakeOwnership = 524288,
  }
  public sealed class EventWaitHandleSecurity : NativeObjectSecurity {
    public EventWaitHandleSecurity();
    public override Type AccessRightType { get; }
    public override Type AccessRuleType { get; }
    public override Type AuditRuleType { get; }
    public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
    public void AddAccessRule(EventWaitHandleAccessRule rule);
    public void AddAuditRule(EventWaitHandleAuditRule rule);
    public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
    public bool RemoveAccessRule(EventWaitHandleAccessRule rule);
    public void RemoveAccessRuleAll(EventWaitHandleAccessRule rule);
    public void RemoveAccessRuleSpecific(EventWaitHandleAccessRule rule);
    public bool RemoveAuditRule(EventWaitHandleAuditRule rule);
    public void RemoveAuditRuleAll(EventWaitHandleAuditRule rule);
    public void RemoveAuditRuleSpecific(EventWaitHandleAuditRule rule);
    public void ResetAccessRule(EventWaitHandleAccessRule rule);
    public void SetAccessRule(EventWaitHandleAccessRule rule);
    public void SetAuditRule(EventWaitHandleAuditRule rule);
  }
  public sealed class MutexAccessRule : AccessRule {
    public MutexAccessRule(IdentityReference identity, MutexRights eventRights, AccessControlType type);
    public MutexAccessRule(string identity, MutexRights eventRights, AccessControlType type);
    public MutexRights MutexRights { get; }
  }
  public sealed class MutexAuditRule : AuditRule {
    public MutexAuditRule(IdentityReference identity, MutexRights eventRights, AuditFlags flags);
    public MutexRights MutexRights { get; }
  }
  public enum MutexRights {
    ChangePermissions = 262144,
    Delete = 65536,
    FullControl = 2031617,
    Modify = 1,
    ReadPermissions = 131072,
    Synchronize = 1048576,
    TakeOwnership = 524288,
  }
  public sealed class MutexSecurity : NativeObjectSecurity {
    public MutexSecurity();
    public MutexSecurity(string name, AccessControlSections includeSections);
    public override Type AccessRightType { get; }
    public override Type AccessRuleType { get; }
    public override Type AuditRuleType { get; }
    public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
    public void AddAccessRule(MutexAccessRule rule);
    public void AddAuditRule(MutexAuditRule rule);
    public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
    public bool RemoveAccessRule(MutexAccessRule rule);
    public void RemoveAccessRuleAll(MutexAccessRule rule);
    public void RemoveAccessRuleSpecific(MutexAccessRule rule);
    public bool RemoveAuditRule(MutexAuditRule rule);
    public void RemoveAuditRuleAll(MutexAuditRule rule);
    public void RemoveAuditRuleSpecific(MutexAuditRule rule);
    public void ResetAccessRule(MutexAccessRule rule);
    public void SetAccessRule(MutexAccessRule rule);
    public void SetAuditRule(MutexAuditRule rule);
  }
  public sealed class SemaphoreAccessRule : AccessRule {
    public SemaphoreAccessRule(IdentityReference identity, SemaphoreRights eventRights, AccessControlType type);
    public SemaphoreAccessRule(string identity, SemaphoreRights eventRights, AccessControlType type);
    public SemaphoreRights SemaphoreRights { get; }
  }
  public sealed class SemaphoreAuditRule : AuditRule {
    public SemaphoreAuditRule(IdentityReference identity, SemaphoreRights eventRights, AuditFlags flags);
    public SemaphoreRights SemaphoreRights { get; }
  }
  public enum SemaphoreRights {
    ChangePermissions = 262144,
    Delete = 65536,
    FullControl = 2031619,
    Modify = 2,
    ReadPermissions = 131072,
    Synchronize = 1048576,
    TakeOwnership = 524288,
  }
  public sealed class SemaphoreSecurity : NativeObjectSecurity {
    public SemaphoreSecurity();
    public SemaphoreSecurity(string name, AccessControlSections includeSections);
    public override Type AccessRightType { get; }
    public override Type AccessRuleType { get; }
    public override Type AuditRuleType { get; }
    public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
    public void AddAccessRule(SemaphoreAccessRule rule);
    public void AddAuditRule(SemaphoreAuditRule rule);
    public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
    public bool RemoveAccessRule(SemaphoreAccessRule rule);
    public void RemoveAccessRuleAll(SemaphoreAccessRule rule);
    public void RemoveAccessRuleSpecific(SemaphoreAccessRule rule);
    public bool RemoveAuditRule(SemaphoreAuditRule rule);
    public void RemoveAuditRuleAll(SemaphoreAuditRule rule);
    public void RemoveAuditRuleSpecific(SemaphoreAuditRule rule);
    public void ResetAccessRule(SemaphoreAccessRule rule);
    public void SetAccessRule(SemaphoreAccessRule rule);
    public void SetAuditRule(SemaphoreAuditRule rule);
  }
}
namespace System.Threading {
  public static class ThreadingAclExtensions {
    public static EventWaitHandleSecurity GetAccessControl(this EventWaitHandle handle);
    public static MutexSecurity GetAccessControl(this Mutex mutex);
    public static SemaphoreSecurity GetAccessControl(this Semaphore semaphore);
    public static void SetAccessControl(this EventWaitHandle handle, EventWaitHandleSecurity eventSecurity);
    public static void SetAccessControl(this Mutex mutex, MutexSecurity mutexSecurity);
    public static void SetAccessControl(this Semaphore semaphore, SemaphoreSecurity semaphoreSecurity);
  }
}
