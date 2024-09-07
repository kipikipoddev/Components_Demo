
namespace Step_5_Complex;

public class Meow_Command : Action_Command
{
    public override Actions Action => Actions.Meow;
    public Volume Volume { get; }

    public Meow_Command(IComponents components, Volume volume = Volume.Normal) 
        : base(components)
    {
        Volume = volume;
    }
}