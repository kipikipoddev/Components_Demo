﻿namespace Step_2_OOP;

public interface ICat : IAnimal, IWalker
{
    bool Can_Meow { get; }
    void Meow();
}