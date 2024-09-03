namespace Components_Better_Solution;

public class Name_Component : Component, IName_Component
{
    public string Name { get; }

    public Name_Component(string name)
    {
        Name = name;
    }
}