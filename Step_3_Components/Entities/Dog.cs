using Step_3_Components.Enums;

namespace Step_3_Components;

public class Dog : Components
{
    public Dog(Speed speed)
    {
        Add(new Data_Component(speed, Types.Dog));
        Add(new Injured_Writer_Component());
        Add(new Animal_Injure_Component());
        Add(new Walk_Component());
        Add(new Bark_Component());
        Add(new Swim_Component());
    }
}