namespace Components_Solution;

public class Heal_Command : Action_Command
{
    public override string Name => "heal";
    public override string Did => "healed";

    public Heal_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
