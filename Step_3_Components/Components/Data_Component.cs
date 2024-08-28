using Step_3_Components.Enums;

namespace Step_3_Components;

public class Data_Component : Component, IData_Component
{
    public Speed Speed { get; set; }
    public string Name { get; private set; }
    public Types Type { get; private set; }

    public Data_Component(Speed speed, Types type)
    {
        Speed = speed;
        Type = type;
    }

    protected override void Parent_Set()
    {
        Name = Parent!.GetType().Name;
    }
}