using Step_4_Mediator.Commands;
using Step_4_Mediator.Sound_Handlers;

namespace Step_4_Mediator.Walk_Handlers;

public class Fish_Swim_Handler : Handler<Swim_Command>
{
    public override void Handle(Swim_Command evnt)
    {
        Write("swiming like a fish");
    }
}