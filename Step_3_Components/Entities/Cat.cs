using Step_3_Components.Enums;

namespace Step_3_Components;

public class Cat : Components
{
    public Cat(Speed speed)
    {
        Set(new Data_Component(GetType().Name, speed, Types.Cat));
        Set(new Injured_Writer_Component());
        Set(new Animal_Injure_Component());
        Set(new Walk_Component());
        Set(new Meow_Component());
    }
}