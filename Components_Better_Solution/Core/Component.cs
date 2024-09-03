﻿
namespace Components_Better_Solution;

public class Component : IComponent
{
    public IComponents Parent { get; private set; }

    public virtual void Set_Parent(IComponents parent)
    {
        Parent = parent;
    }
}