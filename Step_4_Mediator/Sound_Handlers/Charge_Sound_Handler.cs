using Step_4_Mediator.Commands;

namespace Step_4_Mediator.Sound_Handlers;

public class Charge_Sound_Handler : Handler<Sound_Command>
{
    public override void Handle(Sound_Command evnt)
    {
        new Recharge_Command(evnt.Components);
    }
}