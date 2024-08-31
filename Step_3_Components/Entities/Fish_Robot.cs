using Step_3_Components.Enums;

namespace Step_3_Components;

public class Fish_Robot : Components
{
    public Fish_Robot(Speed speed)
    {
        Set(new Data_Component(GetType().Name, speed, Types.Fish));
        Set(new Writer_Component());
        Set(new Robot_Injure_Component());
        Set(new Recharge_Component());
        Set(new Swim_Component());
        Set(new Beep_Component());
    }
}