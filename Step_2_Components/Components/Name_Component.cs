﻿namespace Components_Demo;

public class Name_Component(string name) : Component, IName_Component
{
    public string Name { get; } = name;
}