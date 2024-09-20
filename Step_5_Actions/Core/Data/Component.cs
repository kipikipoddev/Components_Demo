﻿
namespace Step_5_Actions;

public class Component : IComponent
{
    private IComponents parent;
    
    public IComponents Parent
    {
        get => parent;
        set
        {
            parent = value;
            Parent_Set();
        }
    }

    protected virtual void Parent_Set()
    {
    }
}