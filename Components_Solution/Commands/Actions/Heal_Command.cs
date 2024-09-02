namespace Components_Solution;

[Action(Actions.Heal, Actions.Healed)]
public class Heal_Command : Action_Command
{
    public Heal_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
