using Step_4_Commands.Commands;

namespace Step_4_Commands.Sound_Handlers;

public class No_Handler_Handler : Handler<No_Handler_Command>
{
    public override void Handle(No_Handler_Command cmd)
    {
        if (cmd.Command is Walk_Command)
            Parent.Write_Cannot("walk");
        if (cmd.Command is Swim_Command)
            Parent.Write_Cannot("swim");
        if (cmd.Command is Make_Sound_Command)
            Parent.Write_Cannot("make sound");
    }
}