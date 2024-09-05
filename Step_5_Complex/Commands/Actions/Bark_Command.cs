
namespace Step_5_Complex;

public class Bark_Command : Action_Command
{
    public override Actions Name => Actions.Bark;
    public Volume Volume { get; }

    public Bark_Command(IComponents components, Volume volume = Volume.Normal)
        : base(components)
    {
        Volume = volume;
    }
}