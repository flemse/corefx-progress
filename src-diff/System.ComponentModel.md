```diff
---lib-full\System.ComponentModel.dll
+++lib-oss\System.ComponentModel.dll
 namespace System {
  public interface IServiceProvider {
    object GetService(Type serviceType);
  }
 }
 namespace System.ComponentModel {
  public class CancelEventArgs : EventArgs {
    public CancelEventArgs();
    public CancelEventArgs(bool cancel);
    public bool Cancel { get; set; }
  }
  public interface IChangeTracking {
    bool IsChanged { get; }
    void AcceptChanges();
  }
  public interface IEditableObject {
    void BeginEdit();
    void CancelEdit();
    void EndEdit();
  }
  public interface IRevertibleChangeTracking : IChangeTracking {
    void RejectChanges();
  }
 }
```
