namespace Components_Demo;

public class Bark_Command : Action_Command
{
    public override string Name => "bark";
    public override string Did => "barked";

    public Bark_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
