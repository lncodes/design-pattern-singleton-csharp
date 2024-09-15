using Xunit;

namespace Lncodes.DesignPattern.Singleton.Tests;

public sealed class LazySingletonTest : SingletonTest
{
    [Fact]
    public void LazySingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(LazySingleton.GetInstance);

    [Fact]
    public void GenericLazySingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(GenericLazySingleton<LazySingletonTest>.GetInstance);

    [Fact]
    public void ClassicThreadSafeLazySingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(ClassicThreadSafeLazySingleton.GetInstance);

    [Fact]
    public void ModernThreadSafeLazySingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(ModernThreadSafeLazySingleton.GetInstance);

    [Fact]
    public void ClassicThreadSafeGenericLazySingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(ClassicThreadSafeGenericLazySingleton<LazySingletonTest>.GetInstance);

    [Fact]
    public void ModernThreadSafeGenericLazySingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(ModernThreadSafeGenericLazySingleton<LazySingletonTest>.GetInstance);
}