namespace Step_2_Components;

public class Name_Component : Component, IName_Component
{
    public string Name { get; }

    public Name_Component(string name)
    {
        Name = name;
    }
}