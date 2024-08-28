using Step_5_Files.Attributes;
using Step_5_Files.Commands;
using Step_5_Files.Core;

namespace Step_5_Files.Sound_Handlers;

[Component_Name("Sound", "Bark")]
public class Bark_Sound_Handler : Handler<Make_Sound_Command>
{
    public override void Handle(Make_Sound_Command cmd)
    {
        Write("barking");
    }
}