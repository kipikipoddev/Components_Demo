using Step_5_Files.Attributes;
using Step_5_Files.Commands;
using Step_5_Files.Core;

namespace Step_5_Files.Walk_Handlers;

[Component_Name("Dog_Walk")]
public class Dog_Walk_Handler : Handler<Walk_Command>
{
    public override void Handle(Walk_Command cmd)
    {
        Write($"walking {Get_Speed(cmd.Speed)}like a dog");
    }
}