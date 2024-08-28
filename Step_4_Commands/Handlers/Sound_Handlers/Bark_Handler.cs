using Step_4_Commands.Commands;

namespace Step_4_Commands.Sound_Handlers;

public class Bark_Handler : Handler<Make_Sound_Command>
{
    public override void Handle(Make_Sound_Command cmd)
    {
        Parent.Write_Action("barking");
    }
}