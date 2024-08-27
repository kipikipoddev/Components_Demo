using Step_4_Commands.Commands;
using Step_4_Commands.Core;
using Step_4_Commands.Sound_Handlers;
using Step_4_Commands.Walk_Handlers;

namespace Step_4_Commands.Entities;

public class Robot : Components
{
    public Robot()
    {
        Add(new Name_Component());
        Add(new Beep_Sound_Handler());
        Add(new Recharge_Handler<Make_Sound_Command>());
        Add(new Robot_Walk_Handler());
        Add(new Recharge_Handler<Walk_Command>());
    }
}