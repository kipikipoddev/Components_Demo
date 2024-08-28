using Step_4_Commands.Enums;
using Step_4_Commands.Sound_Handlers;

namespace Step_4_Commands;

public class Cat : Components
{
    public Cat(Speed_Type speed)
    {
        Add(new Data_Component(speed, Entity_Types.Cat));
        Add(new Injured_Write_Handler());
        Add(new Animal_Injure_Handler());
        Add(new No_Handler_Handler());

        Add(new Walk_Handler());
        Add(new Meow_Handler());
    }
}