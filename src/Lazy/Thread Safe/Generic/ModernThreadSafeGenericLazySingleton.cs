using System;

namespace Lncodes.DesignPattern.Singleton;

public abstract class ModernThreadSafeGenericLazySingleton<T> where T : class, new()
{
    private static readonly Lazy<T> _lazyInstance = new(() => new T());

    protected ModernThreadSafeGenericLazySingleton() { }

    public static T GetInstance() =>
        _lazyInstance.Value;
}
