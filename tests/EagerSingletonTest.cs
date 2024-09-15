using Xunit;

namespace Lncodes.DesignPattern.Singleton.Tests;

public sealed class EagerSingletonTest : SingletonTest
{
    [Fact]
    public void EagerSingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(EagerSingleton.GetInstance);

    [Fact]
    public void EagerGenericSingleton_Should_Return_Same_Instance() =>
        AssertSingletonInstance(GenericEagerSingleton<EagerSingletonTest>.GetInstance);
}