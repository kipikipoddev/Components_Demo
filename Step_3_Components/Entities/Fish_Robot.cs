using Step_3_Components.Enums;

namespace Step_3_Components;

public class Fish_Robot : Components
{
    public Fish_Robot(Speed speed)
    {
        Add(new Data_Component(GetType().Name, speed, Types.Fish));
        Add(new Writer_Component());
        Add(new Robot_Injure_Component());
        Add(new Recharge_Component());
        Add(new Swim_Component());
        Add(new Beep_Component());
    }
}