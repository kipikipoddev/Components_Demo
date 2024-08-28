using Step_4_Commands.Commands;

namespace Step_4_Commands.Sound_Handlers;

public class Walk_Handler : Handler<Walk_Command>
{
    public override void Handle(Walk_Command cmd)
    {
        Parent.Write_Action_Like("walking");
    }
}