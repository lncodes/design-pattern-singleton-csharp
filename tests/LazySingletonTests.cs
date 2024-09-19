using Xunit;

namespace Lncodes.DesignPattern.Singleton.Tests;

public sealed class LazySingletonTests : SingletonTests
{
    [Fact]
    public void LazySingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(LazySingleton.GetInstance);

    [Fact]
    public void LazyGenericSingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(LazyGenericSingleton<LazySingletonTests>.GetInstance);

    [Fact]
    public void BillPughSingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(BillPughSingleton.GetInstance);

    [Fact]
    public void LazyClassicThreadSafeSingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(LazyClassicThreadSafeSingleton.GetInstance);

    [Fact]
    public void LazyModernThreadSafeSingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(LazyModernThreadSafeSingleton.GetInstance);

    [Fact]
    public void LazyClassicThreadSafeGenericSingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(LazyClassicThreadSafeGenericSingleton<LazySingletonTests>.GetInstance);

    [Fact]
    public void LazyModernThreadSafeGenericSingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(LazyModernThreadSafeGenericSingleton<LazySingletonTests>.GetInstance);
}