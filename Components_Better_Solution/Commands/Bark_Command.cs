
namespace Components_Better_Solution;

public class Bark_Command : Action_Command
{
    protected override Actions Action => Actions.Bark;

    public Bark_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }

    public override bool Is_Valid()
    {
        return Components.Has<Bark_Component>();
    }
}