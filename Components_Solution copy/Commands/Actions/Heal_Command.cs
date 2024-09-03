namespace Components_Solution;

public class Heal_Command : Action_Command
{
    public override Actions Name => Actions.Heal;
    public override Actions Did => Actions.Healed;
    
    public Heal_Command(IComponents components)
        : base(components)
    {
    }
}
