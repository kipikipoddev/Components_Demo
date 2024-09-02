namespace Components_Solution;

[Action(Actions.Meow, Actions.Meowing)]
public class Meow_Command : Action_Command
{
    public Meow_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
