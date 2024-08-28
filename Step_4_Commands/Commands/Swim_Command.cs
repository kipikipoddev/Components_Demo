using Step_4_Commands.Core;
using Step_4_Commands.Enums;

namespace Step_4_Commands.Commands;

public class Swim_Command : Command
{
    public Speed Speed { get; }
    public Swim_Command(IComponents component, Speed speed = Speed.Normal)
        : base(component)
    {
        Speed = speed;
        Send(this);
    }
}
