using Step_5_Files.Commands;

namespace Step_5_Files.Sound_Handlers;

public class Swim_Handler : Handler<Swim_Command>
{
    public override void Handle(Swim_Command cmd)
    {
        Parent.Write_Action_Like("swiming");
    }
}