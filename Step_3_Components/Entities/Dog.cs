using Step_3_Components.Enums;

namespace Step_3_Components;

public class Dog : Components
{
    public Dog(Speed speed)
    {
        Set(new Data_Component(GetType().Name, speed, Types.Dog));
        Set(new Injured_Writer_Component());
        Set(new Animal_Injure_Component());
        Set(new Walk_Component());
        Set(new Bark_Component());
        Set(new Swim_Component());
    }
}