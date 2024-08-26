﻿namespace Step_3_Components;

public interface IComponents : IComponent
{
    IComponents Add(IComponent component);

    T Get<T>()
        where T : IComponent;
    T? Get_Or_Default<T>()
        where T : IComponent;
}