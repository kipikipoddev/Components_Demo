using Step_4_Commands.Enums;
using Step_4_Commands.Sound_Handlers;

namespace Step_4_Commands;

public class Dog : Components
{
    public Dog(Speed_Type speed)
    {
        Add(new Data_Component(speed, Entity_Types.Dog));
        Add(new Injured_Write_Handler());
        Add(new Animal_Injure_Handler());
        Add(new No_Handler_Handler());

        Add(new Walk_Handler());
        Add(new Bark_Handler());
        Add(new Swim_Handler());
    }
}