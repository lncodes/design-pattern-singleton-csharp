namespace Lncodes.DesignPattern.Singleton;

public sealed class ClassicThreadSafeLazySingleton
{
    private static volatile ClassicThreadSafeLazySingleton _instance = null;

    private static readonly object _instanceLock = new();

    private ClassicThreadSafeLazySingleton() { }

    public static ClassicThreadSafeLazySingleton GetInstance()
    {
        if (_instance is null)
            lock (_instanceLock)
                if (_instance is null)
                    _instance = new();
        return _instance;
    }
}