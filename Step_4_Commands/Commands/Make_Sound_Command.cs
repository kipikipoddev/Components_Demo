using Step_4_Commands.Core;

namespace Step_4_Commands.Commands;

public class Make_Sound_Command : Command
{
    public Make_Sound_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}