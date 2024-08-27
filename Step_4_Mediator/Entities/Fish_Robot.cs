using Step_4_Mediator.Commands;
using Step_4_Mediator.Core;
using Step_4_Mediator.Sound_Handlers;
using Step_4_Mediator.Walk_Handlers;

namespace Step_4_Mediator.Entities;

public class Fish_Robot : Components
{
    public Fish_Robot()
    {
        Add(new Name_Component());
        Add(new Beep_Sound_Handler());
        Add(new Charge_Handler<Sound_Command>());
        Add(new Fish_Swim_Handler());
        Add(new Charge_Handler<Swim_Command>());
    }
}