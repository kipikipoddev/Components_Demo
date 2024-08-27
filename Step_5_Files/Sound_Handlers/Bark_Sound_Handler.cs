using Step_5_Files.Commands;

namespace Step_5_Files.Sound_Handlers;

public class Bark_Sound_Handler : Handler<Sound_Command>
{
    public override void Handle(Sound_Command evnt)
    {
        Write("Barking");
    }
}