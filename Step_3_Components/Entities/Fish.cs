using Step_3_Components.Enums;

namespace Step_3_Components;

public class Fish : Components
{
    public Fish(Speed speed)
    {
        Add(new Data_Component(GetType().Name, speed, Types.Fish));
        Add(new Writer_Component());
        Add(new Animal_Injure_Component());
        Add(new Swim_Component());
    }
}