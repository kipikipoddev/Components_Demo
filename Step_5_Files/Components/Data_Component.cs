using Step_5_Files.Enums;

namespace Step_5_Files;

public class Data_Component : Component
{
    public Speed_Type Speed { get; set; }
    public string Name { get; private set; }
    public bool Is_Injured { get; set; }
    public Entity_Types Type { get; private set; }

    public Data_Component(string name, Speed_Type speed, Entity_Types type)
    {
        Name = name;
        Speed = speed;
        Type = type;
    }
}
