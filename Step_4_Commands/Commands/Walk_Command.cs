using Step_4_Commands.Core;
using Step_4_Commands.Enums;

namespace Step_4_Commands.Commands;

public class Walk_Command : Command
{
    public Speed Speed { get; }

    public Walk_Command(IComponents component, Speed speed = Speed.Normal)
        : base(component)
    {
        Speed = speed;
        Send(this);
    }
}
