using Step_4_Commands.Enums;

namespace Step_4_Commands;

public class Data_Component : Component
{
    public Speed_Type Speed { get; set; }
    public string Name { get; private set; }
    public bool Is_Injured { get; set; }
    public Entity_Types Type { get; private set; }

    public Data_Component(Speed_Type speed, Entity_Types type)
    {
        Speed = speed;
        Type = type;
        Name = string.Empty;
    }

    protected override void Parent_Set()
    {
        Name = Parent!.GetType().Name;
    }
}
