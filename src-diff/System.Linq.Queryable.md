```diff
---lib-full\System.Linq.Queryable.dll
+++lib-oss\System.Linq.Queryable.dll
 namespace System.Linq {
  public abstract class EnumerableExecutor {
    protected EnumerableExecutor();
  }
  public class EnumerableExecutor<T> : EnumerableExecutor {
    public EnumerableExecutor(Expression expression);
  }
  public abstract class EnumerableQuery {
    protected EnumerableQuery();
  }
  public class EnumerableQuery<T> : EnumerableQuery, IEnumerable, IEnumerable<T>, IOrderedQueryable, IOrderedQueryable<T>, IQueryable, IQueryable<T>, IQueryProvider {
    public EnumerableQuery(IEnumerable<T> enumerable);
    public EnumerableQuery(Expression expression);
    Type System.Linq.IQueryable.ElementType { get; }
    Expression System.Linq.IQueryable.Expression { get; }
    IQueryProvider System.Linq.IQueryable.Provider { get; }
    IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    IQueryable System.Linq.IQueryProvider.CreateQuery(Expression expression);
    IQueryable<S> System.Linq.IQueryProvider.CreateQuery<S>(Expression expression);
    object System.Linq.IQueryProvider.Execute(Expression expression);
    S System.Linq.IQueryProvider.Execute<S>(Expression expression);
    public override string ToString();
  }
  public static class Queryable {
    public static TResult Aggregate<TSource, TAccumulate, TResult>(this IQueryable<TSource> source, TAccumulate seed, Expression<Func<TAccumulate, TSource, TAccumulate>> func, Expression<Func<TAccumulate, TResult>> selector);
    public static TAccumulate Aggregate<TSource, TAccumulate>(this IQueryable<TSource> source, TAccumulate seed, Expression<Func<TAccumulate, TSource, TAccumulate>> func);
    public static TSource Aggregate<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, TSource, TSource>> func);
    public static bool All<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static bool Any<TSource>(this IQueryable<TSource> source);
    public static bool Any<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static IQueryable AsQueryable(this IEnumerable source);
    public static IQueryable<TElement> AsQueryable<TElement>(this IEnumerable<TElement> source);
    public static decimal Average(this IQueryable<decimal> source);
    public static double Average(this IQueryable<double> source);
    public static double Average(this IQueryable<int> source);
    public static double Average(this IQueryable<long> source);
    public static Nullable<decimal> Average(this IQueryable<Nullable<decimal>> source);
    public static Nullable<double> Average(this IQueryable<Nullable<double>> source);
    public static Nullable<double> Average(this IQueryable<Nullable<int>> source);
    public static Nullable<double> Average(this IQueryable<Nullable<long>> source);
    public static Nullable<float> Average(this IQueryable<Nullable<float>> source);
    public static float Average(this IQueryable<float> source);
    public static decimal Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector);
    public static double Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector);
    public static double Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector);
    public static double Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector);
    public static Nullable<decimal> Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<decimal>>> selector);
    public static Nullable<double> Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<double>>> selector);
    public static Nullable<double> Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<int>>> selector);
    public static Nullable<double> Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<long>>> selector);
    public static Nullable<float> Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<float>>> selector);
    public static float Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector);
    public static IQueryable<TResult> Cast<TResult>(this IQueryable source);
    public static IQueryable<TSource> Concat<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2);
    public static bool Contains<TSource>(this IQueryable<TSource> source, TSource item);
    public static bool Contains<TSource>(this IQueryable<TSource> source, TSource item, IEqualityComparer<TSource> comparer);
    public static int Count<TSource>(this IQueryable<TSource> source);
    public static int Count<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static IQueryable<TSource> DefaultIfEmpty<TSource>(this IQueryable<TSource> source);
    public static IQueryable<TSource> DefaultIfEmpty<TSource>(this IQueryable<TSource> source, TSource defaultValue);
    public static IQueryable<TSource> Distinct<TSource>(this IQueryable<TSource> source);
    public static IQueryable<TSource> Distinct<TSource>(this IQueryable<TSource> source, IEqualityComparer<TSource> comparer);
    public static TSource ElementAt<TSource>(this IQueryable<TSource> source, int index);
    public static TSource ElementAtOrDefault<TSource>(this IQueryable<TSource> source, int index);
    public static IQueryable<TSource> Except<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2);
    public static IQueryable<TSource> Except<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer);
    public static TSource First<TSource>(this IQueryable<TSource> source);
    public static TSource First<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static TSource FirstOrDefault<TSource>(this IQueryable<TSource> source);
    public static TSource FirstOrDefault<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector);
    public static IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector, IEqualityComparer<TKey> comparer);
    public static IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector);
    public static IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, IEqualityComparer<TKey> comparer);
    public static IQueryable<TResult> GroupBy<TSource, TKey, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector);
    public static IQueryable<TResult> GroupBy<TSource, TKey, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector, IEqualityComparer<TKey> comparer);
    public static IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector);
    public static IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IEqualityComparer<TKey> comparer);
    public static IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector);
    public static IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector, IEqualityComparer<TKey> comparer);
    public static IQueryable<TSource> Intersect<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2);
    public static IQueryable<TSource> Intersect<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer);
    public static IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector);
    public static IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector, IEqualityComparer<TKey> comparer);
    public static TSource Last<TSource>(this IQueryable<TSource> source);
    public static TSource Last<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static TSource LastOrDefault<TSource>(this IQueryable<TSource> source);
    public static TSource LastOrDefault<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static long LongCount<TSource>(this IQueryable<TSource> source);
    public static long LongCount<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static TResult Max<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector);
    public static TSource Max<TSource>(this IQueryable<TSource> source);
    public static TResult Min<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector);
    public static TSource Min<TSource>(this IQueryable<TSource> source);
    public static IQueryable<TResult> OfType<TResult>(this IQueryable source);
    public static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector);
    public static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer);
    public static IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector);
    public static IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer);
    public static IQueryable<TSource> Reverse<TSource>(this IQueryable<TSource> source);
    public static IQueryable<TResult> Select<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, int, TResult>> selector);
    public static IQueryable<TResult> Select<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector);
    public static IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector);
    public static IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, int, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector);
    public static IQueryable<TResult> SelectMany<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TResult>>> selector);
    public static IQueryable<TResult> SelectMany<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, int, IEnumerable<TResult>>> selector);
    public static bool SequenceEqual<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2);
    public static bool SequenceEqual<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer);
    public static TSource Single<TSource>(this IQueryable<TSource> source);
    public static TSource Single<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static TSource SingleOrDefault<TSource>(this IQueryable<TSource> source);
    public static TSource SingleOrDefault<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static IQueryable<TSource> Skip<TSource>(this IQueryable<TSource> source, int count);
    public static IQueryable<TSource> SkipWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static IQueryable<TSource> SkipWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate);
    public static decimal Sum(this IQueryable<decimal> source);
    public static double Sum(this IQueryable<double> source);
    public static int Sum(this IQueryable<int> source);
    public static long Sum(this IQueryable<long> source);
    public static Nullable<decimal> Sum(this IQueryable<Nullable<decimal>> source);
    public static Nullable<double> Sum(this IQueryable<Nullable<double>> source);
    public static Nullable<int> Sum(this IQueryable<Nullable<int>> source);
    public static Nullable<long> Sum(this IQueryable<Nullable<long>> source);
    public static Nullable<float> Sum(this IQueryable<Nullable<float>> source);
    public static float Sum(this IQueryable<float> source);
    public static decimal Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector);
    public static double Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector);
    public static int Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector);
    public static long Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector);
    public static Nullable<decimal> Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<decimal>>> selector);
    public static Nullable<double> Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<double>>> selector);
    public static Nullable<int> Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<int>>> selector);
    public static Nullable<long> Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<long>>> selector);
    public static Nullable<float> Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<float>>> selector);
    public static float Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector);
    public static IQueryable<TSource> Take<TSource>(this IQueryable<TSource> source, int count);
    public static IQueryable<TSource> TakeWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static IQueryable<TSource> TakeWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate);
    public static IOrderedQueryable<TSource> ThenBy<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector);
    public static IOrderedQueryable<TSource> ThenBy<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer);
    public static IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector);
    public static IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer);
    public static IQueryable<TSource> Union<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2);
    public static IQueryable<TSource> Union<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer);
    public static IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    public static IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate);
    public static IQueryable<TResult> Zip<TFirst, TSecond, TResult>(this IQueryable<TFirst> source1, IEnumerable<TSecond> source2, Expression<Func<TFirst, TSecond, TResult>> resultSelector);
  }
 }
```
