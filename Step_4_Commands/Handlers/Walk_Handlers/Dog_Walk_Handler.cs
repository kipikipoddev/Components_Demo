using Step_4_Commands.Commands;
using Step_4_Commands.Core;

namespace Step_4_Commands.Walk_Handlers;

public class Dog_Walk_Handler : Handler<Walk_Command>
{
    public override void Handle(Walk_Command cmd)
    {
        Write($"walking {Get_Speed(cmd.Speed)}like a dog");
    }
}