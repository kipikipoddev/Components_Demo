namespace Components_Solution;

public class Bark_Command : Action_Command
{
    public override string Name => "bark";
    public override string Did => "barking";

    public Bark_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
