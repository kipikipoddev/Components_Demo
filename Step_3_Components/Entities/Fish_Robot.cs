using Step_3_Components.Enums;

namespace Step_3_Components;

public class Fish_Robot : Components
{
    public Fish_Robot(Speed speed)
    {
        Add(new Data_Component(speed, Types.Fish));
        Add(new Writer_Component());
        Add(new Robot_Injure_Component());
        Add(new Recharge_Component());
        Add(new Robot_Swim_Component(new Swim_Component()));
        Add(new Robot_Sound_Component(new Beep_Component()));
    }
}