using Step_4_Commands.Core;

namespace Step_4_Commands.Commands;

public class Swim_Command : Command
{
    public Swim_Command(IComponents component)
        : base(component)
    {
        Send(this);
    }
}
