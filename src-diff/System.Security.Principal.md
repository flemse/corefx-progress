```diff
---lib-full\System.Security.Principal.dll
+++lib-oss\System.Security.Principal.dll
-namespace System.Security.Principal {
- public interface IIdentity {
-   string AuthenticationType { get; }
-   bool IsAuthenticated { get; }
-   string Name { get; }
  }
- public interface IPrincipal {
-   IIdentity Identity { get; }
-   bool IsInRole(string role);
  }
- public enum TokenImpersonationLevel {
-   Anonymous = 1,
-   Delegation = 4,
-   Identification = 2,
-   Impersonation = 3,
-   None = 0,
  }
 }
```
