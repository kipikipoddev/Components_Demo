using Step_3_Components.Enums;

namespace Step_3_Components;

public class Data_Component : Component, IData_Component
{
    public string Name { get; }
    public Speed Speed { get; }
    public Types Type { get; }

    public Data_Component(string name, Speed speed, Types type)
    {
        Name = name;
        Speed = speed;
        Type = type;
    }
}