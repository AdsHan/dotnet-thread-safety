namespace ThreadSafety.UnitTests.Types;

internal static class LazyThreadSafetyType
{
    private static readonly Lazy<List<int>> _products = new Lazy<List<int>>(() => new List<int>());
    public static List<int> GetInstance => _products.Value;

    public static void Populate()
    {
        foreach (var id in Enumerable.Range(1, 1000))
        {
            lock (_products)
                GetInstance.Add(id);
        }
    }

    public static int Count() => GetInstance.Count();
}
