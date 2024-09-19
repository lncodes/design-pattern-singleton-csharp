namespace Lncodes.DesignPattern.Singleton;

public abstract class EagerGenericSingleton<T> where T : class, new()
{
    private readonly static T _instance = new();

    protected EagerGenericSingleton() { }

    public static T GetInstance() =>
        _instance;
}