using Step_4_Mediator.Commands;
using Step_4_Mediator.Sound_Handlers;

namespace Step_4_Mediator.Walk_Handlers;

public class Robot_Walk_Handler : Handler<Walk_Command>
{
    public override void Handle(Walk_Command evnt)
    {
        new Recharge_Command(Parent);
        Write("Walking like a robot");
    }
}