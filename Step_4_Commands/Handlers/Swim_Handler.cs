using Step_4_Commands.Commands;

namespace Step_4_Commands.Sound_Handlers;

public class Swim_Handler : Handler<Swim_Command>
{
    public override void Handle(Swim_Command cmd)
    {
        Parent.Write_Action_Like("swiming");
    }
}