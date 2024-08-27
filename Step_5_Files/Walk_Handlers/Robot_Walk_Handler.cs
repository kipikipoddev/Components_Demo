using Step_5_Files.Commands;
using Step_5_Files.Sound_Handlers;

namespace Step_5_Files.Walk_Handlers;

public class Robot_Walk_Handler : Handler<Walk_Command>
{
    public override void Handle(Walk_Command evnt)
    {
        new Recharge_Command(Parent);
        Write("Walking like a robot");
    }
}