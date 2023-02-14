namespace ThreadSafety.UnitTests.Types;
internal static class LockThreadSafetyType
{
    private static List<int> _products = new List<int>();

    private static readonly object _lock = new();

    public static List<int> GetInstance
    {
        get
        {
            if (_products is null)
            {
                _products = new List<int>();
            }

            return _products;
        }
    }

    public static void Populate()
    {
        foreach (var id in Enumerable.Range(1, 1000))
        {
            lock (_lock)
                GetInstance.Add(id);
        }
    }

    public static int Count() => GetInstance.Count();
}
