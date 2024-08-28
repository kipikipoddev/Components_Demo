using Step_5_Files.Core;
using Step_5_Files.Enums;

namespace Step_5_Files.Commands;

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
