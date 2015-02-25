namespace System.ComponentModel {
  public class ComponentCollection {
  }
  public interface IComponent : IDisposable {
    ISite Site { get; set; }
    event EventHandler Disposed;
  }
  public interface IContainer : IDisposable {
    ComponentCollection Components { get; }
    void Add(IComponent component);
    void Add(IComponent component, string name);
    void Remove(IComponent component);
  }
  public interface ISite : IServiceProvider {
    IComponent Component { get; }
    IContainer Container { get; }
    bool DesignMode { get; }
    string Name { get; set; }
  }
}
