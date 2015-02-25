```diff
---lib-full\System.Runtime.Loader.dll
+++lib-oss\System.Runtime.Loader.dll
-namespace System.Runtime.Loader {
- public abstract class AssemblyLoadContext {
-   protected AssemblyLoadContext();
-   public static AssemblyLoadContext Default { get; }
-   public static AssemblyName GetAssemblyName(string assemblyPath);
-   public static AssemblyLoadContext GetLoadContext(Assembly assembly);
-   public static void InitializeDefaultContext(AssemblyLoadContext context);
-   protected abstract Assembly Load(AssemblyName assemblyName);
-   public Assembly LoadFromAssemblyName(AssemblyName assemblyName);
-   protected Assembly LoadFromAssemblyPath(string assemblyPath);
-   protected Assembly LoadFromNativeImagePath(string nativeImagePath, string assemblyPath);
-   protected Assembly LoadFromStream(Stream assembly);
-   protected Assembly LoadFromStream(Stream assembly, Stream assemblySymbols);
-   protected virtual IntPtr LoadUnmanagedDll(string unmanagedDllName);
-   public void SetProfileOptimizationRoot(string directoryPath);
-   public void StartProfileOptimization(string profile);
  }
 }
```
