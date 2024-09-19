﻿using System;

namespace Lncodes.DesignPattern.Singleton;

public sealed class LazyModernThreadSafeSingleton
{
    private static readonly Lazy<LazyModernThreadSafeSingleton> _instance = new(() => new());

    private LazyModernThreadSafeSingleton() { }

    public static LazyModernThreadSafeSingleton GetInstance() =>
        _instance.Value;
}