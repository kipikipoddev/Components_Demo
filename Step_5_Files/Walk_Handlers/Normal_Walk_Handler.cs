using Step_5_Files.Commands;
using Step_5_Files.Sound_Handlers;

namespace Step_5_Files.Walk_Handlers;

public class Normal_Walk_Handler : Handler<Walk_Command>
{
    public override void Handle(Walk_Command evnt)
    {
        Write("Walking");
    }
}