using Step_4_Mediator.Commands;

namespace Step_4_Mediator.Sound_Handlers;

public class Meow_Sound_Handler : Handler<Sound_Command>
{
    public override void Handle(Sound_Command evnt)
    {
        Write("meowing");
    }
}
