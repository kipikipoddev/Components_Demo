using Step_4_Commands.Commands;
using Step_4_Commands.Core;

namespace Step_4_Commands.Walk_Handlers;

public class Dog_Swim_Handler : Handler<Swim_Command>
{
    public override void Handle(Swim_Command cmd)
    {
        Write($"swiming {Get_Speed(cmd.Speed)}like a dog");
    }
}