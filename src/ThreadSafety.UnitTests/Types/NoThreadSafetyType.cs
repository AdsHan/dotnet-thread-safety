namespace ThreadSafety.UnitTests.Types;
internal static class NoThreadSafetyType
{
    private static List<int> _products = new List<int>();

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
            GetInstance.Add(id);
        }
    }

    public static int Count() => GetInstance.Count();
}
