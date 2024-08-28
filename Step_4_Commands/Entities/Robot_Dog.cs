using Step_4_Commands.Commands;
using Step_4_Commands.Enums;
using Step_4_Commands.Sound_Handlers;

namespace Step_4_Commands;

public class Robot_Dog : Components
{
    public Robot_Dog(Speed_Type speed)
    {
        Add(new Data_Component(speed, Entity_Types.Dog));
        Add(new Write_Handler());
        Add(new Recharge_Component());
        Add(new Robot_Injure_Handler());
        Add(new No_Handler_Handler());
        
        Add(new Recharge_Handler<Walk_Command>());
        Add(new Walk_Handler());
        Add(new Recharge_Handler<Make_Sound_Command>());
        Add(new Bark_Handler());
        Add(new Recharge_Handler<Swim_Command>());
        Add(new Swim_Handler());
    }
}