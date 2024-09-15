namespace Lncodes.DesignPattern.Singleton;

public abstract class ClassicThreadSafeGenericLazySingleton<T> where T : class, new()
{
    private static volatile T _instance = null;

    private static readonly object _instanceLock = new();

    protected ClassicThreadSafeGenericLazySingleton() { }

    public static T GetInstance()
    {
        if (_instance is null)
            lock (_instanceLock)
                if (_instance is null)
                    _instance = new();
        return _instance;
    }
}