namespace Lncodes.DesignPattern.Singleton;

public abstract class GenericLazySingleton<T> where T : class, new()
{
    private static T _instance = null;

    protected GenericLazySingleton() { }

    public static T GetInstance() =>
        _instance ??= new();
}
