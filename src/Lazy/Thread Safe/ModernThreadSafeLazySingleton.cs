using System;

namespace Lncodes.DesignPattern.Singleton;

public sealed class ModernThreadSafeLazySingleton
{
    private static readonly Lazy<ModernThreadSafeLazySingleton> _instance = new(() => new());

    private ModernThreadSafeLazySingleton() { }

    public static ModernThreadSafeLazySingleton GetInstance() =>
        _instance.Value;
}