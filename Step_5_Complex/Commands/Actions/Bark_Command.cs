
namespace Step_5_Complex;

public class Bark_Command(IComponents components, Volume volume) : Action_Command(components)
{
    public override Actions Name => Actions.Bark;
    public override Actions Was => Actions.Barking;
    public Volume Volume { get; } = volume;
}