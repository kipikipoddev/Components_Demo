namespace Components_Demo;

public class Meow_Command : Action_Command
{
    public override string Name => "meow";
    public override string Did => "meowing";

    public Meow_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
