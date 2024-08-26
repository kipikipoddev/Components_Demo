using Step_4_Mediator.Commands;
using Step_4_Mediator.Core;

namespace Step_4_Mediator.Sound_Handlers;

public class Charge_Sound_Handler : IHandler<Sound_Command>
{
    public void Handle(Sound_Command evnt)
    {
        new Recharge_Command(evnt.Components);
    }
}