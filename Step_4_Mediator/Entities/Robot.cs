using Step_4_Mediator.Core;
using Step_4_Mediator.Sound_Handlers;
using Step_4_Mediator.Walk_Handlers;

namespace Step_4_Mediator.Entities;

public class Robot : Components
{
    public Robot()
    {
        Add(new Name_Component());
        Add(new Charge_Component());
        Add(new Beep_Sound_Handler());
        Add(new Charge_Sound_Handler());
        Add(new Robot_Walk_Handler());
    }
}