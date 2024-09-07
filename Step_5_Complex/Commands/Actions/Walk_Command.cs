
namespace Step_5_Complex;

public class Walk_Command : Action_Command
{
    public override Actions Action => Actions.Walk;
    public Speed Speed { get; }

    public Walk_Command(IComponents components, Speed speed = Speed.Normal)
        : base(components)
    {
        Speed = speed;
    }
}