using Step_5_Files.Commands;

namespace Step_5_Files.Sound_Handlers;

public class Charge_Sound_Handler : Handler<Sound_Command>
{
    public override void Handle(Sound_Command evnt)
    {
        new Recharge_Command(evnt.Components);
    }
}