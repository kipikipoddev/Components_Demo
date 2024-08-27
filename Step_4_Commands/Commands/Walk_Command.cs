using Step_4_Commands.Core;

namespace Step_4_Commands.Commands;

public class Walk_Command : Command
{
    public Walk_Command(IComponents component)
        : base(component)
    {
        Send(this);
    }
}
