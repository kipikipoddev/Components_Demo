using Step_4_Commands.Commands;
using Step_4_Commands.Core;

namespace Step_4_Commands.Sound_Handlers;

public class Beep_Sound_Handler : Handler<Make_Sound_Command>
{
    public override void Handle(Make_Sound_Command cmd)
    {
        Write("beeping");
    }
}