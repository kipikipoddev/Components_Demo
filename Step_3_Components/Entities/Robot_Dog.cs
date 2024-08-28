using Step_3_Components.Enums;

namespace Step_3_Components;

public class Robot_Dog : Components
{
    public Robot_Dog(Speed speed)
    {
        Add(new Data_Component(speed, Types.Dog));
        Add(new Writer_Component());
        Add(new Robot_Injure_Component());
        Add(new Recharge_Component());
        Add(new Robot_Swim_Component(new Swim_Component()));
        Add(new Robot_Walk_Component(new Walk_Component()));
        Add(new Robot_Sound_Component(new Bark_Component()));
    }
}