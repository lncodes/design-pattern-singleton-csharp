using Xunit;

namespace Lncodes.DesignPattern.Singleton.Tests;

public sealed class EagerSingletonTests : SingletonTests
{
    [Fact]
    public void EagerSingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(EagerSingleton.GetInstance);

    [Fact]
    public void EagerGenericSingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(EagerGenericSingleton<EagerSingletonTests>.GetInstance);
}