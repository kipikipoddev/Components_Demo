﻿
namespace Components_Basic_Solution;

public interface IComponent
{
    IComponents Parent { get; }

    void Set_Parent(IComponents components);
}