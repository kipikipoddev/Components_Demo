using Step_5_Files.Attributes;
using Step_5_Files.Commands;

namespace Step_5_Files.Sound_Handlers;

[Component_Name("Meow_Sound")]
public class Meow_Sound_Handler : Handler<Sound_Command>
{
    public override void Handle(Sound_Command evnt)
    {
        Write("meowing");
    }
}
