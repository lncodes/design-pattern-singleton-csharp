namespace Lncodes.DesignPattern.Singleton;

public abstract class GenericEagerSingleton<T> where T : class, new()
{
    private readonly static T _instance = new();

    protected GenericEagerSingleton() { }

    public static T GetInstance() =>
        _instance;
}