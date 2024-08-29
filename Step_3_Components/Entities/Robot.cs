using Step_3_Components.Enums;

namespace Step_3_Components;

public class Robot : Components
{
    public Robot(Speed speed)
    {
        Add(new Data_Component(GetType().Name, speed, Types.Robot));
        Add(new Writer_Component());
        Add(new Robot_Injure_Component());
        Add(new Recharge_Component());
        Add(new Walk_Component());
        Add(new Beep_Component());
    }
}