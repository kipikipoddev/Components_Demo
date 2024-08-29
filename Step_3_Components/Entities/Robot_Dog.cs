using Step_3_Components.Enums;

namespace Step_3_Components;

public class Robot_Dog : Components
{
    public Robot_Dog(Speed speed)
    {
        Add(new Data_Component(GetType().Name, speed, Types.Dog));
        Add(new Writer_Component());
        Add(new Robot_Injure_Component());
        Add(new Recharge_Component());
        Add(new Swim_Component());
        Add(new Walk_Component());
        Add(new Bark_Component());
    }
}