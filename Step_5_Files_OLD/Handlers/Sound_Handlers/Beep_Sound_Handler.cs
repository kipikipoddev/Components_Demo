using Step_5_Files.Attributes;
using Step_5_Files.Commands;

namespace Step_5_Files.Sound_Handlers;

[Component_Name("Beep_Sound")]
public class Beep_Sound_Handler : Handler<Sound_Command>
{ 
    public override void Handle(Sound_Command cmd)
    {
        Write("beeping");
    }
}