using Step_5_Files.Core;

namespace Step_5_Files.Commands;

public class Make_Sound_Command : Command
{
    public Make_Sound_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}