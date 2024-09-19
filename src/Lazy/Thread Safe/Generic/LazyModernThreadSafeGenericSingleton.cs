using System;

namespace Lncodes.DesignPattern.Singleton;

public abstract class LazyModernThreadSafeGenericSingleton<T> where T : class, new()
{
    private static readonly Lazy<T> _lazyInstance = new(() => new T());

    protected LazyModernThreadSafeGenericSingleton() { }

    public static T GetInstance() =>
        _lazyInstance.Value;
}
