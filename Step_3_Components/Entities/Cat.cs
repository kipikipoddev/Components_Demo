using Step_3_Components.Enums;

namespace Step_3_Components;

public class Cat : Components
{
    public Cat(Speed speed)
    {
        Add(new Data_Component(speed, Types.Cat));
        Add(new Injured_Writer_Component());
        Add(new Animal_Injure_Component());
        Add(new Walk_Component());
        Add(new Meow_Component());
    }
}