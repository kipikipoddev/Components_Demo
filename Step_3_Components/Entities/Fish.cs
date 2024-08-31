using Step_3_Components.Enums;

namespace Step_3_Components;

public class Fish : Components
{
    public Fish(Speed speed)
    {
        Set(new Data_Component(GetType().Name, speed, Types.Fish));
        Set(new Writer_Component());
        Set(new Animal_Injure_Component());
        Set(new Swim_Component());
    }
}