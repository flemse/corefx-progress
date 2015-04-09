```diff
---lib-full\System.Resources.ReaderWriter.dll
+++lib-oss\System.Resources.ReaderWriter.dll
-namespace System.Resources {
- public sealed class ResourceReader : IDisposable {
-   public ResourceReader(Stream stream);
-   public void Dispose();
-   public IDictionaryEnumerator GetEnumerator();
  }
- public sealed class ResourceWriter : IDisposable {
-   public ResourceWriter(Stream stream);
-   public void AddResource(string name, string value);
-   public void Dispose();
-   public void Generate();
  }
 }
```
