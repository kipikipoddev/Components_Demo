using Step_5_Files.Commands;

namespace Step_5_Files.Sound_Handlers;

public class Walk_Handler : Handler<Walk_Command>
{
    public override void Handle(Walk_Command cmd)
    {
        Parent.Write_Action_Like("walking");
    }
}