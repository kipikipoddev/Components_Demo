using Step_3_Components.Enums;

namespace Step_3_Components;

public class Robot_Dog : Components
{
    public Robot_Dog(Speed speed)
    {
        Set(new Data_Component(GetType().Name, speed, Types.Dog));
        Set(new Writer_Component());
        Set(new Robot_Injure_Component());
        Set(new Recharge_Component());
        Set(new Swim_Component());
        Set(new Walk_Component());
        Set(new Bark_Component());
    }
}