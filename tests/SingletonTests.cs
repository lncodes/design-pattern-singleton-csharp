using Xunit;
using System;

namespace Lncodes.DesignPattern.Singleton.Tests;

public abstract class SingletonTests
{
    protected static void AssertSingletonInstance<T>(Func<T> getInstance) where T : class
    {
        var firstInstance = getInstance();
        var secondInstance = getInstance();
        Assert.Same(firstInstance, secondInstance);
    }
}
