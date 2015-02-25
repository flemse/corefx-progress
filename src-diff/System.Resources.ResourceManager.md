```diff
---lib-full\System.Resources.ResourceManager.dll
+++lib-oss\System.Resources.ResourceManager.dll
-namespace System.Resources {
- public class MissingManifestResourceException : Exception {
-   public MissingManifestResourceException();
-   public MissingManifestResourceException(string message);
-   public MissingManifestResourceException(string message, Exception inner);
  }
- public sealed class NeutralResourcesLanguageAttribute : Attribute {
-   public NeutralResourcesLanguageAttribute(string cultureName);
-   public string CultureName { get; }
  }
- public class ResourceManager {
-   public ResourceManager(string baseName, Assembly assembly);
-   public ResourceManager(Type resourceSource);
-   public string GetString(string name);
-   public virtual string GetString(string name, CultureInfo culture);
  }
- public sealed class SatelliteContractVersionAttribute : Attribute {
-   public SatelliteContractVersionAttribute(string version);
-   public string Version { get; }
  }
 }
```
