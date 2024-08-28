using Step_5_Files.Attributes;
using Step_5_Files.Commands;
using Step_5_Files.Sound_Handlers;

namespace Step_5_Files.Walk_Handlers;

[Component_Name("Fish_Swim")]
public class Fish_Swim_Handler : Handler<Swim_Command>
{
    public override void Handle(Swim_Command cmd)
    {
        Write("swiming like a fish");
    }
}