using Step_5_Files.Attributes;
using Step_5_Files.Commands;
using Step_5_Files.Core;

namespace Step_5_Files.Walk_Handlers;

[Component_Name("Swim", "Fish")]
public class Fish_Swim_Handler : Handler<Swim_Command>
{
    public override void Handle(Swim_Command cmd)
    {
        Write("swiming like a fish");
    }
}