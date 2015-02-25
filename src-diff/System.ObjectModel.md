```diff
---lib-full\System.ObjectModel.dll
+++lib-oss\System.ObjectModel.dll
 namespace System.Collections.ObjectModel {
  public abstract class KeyedCollection<TKey, TItem> : Collection<TItem> {
    protected KeyedCollection();
    protected KeyedCollection(IEqualityComparer<TKey> comparer);
    protected KeyedCollection(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold);
    public IEqualityComparer<TKey> Comparer { get; }
    protected IDictionary<TKey, TItem> Dictionary { get; }
    public TItem this[TKey key] { get; }
    protected void ChangeItemKey(TItem item, TKey newKey);
    protected override void ClearItems();
    public bool Contains(TKey key);
    protected abstract TKey GetKeyForItem(TItem item);
    protected override void InsertItem(int index, TItem item);
    public bool Remove(TKey key);
    protected override void RemoveItem(int index);
    protected override void SetItem(int index, TItem item);
  }
  public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged {
    public ObservableCollection();
    public ObservableCollection(IEnumerable<T> collection);
    public virtual event NotifyCollectionChangedEventHandler CollectionChanged;
    protected virtual event PropertyChangedEventHandler PropertyChanged;
    event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
    protected IDisposable BlockReentrancy();
    protected void CheckReentrancy();
    protected override void ClearItems();
    protected override void InsertItem(int index, T item);
    public void Move(int oldIndex, int newIndex);
    protected virtual void MoveItem(int oldIndex, int newIndex);
    protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e);
    protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
    protected override void RemoveItem(int index);
    protected override void SetItem(int index, T item);
  }
  public class ReadOnlyDictionary<TKey, TValue> : ICollection, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, IDictionary<TKey, TValue>, IEnumerable, IEnumerable<KeyValuePair<TKey, TValue>>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IReadOnlyDictionary<TKey, TValue> {
    public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary);
    public int Count { get; }
    protected IDictionary<TKey, TValue> Dictionary { get; }
    public ReadOnlyDictionary<TKey, TValue>.KeyCollection Keys { get; }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
    TValue System.Collections.Generic.IDictionary<TKey,TValue>.this[TKey key] { get; set; }
    ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
    ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
    IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
    IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    bool System.Collections.IDictionary.IsFixedSize { get; }
    bool System.Collections.IDictionary.IsReadOnly { get; }
    object System.Collections.IDictionary.this[object key] { get; set; }
    ICollection System.Collections.IDictionary.Keys { get; }
    ICollection System.Collections.IDictionary.Values { get; }
    public TValue this[TKey key] { get; }
    public ReadOnlyDictionary<TKey, TValue>.ValueCollection Values { get; }
    public bool ContainsKey(TKey key);
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator();
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item);
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear();
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item);
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex);
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item);
    void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value);
    bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key);
    void System.Collections.ICollection.CopyTo(Array array, int index);
    void System.Collections.IDictionary.Add(object key, object value);
    void System.Collections.IDictionary.Clear();
    bool System.Collections.IDictionary.Contains(object key);
    IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
    void System.Collections.IDictionary.Remove(object key);
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    public bool TryGetValue(TKey key, out TValue value);
    public sealed class KeyCollection : ICollection, ICollection<TKey>, IEnumerable, IEnumerable<TKey>, IReadOnlyCollection<TKey> {
      public int Count { get; }
      bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }
      bool System.Collections.ICollection.IsSynchronized { get; }
      object System.Collections.ICollection.SyncRoot { get; }
      public void CopyTo(TKey[] array, int arrayIndex);
      public IEnumerator<TKey> GetEnumerator();
      void System.Collections.Generic.ICollection<TKey>.Add(TKey item);
      void System.Collections.Generic.ICollection<TKey>.Clear();
      bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item);
      bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item);
      void System.Collections.ICollection.CopyTo(Array array, int index);
      IEnumerator System.Collections.IEnumerable.GetEnumerator();
    }
    public sealed class ValueCollection : ICollection, ICollection<TValue>, IEnumerable, IEnumerable<TValue>, IReadOnlyCollection<TValue> {
      public int Count { get; }
      bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
      bool System.Collections.ICollection.IsSynchronized { get; }
      object System.Collections.ICollection.SyncRoot { get; }
      public void CopyTo(TValue[] array, int arrayIndex);
      public IEnumerator<TValue> GetEnumerator();
      void System.Collections.Generic.ICollection<TValue>.Add(TValue item);
      void System.Collections.Generic.ICollection<TValue>.Clear();
      bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item);
      bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item);
      void System.Collections.ICollection.CopyTo(Array array, int index);
      IEnumerator System.Collections.IEnumerable.GetEnumerator();
    }
  }
  public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged {
    public ReadOnlyObservableCollection(ObservableCollection<T> list);
    protected virtual event NotifyCollectionChangedEventHandler CollectionChanged;
    protected virtual event PropertyChangedEventHandler PropertyChanged;
    event NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged;
    event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
    protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args);
    protected virtual void OnPropertyChanged(PropertyChangedEventArgs args);
  }
 }
 namespace System.Collections.Specialized {
  public interface INotifyCollectionChanged {
    event NotifyCollectionChangedEventHandler CollectionChanged;
  }
  public enum NotifyCollectionChangedAction {
    Add = 0,
    Move = 3,
    Remove = 1,
    Replace = 2,
    Reset = 4,
  }
  public class NotifyCollectionChangedEventArgs : EventArgs {
    public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action);
    public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems);
    public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems);
    public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex);
    public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int startingIndex);
    public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex);
    public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem);
    public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index);
    public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex);
    public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem);
    public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index);
    public NotifyCollectionChangedAction Action { get; }
    public IList NewItems { get; }
    public int NewStartingIndex { get; }
    public IList OldItems { get; }
    public int OldStartingIndex { get; }
  }
  public delegate void NotifyCollectionChangedEventHandler(object sender, NotifyCollectionChangedEventArgs e);
 }
 namespace System.ComponentModel {
  public class DataErrorsChangedEventArgs : EventArgs {
    public DataErrorsChangedEventArgs(string propertyName);
    public virtual string PropertyName { get; }
  }
  public interface INotifyDataErrorInfo {
    bool HasErrors { get; }
    event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
    IEnumerable GetErrors(string propertyName);
  }
  public interface INotifyPropertyChanged {
    event PropertyChangedEventHandler PropertyChanged;
  }
  public interface INotifyPropertyChanging {
    event PropertyChangingEventHandler PropertyChanging;
  }
  public class PropertyChangedEventArgs : EventArgs {
    public PropertyChangedEventArgs(string propertyName);
    public virtual string PropertyName { get; }
  }
  public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);
  public class PropertyChangingEventArgs : EventArgs {
    public PropertyChangingEventArgs(string propertyName);
    public virtual string PropertyName { get; }
  }
  public delegate void PropertyChangingEventHandler(object sender, PropertyChangingEventArgs e);
 }
 namespace System.Windows.Input {
  public interface ICommand {
    event EventHandler CanExecuteChanged;
    bool CanExecute(object parameter);
    void Execute(object parameter);
  }
 }
```
