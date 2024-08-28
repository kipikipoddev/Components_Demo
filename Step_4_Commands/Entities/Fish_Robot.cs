using Step_4_Commands.Commands;
using Step_4_Commands.Enums;
using Step_4_Commands.Sound_Handlers;

namespace Step_4_Commands;

public class Fish_Robot : Components
{
    public Fish_Robot(Speed_Type speed)
    {
        Add(new Data_Component(speed, Entity_Types.Fish));
        Add(new Write_Handler());
        Add(new Recharge_Component());
        Add(new Robot_Injure_Handler());
        Add(new No_Handler_Handler());
        
        Add(new Recharge_Handler<Make_Sound_Command>());
        Add(new Beep_Handler());
        Add(new Recharge_Handler<Swim_Command>());
        Add(new Swim_Handler());
    }
}