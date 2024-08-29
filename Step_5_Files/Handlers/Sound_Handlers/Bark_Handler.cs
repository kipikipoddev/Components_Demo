using Step_5_Files.Commands;

namespace Step_5_Files.Sound_Handlers;

public class Bark_Handler : Handler<Make_Sound_Command>
{
    public override void Handle(Make_Sound_Command cmd)
    {
        Parent.Write_Action("barking");
    }
}