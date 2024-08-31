using Step_3_Components.Enums;

namespace Step_3_Components;

public class Robot : Components
{
    public Robot(Speed speed)
    {
        Set(new Data_Component(GetType().Name, speed, Types.Robot));
        Set(new Writer_Component());
        Set(new Robot_Injure_Component());
        Set(new Recharge_Component());
        Set(new Walk_Component());
        Set(new Beep_Component());
    }
}